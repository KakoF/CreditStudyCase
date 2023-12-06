using Domain.Entities;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Records;
using Infrastructure.Interfaces.DataConnector;

namespace Service.Services
{
    public class CreditoService : ICreditoService
    {
        private readonly ICreditoFactory _factory;
        private readonly IClienteRepository _clienteRepository;
        private readonly IFinanciamentoRepository _financiamentoRepository;
        private readonly IParcelaRepository _parcelaRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreditoService(ICreditoFactory factory, IClienteRepository clienteRepository, IFinanciamentoRepository financiamentoRepository, IParcelaRepository parcelaRepository, IUnitOfWork unitOfWork)
        {
            _factory = factory;
            _clienteRepository = clienteRepository;
            _financiamentoRepository = financiamentoRepository;
            _parcelaRepository = parcelaRepository;
            _unitOfWork = unitOfWork;

        }
        public async Task<CreditoAprovado> LiberarCredito(PropostaCredito propostaCredito)
        {
            var credito = _factory.Factory(propostaCredito);
            credito.ViabilizarLiberacao();
            var calculo = credito.CalcularCredito();
            await SalvarAsync(calculo, propostaCredito);
            return calculo;
        }

        private async Task SalvarAsync(CreditoAprovado calculo, PropostaCredito propostaCredito)
        {
            _unitOfWork.BeginTransaction();

            try
            {
                var cliente = await _clienteRepository.CreateAsync(new ClienteEntity(propostaCredito.Cpf, propostaCredito.Nome, propostaCredito.UF, propostaCredito.Celular));
                var financiamento = await _financiamentoRepository.CreateAsync(new FinanciamentoEntity(propostaCredito.TipoCredito, calculo.valorTotalComJuros, DateTime.Now.AddMonths(propostaCredito.QuantidadeParcelas), cliente.Id));
                for (int i = 0; i < propostaCredito.QuantidadeParcelas; i++)
                {
                    await _parcelaRepository.CreateAsync(new ParcelaEntity(i, (calculo.valorTotalComJuros / propostaCredito.QuantidadeParcelas), DateTime.Now.AddMonths(i), null, financiamento.Id));
                }
                _unitOfWork.CommitTransaction();
            }
            catch (Exception)
            {
                _unitOfWork.RollbackTransaction();
                throw;
            }
        }
    }
}
