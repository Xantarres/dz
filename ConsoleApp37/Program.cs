namespace ConsoleApp37
{
    class Program
    {
        
        public static void PrintList<T>(List<T> list) where T : IFormattable
        {
           
            foreach (var item in list)
            {
                
                Console.WriteLine(item.ToString(null, null));
            }
        }

        static void Main()
        {
           
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            PrintList(intList); 
            Console.WriteLine();

            
            List<double> doubleList = new List<double> { 1.1, 2.2, 3.3 };
            PrintList(doubleList); 
            Console.WriteLine();
 
        }
    }
}