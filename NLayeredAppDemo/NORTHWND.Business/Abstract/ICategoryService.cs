using NORTHWND.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWND.Business.Abstract
{
    public class ICategoryService
    {
        List<Category> GetAll();
    }
}
