using Domain.Abstractions;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Records;
using Infrastructure.Interfaces.DataConnector;

namespace Service.Services
{
    public class SalvarCreditoService : ISalvarCreditoService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IFinanciamentoRepository _financiamentoRepository;
        private readonly IParcelaRepository _parcelaRepository;
        private readonly IUnitOfWork _unitOfWork;
        public SalvarCreditoService(IClienteRepository clienteRepository, IFinanciamentoRepository financiamentoRepository, IParcelaRepository parcelaRepository, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _financiamentoRepository = financiamentoRepository;
            _parcelaRepository = parcelaRepository;
            _unitOfWork = unitOfWork;

        }
        public async Task<Credito> SalvarAsync(CreditoAbstract credito)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var calculo = credito.CalcularCredito();
                var cliente = await _clienteRepository.CreateAsync(new ClienteEntity(credito.Cpf, credito.Nome, credito.UF, credito.Celular));
                var financiamento = await _financiamentoRepository.CreateAsync(new FinanciamentoEntity(credito.TipoCredito, calculo.valorTotalComJuros, DateTime.Now.AddMonths(credito.QuantidadeParcelas), cliente.Id));
                var parcelas = new List<ParcelaEntity>();
                for (int i = 0; i < credito.QuantidadeParcelas; i++)
                {
                    parcelas.Add(await _parcelaRepository.CreateAsync(new ParcelaEntity(i, (calculo.valorTotalComJuros / credito.QuantidadeParcelas), DateTime.Now.AddMonths(i), null, financiamento.Id)));
                }
                _unitOfWork.CommitTransaction();

                return new Credito(cliente, financiamento, parcelas);
            }
            catch (Exception)
            {
                _unitOfWork.RollbackTransaction();
                throw;
            }
        }
    }
}
