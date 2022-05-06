// See https://aka.ms/new-console-template for more information
using Maximumofthree;


Console.WriteLine("Welcome to Maximum of Three using generics!");

while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)using INT\n2)using Float\n3)usingString\n4)using generic class" +
        "");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Please enter the values of integers x, y and z:");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            int z = Convert.ToInt16(Console.ReadLine());
            UsingInt usingInt = new UsingInt();
            int result = usingInt.Maximum(x, y, z);
            Console.WriteLine("The Maximum of three integers is :" + result);
            Console.WriteLine("\n");
            break;
        case 2:
            Console.WriteLine("Please enter the values of floats a, b and c:");
            double a = Convert.ToInt16(Console.ReadLine());
            double b = Convert.ToInt16(Console.ReadLine());
            double c = Convert.ToInt16(Console.ReadLine());
            usingfloat Usingfloat = new usingfloat();
            double result1 = Usingfloat.Maximumfloat(a, b, c);
            Console.WriteLine("The Maximum of three integers is :" + result1);
            Console.WriteLine("\n");
            break;
        case 3:
            Console.WriteLine("Please enter the values of Strings first, second and thirdString");
            string firstString = Convert.ToString(Console.ReadLine());
            string secondString = Convert.ToString(Console.ReadLine());
            string thirdString = Convert.ToString(Console.ReadLine());
            Usingstrings usingstrings = new Usingstrings();
            string result2 = usingstrings.MaxValueStrings(firstString, secondString, thirdString);
            Console.WriteLine("The Maximum of three strings is :" + result2);
            Console.WriteLine("\n");
            break;
        case 4:
            GenericClass genericClass = new GenericClass();
            int value1 = GenericClass.MaxusingGenerics<int>(2, 3, 4);
            Console.WriteLine("The Maximum of three integers is :" + value1);
            double value2 = GenericClass.MaxusingGenerics<double>(2.2, 3.3, 4.4);
            Console.WriteLine("The Maximum of three values is :" + value2);
            string value3 = GenericClass.MaxusingGenerics<string>("Apple", "peach", "banana");
            Console.WriteLine("The Maximum of three strings is :" + value3);
            Console.WriteLine("\n");
            break;

    }
}

