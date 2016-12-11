using LibraryClient.LibraryServiceRef;
using System;
using System.ServiceModel;
using System.Transactions;

namespace LibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var transScope = new TransactionScope())
                {
                    using (LibraryServiceClient client = new LibraryServiceClient())
                    {
                        Student s = new Student()
                        { FristName = "Santosh", LastName = "Yadav", DateOfBirth = Convert.ToDateTime("13-Nov-1986") };
                        int student=client.AddStudent(s);

                        Console.WriteLine("Number of student:" + student);

                        Book b = new Book() { PublishDate = Convert.ToDateTime("3423"), Author = "Santosh", Name = "WCF", Quantity = 10, Section = "Test" };
                        client.AddBooks(b);

                        transScope.Complete();
                    }
                }
            }
            catch (FaultException ex)
            {
                Console.Write(ex);
            }
        }
    }
}
