using System;

// Enum para representar os diferentes tipos de canais
public enum Canal
{
    WhatsApp,
    Telegram,
    Facebook,
    Instagram
}

// Classe base para mensagens
public class Mensagem
{
    public string Conteudo { get; set; }
    public DateTime DataEnvio { get; set; }

    public Mensagem(string conteudo, DateTime dataEnvio)
    {
        Conteudo = conteudo;
        DataEnvio = DateTime.Now;
    }
}

// Classes para diferentes tipos de mensagens
public class MensagemTexto : Mensagem
{
    public MensagemTexto(string conteudo, DateTime dataEnvio) : base(conteudo, dataEnvio)
    {

    }
}

public class MensagemVideo : Mensagem
{
    public string Arquivo { get; set; }
    public string Formato { get; set; }
    public TimeSpan Duracao { get; set; }

    public MensagemVideo(string conteudo, DateTime dataEnvio, string arquivo, string formato, TimeSpan duracao)
        : base(conteudo, dataEnvio)
    {
        Arquivo = arquivo;
        Formato = formato;
        Duracao = duracao;
    }
}

public class MensagemFoto : Mensagem
{
    public string Arquivo { get; set; }
    public string Formato { get; set; }

    public MensagemFoto(string conteudo, DateTime dataEnvio, string arquivo, string formato)
        : base(conteudo, dataEnvio)
    {
        Arquivo = arquivo;
        Formato = formato;
    }
}

public class MensagemArquivo : Mensagem
{
    public string Arquivo { get; set; }
    public string Formato { get; set; }

    public MensagemArquivo(string conteudo, DateTime dataEnvio, string arquivo, string formato)
        : base(conteudo, dataEnvio)
    {
        Arquivo = arquivo;
        Formato = formato;
    }
}

// Classe para envio de mensagens
public class EnviadorMensagens
{
    public void EnviarMensagem(Canal canal, string destinatario, Mensagem mensagem)
    {
        switch (canal)
        {
            case Canal.WhatsApp:
                // Lógica de envio para WhatsApp
                Console.WriteLine($"Enviando mensagem para {+5511993343626} via WhatsApp: {mensagem.Conteudo}");
                break;
            case Canal.Telegram:
                // Lógica de envio para Telegram
                Console.WriteLine($"Enviando mensagem para {destinatario} via Telegram: {mensagem.Conteudo}");
                break;
            case Canal.Facebook:
                // Lógica de envio para Facebook
                Console.WriteLine($"Enviando mensagem para {destinatario} via Facebook: {mensagem.Conteudo}");
                break;
            case Canal.Instagram:
                // Lógica de envio para Instagram
                Console.WriteLine($"Enviando mensagem para {destinatario} via Instagram: {mensagem.Conteudo}");
                break;
            default:
                Console.WriteLine($"Canal {canal} não suportado.");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso
        EnviadorMensagens enviador = new EnviadorMensagens();

        MensagemTexto mensagemTexto = new MensagemTexto("Olá, como vai?", DateTime.Now);
        enviador.EnviarMensagem(Canal.WhatsApp, "+5511997375160", mensagemTexto);

        MensagemVideo mensagemVideo = new MensagemVideo("Vídeo legal!", DateTime.Now, "video.mp4", "mp4", TimeSpan.FromMinutes(2));
        enviador.EnviarMensagem(Canal.Telegram, "@usuario_telegram", mensagemVideo);

        // Adicione mais exemplos conforme necessário

        Console.ReadLine();
    }
}
