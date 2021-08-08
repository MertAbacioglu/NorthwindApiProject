using Project.BLL.CustomMapper;
using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DTO;
using Project.BLL.DTO.DTO;
using Project.BLL.DTO.IntDTO;
using Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRepository
{
    public class CategoryReporsitory : BaseRepository,
        IRepository<CategoryDTO,Category>, IMapper<Category, CategoryDTO>
    {
        public void Add(CategoryDTO item)
        {
            _db.Categories.Add(new Category
            {

                CategoryName = item.CategoryName,
                Description = item.Description,

            });
            _db.SaveChanges();
        }
        
       

        public bool Any(Expression<Func<CategoryDTO, bool>> exp,CategoryDTO item)
        {

            Category c = DtoToModel(item);
         
        
            return _db.Categories.Any(x=> exp.Body.);
        }

        public void Delete(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            Save();
        }

        public Category DtoToModel(CategoryDTO d)
        {
            return new Category
            {
                CategoryID = d.ID,
                CategoryName = d.CategoryName,
                Description = d.Description,
            };
        }



        public CategoryDTO Find(int id)
        {
            
            return ModelToDto(_db.Categories.Find(id));//ToDo: bu int ile ilgilen
        }

        public List<CategoryDTO> GetAll()
        {
            return _db.Categories.Select(x => new CategoryDTO
            {
                ID = x.CategoryID,
                CategoryName = x.CategoryName,
                Description = x.Description,
            }).ToList();
        }

        public CategoryDTO ModelToDto(Category m)
        {
            return new CategoryDTO
            {
                ID = m.CategoryID,
                CategoryName = m.CategoryName,
                Description = m.Description,
            };
        }

        public void Update(CategoryDTO item, int id)
        {
            Category toBeUpdated = _db.Categories.Find(id);

            _db.Entry(toBeUpdated).CurrentValues.SetValues(new Category
            {
                CategoryID = item.ID,
                CategoryName = item.CategoryName,
                Description = item.Description
            });
            Save();
        }



        void Save()
        {
            _db.SaveChanges();
        }
    }
}
