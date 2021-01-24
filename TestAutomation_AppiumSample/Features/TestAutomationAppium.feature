Feature: TestAutomationAppium

Background: 
* Getir uygulamasının giriş sayfası açılır
* Kullanıcı adı 'your_email_adress' olarak girilir
* Şifre 'your_password' olarak girilir
* Submit butonuna tıklanır


Scenario: AddAndDeleteProductBasketFirst
* 'Atıştırmalık' Kategorisine tıklanır
* İki farklı ürün eklenir
* Anasayfa butonuna tıklanır
* 'İçecekler' Kategorisine tıklanır
* Bir ürün eklenir
* Sepete gidilir
* Sepetteki ürünler silinir

Scenario: AddAndDeleteProductBasketSecond
* Sepet kontrol edilir
* Anasayfa butonuna tıklanır
* Kategori sayısı kontrol edilir
* 'Atıştırmalık' Kategorisine tıklanır
* Atıştırmalık Kategorisinde iki farklı üründen ikişer tane eklenir
* Anasayfa butonuna tıklanır
* 'İçecekler' Kategorisine tıklanır
* Yiyecek Kategorisinde bir üründen 3 adet eklenir
* Sepetteki ürünler bir adet arttırılır
* Sepetteki ürünlerin arttığı kontrol edilir
* Sepetteki ürünler silinir
