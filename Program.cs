using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", iMEI: "1234567890123", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 16", iMEI: "9876543210987", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");