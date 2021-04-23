# 1. Gelişim Raporu (Bitirme Projesi 2)

## Düzeltmeler
- Unity kısmında önceden yapılan modellere ek olarak Yakutiye Medresesi ve Erzurum Kalesi olmak üzere 2 model ve bu modellerin dokuları eklenmiştir. Ayrıca bu modellere AR tasarımı yapılmıştır.
![unityEkranı1](/images/unityEkran1.png)
![unityEkranı2](/images/unityEkran2.png)
![unityEkranı3Canvas](/images/unityEkran3.png)
![unityGif](/images/unityvideo.gif)

- 1.dönemde bahsedilen final sunumuna ek olarak ilerleme kat edilen emotiv kısmındaki marker hatası giderildi. Aşağıda da görüldüğü gibi Python ve Emotiv arasında WebSocket ile local bağlantı kurulup örnek bir test marker kaydı alındı.

![Marker](/images/marker_ekran_kaydi1.gif)

## Kaynaklar
1. Wanderson. _"PYTHON and QT QUICK - Custom Buttons With QML And JavaScript - [MODERN GUI]"_, Youtube, 24 Kasım 2020, https://www.youtube.com/watch?v=JhPXOcmXf8I.
2. Temlioğlu, Eyüp. _"PyQt5 Signal - Slot (İşaret - İşlev) Kavramı"_, WebPage, 20 Şubat 2019, http://yapayzekalabs.blogspot.com/2019/02/pyqt5-signal-slot.html

## Zorluklar

Projenin ilerleyen kısımlarında ihtiyaç duyulduğu için ve işleri daha düzenli ve seri EEG kaydı alıp süre tutmamız ve belirli bir süre içinde tüm adımların zamanlama ile yapılması için bir arayüz tasarımı yapılmaya ve araştırılmaya başlandı. Tüm dillerin arayüz kütüphanleri araştırıldı, istekleri karşılayan bir kütüphane düşünüldü ve araştırmalar sırasında, yeni karşılaştığımız bir arayüz programı öğrenildi(QT5 Designer), Gerekli tasarım ve kodlar yazıldı.   

![QTdesing](/images/qtDesignerGui.png)

Arayüzün tasarım kısmı .QML ile kodlama kısmı python ile hazırlandı. Bi farklı pyside2 de yine qt ait olan .ui tasarım yapabilen ama genel işlevi aynı olan arayüz programı.



**self.browser = QWebEngineView()**
**PyQt5.QtWebEngine**  kütüphanesi kullanılarak GUI üzerinde timer'a bağlı olarak daha önce hazırlanmış olan anket sorularımız ile belirli sürede doldurmasını isteyeceğimiz için arayüze ekleme adımını uyguladık. Doc ve github profillerinde uygun bir kod bulup gerekli düzenlemeleri yaptık.

Alttaki resimde de 2 numaralı buton ile gösterilen yerde gui göstermeye çalıştık.[ Çözülemeyen Sorunlar 1] 


![anket1](/images/anket1.png)

(Belirli bir sürede anketi doldurup kayda geçecek olan deneye başlayacak kişinin doldurmasını istediğimiz anket soruları ekranı.)(-)


![gui1](/images/gui1.png)
Üsteki örnek resimde de gözüktüğü gibi bir arayüz hazırlandı. İlk etapta kullanıcı EEG cihazına bağlı olacağı için ve kayıtlarda gürültü olmaması adına 4 numaralı butondaki gibi bir baseline ihtiyacı doğdu.
![gui2](/images/gui2.png)
Bunun çözümü için kullanıcının ilk olarak ekrana odaklanıp 15 saniye boyunca kafasını boşaltması ve rahatlanması için bir süre verildi.

![gui3](/images/gui3.png)
15 saniye dolumundan sonra ise bu sefer gözleri kapalı bir şekilde tekrardan 15 saniye süre tutuldu. 
### Çözülemeyen Sorunlar
Timer fonksiyonu consolda sorunsuz çalışırken gerekli seslendirmeleri ve timer beep sesini çıkartırken , self.ui.timer_label.set_text(timer()) yerinde yani label update kısmında sadece set text()-> 0 çıktısı veriyor. Alternatif olarak Qtimer kullandık henüz label setText sorunu devam ediyor. Farklı çözüm yolları aramaktayız.

3 Numaralı butonda kayıt almamız için gerekli kodlar hazır iken karşılaştığımız sorun, marker.py (üsteki gifte örnek verilen python dosyası)  main.py(gui) de sadece import edildiğinde bile direk consolda kayda başlaması ve arayüzü çalıştırmaması.

Buton click olayı ile kayıt tutmasını ve timer ile süre tutmasını ayarlamaya çalışmaktayız. Alternatif farklı çözümler arayışımız devam etmektedir.

Python Selenium ile veya eşdeğer farklı bir metot ile gui için gerekli düzenlemeler için çalışmalar,araştırmalar devam etmektedir.

## Araçlar

- **Unity Vuforia** ( *AR sahne tasarımı* )
- **EchoAr** (*Ar için alternatif "sınırlı erişim istekleri karşılamadığı için devam edilmedi.*) 
- **Python MNE** (*MEG/EEG analizi- EDF formatına dönüştürülmüş veriyi işleme*)
- **Python Pyside2- Pyside6, PyQt5, Qt Designer, QtCreator** (*Arayüz için kullanılan python araçları*) 
- **Emotiv PRO**(*Beyin sinyallerini takip etmemiz ve kayıt alıp düzenlememiz için gerekli uygulama*)
- **Vs Code, PyCharm 2020.3.5, Spyder(Anaconda3)**()
