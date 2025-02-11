namespace Lab9
{
    class LibraryInfoAttribute : Attribute
    {
        public string name{ get;}
        public int age{get;}
        public LibraryInfoAttribute(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}