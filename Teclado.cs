using System;

class Teclado
{
    internal static int leInteiro(string msg)
    {
        int valor;
        do
        {
            try
            {
                Console.Write(msg);
                valor = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro fatal evitado");
                valor = -1;
            }
        } while (valor == -1);

        return valor;
    }

    internal static double leDouble(string msg)
    {
        double valor;
        do
        {
            try
            {
                Console.Write(msg);
                valor = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro fatal evitado");
                valor = -1;
            }
        } while (valor == -1);

        return valor;
    }

    internal static string leString(string msg)
    {
        string valor;
        Console.Write(msg);
        valor = Console.ReadLine();

        return valor;
    }

    internal static string sOuN(string msg)
    {
        bool eSOuN = true;
        string valor;
        do
        {
            eSOuN = true;
            Console.Write(msg);
            valor = Console.ReadLine();
            if (valor != "S" && valor != "N")
            {
                eSOuN = false;
            }
        } while (eSOuN == false);


        return valor;
    }
}