namespace Lab9
{
    abstract class Product
    {
        protected string name;
        protected int quantity;
        protected int price;
        public Product(string name, int quantity, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Продукт с названием - {name}, цена - {price}, и количеством - {quantity}");
        }
        public void CalculateDiscount(int discount)
        {
            if (0 < discount && discount < 100)
            {
                Console.WriteLine($"Цена продукта с учетом скидки - {price -price * discount * 0.01}");
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }
        }
    }
}