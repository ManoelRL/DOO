using System.Reflection;
using CalculadoraMuitoManeira.Model.DTOs;
using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.View
{
    public class MenuReflection
    {
        private readonly Dictionary<int, string> _opcoes;

        public MenuReflection()
        {
            _opcoes = Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => typeof(IOperacao).IsAssignableFrom(t)
                                    && !t.IsInterface
                                    && !t.IsAbstract)
                        .Select((t, index) => new { Index = index + 1, Name = t.Name })
                        .ToDictionary(x => x.Index, x => x.Name);
        }

        public void Show()
        {
            Console.WriteLine("Informe a operação");
            foreach (var opcao in _opcoes)
            {
                Console.WriteLine($"{opcao.Key}. {opcao.Value}");
            }
        }

        public RequestDTO RetrieveValue()
        {
            int escolha = int.Parse(Console.ReadLine());

            if (!_opcoes.ContainsKey(escolha))
            {
                Console.WriteLine("Opção inválida!");
                throw new Exception("Opção inválida!");
            }

            string opcao = _opcoes[escolha];

            Console.WriteLine("Informe o valor 1:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2:");
            int valor2 = int.Parse(Console.ReadLine());

            return new RequestDTO(opcao, valor1, valor2);
        }

        public void ShowResult(ResponseDTO responseDTO)
        {
            Console.WriteLine($"Resultado: {responseDTO.Result}");
        }
    }
}
