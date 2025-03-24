using CalculadoraMuitoManeira.Model.DTOs;

namespace CalculadoraMuitoManeira.Model.Interfaces
{
    public interface ICalculadora
    {
        public ResponseDTO Calcular(RequestDTO requestDTO);
    }
}
