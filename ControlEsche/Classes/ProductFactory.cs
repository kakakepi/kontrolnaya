namespace Lab9
{
    abstract class ProductFactory
    {
        protected string name;
        public ProductFactory(string name)
        {
            this.name = name;
        }
        public abstract Product CreateProduct(string name, int quantity,int price);
    }
}