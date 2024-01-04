

//int sayi = 10;
//int sayi2 = 20;


//// int değeri string tipine dönüştü
//string stringSayi = Convert.ToString(sayi);



//// sayisal değerleri string tipine dönüştürmek için ToString yöntemi kullanılabilir.
//// ToString yöntemi, sadece string'e dönüşüm için özel olarak hazırlanmıştır.
//string stringSayi2 = sayi2.ToString();




//// bool to int convert

//bool isOk = true;

//int boolInt = 0;

//boolInt= Convert.ToInt32(isOk);

//// int tipindeki değişkenler, bool tipine dönüşebilir.
//// bool true değeri int'e dönüşürse 1 değeri olur, bool false değeri int'e dönüşürse 0 değeri olur
//Console.WriteLine(boolInt);  


// int tipini bool tipine
// byte tipini string tipine
// short tipini int tipine
//string tipini int tipine dönüştürelim

#region Örnek tip dönüşümleri
// int tipini bool tipine dönüştürdük
int intSayi = 1;
bool boolSayi =Convert.ToBoolean(intSayi);


// byte tipini string tipine dönüştürdük
byte byteSayi = 15;

string byteString = byteSayi.ToString();

// short to int
short shortSayi = 5;
int shortInt =Convert.ToInt32(shortSayi);


// string tipini int tipine dönüştürdük
string stringSayi = "20";
int stringInt = Convert.ToInt32(stringSayi);


#endregion

// Ondalık değişken tipleri tanımlayalım

double ondalikDouble = 10.5;


//decimal için, yazmış olduğunuz değerin sonuna M dğerini koymanız gerekmektedir.
decimal decimalDegisken = 50.5M;

// float değişkeni için değerin sonuna F değerini yazmanız gerekmektedir.
float floatDegisken = 46.78F;












