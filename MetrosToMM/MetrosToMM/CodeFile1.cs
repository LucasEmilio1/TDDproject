using TDDproject;

bool prossiga = true;
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

} while (prossiga);