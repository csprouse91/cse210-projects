using System;

class Program
{
    static void Main(string[] args)
    {
        //create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor)
        Fraction fraction1 = new Fraction(); //Default 1/1
        Fraction fraction2 = new Fraction(6); //6/1
        Fraction fraction3 = new Fraction(6, 7);//6/7

        //Call the getter and setter methods to verify they work
        // Console.WriteLine(fraction1.GetTop()); //Display 1
        // fraction1.SetTop(2);
        // Console.WriteLine(fraction1.GetTop()); //Display 2
        // Console.WriteLine(fraction3.GetBottom()); //Display 7
        // fraction3.SetBottom(8);
        // Console.WriteLine(fraction3.GetBottom()); //Display 8

        //Display the fractions as a string and as a decimal
        Console.WriteLine(fraction1.GetFractionString()); //Display 1/1
        Console.WriteLine(fraction1.GetDecimalValue()); //Display 1

        Console.WriteLine(fraction2.GetFractionString()); //Display 6/1
        Console.WriteLine(fraction2.GetDecimalValue()); //Display 6

        Console.WriteLine(fraction3.GetFractionString()); //Display 6/7
        Console.WriteLine(fraction3.GetDecimalValue()); //Display decimalValue

    }
}