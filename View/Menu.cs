using CalculadoraMuitoManeira.Model.DTOs;

namespace CalculadoraMuitoManeira.View
{
    public class Menu
    {
        public void Show()
        {
            Console.WriteLine("Informe a operação:");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
        }


        public RequestDTO RetriveValue()
        {
            string opcao = SelecionarOpcao(int.Parse(Console.ReadLine()));
            Console.WriteLine("Informe o valor 1");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            int valor2 = int.Parse(Console.ReadLine());

            return new RequestDTO(opcao, valor1, valor2);
        }

        private string SelecionarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1: return "Somar";
                case 2: return "Subtrair";
                case 3: return "Multiplicar";
                case 4: return "Dividir";
                default: return "Opção Inválida";
            }
        }

        public void ShowResult(ResponseDTO responseDTO)
        {
            Console.WriteLine($"Resultado: {responseDTO.Result}");
        }
    }
}
