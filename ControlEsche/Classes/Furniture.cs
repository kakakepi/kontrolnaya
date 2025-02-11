namespace Lab9
{
    class Furniture : Product
    {
        public Furniture(string name, int quantity, int price) : base(name,  quantity,  price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}