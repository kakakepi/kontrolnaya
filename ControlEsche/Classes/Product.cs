namespace Lab9
{
    abstract class Product
    {
        protected string name;
        protected int quantity;
        protected decimal price;
        public Product(string name, int quantity, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Продукт с названием - {name}, цена - {price}, и количеством - {quantity}");
        }
        public void CalculateDiscount(decimal discount)
        {
            if (0 < discount && discount < 100)
            {
                Console.WriteLine($"Цена продукта с учетом скидки - {price -price * discount * 0.01m}");
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }
        }
    }
}