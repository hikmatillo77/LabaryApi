using LabaryApi.Modele;

namespace LabaryApi.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
        Task<Book> GetBookAsync(Guid id);
        Task<Book> CreateBookAsync(Book newBook);
        Task<Book> UpdateBookAsync(Book book);
        bool DeleteBook(Guid id);


    }
}
