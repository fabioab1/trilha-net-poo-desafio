using DesafioPOO.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(11) 11111-1111", modelo: "Nokia X30 Versão Global", imei: "ABC123456", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Ifood");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(11) 11111-1112", modelo: "Iphone 13 Meia-noite", imei: "DEF789012", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");

Console.WriteLine("\nPressione qualquer tecla para continuar...");
Console.ReadLine();

string numeroDestinatario = iphone.Numero;
string numeroRemetente = nokia.Numero;
string mensagem;

do
{
Console.Clear();
Console.WriteLine("Conexão estabelecida. \nEnvie 2 para encerrar a ligação\n");

Console.Write($"{numeroDestinatario}: ");
mensagem = Console.ReadLine();

if (mensagem != "2")
{
    Console.Write($"{numeroRemetente}: ");
    mensagem = Console.ReadLine();

    if (mensagem != "2")
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadLine();
    }
    else
    {
        if (numeroRemetente == nokia.Numero)
        {
            nokia.EncerrarLigacao();
        }
        if (numeroRemetente == iphone.Numero)
        {
            iphone.EncerrarLigacao();
        }
    }
}
else
{
    if (numeroDestinatario == iphone.Numero)
    {
        iphone.EncerrarLigacao();
    }
    if (numeroDestinatario == nokia.Numero)
    {
        nokia.EncerrarLigacao();
    }
}

} while (mensagem != "2");