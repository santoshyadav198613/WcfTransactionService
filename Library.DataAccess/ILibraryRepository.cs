using Library.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface ILibraryRepository
    {
        Task<List<Book>> GetBooks();
        Task<List<Student>> GetStudent();
        Task<int> AddBooks(Book book);
        Task<int> AddStudent(Student student);
        Task<int> ProvideBookToStudent(StudentBookDetails details);
        Task<bool> AddRemoveQuantity(Book book);
    }
}
