using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Web_Api1.Models;

namespace Web_Api1.App_Start
{
    public class PersonDBInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person> {
                new Person {  Name = "Julio", LastName ="Gonzales", Mail = "Mail1"},
                new Person {Name = "Pedro", LastName = "Rodriguez", Mail = "Mail2" },
                new Person {Name = "Diego", LastName = "Skupnjak", Mail ="Mail3" },
                new Person {Name = "Pablo", LastName ="Martinez", Mail ="Mail4" }
            };
            persons.ForEach(c => context.Personas.Add(c));
            context.SaveChanges();
        }

    }
}