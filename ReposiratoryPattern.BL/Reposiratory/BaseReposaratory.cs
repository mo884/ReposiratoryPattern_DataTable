using Microsoft.EntityFrameworkCore;
using ReposiratoryPattern.BL.Interface;
using ReposiratoryPattern.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReposiratoryPattern.BL.Reposiratory
{
    public class BaseReposaratory<T> : IBaseReposaratory<T> where T : class
    {
        protected  DBApplication DB;
        public BaseReposaratory(DBApplication DB)
        {
            this.DB = DB;
        }

        public T Find(Expression<Func<T, bool>> match) =>
            DB.Set<T>().SingleOrDefault(match);
       

        public async Task<T> GatByIDAsync(int id) =>
            await DB.Set<T>().FindAsync(id);
        

        public async Task<IEnumerable<T>> GetALLAsync() => 
            await DB.Set<T>().ToListAsync();
        
    }
}
