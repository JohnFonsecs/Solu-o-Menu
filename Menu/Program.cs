using Atividade_PO1;
using Atividade_PO2;
using Atividade_PO3;

bool prossiga = true;
do
{

    try
    {
        Console.WriteLine("Selecione um projeto: \n Opções: \n 1 - Soma dois números. \n 2 - Metro para milimetro. \n 3 - Desconto \n Qualquer outra tecla para sair");

        int num = int.Parse(Console.ReadLine());

        if (num == 1)
        {
            Console.WriteLine("Adicione o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adicione o segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            SomaDoisNumeros soma = new SomaDoisNumeros();

            Console.WriteLine(soma.Calcular(num1, num2));
        }
        else if (num == 2)
        {
            Console.WriteLine("Adicione o metro para conversão:");
            int metro = int.Parse(Console.ReadLine());


            MeToMi conversao = new MeToMi();

            Console.WriteLine(conversao.ConverterMetroParaMilimetro(metro));
        }
        else if (num == 3)
        {
            Console.WriteLine("Valor do Produto:");
            int valorProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do Desconto:");
            int valorDesconto = int.Parse(Console.ReadLine());

            CalcDesconto soma = new CalcDesconto();

            Console.WriteLine(soma.CalcularDesconto(valorProduto, valorDesconto));
        }
        else
            prossiga = false;
    } catch(Exception ex) { }

} while (prossiga);
