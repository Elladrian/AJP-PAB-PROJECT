namespace FinancialHelper.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual List<Category> Categories { get; set; } = new();
        public virtual List<BankData> BankDatas { get; set; } = new();
    }
}
