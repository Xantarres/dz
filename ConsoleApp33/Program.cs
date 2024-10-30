namespace ConsoleApp33
{
    class Program
    {
        
        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            if (items == null || items.Length == 0)
            {
                throw new ArgumentException("массив не должен быть нулевым или пустым!");
            }

            T max = items[0]; 
            foreach (var item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item; 
                }
            }

            return max;
        }

        static void Main()
        {
            
            int[] intArray = { 3, 5, 7, 2, 8 };
            int maxInt = FindMax(intArray);
            Console.WriteLine($"Max int: {maxInt}");

        }
    }
}