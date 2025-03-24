using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Factories
{
    public class CalculadoraFabrica : AbstractFactory<ICalculadora>
    {
        public CalculadoraFabrica()
        {
            base.namespaceBase = base.namespaceBase + ".Calculadora.";
        }
    }
}
