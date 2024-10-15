namespace method3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = -20;
            Product product = new Product("iphone13", "apple", 100, 40, count);
            product.GetInfo();
            product.Sale(count);

        }
    }
}