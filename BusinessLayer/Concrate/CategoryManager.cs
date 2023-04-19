using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _efCategoryRepository;

        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            _efCategoryRepository = efCategoryRepository;
        }

        public void Add(Category category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void Delete(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public Category GetByID(int id)
        {
            return _efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _efCategoryRepository.ListAll();
        }

        public void Update(Category category)
        {
            _efCategoryRepository.Update(category);
        }
    }
}
