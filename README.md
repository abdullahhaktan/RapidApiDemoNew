Project - Daily Briefing & Travel Dashboard

[TR]
**ASP.NET Core ile Geliştirilmiş, Gemini AI ve Çoklu RapidAPI Servisleri Entegreli Modern Dashboard**

[![.NET Core](https://img.shields.io/badge/.NET_Core-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![RapidAPI](https://img.shields.io/badge/API-RapidAPI-blue.svg)](https://rapidapi.com/)
[![Gemini AI](https://img.shields.io/badge/AI-Gemini_Google-orange.svg)]()

---

## 💻 Proje Hakkında
Bu proje, finans, hava durumu ve seyahat gibi kritik verileri tek bir modern **dashboard** üzerinden kullanıcıya sunan bir "Günlük Bilgilendirme" platformudur. 

Projenin temel amacı, farklı **RESTful API** servislerinden gelen dinamik verileri tek merkezde toplamak ve **Gemini AI** ile bu verileri zenginleştirerek kullanıcıya kişiselleştirilmiş öneriler sunmaktır. Tüm veri akışı asenkron (async) servis yapıları üzerinden sağlanmaktadır.

---

## ✨ Temel Özellikler

### Teknik Mimari
* **ASP.NET Core:** RESTful API tüketimi için merkezi mimari.
* **HttpClient & Async:** Tüm dış servisler `HttpClient` kullanılarak asenkron şekilde entegre edildi.
* **JSON Yönetimi:** Veri işleme süreçlerinde `Newtonsoft.Json`, `JObject` ve güçlü model binding yapıları kullanıldı.
* **Session Management:** Otel arama sonuçları ve kullanıcı tercihleri `Session` üzerinden dinamik olarak yönetildi.

### Entegre Edilen Servisler (RapidAPI)
* **Finans:** USD/TRY, EUR/TRY kurları ve BTC/USD kripto verileri (günlük değişim yüzdeleri ile).
* **Akaryakıt:** Türkiye bazlı anlık akaryakıt fiyat hesaplamaları.
* **Hava Durumu:** Şehir bazlı anlık ve detaylı hava durumu verileri.
* **Seyahat (Booking API):** Otel arama, filtreleme ve detaylı bilgi görüntüleme.
* **Eğlence (IMDb):** Top 100 film listesi entegrasyonu.

### Yapay Zeka (Gemini AI) Modülleri
* **Günlük Yemek Önerisi:** Kullanıcıya özel, yapay zeka tarafından üretilen menü fikirleri.
* **Gezi Rehberi:** Konum bazlı, AI destekli gezilecek yer ve aktivite önerileri.
* **Dinamik İçerik:** Dashboard üzerinde değişken, yapay zeka destekli metinler.

---

## 🚀 Nasıl Çalıştırılır?

1.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/username/RapidApiProject.git](https://github.com/username/RapidApiProject.git)
    cd RapidApiProject
    ```
2.  **API Anahtarlarını Ayarlama:**
    * `appsettings.json` dosyasını açın.
    * [RapidAPI](https://rapidapi.com/) ve [Google AI Studio](https://aistudio.google.com/) üzerinden aldığınız API Key bilgilerini ilgili alanlara ekleyin.
3.  **Projeyi Başlatma:**
    * Visual Studio ile `.sln` dosyasını açın.
    * **F5** tuşu ile projeyi ayağa kaldırın.

---

[EN]

# 🚀 Rapid API Project
**Daily Briefing & Travel Dashboard Developed with ASP.NET Core, Gemini AI, and Multi-RapidAPI Integration**

---

## 💻 About the Project
This project is a **Daily Briefing & Travel Dashboard** designed to present critical data such as finance, weather, and travel through a single modern interface.

All data is dynamically fetched via external **RESTful API** services and enriched with **Gemini AI** to provide personalized recommendations. The project follows clean code principles and modern web application standards.

---

## ✨ Core Features

### Technical Architecture
* **ASP.NET Core:** Centralized architecture for RESTful API consumption.
* **Async HttpClient:** All external services integrated asynchronously using `HttpClient`.
* **Data Handling:** Advanced JSON processing with `Newtonsoft.Json` and `JObject`.
* **Session Management:** Hotel search results handled efficiently via `Session`.

### RapidAPI Integrations
* **Finance:** Daily exchange rates (USD/TRY, EUR/TRY) and Crypto (BTC/USD).
* **Fuel Prices:** Real-time fuel price calculations for Turkey.
* **Weather:** City-based, instant weather data.
* **Travel (Booking API):** Hotel search and detailed information.
* **Entertainment:** IMDb Top 100 movies integration.

### AI Integration (Gemini AI)
* **Daily Meal Suggestions:** AI-generated daily menu ideas.
* **Travel Recommendations:** AI-powered suggestions for attractions and activities.
* **Dynamic Content:** Smart, AI-driven content generation across the dashboard.

---

## 🚀 How to Run

1.  **Clone the Project:**
    ```bash
    git clone [https://github.com/username/RapidApiProject.git](https://github.com/username/RapidApiProject.git)
    cd RapidApiProject
    ```
2.  **Configure API Keys:**
    * Update your API keys in the `appsettings.json` file for both RapidAPI and Gemini AI.
3.  **Start the Project:**
    * Open the `.sln` file in Visual Studio and press **F5**.

## Proje Görselleri

<img width="1263" height="2057" alt="localhost_7246_Dashboard_Index" src="https://github.com/user-attachments/assets/a8dd9755-b5d9-48c2-a154-3f6dfce5be74" />
<img width="1263" height="1095" alt="localhost_7246_Hotel_Index" src="https://github.com/user-attachments/assets/2aa1e475-5779-4ebb-ad2c-57540978f94a" />
<img width="1521" height="5412" alt="localhost_7246_HotelDetail" src="https://github.com/user-attachments/assets/09ed1c6f-0f31-4193-9146-43abb4a398bc" />
<img width="1521" height="1389" alt="localhost_7246_HotelDetail_Details_hotelId=244174" src="https://github.com/user-attachments/assets/92eb7b5f-ddad-47ff-9829-0ec7456b8a33" />

<img width="1544" height="878" alt="localhost_7246_HotelDetail_PhotosSlider_244174 (2)" src="https://github.com/user-attachments/assets/1c0c0fa7-1db5-4f0f-96cb-0688efc19948" />

<img width="1544" height="878" alt="localhost_7246_HotelDetail_PhotosSlider_244174" src="https://github.com/user-attachments/assets/475bfd23-41be-43c0-a9ce-622142ba7b70" />

<img width="1544" height="878" alt="localhost_7246_HotelDetail_PhotosSlider_244174 (1)" src="https://github.com/user-attachments/assets/b14c4f42-3415-4843-b652-ff049615a6c0" />
<img width="1544" height="878" alt="localhost_7246_HotelDetail_PhotosSlider_244174 (4)" src="https://github.com/user-attachments/assets/22e0debf-dde2-405a-b198-9fe088cebe2f" />
<img width="1544" height="878" alt="localhost_7246_HotelDetail_PhotosSlider_244174 (3)" src="https://github.com/user-attachments/assets/48d93a34-8cc5-453b-9f9b-be148945e2a8" />
<img width="1005" height="846" alt="localhost_7246_Movies_ImdbTop100List" src="https://github.com/user-attachments/assets/770384b4-91ea-4b93-a1bf-5077b2f2b8b8" />

