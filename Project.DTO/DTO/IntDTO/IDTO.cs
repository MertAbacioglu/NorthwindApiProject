using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.IntDTO
{
    public interface IDTO
    {
        //Bu interface BaseRepository'deki generic tipi kısıtlamak için oluşturulmuştur.
       int Name { get; set; }
    }
}
