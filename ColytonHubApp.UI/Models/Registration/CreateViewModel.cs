using ColytonHubApp.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColytonHubApp.UI.Models.Registration
{
    public class CreateViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required]
        public string Suburb { get; set; }

        public List<SelectListItem> States { get; }
                = new List<SelectListItem>
                {
                    new SelectListItem("NSW","NSW"),
                    new SelectListItem("QLD", "QLD"),
                    new SelectListItem("SA", "SA"),
                    new SelectListItem("TAS", "TAS"),
                    new SelectListItem("VIC", "VIC"),
                    new SelectListItem("WA", "WA")
                }; // used to populate the list of options
        [Required]
        public string State { get; set; }


        [Required]
        [Display(Name = "Post Code")]
        public int PostCode { get; set; }

        [Required]
        //[Phone]
        //[MaxLength(10)]
        public int Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //[Display(Name = "What Language/s other than English do you speak")]
        public ICollection<Language_Person> Language_People { get; set; }
        public List<Language> SpokenLanguages { get; set; }//for list of checkboxes
        [Display(Name = "What Language/s other than English do you speak")]
        public List<int> SelectedSpokenLang { get; set;}

        [Display(Name = "Do you need Interpretor Support")]
        public bool IsInterpretorRequired { get; set; }
        [Display(Name = "Please state what language")]
        public string InterpretorLanguage { get; set; }
        public SelectList Language { get; set; }

        [Required]
        [Display(Name = "Country Of Origin")]
        public int CountryId { get; set; } //country of origin
        public SelectList Country { get; set; }

        [Required]
        [Display(Name = "Date Of Arrival in Australia")]
        [DataType(DataType.Date)]
        public DateTime? DateOfArrival { get; set; }

        [Display(Name = "Total number of Children")]
        public int NoOfChildren { get; set; }
        //children code

        [Display(Name = "Child 1 First Name")]
        public string ChildFirstName1 { get; set; }

        [Display(Name = "Last Name")]
        public string ChildLastName1 { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? ChildDOB1 { get; set; }

        [Display(Name = "Child 2 First Name")]
        public string ChildFirstName2 { get; set; }

        [Display(Name = "Last Name")]
        public string ChildLastName2 { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? ChildDOB2 { get; set; }

        [Display(Name = "Child 3 First Name")]
        public string ChildFirstName3 { get; set; }

        [Display(Name = "Last Name")]
        public string ChildLastName3 { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? ChildDOB3 { get; set; }

        [Display(Name = "Child 4 First Name")]
        public string ChildFirstName4 { get; set; }

        [Display(Name = "Last Name")]
        public string ChildLastName4 { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? ChildDOB4 { get; set; }



        [Display(Name = "Children at CPS")]
        public bool IsChildAtSchool { get; set; }

        [Display(Name = "How many children at CPS")]
        public int NoOfChildrenAtSchool { get; set; }
        //end children code

        [Required]
        [Display(Name = "Contact Name")]
        public string EmergencyName { get; set; }

        [Required]
        public string Relationship { get; set; }

        [Required]
        [Display(Name = "Contact number")]
        //[Phone]
        //[MaxLength(10)]
        public int EmergencyPhone { get; set; }

        [Display(Name = "Are there any other programs you would like to do at the hub?")]
        public string OtherProg { get; set; }

        [Display(Name = "Do you have any comments or suggestions you would like to add")]
        public string Comments { get; set; }

        [Display(Name = "Do you want to be a part of the Talent Pool?")]
        public bool IsPartOfTalentPool { get; set; }

        [Display(Name = "Select path to your resume")]
        public string PathToResume { get; set; }

        [Display(Name = "Area Of Interest")]
        public string AreaOfInterest { get; set; }

        [Display(Name = "In what capacity")]
        public int TalentCapacityID { get; set; }

        [Display(Name = "Talent Capacity")]
        public SelectList TalentCapacity { get; set; }

        [Display(Name = "I give consent for my photo to be used for promotional purpose as described above        ")]
        public bool IsMyPhotoConsent { get; set; }

        [Display(Name = "I give consent for my child's photo to be used for promotional purpose as described above")]
        public bool IsChildPhotoConsent { get; set; }
        //public string PathToMyPhoto { get; set; }

        [Required]
        [Display(Name = "Checking this box equals as your Signature")]
        public bool Signature { get; set; }
        

        
    }
}
