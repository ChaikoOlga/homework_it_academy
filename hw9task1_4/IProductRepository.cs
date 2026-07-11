using System;
using System.Collections.Generic;
using System.Text;

namespace hw9task1_4
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
