using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smatphone Nokia Tijolão:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 125 );
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone 14:");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 125 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");