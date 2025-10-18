# 🚗 Polimorfizm (Çok Biçimlilik) – Taşıtlar Örneği

---

## 📘 1. Konu Anlatımı

### 🧩 Polimorfizm Nedir?

Polimorfizm (çok biçimlilik), Yunanca kökenli bir kelimedir:  
> *poly* = çok, *morph* = biçim  
Yani “aynı isimli bir metodun farklı sınıflarda farklı şekilde çalışabilmesi” anlamına gelir.

📌 **Kısa tanım:**  
> “Aynı metot adı farklı sınıflarda farklı davranışlar gösterebiliyorsa, polimorfizm vardır.”

---

### ⚙️ `virtual` ve `override` Ne İşe Yarar?

- **`virtual`** → Üst sınıfta bir metodun alt sınıflarda yeniden yazılabileceğini belirtir.  
- **`override`** → Alt sınıfta üst sınıftaki metodu yeniden yazar (davranışını değiştirir).

---

### 💡 Gerçek Hayat Benzetmesi

Bir **taşıt** düşünelim.  
Bütün taşıtlar **hareket eder** ama hepsi farklı şekilde:
- Araba tekerlekleriyle ilerler,  
- Uçak uçar,  
- Gemi denizde yol alır.  

Yani “hareket etme” davranışı ortaktır ama her sınıfta **farklı şekilde uygulanır**.  
İşte bu duruma **polimorfizm** denir.

---

## 2. Senaryo
## 🚘 Senaryo: "Taşıtlar Ulaşım Merkezinde"

Bir ulaşım merkezinde farklı türden taşıtlar bulunmaktadır: arabalar, uçaklar ve gemiler.  
Her taşıt **hareket edebilir**, **durabilir** ve **bir markaya** sahiptir.  
Ancak bu taşıtların **hareket biçimleri birbirinden farklıdır**:

- **Araba** tekerlekleriyle karayolunda ilerler.  
- **Uçak** gökyüzünde uçar ve piste iniş yapar.  
- **Gemi** denizde yol alır ve limanda demir atar.  

Yazılım geliştirici olarak amacımız, bu farklı taşıt türlerini tek bir sistemde yönetmek  
ve her birinin hareket biçimini **ortak bir metotla (HareketEt)** ama **farklı bir davranışla** göstermektir.

Bu nedenle:
- Tüm taşıtların ortak özelliklerini `Tasit` sınıfında topluyoruz.  
- Araba, Uçak ve Gemi sınıfları bu sınıftan **kalıtım alarak (inheritance)** kendi davranışlarını tanımlıyor.  
- `virtual` ve `override` anahtar sözcüklerini kullanarak aynı metodu (HareketEt)  
  farklı biçimlerde çalıştırıyoruz — yani **polimorfizm (çok biçimlilik)** uyguluyoruz.

Sonuç olarak:
- Tek bir `Tasit` dizisinde farklı taşıt türlerini saklayabiliyoruz.  
- `foreach` döngüsüyle aynı metodu çağırdığımızda her taşıt kendi karakteristik hareketini sergiliyor.  
- Alt sınıflara özgü davranışlara (`KlimaAc`, `InisYap`, `DemirAt`)  
  `(Araba)`, `(Ucak)`, `(Gemi)` tür dönüşümleriyle erişiyoruz.

Bu yapı sayesinde:
> **"Farklı türde nesneleri, aynı çatı altında, ortak metotlarla ama farklı davranışlarla yönetebiliyoruz."**


## Not

Arkadaşlar kodu her zamanki gibi program.cs içerisinde bulabilirsiniz. Detaylı yorum satırlarını da ekledim, inceleyebilirsiniz.
Arkadaşlar bu örnekte, “ulaşım merkezinde” hem arabalar hem uçaklar hem de gemiler var.
Hepsi bir taşıt ama her biri farklı şekilde hareket ediyor.
Biz “HareketEt()” metodunu hepsi için aynı isimle çağırıyoruz ama davranışları farklı oluyor.
İşte bu çok biçimlilik (polimorfizm)!
Ayrıca, taşıt dizimizde (Tasit[] araclar) hepsini birlikte saklayabiliyoruz.
Ancak araba, uçak veya gemiye özgü metotlara (KlimaAc, InisYap, DemirAt)
ulaşmak için (Araba), (Ucak), (Gemi) dönüşümleri yapmamız gerekiyor.