# 👋 Merhaba, M&Y Akademi danışmanlık bünyesinde ve eğitmenliğini Murat Yücedağ hocamın sağladığı .Net Core 8.0 İle bitirmiş olduğum Email & Chat projemi size tanıtmak isterim

## 🧠 Projeyi dinamik bir hale getirmek için ASP.NET Core (.NET Core Framework) kullandım
## 🧩 UI sayfalarını PartialView yapısıyla parçalara ayırarak düzenli ve kontrol edilebilir bir yapı oluşturdum
## 🗃️ Entity Framework - Code First yaklaşımıyla projem ile MS SQL veritabanı arasında iletişimi sağladım
## 🧱 Yapı olarak tek katmanlı mimari tercih ettim
## 🔐 ASP.NET Core Identity ile kullanıcı kimlik doğrulama, rol yönetimi ve oturum açma işlemlerini güvenli bir şekilde yönettim
## 🔎 Arama çubuğu için Contains() metodunu kullandım
## 🧮 Veritabanı: MS SQL Server
## 🎨 Tasarım: Bootstrap 4
## 🧾 Sorgular: LINQ
## 🖥️ Sayfa yapısı: Razor Views

# 🌐 Sayfa Yapısı – 3 Ana Sayfa;
## 📝 Register Sayfası
### 📩Kullanıcı burada kayıt olur, bilgiler veritabanına eklenir.
### 🔐 Şifreler hash’lenerek saklanır.
### 📋 Doğru şifre oluşturulması için Validator ile kurallar belirtilir.
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202006.png)
## 🔑 Login Sayfası
### 👤 Kullanıcı giriş yapar
### ❌ 5 defa yanlış girişte, 🚫 5 dakika boyunca giriş yapılamaz
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202116.png)
## 🧾 Kullanıcı Sayfası
### 📂 Profilim
### 📥 Gelen Kutusu
### 📤 Giden Kutusu
### 🔎 Arama Çubuğu
### ✉️ Yeni Mesaj Gönder
### 🗑️ Çöp Kutusu
### 🚪 Çıkış Yap
### 👁️‍🗨️ Kullanıcıya özel veriler burada listelenir

# Sayfa Detayları
## 📥 Gelen & 📤 Giden Mesajlar & 🗑️ Çöp Kutusu
### 📬 Kullanıcı, gelen/giden mesajlarını görüntüleyebilir

### 🔎 Arama Çubuğu ile filtreleme yapılabilir

### 🈳 Aranan kelime yoksa boş sayfa döndürülür

### ✅ Checkbox ile çoklu seçim yapılabilir

### ☑️ "Okundu Olarak İşaretle" butonu ile IsRead durumu değişir

### 🔄 Mesaj çöp kutusuna gönderilir

### 🔢 Sidebar’daki gelen mesaj sayısı dinamik olarak güncellenir


![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202122.png)
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202136.png)
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202157.png)
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202255.png)
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202319.png)
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202603.png)
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/afbb0e38f7abde30539fe0d86fd7bfb19dcdadf9/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202642.png)

##  📨 Yeni Mesaj Ekleme
### 📧 Alıcının e-posta adresi, adı soyadı, konu ve mesaj içeriği girilir
### ✅ Gönderim sonrası SweetAlert ile başarı mesajı gösterilir
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/2860ec33a502286fc0ad4ae0b5d2457ac6d63157/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202415.png)

![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/2860ec33a502286fc0ad4ae0b5d2457ac6d63157/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20210702.png)

## 👤 Profilim
### 📝 Kullanıcı adı, soyadı, e-posta, kullanıcı adı ve profil fotoğrafı gösterilir
### 📊 Gönderilen & alınan mesaj sayısı count ile hesaplanır
### 🛠️ Tüm bilgiler güncellenebilir
![ImageAlt](https://github.com/SemihSanli/EmailChatProject/blob/2860ec33a502286fc0ad4ae0b5d2457ac6d63157/Images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-09%20202359.png)

