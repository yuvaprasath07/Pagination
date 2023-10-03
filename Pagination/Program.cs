namespace Pagination
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            for (int i = 1; i <= 50; i++)
            {
                items.Add($"Item {i}");
            }
            int itemsPerPage = 10;
            int currentPage = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Items on Page " + currentPage + "\n");

                // Display items for the current page
                for (int i = (currentPage - 1) * itemsPerPage; i < currentPage * itemsPerPage && i < items.Count; i++)
                {
                    Console.WriteLine(items[i]);
                }

                Console.WriteLine("\nPage " + currentPage + " of " + Math.Ceiling((double)items.Count / itemsPerPage));
                Console.WriteLine("Press 'N' for Next Page, 'P' for Previous Page, or 'Q' to Quit.");

                // Get user input
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.N && currentPage < Math.Ceiling((double)items.Count / itemsPerPage))
                {
                    currentPage++;
                }
                else if (key.Key == ConsoleKey.P && currentPage > 1)
                {
                    currentPage--;
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}
