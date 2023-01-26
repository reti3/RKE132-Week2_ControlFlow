// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajat tema sugu (M/F)
//rakendus küsib kasutajalt perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr [kasutaja perekonnanimi] / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

//kasutame char tüüpi, et kulutada vähem vahemälu (RAM), sest vajame ainult ühte tähte vastuseks
char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist andmeid string formaadis
//char.Parse teisendab char tüübi string tüübiks

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine(); //tuleb panna enne if plokki, sest muutujad tuleb kasutamist deklareerida. Muidu tuleb veateada, koodi loetakse ülevalt alla 
//== võrdusmärk, võrdlemiseks; ülakomad on char tüübi jaoks
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}

else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

