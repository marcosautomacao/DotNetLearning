using System;
using System.Collections.Generic;
using DotNetLearning.Models ;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearning.Controllers

{
    
    public class ClientController: Controller {
        [HttpGet("/get-clients")]
        public IActionResult ListarClients()
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
    }
}