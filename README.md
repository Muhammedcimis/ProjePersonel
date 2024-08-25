# ProjePersonel
 Personel CRUD Projesi
Personeller ile ilgili temel CRUD işlemlerinin yapıldığı, Domain(Entity), DataAccessLayer, BusinessLayer(Service) ve UI dan oluşan çok katmanlı mimariye sahip web projesi.
Veritabanındaki Modeller için modellere karşılık gelen DTO model oluşturulmuştur. Yeni propertyler eklenmiştir.
Generic Repository, UnitIOfWork kalıpları kullanılmıştır.
SOLID ve DRY gibi kod yazma konularına dikkat edilerek kod yazılmıştır.
Dependency Injection uygulanmıştır.
Bazı veriler API kullanılarak elde edilmiştir. APIden data da asenkron yapı ile çekilmiştir. 
Radiobutton, Checkbox gibi farklı yapılardan model binding işlemleri yapılarak, View ve Model arası veri transferi gerçekleştirilmiştir.
APIden alınan Türkiyedeki Üniversitelerin isimleri alfabetik sıralama ile kullanıcıya seçenek olarak sunulmuştur.
Hız ve performansdan dolayı Tag Helper kullanılmıştır.
Controllerda useri server katmanı karşılamaktadır. Veritabanı ile ilgili işlemler var ise user'i repository katmanına gönderip gerekli veritabanı işlemlerini yapmaktadır.,
Repositoryde yapılan işlemin ardından, işlem Service de UnitOfWork yapısı ile veritabanına yansıtılmıştır.
Projede hız ve işlemlerden dolayı asenkron yapı kullanılmıştır. 
