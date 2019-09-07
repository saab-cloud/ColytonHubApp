using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ColytonHubApp.DataAccessLayer.Models
{
    public class TalentCapacity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Capacity { get; set; }
        public ICollection<Person> Person { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
