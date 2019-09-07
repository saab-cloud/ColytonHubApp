using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColytonHubApp.UI.Models.Registration
{
    public class IndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
    }
}
