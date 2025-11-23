# 🎮 Karakter Oluşturma Uygulaması  


## 📌 1. Senaryo

Bir oyun geliştiriyorsunuz ve oyuncu kendi karakterini oluşturabilmelidir.  
Oyuncu:

- Karakterin adını **TextBox** ile girecek,
- Yaşını **TextBox** ile girecek,
- Karakter türünü **ComboBox** ile seçecek.

Girilen bu bilgilere göre bir **Character nesnesi** oluşturulacak ve karakterin **gücü** hesaplanacaktır.

Her karakter türünün kendine ait güç hesaplama mantığı vardır:

- **Savaşçı:** yaş × 3  
- **Büyücü:** yaş × 2 + 10  
- **Okçu:** yaş × 2  
- **Suikastçı:** yaş × 4 − 5  

Bu mantığı **GucHesapla()** metoduna siz yazacaksınız.

---

## 📌 2. Formda Olması Gereken Kontroller

Form üzerinde aşağıdaki öğeler **zorunludur**:

### ✔ Label – "Karakter Adı"  
### ✔ TextBox – karakter adı girişi  
`Name: txtAd`

---

### ✔ Label – "Yaş"  
### ✔ TextBox – karakter yaşı girişi  
`Name: txtYas`  
(Yaş **sadece sayı** olmalıdır.)

---

### ✔ Label – "Karakter Türü"  
### ✔ ComboBox – karakter türü seçimi  
`Name: cmbTur`  
İçerik (zorunlu):

- Savaşçı  
- Büyücü  
- Okçu  
- Suikastçı  

---

### ✔ Button – "Karakteri Oluştur"  
`Name: btnOlustur`

Bu butona tıklandığında karakter oluşturulacak ve güç hesaplanacaktır.

---

### ✔ Label – sonuç gösterim alanı  
`Name: lblSonuc`

Bu label içinde aşağıdaki format gösterilecektir:
`
Ad: ...
Tür: ...
Yaş: ...
Güç: ...
`


---

## 📌 3. Öğrencinin Yapması Gerekenler

1. **txtAd** boşsa uyarı vereceksiniz  
2. **txtYas** boşsa veya sayı değilse uyarı vereceksiniz  
3. **cmbTur** seçilmemişse uyarı vereceksiniz  
4. Character sınıfını kullanarak nesne oluşturacaksınız  
5. **GucHesapla() metodunun içini siz dolduracaksınız**  
6. Hesapladığınız sonuçları **lblSonuc** içinde göstereceksiniz  

---

## 📌 4. Kullanılacak Sınıf Yapısı (KOPYA :D)

 Form1.cs içine yazabiliriz bunu direkt değil mi ? Yazabilir miyiz sizce ?

**GucHesapla() metodunun içini siz yazacaksınız.**

```csharp

public class Character
{
    // Bu alanlar private tutulur çünkü karakter bilgileri
    // dışarıdan doğrudan değiştirilmesin (OOP gizleme - encapsulation).
    private string ad;
    private string tur;
    private int yas;

    // Constructor, karakter oluşturulurken gerekli bilgilerin
    // bir defada ve doğru şekilde alınmasını sağlar.(ilk kez yaratılırken kullanıyorduk değil mi ?)
    public Character(string ad, string tur, int yas)
    {
        // this neden kullanılıyordu hatırladık mı ? Parametre ve değişkeni ayırt edebilmek için. Hatırladık bence :D
        this.ad = ad;   // gelen adı karakterin 'ad' alanına yazar
        this.tur = tur; // gelen tür bilgisini atar
        this.yas = yas; // gelen yaş bilgisini atar
    }

    // Bu metodlar bilgileri okumak içindir.
    // Dışarıya değer döner ama değiştirmeye izin vermez.
    public string AdiGetir()
    {
        return ad;
    }

    public string TurGetir()
    {
        return tur; // TurGetir fonksiyonu çalıştığında direkt tur değişkeninin tuttuğu değer döndürülüyor. değişkene direkt nesne üzerinden erişilemiyor fakat burada yaptığımız mantık sayesinde main methoduna kullanabileceğiz değil mi ?
    }

    public int YasGetir()
    {
        return yas;
    }

    public int GucHesapla()
    {
        int guc = 0;

        // Buraya hesaplamayı siz yazacaksınız.
        // Karakter türüne göre güç hesaplama mantığını 1.bölümde verdim.

        return guc;
    }
}
