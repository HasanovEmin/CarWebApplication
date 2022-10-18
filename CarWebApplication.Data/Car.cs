using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWebApplication.Data
{
    public class Car
    {
        public int Id { get; set; }

        [DisplayName("Year")]
        public int Year { get; set; }

        [DisplayName("Name")]
        public string? Name { get; set; }
    }
}
