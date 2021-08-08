using Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.SingletonPattern
{
    public class DBTool: DbContext
    {

        DBTool() { }

        static NorthwindEntities _dbInstance;
        public static NorthwindEntities DBInstance
        {
            
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new NorthwindEntities();
                }
                return _dbInstance;

            }
        }





    }
}
