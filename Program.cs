using CalculadoraMuitoManeira.Controller;
using CalculadoraMuitoManeira.Model.DTOs;
using CalculadoraMuitoManeira.View;

class Program
{
    public static void Main(String[] args)
    {
        ////Inicializando o Menu
        //var menu = new Menu();

        //menu.Show();
        //var request = menu.RetriveValue();

        ////Inicializando a Calculadora
        //var calculadora = new Calculadora();
        //var response = calculadora.Calcular(request);

        ////Resposta Final
        //menu.ShowResult(response);



        //Inicializando o MenuReflection
        var menu = new MenuReflection();
        menu.Show();

        RequestDTO request = menu.RetrieveValue();
        ResponseDTO response = null;

        //Inicializando a Calculadora
        CalculadoraController calculadoraController = new CalculadoraController();
        response = calculadoraController.Calcular(request);

        //Resposta Final
        menu.ShowResult(response);



    }
}