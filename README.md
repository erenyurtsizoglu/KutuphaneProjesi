Bu projede giriş ekranı bizi karşılıyor. Burada bizden kullanıcı adı ve şifre isteniyor. İstenilenleri doldurup giriş butonuna basınca program ilk başta değerlerin doldurulup doldurulmadığını kontrol ediyor eğer doldurulmuşsa kullanıcının başta ve sonda basabileceği boşlukları temizliyor ve şifreyi md5 şifreleme fonksiyonu ile şifreleyip sonrasında veri tabanından girilen değerlerin doğruluğunu kontrol ediyor eğer yanlış girilmişse hata ekranını gösteriyor değerler doğruysa ana ekran açılıyor.

Ana ekranda hangi kullanıcının giriş yaptığı alt tarafta belirtiliyor. Kütüphane yönetimi, üye yönetimi, kitap teslim ver ve kitap teslim al seçenekleri bizi karşılıyor.

Kitap yönetimi seçeneğini seçersek yeni bir ekran açılıyor ve veri tabanında bulunan kitaplar gösteriliyor. Üst tarafta işlemler sekmesinde yeni kitap ekle ve tanımlamalar seçeneği sunuluyor. Tanımlamaların içinde kitap kategorileri, kitap türleri ve yazarlar sunuluyor. 

Kitap kategorileri seçilirse yeni bir kayıt eklemek için kategoriyi yazıp kaydet tuşuna basabilirsiniz ama eğer bu kayıt zaten listede mevcut ise eklenme başarısız olacak ve kontrol etmenizi isteyecek ya da kayıt listede yoksa listeye kaydedilecek ve liste yenilenecek. Bir kategorinin üzerine çift tıklarsanız kaydet olarak görünen buton düzenlemeler olarak yenilenir ve düzenlemenizi yapıp butona tıklanınca aynı kategoride giriş olup olmadığını kontrol eder eğer yoksa kategori yenilenir ve tekrardan buton kaydet olarak gözükür. kategoriyi silmeyi sil butonu ile yapabilirsiniz. Çift tıklayıp sonradan işlemden vazgeçtiyseniz seçili kaldır butonuna tıklayarak temizleyebilirsiniz. 

Kitap kategorileri için geçerli olan işlemler kitap türleri ve yazarlar sekmesinde benzer şekilde ilerliyor.

Yeni kitap ekle seçeneği seçilirse kitap kategorisi, kitap türü, yazar hazır olarak geliyor yapmanız gereken seçim yapmak ve diğer istenen bilgiler girilerek bilgileri kaydet butonuna basabilirsiniz.

Ana sayfadaki üye yönetimi seçeneği ise kütüphaneye kayıtlı olan kullanıcıları gösterir. Yeni üye eklemek için gerekli alanlar doldurulur ancak bir üye ile diğer üyenin e-maili ve telefon numarası aynı olamayacağı için aynı girildiği takdirde işlem hata verir ve kontrol etmenizi ister. Kayıtlı bir üye için üzerine çift tıklayıp bilgiler düzenlenebilir fakat e mail ve telefon benzersiz olmalıdır veya sil butonu ile üye silinebilir.

Ana sayfadaki kitap ver seçeneği seçilirse kitabın adını ve üyenin adını seçmenizi ister doldurup kitabı teslim et butonuna tıklayabilirsiniz.

Ana sayfadaki kitap teslim al seçeneği seçilirse üyelerin adları gelir üye adı seçilir üye eğer kitap almışsa aldığı kitap listelenir çift tıkladıktan sonra kitabı teslim al butonuna tıklayarak teslim alabilirsiniz.

 
