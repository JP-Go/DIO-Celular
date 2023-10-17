// See https://aka.ms/new-console-template for more information
using Celular.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo(nome: "WhatsApp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(
    numero: "456789",
    modelo: "Modelo 2",
    imei: "122122122",
    memoria: 128
);
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nome: "Telegram");
