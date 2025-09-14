# 📧 M&Y Akademi - Email Projesi
Bu proje, .NET Core ile geliştirilmiş tam işlevsel bir e-posta yönetim sistemidir. Kullanıcılar kayıt olabilir, giriş yapabilir, e-posta gönderebilir, alabilir, silebilir ve okundu olarak işaretleyebilir. Proje, Entity Framework Core ve Identity altyapısı ile desteklenmektedir.

# 🔑 Özellikler
✅ Kullanıcı Kaydı ve Girişi (Register/Login)

🔐 Şifrelerin Hash'lenmiş şekilde veritabanında saklanması

👤 Profil sayfasında kullanıcının adı, soyadı, e-posta adresi, kullanıcı adı ve profil fotoğrafı

📊 Kullanıcının bugüne kadar gönderdiği ve aldığı e-posta sayılarının görüntülenmesi

✏️ Profil bilgilerini güncelleme

📨 Yeni mesaj gönderme

📥 Gelen kutusu 

📤 Gönderilenler klasörü

🗑️ Silinenler klasörü

📬 Okunan ve okunmayan mesaj yönetimi

📌 Sidebar'da dinamik mesaj sayıları (Okunmamış, silinmiş vb.)

⚙️ EF Core ile veri yönetimi, AppDbContext ve Migrations

# 🛠️ Teknolojiler

ASP.NET Core MVC 9.0

Entity Framework Core

ASP.NET Identity

MS SQL Server

Bootstrap 5

LINQ

# 💾 Veritabanı Yapısı
E-posta verileri Message tablosunda saklanmaktadır.

IsRead: Mesaj okunduysa true

IsDeleted: Mesaj silindiyse true

SenderEmailAddress, RecipientEmailAddress, EmailSubject, EmailBody gibi alanlar mevcuttur.

Kullanıcı bilgileri ise AspNetUsers tablosunda tutulur. Şifreler Identity ile hash'lenerek saklanır.

# 📸 Proje Görselleri
<img width="1590" height="724" alt="4" src="https://github.com/user-attachments/assets/973e7fe3-8a9e-4624-a6c9-4e09aedb7e08" />
<img width="1591" height="722" alt="3" src="https://github.com/user-attachments/assets/fb73983c-c41d-4036-98ed-bca2b57e0c4e" />
<img width="1589" height="725" alt="5" src="https://github.com/user-attachments/assets/ee9e192a-6bbb-4af4-afb7-1bd7df8125d9" />
<img width="1595" height="721" alt="6" src="https://github.com/user-attachments/assets/1509dd20-5a50-47ce-9623-f9b3c1100698" />
<img width="1592" height="722" alt="7" src="https://github.com/user-attachments/assets/4c05be20-f2c5-488d-b4d6-e649a541d8a3" />
<img width="1588" height="725" alt="8" src="https://github.com/user-attachments/assets/e1a1a7e9-1561-4235-a0b4-5c88da128a4a" />
<img width="1586" height="719" alt="9" src="https://github.com/user-attachments/assets/e90c486a-0f5f-4f6b-8899-3fddba70f714" />
<img width="1594" height="728" alt="1" src="https://github.com/user-attachments/assets/da27cd90-e696-4887-89a9-f627378a7cbe" />
<img width="1591" height="730" alt="2" src="https://github.com/user-attachments/assets/7708de64-1498-4c6c-8fdf-4583bd407458" />
<img width="1588" height="720" alt="10" src="https://github.com/user-attachments/assets/ad154858-fc45-454d-98ec-1c7b5f431b5e" />


