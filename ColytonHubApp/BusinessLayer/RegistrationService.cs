using ColytonHubApp.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ColytonHubApp.BusinessLayer
{
    public class RegistrationService
    {
        private ColytonHubDbContext _context;

        public RegistrationService(ColytonHubDbContext context)
        {
            _context = context;
        }

        //public DbSet<Person> GetPeople()
        public IEnumerable<Person> GetPeople()
        {
            return _context.People;
        }

        public IEnumerable<Country> GetCountries()
        {
            return _context.Countries;
        }

        public IEnumerable<Language> GetLanguages()
        {
            return _context.Languages;
        }

        public IEnumerable<TalentCapacity> GetTalentCapacity()
        {
            return _context.TalentCapacities;
        }

        public void CreatePerson(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

    }
}
