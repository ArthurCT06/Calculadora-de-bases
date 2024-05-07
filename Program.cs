internal class Program
{
    private static void Main(string[] args)
    {
        int escolha;
        do
        {
            Console.WriteLine("Menu de conversão de base: ");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine(" 1: Decimal --> Binário");
            Console.WriteLine(" 2: Binário --> Decimal");
            Console.WriteLine(" 3: Decimal --> Octal");
            Console.WriteLine(" 4: Octal --> Decimal");
            Console.WriteLine(" 5: Decimal --> Hexadecimal");
            Console.WriteLine(" 6: Hexadecimal --> Decimal");
            Console.WriteLine(" 7: Binário --> Octal");
            Console.WriteLine(" 8: Octal --> Binário");
            Console.WriteLine(" 9: Binário --> Hexadecimal");
            Console.WriteLine(" 10: Hexadecimal --> Binário");
            Console.WriteLine(" 11: Octal --> Hexadecimal");
            Console.WriteLine(" 12 hexadecimal --> Octal");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine(" 0: Sair da calculadora");
            escolha = Convert.ToInt32(Console.ReadLine());


            switch (escolha)
            {
                    case 1:

                    Opcao1();
                    break;

                    case 2:

                    Opcao2();
                    break;

                    case 3:
                    Opcao3();
                    break;

                    case 4:
                    Opcao4();
                    break;

                    case 5:
                    Opcao5();
                    break;

                    case 6:
                    Opcao6();
                    break;

                    case 7:
                    Opcao7();
                    break;
                    
                    case 8:
                    Opcao8();
                    break;

                    case 9:
                    Opcao9();
                    break;

                    case 10:
                    Opcao10();
                    break;

                    case 11:
                    Opcao11();
                    break;

                     case 12:
                    Opcao12();
                    break;
            }
        } while (escolha != 0);

    }    

    static void Opcao1()
    {


        int resto, quociente;
        List<int> resultado = [];

        Console.WriteLine("Digite um número decimal para ser convertido para binário: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

        quociente = numero / 2;
        resto = numero % 2;

        Console.WriteLine($"Primeiro passo: {numero} / 2 -> Quociente: {quociente}, Resto: {resto}");

        resultado.Add(resto);
        do
     {
            int passos = quociente;
            resto = quociente % 2;
            quociente /= 2;
            resultado.Add(resto);

            Console.WriteLine($"Próximo passo: {passos} / 2 -> Quociente: {quociente}, Resto: {resto}");


        } while (quociente > 0);


     foreach (int i in resultado)
     {
                
      Console.Write(i);

     }
     Console.WriteLine("\n");
     Console.ReadKey();
     Console.Clear();
    }

    static void Opcao2()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao3()
    {
        List<int> resultado = [];
        int resto, quociente;
        Console.WriteLine("Digite um número decimal para ser convertido para octal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

        quociente=numero / 8;
        resto=numero % 8;

        Console.WriteLine($"Primeiro passo: {numero} / 2 -> Quociente: {quociente}, Resto: {resto}");

        do
        {
            int passos = quociente;
            resto = quociente % 8;
            quociente /= 8;
            resultado.Add(resto);

            Console.WriteLine($"Próximo passo: {passos} / 2 -> Quociente: {quociente}, Resto: {resto}");
        }while(quociente > 0);



        foreach(int i in resultado)
        {
            Console.Write(i);
        }
        Console.WriteLine("\n");
        Console.ReadKey();
        Console.Clear();
    }   

    static void Opcao4()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao5()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao6()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao7()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao8()
    {

        Console.WriteLine("Digite um número octal para ser convertido para binario: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

        
    }

    static void Opcao9()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao10()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao11()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }

    static void Opcao12()
    {
        Console.WriteLine("Digite um número binário para ser convertido para decimal: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("|------------------------------------------------------------------|");

    }




}



