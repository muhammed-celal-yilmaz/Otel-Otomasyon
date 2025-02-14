/*
SQL Server'da döngü kullanarak tablo oluşturmak genellikle dinamik SQL kullanarak gerçekleştirilir. Örneğin, belirli bir sayıda tablo oluşturmak istiyorsanız 
bir döngü kullanarak bu tablolara dinamik isimler verebilirsiniz.
Çoğunlukla WHILE döngüsü kullanılır. Bu kod parçası 10 adet tablo oluşturur.
Tabloları elle tek tek yapmak yerine bu yöntem daha etkilidir.
Ayrıca daha iyi bir dizayn için her bir oda için tablo oluşturmak yerine
Odalar tablosunda bunu tutmak daha sağlıklı olur.Proje özelinde buna gerek duymadım.

Değişken Tanımlama:
@i: Döngü sayacını tutmak için (başlangıç değeri 301).
@sql: Dinamik SQL sorgusunu tutacak değişken.
@tablename: Oluşturulacak tablonun adını tutacak değişken.

Döngü Başlatma:
WHILE döngüsü, @i değişkeni 309'a eşit veya ondan küçük olduğu sürece çalışacaktır.
Tablo Adı Belirleme:
@tablename değişkenine her döngüde yeni bir tablo adı atanır.
SQL Sorgusunu Oluşturma:
@sql değişkenine, CREATE TABLE ifadesi atanır. Burada tablo adı ve içerik dinamik olarak belirlenir.
Dinamik SQL Çalıştırma:
sp_executesql prosedürüyle dinamik olarak oluşturulan SQL sorgusu çalıştırılır.
Sayaç Güncelleme:
Her döngü sonunda @i değeri 1 artırılır.

Bu şekilde, SQL Server'da döngü ile çok sayıda tablo oluşturabilirsiniz. Dikkat etmeniz gereken nokta,
dinamik SQL kullanırken güvenliğinizi sağlamak için gerekli önlemleri almaktır.
Özellikle kullanıcıdan gelen verilerle dinamik SQL oluşturuyorsanız,
SQL Injection saldırılarına karşı koruma sağlamalısınız.
*/

-- DROP TABLE Oda301 ile tablo silersin.
-- DROP DATABASE veritabani_adi; veritabanı silersin.

-- Veri yolumuz ve bağlantı adresimiz :  
-- SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");
-- truncate table MusteriEkle komutuyla tablo değerlerini sıfırlarsın ve id sıfırdan başlar tekrar.

DECLARE @i INT = 301;
DECLARE @sql NVARCHAR(MAX);
DECLARE @tablename NVARCHAR(50);

WHILE @i <= 309
BEGIN
    SET @tablename = 'Oda' + CAST(@i AS NVARCHAR(10));
    SET @sql = 'CREATE TABLE ' + @tablename + ' (Adi NVARCHAR(50),Soyadi NVARCHAR(50))';
    
    EXEC sp_executesql @sql;
    
    SET @i = @i + 1;
END