using FinancialHelper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper.Shared.Contracts
{
    public interface IBankDataService : IDisposable
    {
        List<Entities.BankData> AddDataToDB(List<Shared.BankData> bankDatas, int userId, int? categoryId);
        Entities.BankData ModifyCategory(int bankDataId, int categoryId);
        List<Entities.BankData> GetUserData(int userId);
        List<Entities.BankData> GetSearchedData(string searchedPhrase, int userId);
        void Dispose();
        void Dispose(bool disposing);
    }
}