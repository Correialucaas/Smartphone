public abstract class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Ligando o celular " + Marca + " " + Modelo);
    }

    public void Desligar()
    {
        Console.WriteLine("Desligando o celular " + Marca + " " + Modelo);
    }

    public abstract void FazerLigacao(string numero);

    public abstract void EnviarMensagem(string destinatario, string mensagem);
}


public class CelularSamsung : Celular
{
    public CelularSamsung(string marca, string modelo)
        : base(marca, modelo)
    {
    }

    public override void FazerLigacao(string numero)
    {
        Console.WriteLine("Fazendo ligação com o " + Marca + " " + Modelo + " para o número " + numero);
    }

    public override void EnviarMensagem(string destinatario, string mensagem)
    {
        Console.WriteLine("Enviando mensagem com o " + Marca + " " + Modelo + " para " + destinatario + ": " + mensagem);
    }
}

public class CelularIphone : Celular
{
    public CelularIphone(string marca, string modelo)
        : base(marca, modelo)
    {
    }

    public override void FazerLigacao(string numero)
    {
        Console.WriteLine("Fazendo ligação com o " + Marca + " " + Modelo + " para o número " + numero);
    }

    public override void EnviarMensagem(string destinatario, string mensagem)
    {
        Console.WriteLine("Enviando mensagem com o " + Marca + " " + Modelo + " para " + destinatario + ": " + mensagem);
    }
}



Celular celularSamsung = new CelularSamsung("Samsung", "Galaxy S22 Ultra");
celularSamsung.Ligar();
celularSamsung.FazerLigacao("123456789");
celularSamsung.EnviarMensagem("contato@email.com", "Olá!");
celularSamsung.Desligar();

Celular celularIphone = new CelularIphone("Apple", "iPhone 13 Pro Max");
celularIphone.Ligar();
celularIphone.FazerLigacao("987654321");
celularIphone.EnviarMensagem("usuario@rede.com", "Tudo bem?");
celularIphone.Desligar();