import { Pipe, PipeTransform } from '@angular/core';
import { ESize } from '../enums/e-size.enum';

@Pipe({
  name: 'sizeEnum'
})
export class SizeEnumPipe implements PipeTransform {

  transform(value: ESize | string | number): string {
    if (value === null || value === undefined) {
      return 'Unknown';
    }

    let normalized: string;

    if (typeof value === 'string') {
      normalized = value.toUpperCase();
    } else if (typeof value === 'number') {
      const map: Record<number, ESize> = {
        1: ESize.S,
        2: ESize.M,
        3: ESize.L,
        4: ESize.XL
      };
      normalized = map[value] || '';
    } else {
      normalized = value;
    }

    switch (normalized) {
      case ESize.S:
        return 'Small';
      case ESize.M:
        return 'Medium';
      case ESize.L:
        return 'Large';
      case ESize.XL:
        return 'XL';
      default:
        return 'Unknown';
    }
  }
}
