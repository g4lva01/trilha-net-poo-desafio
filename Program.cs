using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(Numero: "986213527", Modelo: "Modelo 1", IMEI: "111111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("AnimeTV");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(Numero: "40028922", Modelo: "modelo 2", IMEI: "222222222", Memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Crunchyroll");

Console.WriteLine("\n");