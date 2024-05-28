using System.ComponentModel;
using DesafioPOO.Models;


Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia(numero :"(21)99998-8887", modelo: "Nokia A14", imei: "123456", memoria: 128);
nokia.InstalarAplicativo("telegran");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine($"Meu número é {nokia.Numero} \n \n \n");

Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone(numero: "(21)9999-8888", modelo: "Iphone 6S Plus", imei: "12345678", memoria: 64);
iphone.InstalarAplicativo("Whatsapp");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine($"Meu número é {iphone.Numero}");
