using Microsoft.AspNetCore.Mvc;
using TocantinsPay.Core.Interfaces.Applications;
using TocantinsPay.Core.Models.InputModels;

namespace TocantinsPay.Api.Controllers
{
    public class ClienteController(
        ICadastrarClienteApplication cadastrarClienteApplication,
        IBuscarClientesApplication buscarClientesApplication,
        IBuscarClientePorIdApplication buscarClientePorIdApplication,
        IAtualizarClienteApplication atualizarClienteApplication
    ) : MainController
    {
        [HttpPost]
        public async Task<IActionResult> CadastrarAsync([FromBody] ClienteInputModel inputModel)
        {
            var id = await cadastrarClienteApplication.CadastrarAsync(inputModel);

            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarAsync()
        {
            var clientes = await buscarClientesApplication.BuscarAsync();

            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorIdAsync([FromRoute] Guid id)
        {
            var cliente = await buscarClientePorIdApplication.BuscarPorIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarAsync([FromRoute] Guid id, [FromBody] AtualizacaoClienteInputModel inputModel)
        {
            await atualizarClienteApplication.AtualizarAsync(id, inputModel);

            return NoContent();
        }
    }
}
