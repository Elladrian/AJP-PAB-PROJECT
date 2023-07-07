using CsvHelper.Configuration.Attributes;

namespace FinancialHelper.Shared
{
    public class BankData
    {
        [Name("Data operacji")]
        [Index(0)]
        public string OperationDate { get; set; }

        [Name("Data waluty")]
        [Index(1)]
        public DateTime ValueDate { get; set; }

        [Name("Typ transakcji")]
        [Index(2)]
        public string TransactionType { get; set; }

        [Name("Kwota")]
        [Index(3)]
        public decimal Amount { get; set; }

        [Name("Waluta")]
        [Index(4)]
        public string Currency { get; set; }

        [Name("Saldo po transakcji")]
        [Index(5)]
        public decimal SaldoAfterTransaction { get; set; }

        [Name("Opis transakcji")]
        [Index(6)]
        public string TransactionDescription { get; set; }

        [Index(7)]
        public string? TransactionDescriptionAdditional1 { get; set; }

        [Index(8)]
        public string? TransactionDescriptionAdditional2 { get; set; }

        [Index(9)]
        public string? TransactionDescriptionAdditional3 { get; set; }

        [Index(10)]
        public string? TransactionDescriptionAdditional4 { get; set; }

        [Index(11)]
        public string? TransactionDescriptionAdditional5 { get; set; }

        [Index(12)]
        public string? TransactionDescriptionAdditional6 { get; set; }

        [Index(13)]
        public string? TransactionDescriptionAdditional7 { get; set; }
    }
}
