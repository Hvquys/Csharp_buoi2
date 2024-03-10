using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_buoi2
{
    struct Student
    {
        private string Id;
        public string Name;
        public string IdProperty
        {
            get { return Id; }
            set { Id = value; }
        }
        public void Method()
        {
            Console.WriteLine("Tên của bạn là " + Name + "\nID: " + Id);
        }
    }

    struct Book
    {
        public string tenSach { get; set; }
        public string tacGia { get; set; }

        public void Method2()
        {
            Console.WriteLine("Cuốn sách: " + tenSach + " là của tác giả: " + tacGia);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "quy";
            student.IdProperty = "12345";
            student.Method();

            Book book = new Book();
            book.tacGia = "AB";
            book.tenSach = "AB";
            book.Method2();
            Console.ReadKey();
        }
    }
}
