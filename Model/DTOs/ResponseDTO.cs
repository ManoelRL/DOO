namespace CalculadoraMuitoManeira.Model.DTOs
{
    public class ResponseDTO
    {
        public int Result { get; set; }
        public ResponseDTO(int result)
        {
            this.Result = result;
        }
    }
}
