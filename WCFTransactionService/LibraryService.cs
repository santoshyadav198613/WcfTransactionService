using Library.Model;
using Library.Repository;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Transactions;

namespace WCFTransactionService
{
    [ServiceBehavior(TransactionIsolationLevel = IsolationLevel.Serializable, TransactionTimeout = " 00:00:30")]
    public class LibraryService : ILibraryService
    {

        private ILibraryRepository _repo;
        private LibraryContext _context = new LibraryContext();
        public LibraryService()
        {
            _repo = new LibraryRepository(_context);
        }
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public async Task<int> AddBooks(Book book)
        {
            return await _repo.AddBooks(book);
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public async Task<bool> AddRemoveQuantity(Book book)
        {
            return await _repo.AddRemoveQuantity(book);
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public async Task<int> AddStudent(Student student)
        {
            return await _repo.AddStudent(student);
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _repo.GetBooks();
        }

        public async Task<List<Student>> GetStudent()
        {
            return await _repo.GetStudent();
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public async Task<int> ProvideBookToStudent(StudentBookDetails details)
        {
            return await _repo.ProvideBookToStudent(details);
        }
    }
}
