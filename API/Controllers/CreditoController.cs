using Domain.Interfaces.Service;
using Domain.Records;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditoController : ControllerBase
    {
        private readonly ILiberarCreditoService _service;
        public CreditoController(ILiberarCreditoService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("Liberar")]
        public async Task<CreditoAprovado> Liberar([FromBody] PropostaCredito credito)
        {
            return await _service.LiberarCredito(credito);
        }
    }
}