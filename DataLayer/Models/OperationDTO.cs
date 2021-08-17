using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class OperationDTO
    {
        public string Type{ get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }

    }
}
