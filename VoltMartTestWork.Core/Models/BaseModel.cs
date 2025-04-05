using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltMartTestWork.Core.Models
{
    public class BaseModel<T>
    {
        [Key]
        public T Id {  get; set; } 
        public DateOnly Createat { get; set; }
        public DateOnly? Updateat { get; set; }
    }
}
