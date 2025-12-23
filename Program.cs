using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO!!

Iphone iph = new("(21) 912343212", "Iphone 14", "392931932193993131", 256);
Nokia nok = new("(11) 934021956", "Nokia 525","1113210312031030131", 32 );

Console.WriteLine("TESTE IPHONE:");
iph.Informacoes();
Console.WriteLine("----------------------------");
iph.Ligar();
Console.WriteLine("----------------------------");
iph.ReceberLigacao();
Console.WriteLine("----------------------------");
iph.InstalarAplicativo("Whatsapp");
Console.WriteLine("----------------------------");
Console.WriteLine("FIM DO TESTE IPHONE");
Console.WriteLine("\n\nTESTE NOKIA:");
nok.Informacoes();
Console.WriteLine("----------------------------");
nok.Ligar();
Console.WriteLine("----------------------------");
nok.ReceberLigacao();
Console.WriteLine("----------------------------");
nok.InstalarAplicativo("Telegram");
Console.WriteLine("----------------------------");
Console.WriteLine("FIM DO TESTE NOKIA");