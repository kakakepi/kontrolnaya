namespace Lab9
{
    class ClothingFactory : ProductFactory
    {
        public ClothingFactory(string name) : base(name)
        {
            this.name = name;
        }
        public override Product CreateProduct(string name, int quantity, decimal price)
        {
            return new Clothing(name,quantity,price);
        }
    }
}