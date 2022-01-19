using K205_CarAPP.Methods;
using K205_CarAPP.Models;

TelebeManager telebeManager = new TelebeManager();


Telebe telebe1 = new Telebe() { 
    Id = 1,
    Name = "Nigar",
    Qiymeti = 0,
   

};


Evvele:
Console.WriteLine("1. Qiymet yaz");
Console.WriteLine("2. Telebe Info");

string daxilEdilenReqem = Console.ReadLine();





switch (Convert.ToInt32(daxilEdilenReqem)) { 

	case 1:
        telebeManager.QiymetYaz(telebe1);
        goto Evvele;
        break;

	case 2:
        telebeManager.TelebeInfo(telebe1);
        goto Evvele;
        break;
    default:
        Console.WriteLine("Dogru reqem daxil edin.");
        break;
}
