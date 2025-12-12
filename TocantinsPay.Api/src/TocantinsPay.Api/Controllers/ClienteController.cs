using Microsoft.AspNetCore.Mvc;
using TocantinsPay.Core.Interfaces.Applications;
using TocantinsPay.Core.Models.InputModels;

namespace TocantinsPay.Api.Controllers
{
    public class ClienteController(ICadastrarClienteApplication cadastrarClienteApplication) : MainController
    {
        private readonly ICadastrarClienteApplication _cadastrarClienteApplication = cadastrarClienteApplication;

        [HttpPost]
        public async Task<IActionResult> CadastrarAsync([FromBody] ClienteInputModel inputModel)
        {
            var id = await _cadastrarClienteApplication.CadastrarAsync(inputModel);

            return Ok(id);
        }
    }
}
