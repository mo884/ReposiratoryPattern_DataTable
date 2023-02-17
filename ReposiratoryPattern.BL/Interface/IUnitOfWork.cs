using ReposiratoryPattern.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposiratoryPattern.BL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseReposaratory<Book> book { get;}
        int Complet();

    }
}
