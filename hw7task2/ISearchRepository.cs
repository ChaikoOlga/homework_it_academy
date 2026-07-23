using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public interface ISearchRepository
    {
        List<Order> SearchByName(string name);
    }
}
