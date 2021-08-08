using Project.BLL.DTO.IntDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<D,M> where D:IDTO where M:class
    {

        //List Commands
        List<D> GetAll();

        //Modify Commands 
        void Add(D item);
        void Delete(int id);
        void Update(D item,int id);
        
        //Find 
        D Find(int id);


        //Linq Expressions  
        bool Any(Expression<Func<D, bool>> exp,D item);











    }
}
