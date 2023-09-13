// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//method for Fizz buzz challenge

string FizzBuzz(int num)  /// have to remove access modifier "public" before compile-- (Error CS0106	The modifier 'public' is not valid for this item	FizzBuzzChallenge	C:\Users\XXXX\FizzBuzzChallenge\Program.cs	5	Active)

{
    string result = "";

    if (num % 3 == 0 && num % 5 == 0)
    {
        result = "FizzBuzz";
        return result;
    }
    else if (num % 5 == 0)
    {
        result = "Buzz";
        return result;
    }
    else if (num % 3 == 0)
    {
        result = "Fizz";
        return result;
    }
    else 
    {return "";}
}

Console.WriteLine(FizzBuzz(2) +  "--2");
Console.WriteLine(FizzBuzz(3) + "--3");
Console.WriteLine(FizzBuzz(4) + "--4");
Console.WriteLine(FizzBuzz(5) + "--5");
Console.WriteLine(FizzBuzz(9) + "--9");
Console.WriteLine(FizzBuzz(10) + "--10");
Console.WriteLine(FizzBuzz(12) + "--12");
Console.WriteLine(FizzBuzz(15) + "--15");
Console.WriteLine(FizzBuzz(20) + "--20");