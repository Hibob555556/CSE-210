namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal j = new();
            j.CreateEntry();

            j.DisplayAll();
        }
    }
}