using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

Console.WriteLine("Programm zur Berechnung der Stromstärke oder \nder Leistung in einem Stromkreis");
Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("Geben Sie eine 1 für die Brechnung der Stromstärke  \noder eine 2 für die Leistungsbrechung ein:");
int a = int.Parse(Console.ReadLine());
if( a == 1)
{
    Console.Write("Geben sie die Spannung in <Volt> ein: ");
    double eingabe = double.Parse(Console.ReadLine());
    Console.Write("Geben Sie den Wiederstandswert in <ohm> ein: ");
    double eingabe2 = double.Parse(Console.ReadLine());
    double ergebnis = eingabe / eingabe2;
    if (ergebnis <= 1000)
    {
        Console.WriteLine("Die Stromstärke beträgt " + ergebnis + " A");
    }
    else
        Console.WriteLine("Die Stromstärke beträgt "+ (ergebnis / 1000)  + " kA");
}else if ( a == 2 ) 
{
    Console.Write("Geben sie die Spannung in <Volt> ein: " );
    double eingabe = double.Parse(Console.ReadLine());
    Console.Write("Geben sie den Wiederstandswert in <ohm> ein: ");
    double eingabe2 = double.Parse(Console.ReadLine());
    double ergebnis2 = eingabe * eingabe / eingabe2;
    if (ergebnis2 <= 1000)
    {
        Console.WriteLine("Die leistung beträgt " + ergebnis2 + " ");

    }
    else
        Console.WriteLine("Die Leistung beträgt "+ ( ergebnis2 / 1000), " kW");
}

