namespace Lab9
{
    class Electronics : Product
    {
        public Electronics(string name, int quantity, int price) : base(name,  quantity,  price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}