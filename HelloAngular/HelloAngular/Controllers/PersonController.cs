using HelloAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HelloAngular.Controllers
{
    public class PersonController : ApiController
    {
        public IHttpActionResult Get()
        {
            
           List<Person> persons = new List<Person>()
            {
                new Person {FirstName="Craig", LastName="Playstead",  Address="Dumaguete City"},
                 new Person {FirstName="Mark", LastName="javier",  Address="Dumaguete City"},
              new Person {FirstName="juan", LastName="del cruz",  Address="Makati City"},
            };
         
            return Ok(persons);
        }
    }
}