namespace CalculadoraMuitoManeira.Model.Interfaces
{
    public interface IFabrica<T>
    {
        T Criar(string opcao);
    }
}
