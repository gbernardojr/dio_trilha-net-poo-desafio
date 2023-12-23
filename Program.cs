using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia...");
Smartphone nokia = new Nokia(numero:"123456789", modelo:"Modelo Nokia", imei:"123321",32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone IPhone...");
Smartphone iphone = new Iphone(numero:"987654211", modelo:"Modelo IPhone", imei:"9875748",128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
