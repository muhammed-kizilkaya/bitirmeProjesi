# 2. Gelişim Raporu

## Düzeltmeler
Gantt Şemasının düzeltilmiş hali eklenmiştir.
![img](https://i.hizliresim.com/MG9AM3.png)


## Kaynaklar
1. Pham, Tan ve Patrick. “Cortex-v2-Example” Github, 7 Temmuz 2020, github.com/Emotiv/cortex-v2-example.
2. Baral, Luzan. "Save data to Google Spreadsheet from Unity 3D",Youtube, 26 Mayıs 2017, www.youtube.com/watch?v=z9b5aRfrz7M

## Zorluklar

![anket](/images/unityAnket.png)

Katılımcılara yapılacak olan anket için ilk etapta basit bir arayüz tasarımı ile unity üzerinde form ekranı oluşturuldu ve excel formatında Google Drive'a yedeklendi. Aşağıda veri yazma işileminin nasıl yapıldığı örenek bir resim ile gösterilmiştir. Bu aşamada unity bir oyun geliştirme programı olduğundan bu tarz arayüzsel ve formsal işlevlerde pek tercih edilmediğinden araştırma yapılırken kaynak zorluğu çekildi.
Çözüm olarak, google form oluşturulup kaynak linki gösterilip, herbir textfield için entry kodlarına bakılıp koda eklendi.

![anketgoogle](/images/anketGD.png)

(Unity'den Google form aracılığyla gönderilmiş örnek form)

![unityAR](/images/unityAR.png)

Kitap üzerindeki resimler artırılmış gerçeklik ile gösterileceğinden projenin en önemli kısımlarından unity vuforia kısmında sürüm hataları alındı. Sürüm hatalarını gidermek adına unity 2021 için vuforia eklentisi ve kütüphanleri manuel olarak eklendi. Karşılaşılan bir diğer zorluk ise resimde gözüken mavi ekrana herhangi bir tuş veya kombinasyon olmadan kameradan mavi butona dokunarak modelin (alt resimde) hareket ettirilmesi ve parmağın butondan çekilince animasyonun durdurulması aşamalarıdır. Bu aşamada sorunların çözümlenmesinde Udemy'den alınan vuforia eğitim seti eğitimi detaylıca izlenildi.

![animasyon](/images/animasyon.png)

(Unity model animasyon ve sanal buton)

# Öğrenilen Kavramlar

Form gönderme işlemini ilk etapta Google Firebase üzerinden yapılması planlandı fakat Firebase'de ilerleyen zamanlarda ücret kısıtlamasının sorun yaratabileceğinden dolayı en mantıklı çözüm olarak alttaki kodda da gösterildiği gibi entry id'leri verilerek çözüm sağlandı.



![KodOrnegi](/images/kodOrnegientry.png)


Unity yeni sürümlerinde özellikle LTS(kararlı olamayan sürüm) de unity 2017 ve sonrasında vuforia unity ile beraber gelmiyor. Haricen paket olarak kurulması gerekiyor. Ayrıca ``` 
using Vuforia 
using System.IO.Ports ``` gibi  kütüphaneleri haricen indirip referans göstererek bug'lar giderildi.

***HTML 5 WEBGL öğrenildi.***

WebGL, web tarayıcıları üzerinde 3D grafikler oluşturmak için kullanılan platform bağımsız ve ücretsiz bir API’dir. Ayrıca internet sayfalarında 3 boyutlu görüntüler üretmeye yarayan arabirimdir. HTML 5 ile birlikte çıkan bu sisteme şu anda birçok tarayıcılar tarafından destek verilmekte ve Google Chrome,Firefox gibi sistemlerde kullanılmaktadır.

Bizim projeye faydası gerek windows, gerek linux veya macos gibi işletim sistemlerinde 3d modeli projeyi tam olarak açmamıza olanak sağlıyor olmasıdır.

***PySerial Kavramı Öğrenildi***

Daha öncesinden gerekli şekilde ayarlanmış EMOTİV cihazına başla komutu alması gerektiği ayarlandı. Pyserial kavramı araştırıldı ve öğrenildi.

## Sağlanan kolaylıklar ##

Projenin bitiminde kullanılacak olan cihazda hangi COM portunu kullanmak istiyorsak ve aynı şekilde COM portu kapatıp açtırmak veya hızlıca demo, test, send işlemleri yapmak ve cihazdan dönüt almayı kontrol etmek için ve  işlemleri daha da hızlı hale getirmek ve zaman kazanmak için C# üzerinden windows form ile arayüz geliştirildi.

![serialPort](/images/serialPortOkuma.png)

## BUG ##

![bug](/images/bug.png)

```
PackageVersionLookUpdata.Update: Package Search Request failed UnityEngine.Debug:LogError (object) Vuforia.EditorClasses.PackageVersionLookupService:Update () UnityEditor.EditorApplication:Internal_CallUpdateFunctions () 
```

Build ederken şöyle bir bug almaktayız.

## Örnek Proje GIF gösterimi ##

![bug](/images/GIF-210103_180539.gif)


## Araçlar

Erzurum Teknik Üniversitesi Bilgisayar Mühendisliği laboratuvarı kullanılmaktadır. Laboratuvar ortamı EEG cihazından sinyallerin gürültü binmeyecek şekilde doğru alınabilmesi için sessiz ve floresan lambanın kullanılmadığı uygun ışıklandırmaya sahip bir ortamdır.

Donanımsal araç olarak EEG sinyallerinin alınmasında Emotiv EPOC+ cihazı seçildi.

**Emotiv EPOC+**

Mobil ortamda gösterilecek arayüze ve kitap üstündeki sahneye karşı katılımcının ne kadar etkileşim göstereceğini beyin sinyalleri ile analiz ve elde etmede 14 kanallı Emotiv EPOC+ kullanılmaktadır. EEG cihazı beyinin Frontal, Parietal, Oksipital, Temporal,Serebellum loblarındaki etkileşimi inceleyebilmemiz için AF3, F7, F3, FC5, T7, P7, 02, 02, P8, T8, FC6, F4, F8, AF4 isimli elektrot konumlarından sinyal toplayıp datasetini oluşturmak için kullanılmaktadır. Cihazın örnekleme frekansı 128 sps (2048 Hz dahili), çözünürlüğü 14 bit 1 LSB ve bant genişliği 0.2-45 Hz’dir. Kablosuz özelliği sayesinde 2.4 GHz bandında USB alıcısı ile bilgisayar ortamında kullanılabilmektedir. Cihaz nemli keçeli elektrotlar ile kullanılır. Katılımcıların başına temas eden keçeler yeterince nemlendirilerek beyin sinyallerini daha sağlıklı bir şekilde alınabilmesi için gerekli elktriksel akımı oluşturmaya olanak sağlar. 

Yazılım olarak 3B modelleme aracı Maya, oyun motoru Unity ve AR eklentisi Vuforia, EEG sinyallerinin incelenmesinde Matlab ve Python yazılımları kullanılacaktır.

**Autodesk Maya**

Gerekli 3B modelleme ve animasyonların oluşturulmasında kullanılır.

**Maya ile 3B Modelleme ve Modellemelerin Unity’e Aktarılması**

3B olarak modellenen karakterler hazırlandıktan sonra modellemeler Unity’e aktarılır. Unity modellere ortam hareketlerinin eklenmesinde, animasyon yapımında ve kitaplar hakkındaki bilgilerin yer alacağı arayüz tasarımının hazırlanmasında kullanılacaktır.

**Vuforia**

Vuforia, Artırılmış Gerçeklik uygulamalarının oluşturulmasını sağlayan mobil cihazlarla uyumlu arttırılmış gerçeklik yazılım geliştirme kiti sayesinde animasyonda düzlemsel görüntüleri ve 3B nesneleri gerçek zamanlı olarak tanımak ve izlemek için kullandığımız bu görme teknolojisi kullanıldı. Bu görüntü kayıt özelliği, geliştiricilerin 3B modeller ve diğer ortamlar gibi sanal nesneleri, bir mobil cihazın kamerasıyla görüntülendiğinde gerçek dünyadaki nesnelere göre konumlandırmasını ve yönlendirilmesini sağlar. Böylece okuyucunun perspektifi ile nesnenin konumlandırıldığı perspektif aynı konuma karşılık gelir. Böylece sanal nesnenin gerçek dünya sahnesinin bir parçası olduğu haline getirilir.
    Vuforia, Unity oyun motorunun bir uzantısı aracılığıyla Java dilinde Uygulama Programlama Arabirimleri (API) sağlar. Bu şekilde, SDK hem IOS, Android hem de UWP için yerel gelişimi desteklerken, Unity'de her iki platforma da kolayca taşınabilir AR uygulamalarının geliştirilmesini sağlar.
    
**Unreal Engine 4**
Gerek duyulduğu takdirde ve unity istekleri karşılamadığı durumlarda ve ek olarak grafiksel iyileştirmeler detaylandırmalar gerektiği durumlarda unreal engine 4 kullanılması planlanmaktadır.

**Kullanılacak Platformlar** 
İlk etapta windows üzerinden build edilecek test ve deneme aşamaları yapılacaktır. Ardından yukarıda da bahsedildiği gibi herhangi bir hata ile karşılaşılmadığı sürece WEBGL 
üzerinden gidilmesi hedeflenmektedir. Ek olarak mobil uygulamaya da uyarlanacak ve gerekli adımlar uygulanacaktır.

**Matlab ve Python Yazılımları**

EEG sinyallerinin incelenmesi için cihazının sahip olduğu USB alıcısından sinyallerin alınıp işlenebilmesinde ve katılımcılara deney esnasında gerekli yönlendirmelerin (gözlerini aç, kapa vb.) yapılmasında kullanılacaktır. 

## İş Dağılımı
Grup Üyesi | Saat Yüzdesi
------------ | -------------
Muhammed Bayat | % 40
Ayşe Kartal | % 30
Beyza Coşkun | % 30
