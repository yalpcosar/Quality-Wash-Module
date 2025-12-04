import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

declare let alertify: any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor(private httpClient: HttpClient, public translateService: TranslateService) {
    alertify.set('notifier', 'position', 'top-right');
  }

  private normalizeMessage(message: any, fallback: string): string {
    if (message === null || message === undefined) {
      return fallback;
    }

    if (Array.isArray(message)) {
      return message.filter(Boolean).join(' ');
    }

    if (typeof message === 'object') {
      if ((message as any).message) {
        return (message as any).message;
      }
      try {
        return JSON.stringify(message);
      } catch {
        return fallback;
      }
    }

    const strMessage = String(message).trim();
    return strMessage.length > 0 ? strMessage : fallback;
  }

  success(message: any) {
    const normalized = this.normalizeMessage(message, 'Success');
    this.translateService.get(normalized).subscribe({
      next: (mes: string) => alertify.success(mes),
      error: () => alertify.success(normalized)
    });
  }

  error(message: any) {
    const normalized = this.normalizeMessage(message, 'An unexpected error occurred.');
    this.translateService.get(normalized).subscribe({
      next: (mes: string) => alertify.error(mes),
      error: () => alertify.error(normalized)
    });
  }

  info(message: any) {
    const normalized = this.normalizeMessage(message, 'Info');
    this.translateService.get(normalized).subscribe({
      next: (mes: string) => alertify.info(mes),
      error: () => alertify.info(normalized)
    });
  }

  warning(message: any) {
    const normalized = this.normalizeMessage(message, 'Warning');
    this.translateService.get(normalized).subscribe({
      next: (mes: string) => alertify.warning(mes),
      error: () => alertify.warning(normalized)
    });
  }
}
