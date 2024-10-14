namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int sum = 0;

                for (int i = 0; i < 1000; i++)

                    if (i % 3 == 0 || i % 5 == 0)

                        sum += i;

                Console.WriteLine(sum);

        // project euler task one aboce 

        //string handling: 

        string text = "Hello World"; Console.WriteLine(text.Length); // Output: 11 Console.WriteLine(text[0]); // Output: 'H' Console.WriteLine(text[text.Length - 1]); // Output: 'd' 

 

        string firstName = "John";

        string lastName = "Doe";

        Console.WriteLine(firstName + " " + lastName); // Output: "John Doe" 

 

 

        string numberString = "123"; int number = Convert.ToInt32(numberString); Console.WriteLine(number); 

 

        DateTime currentDate = DateTime.Now; Console.WriteLine(currentDate); 
        }
    }
}
