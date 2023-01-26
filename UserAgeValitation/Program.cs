// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutaja vanust
//kui kastaja vanus on väiksem kui 13, kuvatakse konsoolis "you are too young to use Instagram"
//muul juhul, konsoolis kuvatakse "welcome to Instagram"
Console.WriteLine("Please, enter your age:");
//int.32.Parse - loetakse sisestatud string int tüübiks
int userAge = Int32.Parse(Console.ReadLine()); //salvestamine: "13" - heap; 13 - stack

if(userAge >= 13) //kui on int tüüp, saab kasutada matemaatilisi tehteid
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram!");
}

