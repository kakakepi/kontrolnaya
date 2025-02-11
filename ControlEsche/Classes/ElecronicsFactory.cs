namespace Lab9
{
    class ElectronicsFactory : ProductFactory
    {
        public ElectronicsFactory(string name) : base(name)
        {
            this.name = name;
        }
        public override Product CreateProduct(string name, int quantity, int price)
        {
            return new Electronics(name,quantity,price);
        }
    }
}