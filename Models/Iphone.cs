using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public override void Ligar()
    {
        Console.WriteLine("iPhone ligando...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("iPhone recebendo ligação...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"iPhone instalando aplicativo: {nome}");
    }
    }
}