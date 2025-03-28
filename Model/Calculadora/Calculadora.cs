﻿using CalculadoraMuitoManeira.Model.DTOs;
using CalculadoraMuitoManeira.Model.Factories;
using CalculadoraMuitoManeira.Model.Interfaces;

namespace CalculadoraMuitoManeira.Model.Calculadora
{
    public class Calculadora : ICalculadora
    {
        private static Calculadora _instance;

        private Calculadora() { }

        public ResponseDTO Calcular(RequestDTO requestDTO)
        {
            var fabrica = new OperacaoFabrica();
            IOperacao operacao = fabrica.Criar(requestDTO.Opcao);

            int valor1 = requestDTO.Valor1;
            int valor2 = requestDTO.Valor2;
            int result = -1;

            if (operacao != null)
            {
                result = operacao.Operar(valor1, valor2);
            }

            return new ResponseDTO(result);
        }

        public static Calculadora GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Calculadora();
            }
            return _instance;
        }


    }
}
