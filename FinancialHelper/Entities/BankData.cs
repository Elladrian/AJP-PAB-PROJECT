using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper.Entities
{
    public class BankData
    {
        public int Id { get; set; }
        public string OperationDate { get; set; }
        public DateTime ValueDate { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public decimal SaldoAfterTransaction { get; set; }
        public string TransactionDescription { get; set; }
        public string? TransactionDescriptionAdditional1 { get; set; }
        public string? TransactionDescriptionAdditional2 { get; set; }
        public string? TransactionDescriptionAdditional3 { get; set; }
        public string? TransactionDescriptionAdditional4 { get; set; }
        public string? TransactionDescriptionAdditional5 { get; set; }
        public string? TransactionDescriptionAdditional6 { get; set; }
        public string? TransactionDescriptionAdditional7 { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
        
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
