# 🐾 Tekli Kalıtım (Inheritance) – Hayvan Sınıfı Örneği

---

## 📘 1. Konu Anlatımı

### 🧩 Kalıtım Nedir?

Kalıtım (Inheritance), bir sınıfın başka bir sınıftan **özellikleri (değişkenler)** ve **davranışları (metotlar)** devralmasıdır.  
Bu sayede **kod tekrarı azaltılır** ve ortak özellikler üst sınıfta toplanır.

📌 **Basit Tanım:**  
> “Kalıtım, bir sınıfın başka bir sınıfın özelliklerini miras almasıdır.”

---

### ⚙️ Kalıtımın Faydaları

- Kod tekrarı azalır.  
- Ortak davranışlar tek bir yerde tanımlanır.  
- Yazılım bakımı kolaylaşır.  
- Alt sınıflar, üst sınıfın özelliklerini genişletebilir.

---

## 🧱 2. Senaryo

Bu örnekte bir **Hayvan** sınıfı oluşturacağız.  
Tüm hayvanların ortak davranışları (`SolunumYap`, `Beslen`, `Uyu`, `HareketEt`) bu sınıfta bulunacak.  

Daha sonra:  
- `Kedi` sınıfı `Hayvan` sınıfından kalıtım alacak ve `Miyavla`, `Tirman` metotlarını ekleyecek.  
- `Kopek` sınıfı `Hayvan` sınıfından kalıtım alacak ve `Havla`, `IzSur` metotlarını ekleyecek.  
- `Kus` sınıfı `Hayvan` sınıfından kalıtım alacak ve `Uc`, `Ot` metotlarını ekleyecek.

---

## 3.Not
Arkadaşlar kodu her zamanki gibi program.cs içerisinde bulabilirsiniz. Detaylı yorum satırlarını da ekledim, inceleyebilirsiniz.

