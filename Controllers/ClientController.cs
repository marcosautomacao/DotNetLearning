using System;
using System.Collections.Generic;
using DotNetLearning.Models ;
using DotNetLearning.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearning.Controllers

{
    public class ClientController: Controller {
        private readonly IClientRepository _repository;

        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("v1/get-clients")]
        public IActionResult getClients()
        {
            return Ok(_repository.GetClients());
        }
        [HttpPost("v1/add-client")]
        // id?id=?id=1ad9af1b-affa-4b71-8db6-c1e4df0ef11
        public IActionResult addClient([FromBody]Client client)
        {
            _repository.AddClient(client);
            return Ok();
        }
        [HttpPut("v1/edit-client/{id}")]
        public IActionResult editClient(Guid id, [FromBody]Client client)
        {
            var oldClient = _repository.GetClient(id);
            if (oldClient == null) return NotFound();
            oldClient.Nome = client.Nome;
            oldClient.Idade = client.Idade;
            oldClient.Cidade = client.Cidade;
            oldClient.Criação = new DateTime();
            return Ok();
        }
        [HttpGet("v1/get-client/{id}")]
        public IActionResult getClient(Guid id)
        {
            var client = _repository.GetClient(id);
            if (client == null) return NotFound();
            return Ok(client);
        }
        [HttpDelete("v1/delete-client/{id}")]
        public IActionResult RemoveClient(Guid id)
        {
            return Ok(id);
            //_repository.RemoveClient(id);
            //return Ok();
        }
    }
}