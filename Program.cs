using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("87888501", "Lumia", "123456789", 256);
Smartphone iphone = new Iphone("88871580", "Iphone 11", "987654321", 128);

Console.Clear();

Console.WriteLine("Iniciando o Smartphone Nokia...");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("ZapZap");

Console.WriteLine("\n");

Console.WriteLine("Iniciando o Smartphone Iphone...");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

