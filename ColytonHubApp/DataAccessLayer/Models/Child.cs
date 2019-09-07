using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ColytonHubApp.DataAccessLayer.Models
{
    public class Child
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime? DOB { get; set; }

        public bool IsChildPhotoConsent { get; set; }
        public string PathOfPhoto { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}