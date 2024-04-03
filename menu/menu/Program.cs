// Declare variables and then initialize to zero.
using SomaTest;
using TDDproject;

//int num1 = 0; int num2 = 0; int num3 = 0; int num4 = 0;

// Ask the user to choose an option.
Console.WriteLine("Escolha o que você quer fazer dos itens abaixo:");
Console.WriteLine("\t1 - Somar");
Console.WriteLine("\t2 - Converter M para MM");
Console.WriteLine("\t3 - Fatorial");
Console.Write("Escolha entre os acima ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "1":
        bool prossiga = true;
        do
        {
            try
            {
                Console.WriteLine("Informe o PRIMEIRO número:");
                float num5 = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe o SEGUNDO número:");
                float num6 = float.Parse(Console.ReadLine());
                var CalculadoraSoma = new calculadoraSoma();

                Console.WriteLine(CalculadoraSoma.Soma(num5, num6));

                prossiga = false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Informe apenas numeros");
            }

        } while (prossiga);
        break;
    case "2":
        bool prossiga2 = true;
        do
        {
            try
            {

                Console.WriteLine("Informe o valor em metros que deseja converter para mm");
                float num7 = float.Parse(Console.ReadLine());
                var MetroConversor = new Metros();
                Console.WriteLine($"{MetroConversor.Metrosconversor(num7)} mm");

                prossiga = false;


            }
            catch (FormatException e)
            {
                Console.WriteLine("Informe apenas numeros");
            }
            catch (DivideByZeroException e) { }

        } while (prossiga2);
        break;
    case "3":
          static int CalcFato(int n)
        {
            int fatorial = 1;
            for (int f = 1; f <= n; f++)
            {
                fatorial = fatorial * f;
            }
            return fatorial;
        }
        break;
}
// Wait for the user to respond before closing.
Console.Write("Aperte ESC para sair");
Console.ReadKey();
