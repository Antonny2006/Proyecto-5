// See https://aka.ms/new-console-template for more information
using System;
class edad
{
    static void Main(string[] args)

    {

        Console.WriteLine("calcule su edad");
        Console.Write("ingrese su Nombre:");
        string Nombre = Console.ReadLine();

        Console.Write("ingrese su edad:");
        double Edad = Convert.ToDouble(Console.ReadLine());

        double edadMeses = Edad * 12;
        double EdadSemana = Edad * 52;
        double EdadDias = Edad * 365;
        double EdadHoras = EdadDias * 24;


        Console.WriteLine($"Su edad en años es {Edad}, su edad en meses es {edadMeses}, su edad en Semanas es {EdadSemana}, su Edad en dias es {EdadDias}, su edad en horas es {EdadHoras}");



    }

}

