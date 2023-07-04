using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper.Shared.Contracts
{
    public interface ICSVService : IDisposable
    {
        List<BankData> GetDataFromFile(string path);
        void Dispose();
        void Dispose(bool disposing);
    }
}
