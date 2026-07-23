namespace hw6task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DiscountRule> rules = new List<DiscountRule>();

            rules.Add(new DiscountRule("Customer discount", 10));
            rules.Add(new DiscountRule("Season discount", 20));

            DiscountService service = new DiscountService(rules);

            double finalPrice = service.ApplyDiscounts(1000);

            Console.WriteLine("Final price: " + finalPrice);
        }
    }
}
