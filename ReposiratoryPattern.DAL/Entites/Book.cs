using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposiratoryPattern.DAL.Entites
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50,ErrorMessage ="*")]
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
