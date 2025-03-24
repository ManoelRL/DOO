using System.Reflection;
using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Factories
{
    public class OperacaoFabrica : IFabrica<IOperacao>
    {
        public IOperacao? Criar(string opcao)
        {
            var tipoOperacao = Assembly.GetExecutingAssembly()
                                    .GetTypes()
                                    .FirstOrDefault(t => typeof(IOperacao).IsAssignableFrom(t)
                                                          && !t.IsInterface
                                                          && !t.IsAbstract
                                                          && t.Name.Equals(opcao, StringComparison.OrdinalIgnoreCase));

            if (tipoOperacao == null)
            {
                return null;
            }

            return Activator.CreateInstance(tipoOperacao) as IOperacao;
        }
    }
}
