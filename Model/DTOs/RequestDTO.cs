namespace CalculadoraMuitoManeira.Model.DTOs
{
    public class RequestDTO
    {
        public string Opcao { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public RequestDTO(string opcao, int valor1, int valor2)
        {
            this.Opcao = opcao;
            this.Valor1 = valor1;
            this.Valor2 = valor2;
        }


    }
}
