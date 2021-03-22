using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.ProiectMDS.Models;
using ProiectMDS.ProiectMDS.Repositories.ChelnerRepository;
using ProiectMDS.ProiectMDS.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProiectMDS.ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChelnerController : ControllerBase
    {
        public IChelnerRepository IChelnerRepository { get; set; }
        public ChelnerController(IChelnerRepository repository)
        {
            IChelnerRepository = repository;
        }
        // GET: api/<ChelnerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChelnerController>/5
        [HttpGet("{id}")]
        public ActionResult<List<Chelner>> Get(int id)
        {
            return IChelnerRepository.GetAll();
        }

        // POST api/<ChelnerController>
        [HttpPost]
        public Chelner Post(ChelnerDTO value)
        {
            Chelner model = new Chelner()
            {
                Nume = value.Nume,
                Salariu = value.Salariu,
                Prenume = value.Prenume,
                Comanda = new List<Comanda>()
            };
            return IChelnerRepository.Create(model);
        }

        // PUT api/<ChelnerController>/5
        [HttpPut("{id}")]
        public Chelner Put(int id, ChelnerDTO value)
        {
            Chelner chelner = IChelnerRepository.Get(id);
            Chelner model = new Chelner();
            if (value.Nume != null)
            {
                model.Nume = value.Nume;
            }

         
            model.Salariu = value.Salariu;
            

            if (value.Prenume != null)
            {
                model.Prenume = value.Prenume;
            }

            if (value.Comanda != null)
            {
                model.Comanda = new List<Comanda>();

            }

            return IChelnerRepository.Update(model);
        }

        // DELETE api/<ChelnerController>/5
        [HttpDelete("{id}")]
        public Chelner Delete(int id)
        {
            Chelner provider = IChelnerRepository.Get(id);
            return IChelnerRepository.Delete(provider);
        }
    }
}
