using TDDproject;

bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("Informe o PRIMEIRO número:");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o SEGUNDO número:");
        float num2 = float.Parse(Console.ReadLine());
        var CalculadoraSoma = new calculadoraSoma();

        Console.WriteLine(CalculadoraSoma.Soma(num1, num2));

        prossiga = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("Informe apenas numeros");
    }

} while (prossiga);
