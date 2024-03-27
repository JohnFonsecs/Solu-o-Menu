using Atividade_PO1;
using System;



bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("Adicione o primeiro numero:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Adicione o segundo numero:");
        int num2 = int.Parse(Console.ReadLine());

        SomaDoisNumeros soma = new SomaDoisNumeros();

        Console.WriteLine(soma.Calcular(num1, num2));

        prossiga = false;

    }
    catch (FormatException e)
    {
        Console.WriteLine("Informe apenas numeros");
    }
    catch (DivideByZeroException e) { }

} while (prossiga);