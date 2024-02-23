
int firstNum, secondNum, ope_Choice, cons_Choice;
do
{
    do
    {
        Console.WriteLine("\nBegin by Selecting a Operation");
        Console.WriteLine("[1]Addition");
        Console.WriteLine("[2]Subtraction");
        Console.WriteLine("[3]Multiplication");
        Console.WriteLine("[4]Division");
        Console.Write("Enter you choice: ");
        ope_Choice = int.Parse(Console.ReadLine());
        if ((ope_Choice < 1) || (ope_Choice > 4))
        {
            Console.WriteLine("INVALID CHOICE!");
        }
    } while ((ope_Choice < 1) || (ope_Choice > 4));

    Console.Write("Enter the first number: ");
    firstNum = int.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    secondNum = int.Parse(Console.ReadLine());

    Calculator myCalculator = new Calculator(firstNum, secondNum);

    Console.WriteLine("\nResult: ");
    if (ope_Choice == 1)
    {
        Console.WriteLine($"The sum of {firstNum} and {secondNum} is {myCalculator.getSum()}.");
    }
    else if (ope_Choice == 2)
    {
        Console.WriteLine($"The difference of {firstNum} and {secondNum} is {myCalculator.getDifference()}.");
    }
    else if (ope_Choice == 3)
    {
        Console.WriteLine($"The product of {firstNum} and {secondNum} is {myCalculator.getProduct()}.");
    }
    else if (ope_Choice == 4)
    {
        Console.WriteLine($"The quotient of {firstNum} and {secondNum} is {myCalculator.getQuotient()}.");
    }
    do
    {
        Console.WriteLine("\nWill you use the calculator again? [1]Yes [2]No");
        Console.Write("Enter your choice: ");
        cons_Choice = int.Parse(Console.ReadLine());
        if ((cons_Choice < 1) || (cons_Choice > 2))
        {
            Console.WriteLine("Not a choice");
        }
        else if (cons_Choice == 2)
        {
            Console.WriteLine("Please come again");
        }
    } while ((cons_Choice < 1) || (cons_Choice > 2));
} while (cons_Choice == 1);

