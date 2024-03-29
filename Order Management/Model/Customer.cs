//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Order_Management.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StreetName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public int CreditLimit { get; set; }
        public int Status { get; set; }
    
        public virtual Status Status1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"Customer Information:\n+ Customer ID: {CustomerId}\n+ Customer Name: {CustomerName}\n" +
                   $"+ Street Name: {StreetName}\n+ Province: {Province}\n+ City: {City}\n+ Postal Code: {PostalCode}\n" +
                   $"+ Phone Number: {PhoneNumber}\n+ Contact Name: {ContactName}\n+ Contact Email: {ContactEmail}\n" +
                   $"+ Credit Limit: {CreditLimit}\n+ Status: {Status}";
        }
        public List<Customer> GetAllCustomers()
        {
            List<Customer> listC = new List<Customer>();
            using (HiTechDBEntities1 db = new HiTechDBEntities1())
            {
                var selectAll = (from c in db.Customers
                                 select c).ToList();
                Customer cus;
                foreach (var item in selectAll)
                {
                    cus = new Customer();
                    cus.CustomerId = item.CustomerId;
                    cus.CustomerName = item.CustomerName;
                    cus.StreetName = item.StreetName;
                    cus.Province = item.Province;
                    cus.PhoneNumber = item.PhoneNumber;
                    cus.City = item.City;
                    cus.PostalCode = item.PostalCode;
                    cus.ContactName = item.ContactName;
                    cus.CreditLimit = item.CreditLimit;
                    cus.Status = item.Status;
                    cus.ContactEmail = item.ContactEmail;
                    listC.Add(cus);
                }
            }
            return listC;
        }
    }
}

