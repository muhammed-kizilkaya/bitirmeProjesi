# 2. Gelişim Raporu

## Düzeltmeler
 Gantt Şemasının düzeltilmiş hali eklenmiştir.
![img](https://i.hizliresim.com/MG9AM3.png)


## Kaynaklar
1. Pham, Tan ve Patrick. “Cortex-v2-Example” Github, 7 Temmuz 2020, github.com/Emotiv/cortex-v2-example.
2. International Journal of Human-Computer Studies https://doi.org/10.1016/j.ijhcs.2020.102579

## Zorluklar

![anket](/images/unityAnket.png)

Katılımcılara yapılacak olan anket için ilk etapta basit bir arayüz ile unityden bir form ekranı oluşturuldu ve excel olarak google drive da tutuldu. Örnek olarak alt resimde de olduğu gibi veri yazma işi yapıldı. Zorlanılan kısım, unity oyun geliştirme programı olduğu için bu tarz arayüzsel ve formsal işlevler bakımından kaynak zorluğu çekildi.
Çözüm olarak ise, google form oluştulup kaynak linki gösterilip, her bir textfield için enty kodlarına bakılıp koda eklendi.

![anketgoogle](/images/anketGD.png)

(unityden google form aracılığyla gönderilmiş örnek form)

![unityAR](/images/unityAR.png)

Kitaptan resimleri artırılmış gerçeklik ile gerçekleştireceğimiz için önemli bir kısım olan unity vuforia kısmında sürüm hataları aldığımız için unity 2021 için vuforia eklentisi ve kütüphanleri el ile eklendi. Bir diğer zorluk ise resimde gözüken mavi ekrana herhangi bir tuş veya kombinasyon olmadan kameradan mavi butona elin butona basmasıyla modelin (alt resimde) hareket etmesi ve elin butondan çekilince animasyonun durması bir diğer zorluk kısmı oldu. Çözüm için Udemy den vuforia eğitim seti alınıp detaylıca izlendikten sonra yapılabildi.

![animasyon](/images/animasyon.png)

(Unity model animasyon ve sanal buton)

# Öğrenilen Kavramlar

Form gönderme işini ilk etapta Google Firebase ile düşündük,fakat firebase bi yerden sonra ücret istemesi dolayıysı ile en mantıklı çözümü alttaki kodda da olduğu gibi entry idleri vererek çözüm sağlandı.

![KodOrnegi](/images/kodOrnegientry.png)

## Araçlar
Erzurum Teknik Üniversitesi Bilgisayar Mühendisliği laboratuvarı kullanılmaktadır. Laboratuvar ortamı EEG cihazından sinyallerin gürültü binmeyecek şekilde doğru alınabilmesi için sessiz ve floresan lambanın kullanılmadığı uygun ışıklandırmaya sahip bir ortamdır.
**Emotiv EPOC+**
Mobil ortamda gösterilecek kitap üstündeki sahneye karşı katılımcının ne kadar etkileşim göstereceğini beyin sinyalleriyle analiz ve elde etmede 14 kanallı Emotiv EPOC+ kullanılmaktadır. EEG cihazı beyinin Frontal, Parietal, Oksipital, Temporal,Serebellum loblarındaki etkileşimi inceleyebilmemiz için AF3, F7, F3, FC5, T7, P7, 02, 02, P8, T8, FC6, F4, F8, AF4 isimli elektrot konumlarından sinyal toplayıp datasetini oluşturmak için kullanılmaktadır. Cihazın örnekleme frekansı 128 sps (2048 Hz dahili), çözünürlüğü 14 bit 1 LSB ve bant genişliği 0.2-45 Hz’dir. Kablosuz özelliği sayesinde 2.4 GHz bandında USB alıcısı ile bilgisayar ortamında kullanılabilmektedir. Cihaz nemli keçeli elektrotlar ile kullanılır. Katılımcıların başına temas eden keçeler yeterince nemlendirilerek beyin sinyallerini daha sağlıklı bir şekilde alınabilmesi için gerekli elktriksel akımı oluşturmaya olanak sağlar.

Diğer araçlardan olan 3B modelleme aracı Maya, oyun motoru Unity ve AR eklentisi Vuforia aşağıda detaylı olarak anlatılmıştır.

**Maya ile 3B Modelleme ve Modellemelerin Unity’e Aktarılması**

Bu araçlar, AR uygulamasında kullanılmakta ve animasyon için öncelikle 3B olarak modellenen karakterler yapılmıştır. Daha sonra bu modellemeleri Unity’e aktararak, ortam hareketleri katarak animasyon yapımı ve kitaplar hakkındaki bilgilerin yer alacağı arayüz tasarımına geçilecektir.

**Vuforia**

Vuforia, Artırılmış Gerçeklik uygulamalarının oluşturulmasını sağlayan mobil cihazlarla uyumlu arttırılmış gerçeklik yazılım geliştirme kiti sayesinde animasyonda düzlemsel görüntüleri ve 3B nesneleri gerçek zamanlı olarak tanımak ve izlemek için kullandığımız bu görme teknolojisi kullanıldı. Bu görüntü kayıt özelliği, geliştiricilerin 3B modeller ve diğer ortamlar gibi sanal nesneleri, bir mobil cihazın kamerasıyla görüntülendiğinde gerçek dünyadaki nesnelere göre konumlandırmasını ve yönlendirilmesini sağlar. Böylece okuyucunun perspektifi ile nesnenin konumlandırıldığı perspektif aynı konuma karşılık gelir. Böylece sanal nesnenin gerçek dünya sahnesinin bir parçası olduğu haline getirilir.
    Vuforia, Unity oyun motorunun bir uzantısı aracılığıyla Java dilinde Uygulama Programlama Arabirimleri (API) sağlar. Bu şekilde, SDK hem IOS, Android hem de UWP için yerel gelişimi desteklerken, Unity'de her iki platforma da kolayca taşınabilir AR uygulamalarının geliştirilmesini sağlar.

## İş Dağılımı
Grup Üyesi | Saat Yüzdesi
------------ | -------------
Muhammed Bayat | %
Ayşe Kartal | %
Beyza Coşkun | %
