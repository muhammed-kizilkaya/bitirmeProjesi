# GELİŞİM RAPORU

## PROJE ÖZETİ

 Tasarlanacak özgün bir AR uygulamasının kitap incelemelerinde okuyucular üzerindeki etkisi incelenecektir. AR uygulamaları sayesinde görsel nesnelerin üç boyutlu kullanılması okurların ilgisini çekecek ve konular üzerinde farklı bakış açıları kazanmalarını sağlayacağı beklenilmektedir. Okuyucuların AR kullanılarak tanıtımı yapılan kitaba olan ilgisi ile AR kullanılmadan kitaba olan ilgisi yine okuyucunun beyin sinyallerini inceleyerek araştıracağız. Bu araştırma ile kitap ve benzeri ürün tanıtımlarında AR tekniğinin kullanımının etkilerini belirlemiş olacağız. Bu etkiler ile AR uygulamalarının yaygınlaşması ve hangi tür noktalarda problem çıkardığı ve çalışma ile belirlenen arayüzlerdeki etkili noktalar önerilerek bu tekniği kullanan geliştiricilere yardımcı bir araştırma sunmayı hedefliyoruz.Bu proje, kitaplara olan ilgiyi artıracak özgün ve zengin içerikli bir AR uygulaması geliştirmeyi ve bu uygulamanın başarımını EEG sinyalleri ile doğrulamayı amaçlamaktadır.   

## Proje Arka Planı



## Kullanılacak Teknolojiler

Beyin sinyalleri incelenirken yapay zeka tekniklerinden Derin Öğrenme yöntemi kullanılacaktır. Bunun için yeterince miktarda katılımcı ile büyük bir veriseti oluşturulacaktır. Bu veriseti üzerinde çeşitli sinyal işleme teknikleri kullanarak beyin loblarından hangisinde AR uygulamasının daha fazla aktivasyon meydana getirdiğini gözlemlemeyi düşünüyoruz. Yapacağımız bu analizler ile hem tasarlayacağımız özgün AR arayüzü uygulamasındaki tecrübelerimizi hem de beynin görsel resim ve animasyonlara tepkisini yayınlayacağız.

Okuma alışkanlığını kazandırma amacıyla 2011 yılında deklare edilen Endüstri 4.0 isimli 4. sanayi devriminin en önemli bileşenlerinden birisi olan Artırılmış Gerçeklik uygulamaları kullanılacaktır.

Animasyonda 3B nesneleri gerçek zamanlı olarak tanımak ve izlemek için artırılmış gerçeklik uygulamalarının oluşturulmasını sağlayan mobil cihazlar için artırılmış gerçeklik yazılım geliştirme kiti olan 

[Vuforia]: (https://developer.vuforia.com)

 kullanılacaktır. 

Yazılımsal kısım ve canlandırmaların tek bir ortamda gösterilerek tasarlanması için 

[Unity]: (https://unity.com)

 kullanılacaktır. Bu uygulama tamamen özgün çizimler ve seslendirmelerle modellenerek bir animasyon oluşturulacaktır. Bu AR uygulamasının kullanımını katılımcılara sunacağız. Katılımcıların hem AR uygulaması olmadan kitaplara olan ilgisini hem de Artırılmış gerçeklik (augmented reality) uygulaması ile kitaplara olan ilgisini beyin sinyallerini inceleyerek analiz edeceğiz.

 Mobil beyin sinyalleri elde etme cihazı 14 kanallı **Emotiv EPOC+** kullanılacaktır. 

3-Boyutlu modelleri oluşturmak için 

[MAYA]: (https://www.autodesk.com.tr/products/maya/overview)

kullanılacaktır.

Yazılım olarak 3B modelleme aracı Maya, oyun motoru Unity ve AR eklentisi Vuforia, EEG sinyallerinin incelenmesinde Matlab ve Python yazılımları kullanılacaktır.

Beyin-bilgisayar arayüzlerini tasarlama ve test etmek için 

[OpenVibe]: (http://openvibe.inria.fr)

kullanılacaktır.

 Veriler, Matlab EEGLab eklentisi kullanılarak ön işlemeye tabi tutulacak, AAR (Automatic Artifact Removal) kullanılarak gürültülerden temizlenecektir. Yine araç içerisindeki Bağımsız Bileşenler Analizi (Independent Component Analysis, ICA) ile doğal üretilen EEG kaynakları diğer kaynaklardan ayrıştırılacaktır.

  EEG sinyalleri elde edilirken, sinyallere gürültü de (deri veya terlemeden kaynaklanan potansiyellerden oluşan veya nörolojik olmayan sinyaller) karışmaktadır. Çalışmada EEG sinyalleri 0.16-45 Hz band geçiren filtreden geçirilerek kullanılacaktır. Daha sonra sinyaller deney protokolünde ayrılan periyotlara bölütlenecek ve her periyot arasındaki baseline süresi çıkarılacaktır.

 Derin Öğrenme tekniğinde girdi olarak kullanılan veriler görsel olarak resim matrisi olarak algılanır. EEG elektrotları, 3-boyutlu bir alanda kafa derisi üzerine dağıldığından bu dağılımı derin öğrenmede kullanılacak girdi matrisine dönüştürmek gerekir. Uzaysal olarak dağıtılmış aktivite haritalarını, 2-boyutlu görüntülere dönüştürmek için, öncelikle 3-boyutlu bölgedeki elektrotların yerinin, 2-boyutlu projeksiyonunun yapılması gerekir. Görüntü-benzeri yapıların genişliği ve yüksekliği korteks üzerindeki etkinliklerin uzaysal dağılımını temsil eder. Kafatası üzerinde yayılmış güç ölçümlerinin interpolasyonu yapılır ve boyutları elektrot sayısı (n) kadar olan nxn’lik mesh matrisleri üretilir. Bu prosedür, her bir frekans bandı için tekrarlanır ve her bir frekans bandına karşılık gelen üç temel topografik aktivite haritası elde edilir. Üç uzamsal harita, daha sonra üç farklı rengi temsil eden kanal ile görüntü-benzeri yapı oluşturmak için birleştirilir. Bu üç kanallı görüntü, derin öğrenme yapısına sahip sinir ağına girdi olarak verilecektir

# İş Bölümü Planlama

![şema1](https://i.hizliresim.com/5mv7N8.png)



# Hedeflenen Çıktılar

Bilgisayar ve mobil ortamda geliştirilecek bu uygulamada kitaplara olan ilgiyi artıracak özgün ve zengin içerikli bir AR uygulaması geliştirmeyi ve bu uygulamanın başarımını EEG sinyalleri ile doğrulamayı amaçlamaktadır.   
