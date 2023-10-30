using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste de ligar e instalar aplicativos em smatphones.");
var nokia = new Nokia("987654321", "N95","1564897126aa",64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Nokia home");

var iphone = new Iphone("123456789", "X2","555aple",64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Alexia home");
