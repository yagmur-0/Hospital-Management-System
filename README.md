# 🏥 Hastane Yönetim Sistemi (Hospital Management System)

Bu proje, C# WinForms ve MS SQL Server kullanılarak geliştirilmiş kapsamlı bir Hastane Otomasyon Sistemidir. Sistem; Hastalar, Doktorlar ve Sekreterler olmak üzere 3 farklı kullanıcı tipine özel paneller sunmaktadır.

## 🚀 Özellikler 

### 👥 Sekreter Paneli:
* Yeni doktor kaydı oluşturma, silme ve güncelleme.
* Hastalar için yeni randevu oluşturma ve sistemdeki tüm randevuları listeleme.
* Doktorlar için sistem üzerinden duyuru/mesaj yayınlama.

### 🩺 Doktor Paneli:
* Kendisine ait randevuları ve hasta şikayetlerini görüntüleme.
* Sekreter tarafından yayınlanan duyuruları okuma.
* Kendi şifre ve kişisel bilgilerini güncelleme.

### 👤 Hasta Paneli:
* Sisteme kayıt olma ve giriş yapma.
* Poliklinik ve Doktor seçerek uygun saatlere randevu alma.
* Geçmiş randevu geçmişini (tarih, saat, şikayet) görüntüleme.

## 🛠️ Kullanılan Teknolojiler
* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** MS SQL Server
* **Mimari:** Katmanlı mimari prensiplerine uygun veri erişimi.

## 📸 Ekran Görüntüleri

**Giriş Ekranı:**
<img width="892" height="507" alt="GirisEkrani2" src="https://github.com/user-attachments/assets/298afc4b-5a60-4c12-8bfa-5a61ada2f1b9" />

**Sekreter Paneli:**
<img width="1192" height="712" alt="SekreterPaneli" src="https://github.com/user-attachments/assets/36078ab8-43a2-4c8a-a8ba-208b8c25ff6d" />

**Hasta Paneli:**
<img width="1056" height="723" alt="HastaPaneli" src="https://github.com/user-attachments/assets/211edca4-216e-4db6-9451-1777c649cb62" />

**Doktor Paneli:**
<img width="1047" height="712" alt="DoktorPaneli" src="https://github.com/user-attachments/assets/2c041b18-6409-4e31-b75b-52ba48c76fc3" />

## ⚙️ Kurulum Talimatları 

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1. Bu projeyi bilgisayarınıza klonlayın veya `.zip` olarak indirin.
2. Proje klasörü içindeki `Database` klasöründe bulunan `hastane_veritabani.sql` dosyasını kendi **SQL Server Management Studio (SSMS)** üzerinde çalıştırarak veritabanını oluşturun.
3. Visual Studio'da projeyi açın.
4. Kod içerisindeki (veya `App.config` dosyasındaki) **Connection String (Bağlantı Cümlesi)** kısmını kendi SQL Server adınıza (`Data Source=SİZİN_SUNUCU_ADINIZ`) göre güncelleyin.
5. Projeyi başlatın (`F5`).

## 🧪 Test Hesapları

Projeyi hızlıca test edebilmeniz için örnek giriş bilgileri:
* **Hasta TC:** `22222222222` | **Şifre:** `123456`
* **Sekreter TC:** `47777777777` | **Şifre:** `1234`
* **Doktor TC:** `33333333333` | **Şifre:** `12345`
