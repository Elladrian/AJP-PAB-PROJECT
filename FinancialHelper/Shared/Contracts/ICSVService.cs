namespace FinancialHelper.Shared.Contracts
{
    public interface ICSVService : IDisposable
    {
        List<BankData> GetDataFromFile(string path);
        void Dispose();
        void Dispose(bool disposing);
    }
}
