using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ColytonHubApp.DataAccessLayer.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime? DOB { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int PostCode { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public bool IsInterpretorRequired { get; set; }
        public string InterpretorLanguage { get; set; }
        //public int LanguageId { get; set; }
        //public Language Language { get; set; }

        //[ForeignKey("CountryForeignKey")]
        public int CountryId { get; set; } //country of origin
        public Country Country { get; set; }

        [Required]
        public DateTime? DateOfArrival { get; set; }
        public bool IsChildAtSchool { get; set; }
        public int NoOfChildrenAtSchool { get; set; }

        [Required]
        public string EmergencyName { get; set; }

        [Required]
        public string Relationship { get; set; }

        [Required]
        public int EmergencyPhone { get; set; }
        public string OtherProg { get; set; }
        public string Comments { get; set; }
        public bool IsPartOfTalentPool { get; set; }
        public string PathToResume { get; set; }
        public string AreaOfInterest { get; set; }
        public int TalentCapacityID { get; set; }
        public TalentCapacity TalentCapacity { get; set; }
        public bool IsMyPhotoConsent { get; set; }
        public string PathToMyPhoto { get; set; }
        public bool Signature { get; set; }
        public ICollection<Child> Children { get; set; }
        public ICollection<Language_Person> Language_People { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
