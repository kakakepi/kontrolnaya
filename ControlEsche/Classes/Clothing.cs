namespace Lab9
{
    class Clothing : Product
    {
        public Clothing(string name, int quantity, int price) : base(name,  quantity,  price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}