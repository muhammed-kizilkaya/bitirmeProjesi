# 1. Gelişim Raporu (Bitirme Projesi 2)

## Düzeltmeler
- Önceden yapılan Çifte Minare modeline ek olarak Maya ile Yakutiye Medresesi ve Erzurum Kalesi olmak üzere 2 modelleme yapıldı ve bu modellerin dokuları eklendi. Ayrıca bu modellere Unity ile AR uygulaması yapıldı.
<p float="left">
  <img src="/images/unityEkran1.png" width="500" height="250"/>
  <img src="/images/unityEkran2.png" width="500" height="250" /> 
</p>

- Unity ekranında kamera açılınca modellerin AR ile gösterilmesi sırasında her modelin daha detaylı incelenmesi ve konumlarının her açıdan görülebilmesi, ayrıca boyut ve dönme hareketlerinin ayarlanması için Canvas ekranı ve ekranın üzerine butonlar eklendi. Böylece modeller istenildiği kadar döndürülecek ve boyutu ayarlanabilecektir.  
<p float="left">
  <img src="/images/unityEkran3.png" width="800" height="400"/>
</p>

- Aşağıdaki ekran videosunda görüldüğü gibi vuforia eklentisi kullanılarak 3 model AR ile gösterilmiştir. Ayrıca Multi Target yapılmasının nedeni tek bir ekranda farklı resimlerin gösterilmesiyle, mobil cihaz üzerinde modellerin AR geçişi hızlı ve kolay bir şekilde yapılmış oldu.
<p float="left">
  <img src= "/images/unityvideo.gif" width="1100" height="600"/>
</p>

- Multi Target için seçilen resimler yani target'lar aşağıda gösterilmiştir. Her target, ait olduğu modelin kitaptaki görseline göre ayarlanmıştır. Böylece modellerin birbirlerinden ayırt edilmesi kolaylaştırılmıştır.
<p float="left">
  <img src="/images/targetKale.png" width="300" height="220" />
  <img src="/images/targetMinare.png" width="300" height="220" /> 
  <img src="/images/targetYakutiye.png" width="300"  height="220" />
</p>

- 1.dönemde bahsedilen final sunumuna ek olarak ilerleme kat edilen emotiv kısmındaki marker hatası giderildi. Aşağıda da görüldüğü gibi Python ve Emotiv arasında WebSocket ile local bağlantı kurulup örnek bir test marker kaydı alındı.
![Marker](/images/marker_ekran_kaydi1.gif)


## Kaynaklar
1. Wanderson. _"PYTHON and QT QUICK - Custom Buttons With QML And JavaScript - [MODERN GUI]"_, Youtube, 24 Kasım 2020, https://www.youtube.com/watch?v=JhPXOcmXf8I.
2. Temlioğlu, Eyüp. _"PyQt5 Signal - Slot (İşaret - İşlev) Kavramı"_, WebPage, 20 Şubat 2019, http://yapayzekalabs.blogspot.com/2019/02/pyqt5-signal-slot.html
3. Amcalar, Armagan. _“Wits — A Node.js library that reads your mind with Emotiv EPOC EEG headset”_, Github, 11 Mart 2019, https://github.com/dashersw/wits


## Zorluklar

- Projenin ilerleyen kısımlarında EEG kaydı ile tüm adımların sınırlı bir süre içinde ilerlemesi gerektiği ve işlerin daha düzenli ve seri bir şekilde devam etmesi gerektiği için  bir arayüz tasarımı yapılmaya ve araştırılmaya başlanıldı. Tüm dillerin arayüz kütüphaneleri araştırıldı, istekleri karşılayan bir kütüphane düşünüldü ve araştırmalar sırasında, yeni karşılaşılan bir arayüz programı öğrenildi(QT5 Designer). Daha sonra gerekli tasarım yapıldı ve kodlar yazıldı.   

![QTdesing](/images/qtDesignerGui.png)

- Arayüzün tasarım kısmı .QML ile, kodlama kısmı ise python ile hazırlandı. Farklı olan pyside2 de yine qt'ye ait olan ve .ui tasarım yapabilen ama genel işlevi aynı olan arayüz programıdır.


**self.browser = QWebEngineView()**
**PyQt5.QtWebEngine**  kütüphanesi kullanılarak GUI üzerinde timer'a bağlı olarak daha önce hazırlanmış olan anket soruları ile katılımcılardan belirli sürede doldurulması istenildiği için arayüze ekleme adımı uygulandı. Doc ve github profillerinde uygun bir kod bulunup gerekli düzenlemeler yapıldı.

- Katılımcılara deneye başlamadan önce ve deneyden sonra sunulacak anket soruları aşağıdaki gibidir. Bu sorular katılımcıların durumunun analiz edilmesi için yapılmıştır.

![anket1](/images/anket1.png)
- Alttaki Arayüz ekranında 2 numara ile gösterilen buton ile yukarıda da bahsedilen form ekranına gidilmesi amaçlanmıştır. Fakat bu kısımda ilerleme kat edilememiştir.

- Aşağıda görüldüğü gibi bir arayüz hazırlanmıştır. Bu arayüzde katılımcının bazal metabolizma durumuna en yakın halde olması için kayda başlamadan önce bir baseline ekranı tasarlanarak deneye hazır hale getirilmesi gerektiği düşünülmüştür. Bu yüzden emotiv programındaki baseline ekranına benzer bir tasarım yapılarak hazırlanan arayüze entegre edilmiştir. 
![gui1](/images/gui1.png)

