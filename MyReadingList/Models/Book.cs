namespace MyReadingList.Models
{
    public class Book
    {
        //Id is the primary key column and it uniquely identifies each row in the table
        public int Id { get; set; }
        
        public string? NameOfBook { get; set; }
        public bool HaveRead { get; set; }
    }
}
