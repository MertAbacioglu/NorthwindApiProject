using Project.BLL.DTO.IntDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.CustomMapper
{
    public interface IMapper<M,D> where D:IDTO //ToDO:Model için kısıtlama yap
    {
        
        M DtoToModel(D d); 
        D ModelToDto(M m);
    }
}
