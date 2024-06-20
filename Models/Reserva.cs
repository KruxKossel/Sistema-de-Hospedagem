using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem.Models
{
    public class Reserva(int diasReservados)
    {

        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; } = diasReservados;


        public void CadastrarHospedes(List<Pessoa> hospedes){

                if (Suite?.Capacidade <= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new InvalidOperationException("Capacidade insuficiente para o número de hóspedes.");
                }
        }

        public void CadastrarSuite(Suite suite){

            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){

            if (Hospedes == null)
            {
                return 0;
            }
            else
            {
                return Hospedes.Count;
            }
        }

        public decimal CalcularValorDiaria(){

            if (Suite == null) { return 0; }
            else
            {
                decimal valor = DiasReservados * Suite.ValorDiaria;

                if (DiasReservados >= 10)
                {
                    decimal desconto = valor * 0.1m; // 10% do valor
                    valor -= desconto;
                }

                return valor;
            }
        }
        
    }
}