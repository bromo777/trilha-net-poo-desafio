using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("48998471317", "14 Pro Max", "1234", 32);
Nokia nokia = new Nokia("69992342009", "Tijolão", "12345", 16);

iphone.Ligar();
nokia.Ligar();
iphone.ReceberLigacao();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("Jogo da cobrinha");

iphone.InformacoesCelular();
nokia.InformacoesCelular();

iphone.ListarApps();
nokia.ListarApps();

iphone.InstalarAplicativo("Whatsapp");
iphone.ListarApps();