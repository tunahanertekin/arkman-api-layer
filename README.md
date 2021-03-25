<p align="center">
  <img src="https://acentesoft.com/images/acentelogoosiyah.png" height="60" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
</p>



# ArkmanAPILayer
Arkman Flight API için C# dilinde yazılmış bir API Layer kütüphanesi.


<br>

<h1>Kullanım (VB.Net)</h1>

* Her isteğin ve geri dönüşün bir Wrapper sınıfı vardır. API ile bütün iletişim bu Wrapper sınıflar ile gerçekleşir. 
* Örneğin uçuş araması yapmak istiyorsak istek yollarken bir AirSearchWrapper nesnesinin parametrelerini doldurup `Arkman.AirSearch(airSearchWrapper)` fonksiyonuna yollamalıyız. Bu fonksiyon bize bir ``APIResponse`` nesnesi dönecektir. Bu nesnenin ``responseStr`` parametresinde dönüş parametreleri String halinde JSON olarak verilir. Dönüş mesajını önce bir ``Newtonsoft.JObject`` nesnesi ile JSON objesine çevirip daha sonra bir dönüş Wrapper nesnesine dönüştürmemiz gerekir. Bu örnekte dönüş Wrapper sınıfımız AirSearchResponseWrapper olur.

<br>
<br>

Arkman'ın altyapısından uçak bileti satın alabilmek için tamamlanması gereken 8 adım vardır:

* Login
* AirSearch
* UpdatePassengers
* MakePrebooking
* MakePayment
* EndPayment
* FinalizeShopping
* BillingSubmit

Ayrıca her zaman çağırabileceğimiz, girdi olarak ShoppingCartId bekleyen, bize aktif ShoppingCart parametrelerini dönen bir fonksiyon daha vardır:

* GetShoppingCart

Bu 8 fonksiyonun(her biri Arkman Flight API'ye bir Post isteğine tekabül eder) istek ve dönüş parametreleri için yazılmış Wrapper sınıflar vardır:

<hr>

<h2>Login</h2>

- LoginWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  Username | String | Arkman tarafından verilen kullanıcı adı.
  Password | String | Arkman tarafından verilen şifre.
  IsTest | Boolean | Test sırasında ``true`` gönderilmelidir.
  
- LoginResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionId | String | Oluşturulan oturumun ID'si. Bu aşamadan sonraki her istekte kullanılacaktır.
  SessionToken | String | Oluşturulan oturumun anahtarı. Bu aşamadan sonraki her istekte kullanılacaktır.
  IsTest | Boolean | Test sırasında ``true`` değeri döner.

<hr>

<hr>

<h2>AirSearch</h2>

- AirSearchWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Giriş sırasında dönen oturum bilgileri.
  AirSearchOptions | AirSearchOptions | Aranan uçuşa dair bilgilerin tutulduğu parametre.
  AirSearchPaxItems | AirSearchPaxItem[] | Arama sırasında girilen farklı yolcu gruplarını ve onların kişi sayılarını tutan dizi parametresi.
  AirSearchSegments | AirSearchSegment[] | Tarih, çıkış ve varış noktası gibi bilgileri içeren parametre.
  
- AirSearchResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  OriginDestinationOptions | OriginDestinationOption[] | Arama sonucunda dönen uçuş listesi.
  DirectionInd | int | 0: gidiş, 1: dönüş
  IsInternational | Boolean | true: Dış hat uçuşları da listelenmiştir.
  HasError | Boolean | Hata kontrolü.

<hr>

<h2>AirAllocate</h2>

- AirAllocateWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  AllocateItems | AllocateItem[] | Listelenen uçuşlar arasından seçtiğimiz uçuşun ``ProductId``'sini(veya ilaveten ``PriceId``'sini) yolladığımız parametre.
  
- AirAllocateResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Seçilen uçuşa dair birçok bilgiyi içeren 'sepet' parametresi.(Ödeme yöntemleri vs.)
  HasError | Boolean | Hata Kontrolü.

