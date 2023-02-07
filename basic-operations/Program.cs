using basic_operations.Data;

namespace basic_operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
            }
        }
    }
}
