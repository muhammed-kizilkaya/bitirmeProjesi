# 2. Gelişim Raporu

## Düzeltmeler
 Gantt Şemasının düzeltilmiş hali eklenmiştir.
![img](https://i.hizliresim.com/MG9AM3.png)


## Kaynaklar
1. Pham, Tan ve Patrick. “Cortex-v2-Example” Github, 7 Temmuz 2020, github.com/Emotiv/cortex-v2-example.
2. 

## Zorluklar


## Araçlar
Erzurum Teknik Üniversitesi Bilgisayar Mühendisliği laboratuvarı kullanılmaktadır. Laboratuvar ortamı EEG sinyallerine gürültü binmeyecek şekilde sessiz ve uygun ışıklandırması yapılmış haldedir. 
Mobil beyin sinyalleri elde etme cihazı 14 kanallı Emotiv EPOC+ kullanılmaktadır. EEG cihazı Uluslararası 10-20 konumlarına uygun olarak AF3, F7, F3, FC5, T7, P7, 02, 02, P8, T8, FC6, F4, F8, AF4 isimli elektrot konumlarından sinyal toplamaktadır. Örnekleme frekansı 128 sps (2048 Hz dahili), çözünürlüğü 14 bit 1 LSB ve bant genişliği 
0.2-45 Hz’dir. Kablosuz özelliği olan cihaz 2.4 GHz bandında USB alıcısı ile kullanılabilmektedir. Cihazın ayrıca bir avantajı olarak nemli (saline) keçeli elektrotlar ile kullanabilmesidir. Bu durum katılımcıların saçlarının temiz kalmasını sağlamaktadır.
Diğer araçlardan olan 3B modelleme aracı Maya, oyun motoru Unity ve AR eklentisi Vuforia aşağıda detaylı olarak anlatılmıştır.

Maya ile 3B Modelleme ve Modellemelerin Unity’e Aktarılması
AR uygulamasında kullanılmakta ve animasyon için öncelikle 3B olarak modellenen karakterler yapılmıştır. Daha sonra bu modellemeleri Unity’e aktararak, ortam hareketleri katarak animasyon yapımı ve kitaplar hakkındaki bilgilerin yer alacağı arayüz tasarımına geçilecektir.

Vuforia
    Vuforia, Artırılmış Gerçeklik uygulamalarının oluşturulmasını sağlayan mobil cihazlarla uyumlu arttırılmış gerçeklik yazılım geliştirme kiti sayesinde animasyonda düzlemsel görüntüleri ve 3B nesneleri gerçek zamanlı olarak tanımak ve izlemek için kullandığımız bu görme teknolojisi kullanıldı. Bu görüntü kayıt özelliği, geliştiricilerin 3B modeller ve diğer ortamlar gibi sanal nesneleri, bir mobil cihazın kamerasıyla görüntülendiğinde gerçek dünyadaki nesnelere göre konumlandırmasını ve yönlendirilmesini sağlar. Böylece okuyucunun perspektifi ile nesnenin konumlandırıldığı perspektif aynı konuma karşılık gelir. Böylece sanal nesnenin gerçek dünya sahnesinin bir parçası olduğu haline getirilir.
    Vuforia, Unity oyun motorunun bir uzantısı aracılığıyla Java dilinde Uygulama Programlama Arabirimleri (API) sağlar. Bu şekilde, SDK hem IOS, Android hem de UWP için yerel gelişimi desteklerken, Unity'de her iki platforma da kolayca taşınabilir AR uygulamalarının geliştirilmesini sağlar.

## İş Dağılımı
Grup Üyesi | Saat Yüzdesi
------------ | -------------
Muhammed Bayat | %
Ayşe Kartal | %
Beyza Coşkun | %