- Baseline çözümünde ilk olarak katılımcının ekrana odaklanıp bir şey düşünmemesi ve rahatlaması için 15 saniyelik bir süre verilmiştir. Daha sonra aynı amaç doğrultusunda katılımcının bu sefer gözleri kapalı bir şekilde tekrardan 15 saniyelik süre tutularak işlem tamamlanmıştır.

<p float="left">
  <img src="/images/gui2.png" width="470" height="240" />
  <img src="/images/gui3.png" width="470" height="240" /> 
</p>

- Programın çok fazla python ve kütüphane hataları vermesinden kaynaklı programı executable hale getirerek zorluklara çözüm üretilmeye çalışılmıştır.

>pip install cx_Freeze kütüphanesi ile tüm main.py  kodumuzu exe çevirebilmekteyiz.

**örnek demo ekranı**

![eexe](/images/exegui.gif)

### Çözülemeyen Sorunlar
Timer fonksiyonu consolda sorunsuz çalışırken gerekli seslendirmeleri ve timer beep sesini çıkartırken , self.ui.timer_label.set_text(timer()) yerinde yani label update kısmında sadece set text()-> 0 çıktısı veriyor. Alternatif olarak Qtimer kullandık henüz label setText sorunu devam ediyor. Farklı çözüm yolları aramaktayız.

3 Numaralı butonda kayıt almamız için gerekli kodlar hazır iken karşılaştığımız sorun, marker.py (üsteki gifte örnek verilen python dosyası)  main.py(gui) de sadece import edildiğinde bile direk consolda kayda başlaması ve arayüzü çalıştırmaması.

Buton click olayı ile kayıt tutmasını ve timer ile süre tutmasını ayarlamaya çalışmaktayız. Alternatif farklı çözümler arayışımız devam etmektedir.

Python Selenium ile veya eşdeğer farklı bir metot ile gui için gerekli düzenlemeler için çalışmalar,araştırmalar devam etmektedir.

### Çok kısa kodların amaçları 

> browser.py -> python gui QWebEngineView ile websitesi gösterme Anket için kullanacak
> main.py -> Ana kodlarımızın düzenlendiği alan
> setup.py -> Programımızın exe haline çevirmek için ayarlanmış kod hali -> cmd  > python  setup.py build build adlı klasöre tüm kütüphanelerin dll ile birlikte sorunsuz bir exe çıktısı verdi
> ui_main.py, ui_function.py -> arayüzün .py dönüştürülmüş hali
> QT klasördeki kodlar ise aynı gui farklı denenmiş hali, qml javascript çok yakın bir dil ve tasarım odaklı kullanıldı
> 

## Araçlar

- **Unity**
    Unity oyun motoru, sanal ortamı tasarlamaya çalışırken çalışmayı önizlemek için bir AR modu sunar.
    
- **Unity Vuforia**
    Artırılmış Gerçeklik uygulamalarının oluşturulmasında, 3B nesneleri gerçek zamanlı olarak görmek ve incelemek için kullanıldı. Ayrıca 3B modelleri ve diğer sanal nesneleri, mobil cihazın kamerasıyla görüntülendiğinde gerçek dünyaya göre konumlandırılmasını, yönlendirilmesini de sağlar. Böylece okuyucunun zihninde metinde tasvir edilen mekanın canlandırılması ve sanal nesnenin gerçek dünyanın bir parçası haline getirilmesi sağlanır. Bu işlemleri Vuforia, Unity'de Programlama Arabirimleri (API), SDK'lar (Andoid vs.) ile gerçekleştirerek AR sahne tasarımı uygulamalarının geliştirilmesini sağlar.
    
- **Maya**
    Autodesk'in 3B bilgisayar animasyonu oluşturmaya olanak tanıyan yazılım geliştirme aracıdır. 3B animasyon, modelleme, işleme, gölgeleme gibi araçlarla 3B varlıkları oluşturmalarına olanak tanır. Diğer benzer 3B modelleme ve işleme yazılımı araçlarından daha fazla işletim sistemiyle uyumlu olduğundan tercih edildi.
    
- **EchoAr**
    Hızlı bir şekilde 3B uygulama ve içerik oluşturup dağıtmasına yardımcı olmak için araçlar ve sunucu tarafı altyapısı sağlayan bir VR/AR bulut platformudur. Esnek bulut altyapısı, 3D içeriği kolayca yönetip AR uygulamalarında çok basit bir yolla yayınlamasını sağlar. Ücretsiz versiyonunda Ar için alternatif sınırlı erişim istekleri karşılamadığı ve platforma yüklenecek dosya boyutunun yetersiz olmasından dolayı devam edilmedi.
    
- **Python MNE** 
    MEG, EEG gibi insan nörofizyolojik verileri keşfetmek, görselleştirmek ve analiz etmek için EDF formatına dönüştürülmüş veriyi işlemeye olanak sağlayan açık kaynaklı bir Python paketidir.
    
- **Python Pyside2- Pyside6, PyQt5, Qt Designer, QtCreator**
    Grafiksel arayüz (GUI) sunmak için kullanılan Python kütüphaneleridir.
    
- **Emotiv PRO**
    Beyin sinyallerini analiz edip, takip etmeyi sağlayan ve sinyallerin kayıt alınıp düzenlenmesini sağlayan program.
    
- **Vs Code, PyCharm 2020.3.5, Spyder(Anaconda3)**
    Kullanılan programlama araçları.
