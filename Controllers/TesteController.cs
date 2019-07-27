using Microsoft.AspNetCore.Mvc;

namespace DotNetLearning.Controllers

{
    
    public class TesteController: Controller {
        [HttpGet("teste")]
        public IActionResult Teste()
        {
            return Ok("testando a aplicação");
        }
    }
}