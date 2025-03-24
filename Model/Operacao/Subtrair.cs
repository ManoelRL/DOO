using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Operacao
{
    public class Subtrair : IOperacao
    {
        public int Operar(int value1, int value2) => value1 - value2;
    }
}
