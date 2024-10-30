namespace ConsoleApp35
{
    class Program
    {
        
        public static bool AreEqual<T>(T item1, T item2)
        {
            
            if (item1 == null && item2 == null)
            {
                return true;
            }

            
            if (item1 == null || item2 == null)
            {
                return false;
            }

            
            return item1.Equals(item2);
        }

        static void Main()
        {
            
            int a = 5;
            int b = 5;
            int c = 10;
            Console.WriteLine(AreEqual(a, b)); 
            Console.WriteLine(AreEqual(a, c)); 

            string str1 = "pc";
            string str2 = "pc";
            string str3 = "mouse";
            Console.WriteLine(AreEqual(str1, str2)); 
            Console.WriteLine(AreEqual(str1, str3));
        }
    }
}