<hr>

<hr>

<h2>UpdatePassengers</h2>

- UpdatePassengersWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  CorporatePin | String | THY Corporate anlaşması gibi girilmesi gereken kodlar.
  ShoppingCartId | String | Sepet ID'si.(Önceki istekte döndü.)
  Contact | Contact | Bileti/biletleri alacak kişinin iletişim bilgileri.
  Passengers | Passenger[] | Bileti alan/adına bilet alınan yolcunun/yolcuların bilgileri.
  
- UpdatePassengersResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Sepet.
  HasError | Boolean | Hata Kontrolü.

<hr>


<hr>

<h2>MakePrebooking</h2>

- MakePrebookingWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  ShoppingCartId | String | Sepet ID'si.
  
- MakePrebookingResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Sepet.
  HasError | Boolean | Hata Kontrolü.

<hr>

<h2>MakePayment</h2>

- MakePaymentWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  ShoppingCartId | String | Sepet ID'si.
  PaymentType | String | ``CurrentPayment`` ya da ``ThreeDPayment`` olarak gönderilebilir.
  Amount | Double | Biletin/biletlerin fiyatı.
  
- MakePaymentResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Sepet.
  HasError | Boolean | Hata Kontrolü.

<hr>

<hr>

<h2>EndPayment</h2>

- EndPaymentWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  ShoppingCartId | String | Sepet ID'si.
  PaymentType | String | ``CurrentPayment`` ya da ``ThreeDPayment`` olarak gönderilebilir.
  Amount | Double | Biletin/biletlerin fiyatı.
  PayableBank | String | Seçilen banka.(ShoppingCart->PaymentOption->InstallmentOptions içindeki BankName)
  PaymentForm | PaymentForm | Kart ve ödeme bilgileri.
  
- EndPaymentResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Sepet.
  HasError | Boolean | Hata Kontrolü.
  ServiceError | ServiceError | Hata detayları.

<hr>

<h2>FinalizeShopping</h2>

- FinalizeShoppingWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  ShoppingCartId | String | Sepet ID'si.
  
- FinalizeShoppingResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Sepet.
  HasError | Boolean | Hata Kontrolü.
  ServiceError | ServiceError | Hata detayları.

<hr>

<hr>

<h2>BillingSubmit</h2>

- BillingSubmitWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  ShoppingCartId | String | Sepet ID'si.
  BillingInformation | BillingInformation | Fatura bilgileri.
  
- BillingSubmitResponseWrapper
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  ShoppingCart | ShoppingCart | Sepet.
  HasError | Boolean | Hata Kontrolü.
  ServiceError | ServiceError | Hata detayları.

<hr>

<h2>GetShoppingCart</h2>

Bilet satış senaryosu içerisinde ``ShoppingCartId``'ye sahip olunan herhangi bir yerde kullanılabilir.

- GetShoppingCartWrapper (request)
  
  Parametre Adı | Tür | Açıklama
  ------------ | ------------- | -------------
  SessionHeader | SessionHeader | Oturum bilgileri.
  ShoppingCartId | String | Sepet ID'si.
  
<hr>



<br>
<br>
<br>

- <h2>API Bağlantısı (Login)</h2>
  API kullanımının ilk aşamasıdır. Bu isteğin dönüşünde alınan Session parametreleri sonraki bütün isteklerde kullanılacaktır.
  
  - <h3>İstek</h3>
    
    ````vb
        Dim arkman As Arkman = New Arkman()

        'İstek oluşturma ve sonuç alma
        Dim loginWrapper As LoginWrapper = New LoginWrapper("test@met-aybilisim.com", "metay123", True)
        Dim apiResponse As APIResponse = arkman.Login(loginWrapper)

        
    ````

  - <h3>Dönüşü Objeye Çevirme</h3>

    ````vb
        'String haldeki JSON'u objeye çevirme
        Dim responseJson As JObject = JObject.Parse(apiResponse.responseStr)
        Dim loginResponseWrapper As LoginResponseWrapper = responseJson.ToObject(Of LoginResponseWrapper)()
    ````
    
