namespace hw2task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 0;
            bool isVip = false;
            bool isFirstOrder = false;
            bool hasPromo = false;
            var vip = 7;
            var firstOrder = 5;
            var promo = 10;
            var limitSale = 20;
            int totalSale=0;
            decimal delivery = 1200;
            decimal totalBill;

            Console.Write("Enter amount: ");
            var msg = Console.ReadLine();
            decimal.TryParse(msg, out amount);

            Console.Write("Are you VIP cient? (y/n): ");
            string answerVip = Console.ReadLine();
            isVip = answerVip == "y";

            Console.Write("Is it your first order? (y/n): ");
            string answerFirstOrder = Console.ReadLine();
            isFirstOrder = answerFirstOrder == "y";

            Console.Write("Do you has a promo? (y/n): ");
            string answerPromo = Console.ReadLine();
            hasPromo = answerPromo == "y";

            if (isVip)
            {
                totalSale = totalSale + vip;
            }
            if (isFirstOrder)
            {
                totalSale = totalSale + firstOrder;
            }
            if (hasPromo)
            {
                totalSale = totalSale + promo;
            }
            if (totalSale >= limitSale)
            {
                totalSale = limitSale;
            }
            if (amount>=15000)
            {
                delivery = 0;
            }
            totalBill = amount - (amount * totalSale / 100) + delivery;

            Console.WriteLine($"Total sale %: {totalSale}" );
            Console.WriteLine($"Delivery: {delivery}");
            Console.WriteLine($"Total bill: {totalBill}");
            Console.ReadLine();
        }
    }
}
