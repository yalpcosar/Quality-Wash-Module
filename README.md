# 🧪 Kalite Yıkama Modülü

Endüstriyel yıkama süreçlerinde **sipariş**, **makine** ve **hata yönetimini** tek bir ekranda toplayan,  
**DevArchitecture** altyapısıyla geliştirilmiş **çok katmanlı bir kalite kontrol modülü**.

> Amaç: Üretim hattındaki yıkama operasyonlarını standartlaştırmak,  
> hata analizini görünür kılmak ve karar mekanizmasını hızlandırmak.

---

## 🌟 Öne Çıkanlar

- 🎯 **Gerçek bir iş senaryosu**: Yıkama sürecinde sipariş, makine ve hata yönetimi
- 🧱 **DevArchitecture** tabanlı temiz ve ölçeklenebilir mimari
- 🧮 **Anlık kalite hesapları**:  
  - Toplam kontrol edilen ürün  
  - Hatalı ürün sayısı  
  - Hata yüzdesi ve geçme/kalma kararı
- 🔐 Kullanıcı, rol ve sayfa bazlı yetkilendirme
- 🌍 Türkçe & İngilizce çok dillilik desteği
- 🗂 Soft delete + audit alanları ile **kurumsal standart uyumu**

---

## 🧰 Teknolojiler

| Katman     | Teknoloji / Araçlar                                         |
|-----------|--------------------------------------------------------------|
| Backend   | .NET (DevArchitecture), Web API, CQRS, FluentValidation      |
| Frontend  | Angular, TypeScript, RxJS, SCSS                              |
| Database  | MS SQL Server, Entity Framework Core                         |
| Diğer     | AutoMapper, JWT Auth, Repository Pattern, Global Filters     |

---

## 🏗 Mimari Genel Bakış

Proje, **DevArchitecture** şablonu kullanılarak, çok katmanlı ve modüler bir şekilde kurgulandı:

```text
Solution
├── Core
├── Entities
├── DataAccess
├── Business
├── WebAPI
└── WebUI (Angular)
