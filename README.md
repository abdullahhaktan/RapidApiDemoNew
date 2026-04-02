# 🌍 Daily Briefing & Travel Dashboard – Multi-API & Gemini AI Powered Smart Information Platform

> Finans, hava durumu, seyahat ve eğlence verilerini tek bir modern dashboard üzerinde toplayan yapay zeka destekli günlük bilgilendirme platformu  
> A modern AI-powered daily briefing dashboard aggregating finance, weather, travel, and entertainment data via multiple external APIs

[![.NET](https://img.shields.io/badge/.NET-8.0-512bd4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-blue.svg)](https://learn.microsoft.com/dotnet/csharp/)
[![RapidAPI](https://img.shields.io/badge/API-RapidAPI-blue.svg)](https://rapidapi.com/)
[![Google Gemini](https://img.shields.io/badge/AI-Google_Gemini-4285F4?logo=google)](https://ai.google.dev/)
[![REST](https://img.shields.io/badge/Architecture-RESTful_API-orange.svg)]()

---

## 🚀 Özellikler / Features

| 🇹🇷 Türkçe | 🇬🇧 English |
|-----------|------------|
| RapidAPI üzerinden çoklu servis entegrasyonu | Multi-service integration via RapidAPI |
| Gemini AI ile kişiselleştirilmiş öneriler | Personalized recommendations via Gemini AI |
| Async HttpClient ile performanslı API tüketimi | High-performance async API consumption |
| JSON model binding & JObject veri işleme | JSON model binding & JObject parsing |
| Session tabanlı dinamik kullanıcı yönetimi | Session-based dynamic user flow |
| Booking API ile otel arama & detay görüntüleme | Hotel search & detail views via Booking API |
| Chart.js destekli veri sunumu | Data visualization via Chart.js |
| IMDb Top 100 entegrasyonu | IMDb Top 100 integration |

---

## 🌐 Multi-API Entegrasyon Mimarisi / Multi-API Integration Architecture

Bu projede farklı servislerden gelen REST verileri merkezi bir dashboard yapısında birleştirilmiştir.

✔ Finans verileri  
✔ Akaryakıt fiyatları  
✔ Hava durumu verileri  
✔ Otel arama servisleri  
✔ Film listeleri  

All services are orchestrated asynchronously via HttpClient infrastructure.

---

## 🤖 Gemini AI Entegrasyonu / Gemini AI Integration

Gemini AI kullanılarak dashboard içerikleri dinamik şekilde zenginleştirilmiştir:

### 🍽️ Günlük Yemek Önerisi / Daily Meal Suggestion

AI destekli günlük menü önerileri oluşturulur.

Generates AI-based daily meal suggestions dynamically.

---

### 🧭 Gezi Rehberi / Travel Assistant

Konum bazlı gezilecek yer önerileri sunar.

Location-based travel recommendations generated via AI.

---

### 🧠 Dinamik Dashboard İçerikleri / Smart Dashboard Content

Dashboard üzerinde kullanıcıya özel içerikler üretilir.

Dynamic personalized dashboard content generated with Gemini AI.

---

## 📡 RapidAPI Servis Entegrasyonları / RapidAPI Integrations

Projede aşağıdaki servisler entegre edilmiştir:

| Servis | Açıklama |
|-------|----------|
| Finance API | USD/TRY, EUR/TRY, BTC/USD verileri |
| Fuel API | Türkiye bazlı akaryakıt fiyatları |
| Weather API | Şehir bazlı hava durumu verileri |
| Booking API | Otel arama & detay bilgileri |
| IMDb API | Top 100 film listesi |

Provides centralized aggregation of real-time external datasets.

---

## 🏗️ Mimari / Architecture

```
RapidApiDashboardProject/
├── Controllers/
│
├── Services/
│   ├── FinanceService/
│   ├── WeatherService/
│   ├── FuelService/
│   ├── BookingService/
│   └── MovieService/
│
├── AIIntegrations/
│   └── GeminiService/
│
├── Models/
│
├── ViewComponents/
│
├── Views/
│
└── wwwroot/
```

Async service-based architecture ile dış API yönetimi optimize edilmiştir.

---

## 🧩 Kullanılan Tasarım Yaklaşımları / Design Approaches

### Service-Based API Architecture

Tüm dış servis çağrıları servis katmanında yönetilmektedir.

Ensures maintainable external API orchestration.

---

### Async HttpClient Pattern

Asenkron API çağrıları ile performans artırılmıştır.

Improves scalability and responsiveness.

---

### JSON Parsing Architecture

Newtonsoft.Json ve JObject kullanılarak güçlü veri işleme sağlanmıştır.

Provides flexible structured API response handling.

---

### Session Management Pattern

Kullanıcı tercihleri ve otel arama sonuçları session üzerinden yönetilmektedir.

Supports dynamic user-driven dashboard experience.

---

## 🛠️ Kullanılan Teknolojiler / Tech Stack

| Katman / Layer | Teknoloji |
|---------------|-----------|
| Backend | ASP.NET Core 8 MVC |
| API Integration | RapidAPI Services |
| AI Integration | Google Gemini AI |
| HTTP Client | Async HttpClient |
| JSON Handling | Newtonsoft.Json |
| Session | ASP.NET Core Session |
| Visualization | Chart.js |
| UI | Bootstrap |
| Language | C# |

---

## ⚙️ Kurulum / Setup

### Gereksinimler / Requirements

- .NET 8 SDK
- RapidAPI Key
- Google Gemini API Key
- Visual Studio 2022+

---

### Adımlar / Steps

```bash
git clone https://github.com/username/RapidApiProject.git
cd RapidApiProject
```

**API anahtarlarını appsettings.json içine ekleyin**

```
RapidApiKey=YOUR_API_KEY
GeminiApiKey=YOUR_API_KEY
```

**Projeyi başlatın**

```
dotnet run
```

---

## 📊 Proje Vizyonu / Project Vision

Bu proje yalnızca bir dashboard uygulaması değildir.

✔ Multi-API orchestration mimarisi  
✔ Async HttpClient performans yönetimi  
✔ Gemini AI destekli içerik üretimi  
✔ RESTful servis entegrasyon yönetimi  

This project demonstrates **modern API orchestration with AI-enhanced dashboard architecture**.

---

## 📸 Screenshots

<img src="https://github.com/user-attachments/assets/a8dd9755-b5d9-48c2-a154-3f6dfce5be74" />

<img src="https://github.com/user-attachments/assets/2aa1e475-5779-4ebb-ad2c-57540978f94a" />

<img src="https://github.com/user-attachments/assets/09ed1c6f-0f31-4193-9146-43abb4a398bc" />

<img src="https://github.com/user-attachments/assets/92eb7b5f-ddad-47ff-9829-0ec7456b8a33" />

<img src="https://github.com/user-attachments/assets/1c0c0fa7-1db5-4f0f-96cb-0688efc19948" />

<img src="https://github.com/user-attachments/assets/475bfd23-41be-43c0-a9ce-622142ba7b70" />

<img src="https://github.com/user-attachments/assets/b14c4f42-3415-4843-b652-ff049615a6c0" />

<img src="https://github.com/user-attachments/assets/22e0debf-dde2-405a-b198-9fe088cebe2f" />

<img src="https://github.com/user-attachments/assets/48d93a34-8cc5-453b-9f9b-be148945e2a8" />

<img src="https://github.com/user-attachments/assets/770384b4-91ea-4b93-a1bf-5077b2f2b8b8" />

---

## 👨‍💻 Geliştirici / Developer

**Abdullah Haktan**

GitHub → https://github.com/abdullahhaktan
