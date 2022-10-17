# Katmanlı Mimari Uygulaması(Ürün Arama, Ekleme, Silme, Güncelleme)
Bu proje ürünleri kategoriye göre ve ürün adlarına göre listeleme, ürün ekleme, silme ve güncelleme işlemlerini katmanlı mimariye uygun olarak oluşturuldu.
## Projede Kullanılan Teknolojiler
- .NET CORE 6
- Class Library
- Windows Form Application
- MS SQL SERVER
## Projede Kullanılan Paketler
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- FluentValidation
- Ninject
## Projede Kullanılan Veri Tabanı
- NORTHWND(Microsoft un Örnek Veri Tabanı)-Backup dosyası projede mevcuttur.
## NORTHWND.Entity(Veri Tabanındaki Tablolar)
Burada veritabanında bulunan Product ve Category tablolarındaki alanlar EntityFramework yardımı ile eklendi. Buradaki yapıya [NORTHWND.Entities](https://github.com/BetulBircan/KatmanliMimariUygulamasi/tree/main/NLayeredAppDemo/NORTHWND.Entities) dosyasından ulaşabilirsiniz.
## NORTHWND.DataAccess(Veri Tabanında CRUD İşlemlerinin Yapılması)
Burada veri tabanına bağlanma, veri tabanında ekleme silme güncelleme işlemlerinin yapılması için ayrı bir katman olarak oluşturuldu. Buradaki yapıya [NORTHWND.DataAccess](https://github.com/BetulBircan/KatmanliMimariUygulamasi/tree/main/NLayeredAppDemo/NORTHWND.DataAccess) dosyasından ulaşabilirsiniz.
## NORTHWND.Business(İş Katmanı)
Burada sınıflar arasında bağımlılığı en aza indirmek için IOC Container yapısı, veri eklerken ve güncellerken "Boş Geçilemez", "Ürün Stok Miktarı 0 dan Küçük Olamaz" gibi uyarıları verme gibi işleri yapabilmesi için ayrı bir katman olarak oluşturuldu. Buradaki yapıya [NORTHWND.Business](https://github.com/BetulBircan/KatmanliMimariUygulamasi/tree/main/NLayeredAppDemo/NORTHWND.Business) dosyasından ulaşabilirsiniz.
## NORTHWND.WebFormsUI(Arayüz Katmanı)
Burada kategoriye göre ve ürün adına göre ürünleri listeleme, ürün ekleme, silme ve güncelleme işlemleri için arayüz tasarımı bu kısımda yapıldı. Buradaki yapıya [NORTHWND.WebFormsUI](https://github.com/BetulBircan/KatmanliMimariUygulamasi/tree/main/NLayeredAppDemo/NORTHWND.WebFormsUI) dosyasından ulaşabilirsiniz. 

**Arayüz Tasarımı**

![netkatmanlımimariarayüz](https://user-images.githubusercontent.com/86554799/196217672-69d6ab49-ad16-4cba-847b-ccdce116ceef.png)

