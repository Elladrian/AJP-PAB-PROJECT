namespace FinancialHelper.Shared.Contracts
{
    public interface ICategoryService : IDisposable
    {
        List<CategoryChartData> GetCategoryChartDatas(DateTime from, DateTime to, int userId);
        Entities.Category CreateNewCategory(string name, string commentary, int userId);
        Entities.Category DeleteCategory(int id, int userId);
        List<Entities.Category> GetCategories(int userId);
        Entities.Category ModifyCategory(int categoryId, string name, string commentary, int userId);
        void Dispose();
        void Dispose(bool disposing);
    }
}
