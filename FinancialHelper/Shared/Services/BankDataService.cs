using FinancialHelper.Entities;
using FinancialHelper.Shared.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    if (databaseContext.BankDatas.Contains(bankDataEntity))
                    {
                        addedRows.Add(bankDataEntity);
                    }
                }

                databaseContext.AddRange(addedRows);
                databaseContext.SaveChanges();

                return addedRows;
            }
        }

        public List<Entities.BankData> GetUserData(int userId)
        {
            using(DatabaseContext databaseContext = new())
            {
                return databaseContext.BankDatas
                    .Where(bd => bd.UserId == userId)
                    .ToList();
            }
        }

        public Entities.BankData ChangeCategory(Entities.BankData bankData, int categoryId, int userId)
        {
            throw new NotImplementedException();
        }

        public List<Entities.BankData> GetSearchedData(string searchedPhrase, int userId)
        {
            using(DatabaseContext databaseContext = new())
            {
                var result = databaseContext.BankDatas.ToList();
                List<Entities.BankData> searchResult = new();

                foreach(var bd in result)
                {
                    string s = string.Join(" ",
                        bd.Id.ToString(),
                        bd.OperationDate,
                        bd.ValueDate.ToString(),
                        bd.TransactionType,
                        bd.Amount.ToString(),
                        bd.Currency,
                        bd.SaldoAfterTransaction.ToString(),
                        bd.TransactionDescription,
                        bd.TransactionDescriptionAdditional1,
                        bd.TransactionDescriptionAdditional2,
                        bd.TransactionDescriptionAdditional3,
                        bd.TransactionDescriptionAdditional4,
                        bd.TransactionDescriptionAdditional5,
                        bd.TransactionDescriptionAdditional6,
                        bd.TransactionDescriptionAdditional7);
                    var test = s.ToLower().Contains(searchedPhrase.ToLower());

                    if (test) searchResult.Add(bd);
                }

                return searchResult;
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
