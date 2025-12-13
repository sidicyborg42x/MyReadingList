using MyReadingList.Models;

namespace MyReadingList.Services
{
    public static class BookService
    {
        static List<Book> Books { get; }

        static BookService()
        {
            Books = [

                new Book { Id = 1,  NameOfBook = "kodi i davincit", HaveRead = true},

                ];

        }

        public static List<Book> GetAll() => Books;  //so this basically get the data out of memory and the GetALL will basically call and perform the logic up above 
        public static Book? Get(int id) => Books.FirstOrDefault(b => b.Id == id);
    }

}
