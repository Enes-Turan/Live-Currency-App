# Live Currency App (ASP.NET Core MVC)

Bu proje, gerçek zamanlı döviz kurlarını 10 saniyede bir yenileyerek görüntüleyen basit bir ASP.NET Core MVC uygulamasıdır. Veriler **open.er-api.com** üzerinden çekilmektedir.

## 🚀 Özellikler
- USD tabanlı güncel döviz kurlarını gösterir.
- 10 saniyede bir otomatik yenileme (AJAX).
- Temiz MVC mimarisi.
- Hata durumunda kullanıcıya uyarı gösterir.
- Servis tabanlı API iletişimi.

## 📂 Proje Yapısı
LiveCurrencyApp/
│
├── Controllers/
│   └── HomeController.cs
│
├── Models/
│   └── CurrencyData.cs
│
├── Services/
│   └── CurrencyService.cs
│
├── Views/
│   └── Home/
│       └── Index.cshtml
│
└── wwwroot/
    └── js/
        └── liveRates.js   (10 saniyede bir yenileme scripti)

## 🧩 Kullanılan API
Açık ve anahtarsız bir döviz API’si kullanılmıştır:

https://open.er-api.com/v6/latest/USD

Herhangi bir kişisel anahtar gerekmez ve gizli bilgi içermez.  

## ⚙️ Nasıl Çalıştırılır?
1. Projeyi klonlayın veya indirin.
2. Visual Studio ya da `dotnet` CLI ile açın.
3. Aşağıdaki komutu çalıştırın:

dotnet run


4. Tarayıcıdan şu adrese gidin:

http://localhost:5000

## 🔁 Otomatik Yenileme Scripti
`liveRates.js` dosyası her 10 saniyede bir API'den yeni verileri çeker ve tabloyu yeniler.

## 🛡 Gizlilik
Bu projede:
- API anahtarı yoktur  
- Kullanıcıya ait kişisel bilgi saklanmaz  
- Herkes tarafından güvenle kullanılabilir  

GitHub’a gönül rahatlığıyla yükleyebilirsiniz.

## 📄 Lisans
Bu proje eğitim amaçlıdır ve serbestçe kullanılabilir.
