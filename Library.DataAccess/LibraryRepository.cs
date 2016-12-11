using Library.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private LibraryContext _context = new LibraryContext();
        public LibraryRepository(LibraryContext context)
        {
            this._context = context;
        }

        public async Task<int> AddBooks(Book book)
        {
            book.CreatedDate = DateTime.Now;
            _context.Book.Add(book);
            int x = await _context.SaveChangesAsync();
            return x;
        }

        public async Task<bool> AddRemoveQuantity(Book book)
        {
            Book bupdate = await _context.Book.FindAsync(book.BookId);
            bupdate.Quantity = bupdate.Quantity - 1;
            int x = await _context.SaveChangesAsync();
            return x == 0 ? false : true;
        }

        public async Task<int> AddStudent(Student student)
        {
            student.CreatedDate = DateTime.Now;
            _context.Student.Add(student);
            int x = await _context.SaveChangesAsync();
            return x;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _context.Book.ToListAsync();
        }

        public async Task<List<Student>> GetStudent()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<int> ProvideBookToStudent(StudentBookDetails details)
        {
            _context.StudentBookDetails.Add(details);
            int x = await _context.SaveChangesAsync();
            return x;
        }
    }
}
