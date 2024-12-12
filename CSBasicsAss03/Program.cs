internal class Program
{
    private static void Main(string[] args)
    {


        #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

        //int num;
        //Console.WriteLine("enter the number ");
        //bool check = int.TryParse(Console.ReadLine(), out num);

        //if (check)
        //{
        //    if (num % 3 == 0 && num % 4 == 0)// short circit 
        //        Console.WriteLine("Yes");
        //    else
        //        Console.WriteLine("No");
        //}
        //else
        //{
        //    Console.WriteLine("You entered invalid input , you  must enter number");
        //}

        #endregion

        #region 2 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.


        //int num;
        //Console.WriteLine("enter the number ");
        //bool check = int.TryParse(Console.ReadLine(), out num);
        //string message;


        //if (check)
        //{
        //  message=num >=0 ? "Positive": "Negative";
        //    Console.WriteLine(message);

        //}
        //else
        //{
        //    Console.WriteLine("You entered invalid input , you  must enter number");
        //}
        #endregion

        #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

        //int num1, num2, num3 , maxElement,minElement;
        //Console.WriteLine(" enter 3 numbers");

        //bool check = int.TryParse(Console.ReadLine(),out num1);
        // check = int.TryParse(Console.ReadLine(), out num2);
        // check = int.TryParse(Console.ReadLine(), out num3);
        //if (check)
        //{
        //    //max
        //    maxElement = num1;
        //    if (num2 >= maxElement && num2 >= num3)
        //    {
        //        maxElement = num2;
        //    }
        //    else if (num3 >= maxElement && num3>= num2)

        //    {
        //        maxElement = num3;
        //    }

        //    //min
        //    minElement = num1;
        //    if (num2 <= minElement && num2 <= num3)
        //    {
        //        minElement = num2;
        //    }
        //    else if (num3<= minElement && num3 <= num2)

        //    {
        //        minElement = num3;
        //    }


        //    Console.WriteLine($"Max Number= {maxElement}. \nMin Number= {minElement}.");

        //}
        //else
        //{
        //    Console.WriteLine("You entered invalid input , you  must enter number");
        //}

        #endregion


        #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

        //int num;
        //Console.WriteLine("enter the number ");
        //bool check = int.TryParse(Console.ReadLine(), out num);

        //if (check)
        //{
        //    if (num % 2 == 0 )
        //        Console.WriteLine("Even");
        //    else
        //        Console.WriteLine("Odd");
        //}
        //else
        //{
        //    Console.WriteLine("You entered invalid input , you  must enter number");
        //}

        #endregion


        #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

        //Console.WriteLine("enter character");
        //char letter;
        //bool check = char.TryParse(Console.ReadLine(), out letter);

        //if(check)
        //{
        //    int n = 'a' - letter;
        //    if(n>0) // means capitals
        //    {
        //        letter = (char)('a' + (letter - 'A'));
        //    }


        //    if(letter=='a'|| letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' )
        //    {
        //        Console.WriteLine("vowel");
        //    }
        //    else
        //    {
        //        Console.WriteLine("consonant");
        //    }

        //}
        //else
        //{ Console.WriteLine("You must enter a character "); }

        #endregion

        #region 6 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

        //int num;
        //Console.WriteLine("enter the number ");
        //bool check = int.TryParse(Console.ReadLine(), out num);

        //if (check)
        //{
        //    for (int i = 1; i <= num; i++)
        //        Console.Write($"{i} ");
        //    if (num <= 0)
        //    {
        //        for (int i = 1; i >= num; i--)
        //            Console.Write($"{i} ");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("You entered invalid input , you  must enter number");
        //}
        #endregion

        #region 7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.


        //int num;
        //Console.WriteLine("enter the number ");
        //bool check = int.TryParse(Console.ReadLine(), out num);

        //if (check)
        //{
        //    for(int i = 0;i<=12; i++)
        //    {
        //        Console.Write($"{num*i} ");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("You entered invalid input , you  must enter number");
        //}



        #endregion

    }
}