using CalculadoraMuitoManeira.Model.Calculadora;
using CalculadoraMuitoManeira.Model.DTOs;
using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Controller
{
    public class CalculadoraController
    {
        public ResponseDTO Calcular(RequestDTO requestDTO)
        {
            ICalculadora calculadora = new Calculadora();

            return calculadora.Calcular(requestDTO);
        }
    }
}
