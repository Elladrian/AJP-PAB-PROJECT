using FinancialHelper.Entities;
using FinancialHelper.Shared.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FinancialHelper.Shared.Services
{
    public class BankDataService : IBankDataService
    {
        public List<Entities.BankData> AddDataToDB(List<BankData> bankDatas, int userId, int? categoryId)
        {
            using (DatabaseContext databaseContext = new())
            {
                List<Entities.BankData> addedRows = new();

                foreach (Shared.BankData bankData in bankDatas)
                {
                    Entities.BankData bankDataEntity = new()
                    {
                        OperationDate = bankData.OperationDate,
                        ValueDate = bankData.ValueDate,
                        TransactionType = bankData.TransactionType,
                        Amount = bankData.Amount,
                        Currency = bankData.Currency,
                        SaldoAfterTransaction = bankData.SaldoAfterTransaction,
                        TransactionDescription = bankData.TransactionDescription,
                        TransactionDescriptionAdditional1 = bankData.TransactionDescriptionAdditional1,
                        TransactionDescriptionAdditional2 = bankData.TransactionDescriptionAdditional2,
                        TransactionDescriptionAdditional3 = bankData.TransactionDescriptionAdditional3,
                        TransactionDescriptionAdditional4 = bankData.TransactionDescriptionAdditional4,
                        TransactionDescriptionAdditional5 = bankData.TransactionDescriptionAdditional5,
                        TransactionDescriptionAdditional6 = bankData.TransactionDescriptionAdditional6,
                        TransactionDescriptionAdditional7 = bankData.TransactionDescriptionAdditional7,

                        UserId = userId,

                        CategoryId = categoryId,
                    };

                    if (!databaseContext.BankDatas.Contains(bankDataEntity))
                    {
                        addedRows.Add(bankDataEntity);
                    }
                }

                databaseContext.AddRange(addedRows);
                databaseContext.SaveChanges();

                
                return addedRows;
            }
        }

        public Entities.BankData ModifyCategory(int bankDataId, int categoryId)
        {
            using(DatabaseContext databaseContext = new())
            {
                var category = databaseContext.Categories.FirstOrDefault(c => c.Id == categoryId);

                Entities.BankData modifiedData = databaseContext.BankDatas
                    .Where(bd => bd.Id == bankDataId)
                    .FirstOrDefault();

                modifiedData.Category = category;
                databaseContext.SaveChanges();

                return modifiedData;
            }
        }

        public List<Entities.BankData> GetUserData(int userId)
        {
            using(DatabaseContext databaseContext = new())
            {
                return databaseContext.BankDatas
                    .Include(bd => bd.Category)
                    .OrderByDescending(bd => bd.OperationDate)
                    .Where(bd => bd.UserId == userId)
                    .ToList();
            }
        }

        public List<Entities.BankData> GetSearchedData(string searchedPhrase, int userId)
        {
            using(DatabaseContext databaseContext = new())
            {
                var result = databaseContext.BankDatas
                    .Include(bd => bd.Category)
                    .Where(bd => (
                        bd.Id + " " +
                        bd.Category!.Name + " " +
                        bd.OperationDate + " " +
                        bd.ValueDate + " " +
                        bd.TransactionType + " " +
                        bd.Amount + " " +
                        bd.Currency + " " +
                        bd.SaldoAfterTransaction + " " +
                        bd.TransactionDescription + " " +
                        bd.TransactionDescriptionAdditional1 + " " +
                        bd.TransactionDescriptionAdditional2 + " " +
                        bd.TransactionDescriptionAdditional3 + " " +
                        bd.TransactionDescriptionAdditional4 + " " +
                        bd.TransactionDescriptionAdditional5 + " " +
                        bd.TransactionDescriptionAdditional6 + " " +
                        bd.TransactionDescriptionAdditional7)
                        .ToLower()
                        .Contains(searchedPhrase.ToLower()))
                    .ToList();

                return result;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing) { }
        }
    }
}
