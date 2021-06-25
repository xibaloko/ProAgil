﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e EF Core",
                    Local = "São Paulo",
                    Lote = "1 Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "React e EF Core",
                    Local = "São Paulo",
                    Lote = "1 Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    EventoId = 3,
                    Tema = "Flutter e EF Core",
                    Local = "São Paulo",
                    Lote = "1 Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e EF Core",
                    Local = "São Paulo",
                    Lote = "1 Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "React e EF Core",
                    Local = "São Paulo",
                    Lote = "1 Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    EventoId = 3,
                    Tema = "Flutter e EF Core",
                    Local = "São Paulo",
                    Lote = "1 Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
                }
            }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
