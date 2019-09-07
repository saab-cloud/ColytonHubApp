using System;
using System.Collections.Generic;
using System.Text;

namespace ColytonHubApp.DataAccessLayer.Models
{
    public class Language_Person
    {
        //public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
