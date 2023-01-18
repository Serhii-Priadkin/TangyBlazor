using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_Business.Repository.IRepository;
using Tangy_DataAccess.Data;

namespace Tangy_Business.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db= db;
        }

        public CategoryDTO Create(CategoryDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Update(CategoryDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
