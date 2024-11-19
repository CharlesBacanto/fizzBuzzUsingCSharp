class Program
{
    static void Main(string[] args)
    {
        //Prompt the User to enter the max value
        Console.WriteLine("Please Enter the Max Value: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());


        //For loop to iterate each incrementation from 1 up to max Value
        for(int i = 1; i < maxValue; i++)
        {
            if(i%5 == 0 && i%2 == 0)
            {
                Console.WriteLine("FizzBuzz"); // If divisible both by 5 and 2 print FizzBuzz
            }else if(i%5 == 0)
            {
                Console.WriteLine("Buzz");  // If divisible by 5  print Buzz
            }
            else if(i%2 == 0)
            {
                Console.WriteLine("Fizz"); // If divisible by 2  print Fizz
            }
            else
            {
                Console.WriteLine(i); // If not divisible both by 5 and 2 print current number
            }
        }
    }
}
