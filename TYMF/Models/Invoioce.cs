using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TYMF.Models
{
    public class Invoioce
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceSum { get; set; }

    }
}
