namespace MvcCrud.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, string salary, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
            BirthDate = birthDate;
        }

        public void AddSales(SalesRecord record)
        {
            SalesRecords.Add(record);
        }

        public void RemoveSales(SalesRecord record)
        {
            SalesRecords.Remove(record);
        }

        public double GetSalesPeriod(DateTime initial, DateTime end)
        { 
            return SalesRecords.Where(x => x.Date > initial && x.Date < end).Sum(x => x.Amount);
        }
    }
}
