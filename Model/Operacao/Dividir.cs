using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Operacao
{
    public class Dividir : IOperacao
    {
        public int Operar(int value1, int value2)
        {
            if(value2 == 0)
            {
                throw new DivideByZeroException();
            }

            return value1 / value2;
        }
        
    }
}
