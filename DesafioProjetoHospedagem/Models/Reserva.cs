using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {

        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebidos
            // *IMPLEMENTE AQUI*
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebidos
                // *IMPLEMENTE AQUI*
                throw new Exception("Capacidade de hóspedes excedida!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            decimal valor = valorTotal;

            //Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if(DiasReservados >= 10)
            {
                valor *= 0.90M;
              
            }

            return valor;
        }
    }
}