# 🏠 Ev Fatura Takip Sistemi  
## 🎯 Konular: Constructor (Yapıcı Metot) ve Encapsulation (Kapsülleme)

---

## 📘 1. Konu Anlatımı

### 🧩 **Encapsulation (Kapsülleme)**

Kapsülleme, bir sınıfın verilerini (**değişkenlerini**) dışarıdan doğrudan erişime kapatarak, bu verilere **kontrollü erişim** sağlamaktır.  
Amaç, veriyi korumak ve nesnenin kendi iç mantığını gizlemektir.

Kapsülleme yapılırken:
- Veriler `private` olarak tanımlanır.  
- Bu verilere erişmek için `public` metotlar (örneğin `ParaYatir`, `FaturaOde`) kullanılır.  
- Böylece dışarıdan hatalı veri girişleri engellenmiş olur.

📌 **Basit Tanım:**  
> "Kapsülleme, veriyi saklamak ve sadece izin verilen yollarla değiştirmektir."

---

### ⚙️ **Constructor (Yapıcı Metot)**

Constructor, bir sınıftan **nesne oluşturulurken** çalışan özel metottur.  
Amacı, nesnenin **başlangıç değerlerini atamak** ve ilk durumunu hazırlamaktır.

Özellikleri:
- İsmi sınıfla **aynıdır**.  
- Geri dönüş tipi **yoktur** (void bile yazılmaz).  
- Nesne oluşturulurken `new` anahtar sözcüğüyle **otomatik olarak çağrılır.**

📌 **Basit Tanım:**  
> “Constructor, nesnenin ilk değerlerini tanımlayan otomatik çalışan metottur.”

---


## 2.Senaryo

Bu örnekte bir ev sahibine ait elektrik ve su faturaları takip edilmektedir.  
Veriler (bakiye, borçlar) `private` olarak saklanır; sadece belirli `public` metotlar üzerinden işlem yapılabilir.  
Ev sahibinin adı ve başlangıç bakiyesi ise constructor ile atanır.


## Not
Arkadaşlar kodu her zamanki gibi program.cs içerisinde bulabilirsiniz. Detaylı yorum satırlarını da ekledim, inceleyebilirsiniz.
