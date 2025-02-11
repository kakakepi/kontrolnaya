namespace Lab9
{
    [LibraryInfo("Городская библиотека", 150)]
    class Library
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string name)
        {
            Book? bookToRemove = books.Find(b => b.Name == name);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
            else
            {
                Console.WriteLine("Книга не найдена.");
            }
        }
        public List<Book> FindByAuthor(string name)
        {
            List<Book> authorBooks = books.FindAll(b => b.Author == name);
            return authorBooks;
        }
        public List<Book> FindByGenre(Genre genre)
        {
            List<Book> genreBooks = books.FindAll(b => b.Geneer == genre);
            return genreBooks;
        }
    }
}