# 📚 Static Değişkenler ve Static Metotlar  
## 🎯 Konu: Sınıfa Ait Üyelerin Kullanımı (Static Members)

---

## 📘 1. Konu Anlatımı

### 🧩 **Static Nedir?**
Normalde her sınıftan oluşturulan nesneler kendi verilerini taşır.  
Yani bir sınıftan 10 nesne oluşturduğunda, o sınıfa ait değişkenlerin 10 ayrı kopyası bellekte bulunur.  
Ancak bazen tüm nesnelerin **ortak olarak kullanacağı bir bilgiye** ihtiyaç duyarız — örneğin, “Toplam kaç kitap oluşturuldu?”  

İşte bu durumda **`static`** anahtar kelimesini kullanırız.

📌 **Tanım:**  
> Static üyeler, tüm nesneler tarafından paylaşılan ortak sınıf üyeleridir.  
> Yani o bilgiye ulaşmak için nesne oluşturmaya gerek yoktur.

---

### ⚙️ **Static Değişken (Static Variable)**
- Bellekte **tek bir kopyası** bulunur.  
- Her nesne bu değişkeni paylaşır.  
- Genellikle sayaç veya sabit bilgi gibi durumlarda kullanılır.  

## 2.Senaryo
Bir kütüphane düşünelim.
Her yeni kitap sisteme eklendiğinde “Toplam kaç kitap var?” bilgisinin otomatik güncellenmesini istiyoruz.
Bunu static sayaç kullanarak çözebiliriz.


## 3.Kod Açıklamaları

### Kısım	                              ----------------->         ### Açıklama
-public static int ToplamKitapSayisi	      ----------------->         Tüm kitaplar arasında ortak sayaç
-ToplamKitapSayisi++	                      ----------------->         Her yeni kitap nesnesinde sayaç 1 artar
-public static void SayaciYazdir()	      ----------------->         Static metot, nesne oluşturmadan çağrılır
-BilgiYazdir()	                          ----------------->         Nesneye ait kitap adını gösterir
-new Kitap(...)	                          ----------------->         Constructor’ı çalıştırarak static değişkeni artırır


## Not
Arkadaşlar kodu her zamanki gibi program.cs içerisinde bulabilirsiniz. Detaylı yorum satırlarını da ekledim, inceleyebilirsiniz.
