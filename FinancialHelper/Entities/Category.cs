namespace FinancialHelper.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Commentary { get; set; }
        
        public int UserId { get; set; }
        public User? User { get; set; }

        public virtual List<BankData>? BankDatas { get; set; } = new();

        public override string ToString()
        {
            return Name;
        }
    }
}
