using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColytonHubApp.DataAccessLayer.Models;
using ColytonHubApp.UI.Models.Registration;
using ColytonHubApp.BusinessLayer;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ColytonHubApp.UI.Controllers
{
    public class RegistrationController : Controller
    {
        //private ColytonHubDbContext _context;
        private RegistrationService _registrationService;
        private List<Language> _spokenLang;

        public RegistrationController(/*ColytonHubDbContext context,*/ RegistrationService service)
        {
            //_context = context;
            _registrationService = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<IndexViewModel> indexVMList = new List<IndexViewModel>();
            var people = _registrationService.GetPeople();
            //IEnumerable<Person> people = _registrationService.GetPeople();
            foreach (var person in people)
            {
                IndexViewModel indexVM = new IndexViewModel();
                indexVM.Id = person.Id;
                indexVM.FullName = person.FirstName + " " + person.LastName;
                indexVMList.Add(indexVM);
            }

            return View(indexVMList);

        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateViewModel createVM = new CreateViewModel();

           
            var languagesList = _registrationService.GetLanguages();
            createVM.SpokenLanguages = languagesList.ToList<Language>();
            createVM.Language = new SelectList(languagesList, "Id", "Name");

            var countriesList = _registrationService.GetCountries();
            createVM.Country = new SelectList(countriesList, "Id", "Name");

            var talentCapacityList = _registrationService.GetTalentCapacity();
            createVM.TalentCapacity = new SelectList(talentCapacityList, "Id", "Capacity");
            return View(createVM);
        }

        [HttpPost]
        public void SetSelectedSpokenLang(List<Language> spokenLang)
        {
            this._spokenLang = spokenLang;
        }

        private List<Language> GetSelectedSpokenLang()
        {
            return this._spokenLang;
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel createVM)
        {
            if (ModelState.IsValid)
            {
                Person newPerson = new Person();
                newPerson.FirstName = createVM.FirstName;
                newPerson.LastName = createVM.LastName;
                newPerson.DOB = createVM.DOB;
                newPerson.Street = createVM.Street;
                newPerson.Suburb = createVM.Suburb;
                newPerson.State = createVM.State;
                newPerson.PostCode = createVM.PostCode;
                newPerson.Phone = createVM.Phone;
                newPerson.Email = createVM.Email;
                //for (int i =0; i < createVM.SpokenLanguages.Count; i++)
                //{
                //    //if (createVM.SpokenLanguages.ElementAt(i).se)
                //    //createVM.SelectedSpokenLang.ElementAt(i)
                //}
                for (int i = 0; i < GetSelectedSpokenLang().Count; i++)
                {
                    Language_Person langPerson = new Language_Person();
                    langPerson.PersonId = newPerson.Id;
                    //langPerson.LanguageId = GetSelectedSpokenLang().ElementAt(i);
                    newPerson.Language_People.Add(langPerson);
                }
                //for (int i = 0; i < createVM.SelectedSpokenLang.Count; i++)
                //{
                //    Language_Person langPerson = new Language_Person();
                //    langPerson.PersonId = newPerson.Id;
                //    langPerson.LanguageId = createVM.SelectedSpokenLang.ElementAt(i);
                //    newPerson.Language_People.Add(langPerson);
                //}
                newPerson.IsInterpretorRequired = createVM.IsInterpretorRequired;
                newPerson.InterpretorLanguage = createVM.InterpretorLanguage;
                newPerson.CountryId = createVM.CountryId;
                newPerson.DateOfArrival = createVM.DateOfArrival;
                //children code will go here
                for (int i=1; i<= createVM.NoOfChildren; i++)
                {
                    Child newChild = new Child();
                    switch (i)
                    {
                        case 1:
                            newChild.FirstName = createVM.ChildFirstName1;
                            newChild.LastName = createVM.ChildLastName1;
                            newChild.DOB = createVM.ChildDOB1;
                            newChild.IsChildPhotoConsent = createVM.IsChildPhotoConsent;
                            newChild.PersonId = newPerson.Id;
                            newPerson.Children.Add(newChild);
                            break;
                        case 2:
                            newChild.FirstName = createVM.ChildFirstName2;
                            newChild.LastName = createVM.ChildLastName2;
                            newChild.DOB = createVM.ChildDOB2;
                            newChild.IsChildPhotoConsent = createVM.IsChildPhotoConsent;
                            newChild.PersonId = newPerson.Id;
                            newPerson.Children.Add(newChild);
                            break;
                        case 3:
                            newChild.FirstName = createVM.ChildFirstName3;
                            newChild.LastName = createVM.ChildLastName3;
                            newChild.DOB = createVM.ChildDOB3;
                            newChild.IsChildPhotoConsent = createVM.IsChildPhotoConsent;
                            newChild.PersonId = newPerson.Id;
                            newPerson.Children.Add(newChild);
                            break;
                        case 4:
                            newChild.FirstName = createVM.ChildFirstName4;
                            newChild.LastName = createVM.ChildLastName4;
                            newChild.DOB = createVM.ChildDOB4;
                            newChild.IsChildPhotoConsent = createVM.IsChildPhotoConsent;
                            newChild.PersonId = newPerson.Id;
                            newPerson.Children.Add(newChild);
                            break;
                    }
                    //newChild.FirstName = createVM.ChildFirstName;
                    //newChild.LastName = createVM.ChildLastName;
                    //newChild.DOB = createVM.ChildDOB;
                    //newChild.IsChildPhotoConsent = createVM.IsChildPhotoConsent;
                    //newChild.PersonId = newPerson.Id;
                    //newPerson.Children.Add(newChild);
                }


                newPerson.EmergencyName = createVM.EmergencyName;
                newPerson.Relationship = createVM.Relationship;
                newPerson.EmergencyPhone = createVM.EmergencyPhone;
                newPerson.OtherProg = createVM.OtherProg;
                newPerson.Comments = createVM.Comments;
                newPerson.IsPartOfTalentPool = createVM.IsPartOfTalentPool;
                newPerson.AreaOfInterest = createVM.AreaOfInterest;
                newPerson.TalentCapacityID = createVM.TalentCapacityID;
                newPerson.PathToResume = createVM.PathToResume;
                newPerson.IsMyPhotoConsent = createVM.IsMyPhotoConsent;
                newPerson.Signature = createVM.Signature;
                newPerson.DateCreated = System.DateTime.Now;

                _registrationService.CreatePerson(newPerson);
                return RedirectToAction("Index");
            }
            var languagesList = _registrationService.GetLanguages();
            createVM.SpokenLanguages = languagesList.ToList<Language>();
            createVM.Language = new SelectList(languagesList, "Id", "Name");

            var countriesList = _registrationService.GetCountries();
            createVM.Country = new SelectList(countriesList, "Id", "Name");

            var talentCapacityList = _registrationService.GetTalentCapacity();
            createVM.TalentCapacity = new SelectList(talentCapacityList, "Id", "Capacity");
            return View(createVM);
        }
    }
}