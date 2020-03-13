<p align="center">
  <img src="https://acentesoft.com/images/acentelogoosiyah.png" height="60" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
  <img src="https://lh3.googleusercontent.com/proxy/2AolACWzslhAFNh48fugxRhkYKCwu_8DzuARi8W41LYu0GzR2XMIJgEmPBKYQieRLAT-6_ex8ERICnTKJRIGE1zRd0dsTJC7O2gcCKa98G3CGLEv3dDHRA" height="50" />
</p>



# ArkmanAPILayer
Arkman Flight API için C# dilinde yazılmış bir API Layer kütüphanesi.


<br>

<h1>Kullanım (VB.Net)</h1>
Her isteğin ve geri dönüşün bir Wrapper sınıfı vardır. API ile bütün iletişim bu Wrapper sınıflar ile gerçekleşir. Örneğin uçuş araması yapmak istiyorsak
istek yollarken bir AirSearchWrapper nesnesinin parametrelerini doldurup `Arkman.AirSearch(airSearchWrapper)` fonksiyonuna yollamalıyız. Bu fonksiyon bize
bir `APIResponse` nesnesi dönecektir. Bu nesnenin `responseStr` parametresinde dönüş parametreleri String halinde JSON olarak verilir. Bu dönüş mesajını önce
bir `Newtonsoft.JObject` nesnesi ile JSON objesine çevirip daha sonra bir dönüş Wrapper nesnesine dönüştürmemiz gerekir. Bu örnekte dönüş Wrapper sınıfımız AirSearchResponseWrapper olur.

<br>
<br>

Arkman'ın altyapısından uçak bileti satın alabilmek için tamamlanması gereken 10 adım vardır:

*Heyu
*Meyu


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
