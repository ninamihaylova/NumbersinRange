class NumbersinRange
{
    public static void Main(string[] args)
    {
        int beginning = int.Parse(Console.ReadLine());
        int ending = int.Parse(Console.ReadLine());
       
        for (int i = beginning; i<=ending; i++)
        {
            Console.WriteLine(i);
        }
      
    }
}