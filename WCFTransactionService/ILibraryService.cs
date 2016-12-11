using Library.Model;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WCFTransactionService
{
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        Task<List<Book>> GetBooks();
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        Task<List<Student>> GetStudent();
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        Task<int> AddBooks(Book book);
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        Task<int> AddStudent(Student student);
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        Task<int> ProvideBookToStudent(StudentBookDetails details);
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        Task<bool> AddRemoveQuantity(Book book);
    }
}
