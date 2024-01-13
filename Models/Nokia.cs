using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia: Smartphone
    {
       public Nokia(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public override void Ligar()
    {
        Console.WriteLine("Nokia ligando...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Nokia recebendo ligação...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Nokia instalando aplicativo: {nome}");
    }
    }
}