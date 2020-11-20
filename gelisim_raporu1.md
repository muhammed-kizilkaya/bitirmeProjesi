# GELİŞİM RAPORU

## Proje Özeti

Bu proje, kitaplara olan ilgiyi artıracak özgün ve zengin içerikli bir AR uygulaması geliştirmeyi ve bu uygulamanın başarımını EEG sinyalleri ile doğrulamayı amaçlamaktadır. Tasarlanacak özgün bir AR uygulamasının kitap incelemelerinde okuyucular üzerindeki etkisi incelenecektir. AR uygulamaları sayesinde görsel nesnelerin üç boyutlu kullanılması okurların ilgisini çekecek ve konular üzerinde farklı bakış açıları kazanmalarını sağlayacağı beklenilmektedir. Okuyucuların AR kullanılarak tanıtımı yapılan kitaba olan ilgisi ile AR kullanılmadan kitaba olan ilgisi yine okuyucunun beyin sinyallerini inceleyerek araştırılacaktır. Bu araştırma ile kitap ve benzeri ürün tanıtımlarında AR tekniğinin kullanımının etkileri belirlenecektir. Bu etkiler ile AR uygulamalarının yaygınlaşması ve hangi tür noktalarda problem çıkardığı ve çalışma ile belirlenen arayüzlerdeki etkili noktalar önerilerek bu tekniği kullanan geliştiricilere yardımcı bir araştırma sunmak hedeflenmektedir. Geliştirilecek olan AR tekniği analizi ile bu yöntemin görsel hafızadaki etkilerini, kişilere kolaylıklar sağlaması gösterilecektir.    



## Proje Arka Planı

Yapılacak olan projede kullanılacak materyaller son dönemde daha da sık kullanılmakta olan cihazlardır. EEG sinyali ile kişiler beyin sinyallerini kontrol ederek oyun oynayabilmekte, düşüncelerini aktarabilmekte ve daha birçok işlevi yapabilmektedir. 
- [BCI örnek çalışma](https://www.youtube.com/watch?v=D9ADeXGBdJ0)

Ayrıca AR teknolojisi de eğitim, oyun, tasarım gibi alanlarda kullanılmaktadır. 
- [AR örnek çalışma](https://www.youtube.com/watch?v=G7ZzMX771Ug)


Farklılık olarak  yapılacak projede bu teknolojiler bir arada  kullanılarak özgün ve zengin içeriklerle oluşturulacak olan arayüz, AR tasarımı ve kişiler üzerinde analiz yapılarak veriseti oluşturulacaktır. Bu şekilde yöntemin etkileri incelenecektir.

 

## Kullanılacak Teknolojiler

Seçilen katılımcıların beyin sinyallerini  içeren büyük bir veriseti oluşturulacaktır. Bu veriseti üzerinde çeşitli sinyal işleme teknikleri kullanarak beyin loblarından hangisinde AR uygulamasının daha fazla aktivasyon meydana getirdiği gözlemlenecektir. Yapılacak bu analizler ile hem tasarlanacak özgün AR arayüzü uygulamasındaki tecrübeler hem de beynin görsel resim ve animasyonlara tepkisi yayınlanacaktır. Ayrıca Artırılmış Gerçeklik uygulamaları kullanılacaktır. 

- Animasyonda 3B nesneleri gerçek zamanlı olarak tanımak ve izlemek için artırılmış gerçeklik uygulamalarının oluşturulmasını sağlayan mobil cihazlar için artırılmış gerçeklik yazılım geliştirme kiti olan [Vuforia](https://developer.vuforia.com) kullanılacaktır. 

- Yazılımsal kısım ve canlandırmaların tek bir ortamda gösterilerek tasarlanması için [Unity](https://unity.com) , [Unity Vuforia örnek video](https://www.youtube.com/watch?v=MtiUx_szKbI)

kullanılacaktır. Bu uygulama tamamen özgün çizimler ve seslendirmelerle modellenerek bir animasyon oluşturulacaktır. Bu AR uygulamasının kullanımı katılımcılara sunulacaktır. Katılımcıların hem AR uygulaması olmadan kitaplara olan ilgisini hem de Artırılmış gerçeklik (augmented reality) uygulaması ile kitaplara olan ilgisini beyin sinyalleri incelenerek analiz edilecektir.

- Mobil beyin sinyalleri elde etme cihazı 14 kanallı Emotiv EPOC+ kullanılacaktır. 

- 3-Boyutlu modelleri oluşturmak için [MAYA](https://www.autodesk.com.tr/products/maya/overview) kullanılacaktır.

- Yazılım olarak 3B modelleme aracı Maya, oyun motoru Unity ve AR eklentisi Vuforia, EEG sinyallerinin incelenmesinde Matlab ve Python yazılımları kullanılacaktır.

- Beyin-bilgisayar arayüzlerini tasarlama ve test etmek için [OpenVibe](http://openvibe.inria.fr) ve [OpenBCI](https://openbci.com) kütüphaneleri kullanılacaktır.

- Veriler, Matlab EEGLab eklentisi kullanılarak ön işlemeye tabi tutulacak, AAR (Automatic Artifact Removal) kullanılarak gürültülerden temizlenecektir. Yine araç içerisindeki Bağımsız Bileşenler Analizi (Independent Component Analysis, ICA) ile doğal üretilen EEG kaynakları diğer kaynaklardan ayrıştırılacaktır.



## İş Bölümü Planlama

![şema1](https://i.hizliresim.com/h2qJ9h.png)



## Hedeflenen Çıktılar

Proje sonunda yapılması planlanan mobil uygulama kısmında AR tekniği kullanılarak görsel nesnelerin üç boyutlu gösterimi sağlanacaktır. Ayrıca masaüstü uygulamasında ise, EEG sinyalleri ile toplanan verilerin analizi üzerinde AR tekniğinin ne kadar başarılı olacağı test edilip, EEG sinyallerinin alınmasında özgün bir BCI arayüz tasarlanarak kullanıcıya anlaşılır şekilde kolay yönergeler verilecektir. Bu işlemler Windows işletim sistemi üzerinde   Emotiv EPOC+ cihazı sayesinde gerçekleştirilecektir.

Bunların yanı sıra kitaplara olan ilgiyi artıracak özgün ve zengin içerikli uygulama genel kitleye hitap ettiği için kitap almayı etkin bir hale getirerek insanlara okuma alışkanlığı kazandıracaktır.





