namespace Lab9
{
    class Book
    {
        string name;
        public string Name{get{return name;}}
        string author;
        public string Author{get{return author;}}
        Genre genre;
        public Genre Geneer{get{return genre;}}
        DateTime date;
        public DateTime Date{get{return date;}}
        public Book(string name,string author, Genre genre, DateTime date)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.date = date;
        }
        public override string ToString()
        {
            return $"Книга {Name}, автор - {Author}, дата написания {Date}, в жанре {Geneer}";
        }

    }
}