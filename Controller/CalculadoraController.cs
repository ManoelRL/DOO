using CalculadoraMuitoManeira.Model.Calculadora;
using CalculadoraMuitoManeira.Model.DTOs;
using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Controller
{
    public class CalculadoraController
    {
        public ResponseDTO Calcular(RequestDTO requestDTO)
        {
            ICalculadora calculadora = Calculadora.GetInstance();

            return calculadora.Calcular(requestDTO);
        }
    }
}
