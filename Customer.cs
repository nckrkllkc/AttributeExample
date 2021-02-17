using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [ToTable("Customers")]
    [ToTable("tblCustomers")] // AllowMultiple true olduğu için uygulanabilir. Customers tablosu yoksa tblCustomers tablosuna bak.
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class CustomerDal
    {
        [Obsolete("Bu metodun yerine yenisini kullanınız.")]
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void AddNew()
        {

        }
    }
}
