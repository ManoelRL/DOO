using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Factories
{
    public class CalculadoraFabrica : AbstractFactory<ICalculadora>
    {
        private static CalculadoraFabrica instance;

        private CalculadoraFabrica()
        {
            base.namespaceBase = base.namespaceBase + ".Calculadora.";
        }

        public static CalculadoraFabrica GetInstance()
        {
            if (instance == null)
            {
                instance = new CalculadoraFabrica();
            }
            return instance;
        }
    }
}
