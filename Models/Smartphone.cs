using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected int Memoria { get; set; }

    public abstract void Ligar();
    public abstract void ReceberLigacao();
    public abstract void InstalarAplicativo(string nome);
    }
       
}