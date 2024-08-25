# ProjePersonel
 Personel CRUD Projesi
Personeller ile ilgili temel CRUD işlemlerinin yapıldığı, Çok katmanlı mimariye sahip, Service, Generic Repository, UnitIOfWork kalıplarının kullanıldığı proje.
SOLID ve DRY gibi kod yazma konularına dikkat edilerek kod yazılmıştır.
Bazı veriler API kullanılarak elde edilmiştir.
Radiobutton, Checkbox gibi farklı yapılardan model binding işlemleri yapılarak, View ve Model arası veri transferi gerçekleştirilmiştir.
Hız ve performansdan dolayı Tag Helper kullanılmıştır.
Controllerda useri server katmanı karşılamaktadır. Veritabanı ile ilgili işlemler var ise user'i repository katmanına gönderip gerekli veritabanı işlemlerini yapmaktadır.,
Repositoryde yapılan işlemin ardından, işlem Service de UnitOfWork yapısı ile veritabanına yansıtılmıştır.
Projede asenkron yapı kullanılmıştır.
APIden data da asenkron yapı ile çekilmiştir. 
Veritabanındaki Modeller için modellere karşılık gelen DTO model oluşturulmuştur. Yeni propertyler eklenmiştir.
