namespace Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*
             * This is used for adding two numbers and catching
             * exception
             */
            
            Console.WriteLine("Adding two numbers between 0 -255");
            
            try
            {
                Console.WriteLine("Enter the first number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > 255 && num2 > 255)
                {
                    Console.WriteLine("Enter numbers below 255");
                 }
                else {
                    Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
                }
               
            }catch (OverflowException) 
            {
                Console.WriteLine("Enter a valid number");           
            }
            catch (Exception )
            {
                Console.WriteLine("This is not a valid number");
            }
            
            
            
            
            
        }
    }
}