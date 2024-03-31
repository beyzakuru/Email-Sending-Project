# E-Posta Gönderim Uygulaması Geliştirme Projesi

### Projede kullanılan teknolojiler;

- ASP.NET Core
- WEB API

### Projenin Veritabanı Şeması

![veritabani_semasi](https://github.com/beyzakuru/Email-Sending-Project/assets/88837400/878a4637-5cd2-4fc3-8bf5-331de145635c)

- Yukarıdaki şemada da görüldüğü üzere proje senaryo ile bağlantılı birbiriyle ilişlisi olan 4 farklı tablo oluşmaktadır.
- Proje içerisinde Entity Framework Core yaklaşımı ile veritabanı oluşturulmuştur.

### Swagger 

![swagger](https://github.com/beyzakuru/Email-Sending-Project/assets/88837400/83d9473a-ee31-4887-8ba4-fc8f57fe2552)

- Proje içerisinde istenen gereksinimlerin tamamı karşılanmamaktadır.
- Web API katmanında oluşturmuş olduğum controller'ların çalışma durumları swagger üzerinden kontrol edimiştir.


### Proje Yapısı

- Proje katmanlı mimari yapısı ile oluşturularak içerisinde Core, Repository (Data Access), Service (Business) ve API (Presentation) katmanlarını barındırmaktadır.
- Core katmanı içerisinde veritabanı modelimizin oluşturulduğu model klasörü, önyüz tarafında kullanıcıya sunmak istediğimiz verilerin tutulduğu DTO klasörü, Repository katmanı interfacelerinin yazıldığı repository klasörü, Service interfacelerinin yazıldığı Service klasörü ve veritabanı işlemlerini tek bir transaction üzerinden yönetebilmek için unit of work interface'lerinin klasörü vardır.
- Repository katmanı içerisinde entity'lerin konfigürasyon işlemleri için Configuration klasörü, repository interface'lerinin implementasyonu için Repositories klasörü ve veritabanaı senkronizasyonunu sağlamak için migration klasörü bulunmaktadır.
- Service katmanı içerisinde service interface'lerinin implementasyonunun yapıldığı Service klasörü ve model-dto verilerini eşitlemek için mapping klasörü bulunmaktadır.
- API katmanı içerisinde ise her bir model ögesi için controller'lar mevcuttur.
