using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiproject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private List<Contacts> contacts = new List<Contacts> {
            new Contacts {Id = 1 , FirstName = "Developer" , LastName = "Point" , NickName="Iron Man",Place="India"},
            new Contacts {Id = 2 , FirstName = "angular" , LastName="11", NickName=  "Scripting" , Place = "Us"}
        };
        // GET: api/<ContactsController>
        [HttpGet]
        public ActionResult<IEnumerable<Contacts>>Get()
        {
            return contacts;
        }

        // GET api/<ContactsController>/5
        [HttpGet("{id}")]
        public ActionResult<Contacts> Get(int id)
        {
            Contacts contact = contacts.FirstOrDefault(c => c.Id == id);
            if(contact == null)
            {
                return NotFound(new { Message = "Request Id is not found" });
            }
            return Ok(contact);
        }

        // POST api/<ContactsController>
        [HttpPost]
        public ActionResult<IEnumerable<Contacts>> Post(Contacts newcontact)
        {
            contacts.Add(newcontact);
            return contacts;
        }

        // PUT api/<ContactsController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contacts>>Put(int id, Contacts updatecontacts)
        {
            Contacts contact = contacts.FirstOrDefault(contact => contact.Id == id);
            if(contact == null)
            {
                return NotFound();
            }
            contact.NickName = updatecontacts.NickName;
            contact.IsDeleted = updatecontacts.IsDeleted;
            return contacts;
        }

        // DELETE api/<ContactsController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contacts>> Delete(int id)
        {
            Contacts contact = contacts.FirstOrDefault(c => c.Id == id);
            if(contact == null)
            {
                return NotFound();
            }
            contacts.Remove(contact);
            return contacts;
        }
    }
}
