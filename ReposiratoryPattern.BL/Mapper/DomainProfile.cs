using AutoMapper;
using ReposiratoryPattern.BL.ModelVM;
using ReposiratoryPattern.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposiratoryPattern.BL.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Book, BookVM>();
            CreateMap<BookVM, Book>();
        }
    }
}
