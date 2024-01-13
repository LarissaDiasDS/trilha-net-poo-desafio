using System;

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
{
    {

        Nokia nokia = new Nokia("123456789", "Nokia123", "123456789012345", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Iphone iphone = new Iphone("987654321", "iPhoneX", "987654321098765", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}