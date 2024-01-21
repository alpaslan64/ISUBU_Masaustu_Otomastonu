# ISUBU_Masaustu_Otomastonu

<p>C# ile geliştirdiğimiz ISUBU OBS Masaüstü Otomasyonu uygulamamız sizlere açılmış durumda. 
Proje temelinde anladığınız gibi C# Form uygulaması içermektedir. İki aşamadan oluşan projenin ilk aşası olan giriş sayfasında Selenium kütüphanesi kullanılmıştır. Giriş otomasyonu ve kontrolü bu kütüphane sayesinde kontrol edilmektedir.</p>

<p>Bu uygulamaının web sürümünün aksine avantajı, masaüstü uygulaması olarak daha kolay bir şekilde sisteme ulaşmak, sık kullandığınız menülere daha rahat erişmek ve daha nispeten göze daha çok hitap eden bir ortam oluşmasıdır.</p>

<p>Uygulamada kullandığımız NuGet paketi olan Bunifu Framework UI sayesinde Form tasarımlarımızı göze daha çok hitap edecek şekilde tasarlandı. Görünümü oldukça hoş ve kullanımı da son derece kolay ve anlaşılır.</p>

<p>Kullandığımız NuGet paketlerini Packet Manager Console ile veya NuGet Packet Manager kısmından ekleyebilirsiniz.</p>
<p>İhtiyacımız olan paketler aşağıdadır. Bunları NuGet Packet Manager kısmında aratarak görsel arayüzlü yükleyebilirsiniz.</p>
<p><h3>⚠️Bunifu.UI.WinForms ücretli bir araçtır. Kullanmaya başlamadan önce bunu göz önünde bulundurunuz!⚠️</h3></p>
<p><code>Selenium.WebDriver</code><br>
<code>Selenium.WebDriver.MicrosoftDriver</code><br>
<code>Selenium.WebDriver.MicrosoftWebDriver</code><br>
<code>Bunifu.UI.WinForms</code></p>

<p>Aynı zamanda PMC kullaranak aşağıdaki komutlarla bu paketleri yükleyebilirsiniz.<br>
<code>Install-Package Selenium.WebDriver</code><br>
<code>Install-Package Selenium.WebDriver.MicrosoftDriver</code><br>
<code>Install-Package Selenium.WebDriver.MicrosoftWebDriver</code><br>
<code>Install-Package Bunifu.UI.WinForms</code></p>

<h2>Uygulamanın Giriş Ekranı</h2>
<img src="https://github.com/alpaslan64/ISUBU_Masaustu_Otomastonu/assets/75975892/fdd48c0b-9d7f-49e2-bc8a-2e4302a20c41" width="700">
<p>Görülen görsel uygulamanın 1. aşamasıdır. Giriş sayfası tasarımı itibariyle modern ve şık durmaktadır. Soldaki ISUBU logosu sizi https://isubu.edu.tr adresine yönlendirmektedir.</p>
<p>Alanlara gerekli bilgiler girilip <code>GİRİŞ</code> butonuna basıldığında girilen bilgiler uygulamanın kendi özelliklerine gömülü şekilde saklanır. Bu sayede bir kere giriş yaptıktan sonra diğer girişlerde tekrardan elle giriş bilgisi yazmanıza gerek kalmaz. Bunu da <code>SON KULLANICI VERİLERİNİ GETİR</code> butonu ile yapmaktadır.</p>
<p>Uygulamayı incelediğinizde, şifrenin görünmemesi, kopyalanmaması, animasyonların görüntülenmesi, alanların boş bırakılmaması gerektiğini, yanlış ve doğru girişlerin raporlandığı log sisteminin olması ve giriş yapan kullanıcıyı tanıma gibi küçük detayları fark edebileceksiniz.</p>

<h2>Menü Kısmı</h2>
<img src="https://github.com/alpaslan64/ISUBU_Masaustu_Otomastonu/assets/75975892/3615fc8f-7ce2-4383-834c-127c89acdbe5" src="" width="185" height="500">
<p>Gördüğünüz gibi en sık kullanılan <code>Dönem Dersleri</code>, <code>Devamsızlık Yoklama</code> ve <code>Ders Dökümanları</code> menüleri daha anlaşılır ve erişilebilir halde.</p>

<h2>SON</h2>
<p>Projemizi rahat ve sorunsuz kullanabilmeniz için bir Setup dosyası hazırlandı. Dosyayı indirip, hızlı ve basit adımlarla kurulumu tamamlayıp kullanmaya başlayabilirsiniz</p>

<h2>Geliştiriciler</h2>
<ul>
    <li>Alpaslan Tiryakioğlu <a href="https://github.com/alpaslan64" target="_blank"> GitHub</a> - <a href="https://www.linkedin.com/in/alpaslan-tiryakio%C4%9Flu-344867257/" target="_blank"> LinkedIn</a></li>
    <li>Mert Kemal Gezer <a href="https://github.com/M3rtK4" target="_blank"> GittHub</a> - <a href="https://www.linkedin.com/in/mert-kemal-gezer-796270261/" target="_blank">LinkedIn</li>
</ul>
