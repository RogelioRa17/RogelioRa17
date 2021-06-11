namespace BookManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string name { get; set; }

        internal string fullname {get; set;}
    }
}