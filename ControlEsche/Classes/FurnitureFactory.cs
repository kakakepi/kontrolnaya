namespace Lab9
{
    class FurnitureFactory : ProductFactory
    {
        public FurnitureFactory(string name) : base(name)
        {
            this.name = name;
        }
        public override Product CreateProduct(string name, int quantity, int price)
        {
            return new Furniture(name,quantity,price);
        }
    }
}