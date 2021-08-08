using Project.BLL.DTO.IntDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.DTO
{
    public class CategoryDTO:IDTO
    {
        /// <summary>
        /// Dışarıya açmak istediğimiz bilgiler doğrultusunda oluşturulmuştur.
        /// </summary>
        public int ID { get; set; }
        [MinLength(2,ErrorMessage ="{0} must be at least {1} characters long"),MaxLength(20, ErrorMessage = "{0} must no more than {1} characters long"),Required(ErrorMessage = "{0} is required"), Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
