using ControleEnderecos.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Name.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok("Código: " + id);
            }
            catch (Exception e)
            {
                var message = "Ocorreu um erro interno!";
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ClienteViewModel viewModel)
        {
            try
            {
                return Ok(viewModel.Nome);
            }
            catch (Exception e)
            {
                var message = "Ocorreu um erro interno!";
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status501NotImplemented);
            }
            catch (Exception e)
            {
                var message = "Ocorreu um erro interno!";
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ClienteViewModel viewModel)
        {
            try
            {
                return StatusCode(StatusCodes.Status501NotImplemented);
            }
            catch (Exception e)
            {
                var message = "Ocorreu um erro interno!";
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }

    }


}