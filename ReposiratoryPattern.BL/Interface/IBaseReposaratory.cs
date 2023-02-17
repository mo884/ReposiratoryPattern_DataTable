using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReposiratoryPattern.BL.Interface
{
    public interface IBaseReposaratory<T> where T :  class
    {
        Task<T> GatByIDAsync(int id);
        Task<IEnumerable<T>> GetALLAsync();
        T Find(Expression<Func<T, bool>> match);

    }
}
