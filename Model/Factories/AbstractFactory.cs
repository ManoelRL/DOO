using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Factories
{
    public class AbstractFactory<T> : IFabrica<T> where T : class
    {
        protected string namespaceBase = "CalculadoraMuitoManeira.Model";
        public T Criar(string opcao)
        {
            try
            {
                string nomeClasse = namespaceBase + opcao;
                Type tipoOperacao = Type.GetType(nomeClasse);

                if (tipoOperacao == null) throw new InvalidOperationException($"Tipo {nomeClasse} não encontrado.");

                object instancia = Activator.CreateInstance(tipoOperacao);

                if (instancia is T operacao)
                {
                    return operacao;
                }

                throw new InvalidOperationException("Falha ao converter instância para o tipo desejado.");
            }
            catch (Exception error)
            {
                throw new InvalidOperationException($"Erro ao criar instância da operação: {error.Message}", error);
            }
        }
    }
}
