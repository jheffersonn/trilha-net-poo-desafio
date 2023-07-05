using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n = new Nokia("12133", "abcee", "sdfefeqwe", 64);
n.InstalarAplicativo($"WhatsApp - Número: {n.Numero} , IMEI: {n.IMEI}");
n.Ligar();
n.ReceberLigacao();

Console.WriteLine("--------------------------------------------------");


Iphone i = new Iphone("12122", "abcdd", "sdfefeasd", 128);
i.InstalarAplicativo($"Telegram - Número: {i.Numero} , IMEI: {i.IMEI}");
i.Ligar();
i.ReceberLigacao();