- <h2>Uçuş Arama (AirSearch)</h2>

  - <h3>İstek</h3>
    
    ````vb
        Dim arkman As Arkman = New Arkman()

        'Sırasıyla obje parametreleri --> (String)sessionId, (String)sessionToken
        Dim sessionHeader As SessionHeader = New SessionHeader("***SessionId***", "***SessionToken***")
        'Sırasıyla obje parametreleri --> (String)flightType, (String)cabinType, (String)refundableType, (Boolean)directFlightsOnly, (Boolean)availableFlightsOnly, (String)fareDisplayType
        Dim airSearchOptions As AirSearchOptions = New AirSearchOptions("_flightType", "_cabinType", "_refundableType", "_currency", True, True, "_fareDisplayType")

        'Her yolcu grubu için bir AirSearchPaxItem tanımlanır. Örn. 2 yetişkin ve 1 genç varsa
        '2 yolcu grubu olur. Yolcu sayıları da bu gruplardaki yolcu sayılarıdır.
        Dim yolcuGrubu1 As AirSearchPaxItem = New AirSearchPaxItem("ADT", 2)
        Dim yolcuGrubu2 As AirSearchPaxItem = New AirSearchPaxItem("YTH", 1)

        Dim airSearchPaxItems(2) As AirSearchPaxItem
        airSearchPaxItems(0) = yolcuGrubu1
        airSearchPaxItems(1) = yolcuGrubu2

        'AirSearchSegment objesinin parametreleri --> (int)sequenceNo, (String)departureDay, (Origin)origin, (Destination)destination
        'Origin ve Destination objelerinin parametreleri --> (String)airportCode, (Boolean)isCity
        Dim airSearchSegments(1) As AirSearchSegment
        Dim origin As Origin = New Origin("IST", False)
        Dim destination As Destination = New Destination("ESB", False)
        airSearchSegments(0) = New AirSearchSegment(1, "15.03.2020", origin, destination)

        Dim airSearchWrapper As AirSearchWrapper = New AirSearchWrapper(sessionHeader, airSearchOptions, airSearchPaxItems, airSearchSegments)
        Dim apiResponse As APIResponse = arkman.AirSearch(airSearchWrapper)
        
    ````

  - <h3>Dönüşü Objeye Çevirme</h3>

    ````vb
        'String haldeki JSON'u objeye çevirme
        Dim responseJson As JObject = JObject.Parse(apiResponse.responseStr)
        Dim airSearchResponseWrapper As AirSearchResponseWrapper = responseJson.ToObject(Of AirSearchResponseWrapper)()
    ````
    

- <h2>Yer Ayırtma (AirAllocate)</h2>

  - <h3>İstek</h3>
    
    ````vb
        Dim arkman As Arkman = New Arkman()

        Dim sessionHeader As SessionHeader = New SessionHeader("***SessionId***", "***SessionToken***")

        'AllocateItem objesinin parametreleri --> (String)productId, (String)priceId, (int)markupFare
        Dim allocateItems(1) As AllocateItem
        allocateItems(1) = New AllocateItem(_productId, _priceId, 0)

        Dim airAllocateWrapper As AirAllocateWrapper = New AirAllocateWrapper(sessionHeader, airAllocateWrapper)
        Dim apiResponse As APIResponse = arkman.AirAllocate(airAllocateWrapper)
        
    ````

  - <h3>Dönüşü Objeye Çevirme</h3>

    ````vb
        'String haldeki JSON'u objeye çevirme
        Dim responseJson As JObject = JObject.Parse(apiResponse.responseStr)
        Dim airAllocateResponseWrapper As AirAllocateResponseWrapper = responseJson.ToObject(Of AirAllocateResponseWrapper)()
    ````
