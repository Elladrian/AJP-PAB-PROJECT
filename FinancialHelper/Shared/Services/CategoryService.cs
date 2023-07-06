using FinancialHelper.Entities;
using FinancialHelper.Shared.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FinancialHelper.Shared.Services
{
    public class CategoryService : ICategoryService
    {
        public List<CategoryChartData> GetCategoryChartDatas(DateTime from, DateTime to, int userId)
        {
            using(DatabaseContext databaseContext = new())
            {
                var result = databaseContext.BankDatas
                    .Include(bd => bd.Category)
                    .Where(bd => bd.UserId == userId && (bd.ValueDate >= from && bd.ValueDate <= to))
                    .GroupBy(bd => bd.Category!.Name)
                    .Select(bd => new CategoryChartData()
                    {
                        Name = bd.Key,
                        AmountPlus = bd.Where(s => s.Amount > 0).Sum(s => (double)s.Amount),
                        AmountMinus = bd.Where(s => s.Amount < 0).Sum(s => (double)s.Amount),
                    })
                    .ToList();

                return result;
            }
        }

        public Category CreateNewCategory(string name, string commentary, int userId)
        {
            using(DatabaseContext databaseContext = new())
            {
                Category category = new()
                {
                    Name = name,
                    Commentary = commentary,
                    UserId = userId
                };

                if (databaseContext.Categories.FirstOrDefault(c => c.Name == name) != null) throw new Exception("Such category already exists!");

                databaseContext.Categories.Add(category);

                databaseContext.SaveChanges();

                return category;
            }
        }

        public Category DeleteCategory(int id, int userId)
        {
            using (DatabaseContext databaseContext = new())
            {
                var relatedData = databaseContext.BankDatas
                    .Where(bd => bd.CategoryId == id)
                    .ToList();

                foreach(var item in relatedData)
                {
                    item.CategoryId = null;
                }

                Category category = databaseContext.Categories.FirstOrDefault(c => c.Id == id);

                databaseContext.Categories.Remove(category);

                databaseContext.SaveChanges();

                return category;
            }
        }

        public List<Category> GetCategories(int userId)
        {
            using (DatabaseContext databaseContext = new())
            {
                return databaseContext.Categories
                    .Where(c => c.UserId == userId)
                    .ToList();
            }
        }

        public Category ModifyCategory(int categoryId, string name, string commentary, int userId)
        {
            using (DatabaseContext databaseContext = new())
            {
                Category modifiedCategory = databaseContext.Categories.FirstOrDefault(c => c.Id == categoryId);

                modifiedCategory.Name = name;
                modifiedCategory.Commentary = commentary;

                databaseContext.SaveChanges();

                return modifiedCategory;
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
