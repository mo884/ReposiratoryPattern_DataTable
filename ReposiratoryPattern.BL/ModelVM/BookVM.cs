using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposiratoryPattern.BL.ModelVM
{
    public class BookVM
    {
        
        public int ID { get; set; }
        [Required,MaxLength(50, ErrorMessage = "*")]
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
