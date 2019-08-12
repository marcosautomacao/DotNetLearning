using System;
using System.Collections.Generic;
using DotNetLearning.Models ;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearning.Controllers

{
    
    public class ClientController: Controller {
        [HttpGet("v1/get-clients")]
        public IActionResult getClients()
        {
            return Ok(
                new List<Client> {
                    new Client {
                        Nome = "Marcos Moura",
                        Idade = 30,
                        Cidade = "Belo Horizonte",
                        Criação = new DateTime()
                    }
                }
            );
        }
        [HttpPost("v1/add-client")]
        public IActionResult addClient([FromBody]Client client)
        {
            return Ok();
        }
        [HttpPut("v1/edit-client/{id}")]
        public IActionResult editClient(Guid id, [FromBody]Client client)
        {
            return Ok();
        }
        [HttpGet("v1/get-client/{id}")]
        public IActionResult getClient(Guid id)
        {
            return Ok(
                new List<Client> {
                    new Client {
                        Nome = "Marcos Moura",
                        Idade = 30,
                        Cidade = "Belo Horizonte",
                        Criação = new DateTime()
                    }
                }
            );
        }
        [HttpDelete("v1/delete-client/{id}")]
        public IActionResult removeClient(Guid id)
        {
            return Ok();
        }
    }
}