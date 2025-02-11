namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle CircleA = new Circle(3, 4, 2);
            Circle CircleB = new Circle(6, 8, 2);
            Circle CircleC = new Circle(5,6,125);
            Circle CircleD = new Circle(2,5,77);
            Console.WriteLine($"Больше ли первый круг второго: {CircleA > CircleB}, Пересекаются ли они: {CircleA.checkIfCross(CircleB)}");
            Console.WriteLine($"Больше ли третий круг четвертого: {CircleC > CircleD}, Пересекаются ли они: {CircleC.checkIfCross(CircleD)}");

            Matrix matrixA = new Matrix(4,3);
            Matrix matrixB = new Matrix(4,3);
            matrixA.Print();
            matrixB.Print();
            Matrix transposedMatrix = matrixA.Transpose();
            transposedMatrix.Print();
            Matrix sumMatrix = matrixA + matrixB;
            sumMatrix.Print();
            Matrix multipleMatrix = matrixA * 1;
            multipleMatrix.Print();

            Library library = new Library();
            Book book1 = new Book("фыв", "ник вуйчич", Genre.Приключения, new DateTime(2005,12,30));
            Book book2 = new Book("гав", "ник вуйчич", Genre.Драма, new DateTime(2005,12,30));
            Book book3 = new Book("майм камф", " А. Г.", Genre.Приключения, new DateTime(2005,12,30));
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            foreach (Book i in library.FindByAuthor("ник вуйчич"))
            {
                Console.WriteLine(i.Name);
            }
            foreach (Book i in library.FindByGenre(Genre.Приключения))
            {
                Console.WriteLine(i.Name);
            }
            library.RemoveBook("майм камф");
            foreach (Book i in library.FindByGenre(Genre.Приключения))
            {
                Console.WriteLine(i.Name);
            }

            ProductFactory Electro = new ElectronicsFactory("ZVO");
            ProductFactory Furnitura = new FurnitureFactory("govno");
            ProductFactory Cloths = new ClothingFactory("soso");
            Product computer = Electro.CreateProduct("rtx 100900",1488,1488);
            Product desk = Furnitura.CreateProduct("Drochilnya",1337,228);
            Product cloth = Cloths.CreateProduct("Trusi", 34,69);
            computer.CalculateDiscount(75);
            desk.ShowInfo();
            computer.ShowInfo();
            cloth.ShowInfo();
            cloth.CalculateDiscount(100);
        }
    }
}