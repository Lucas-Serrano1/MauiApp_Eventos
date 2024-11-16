using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now.AddDays(0);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }


        public int DuracaoEmDias
        {
            get
            {

                TimeSpan duracao = DataTermino - DataInicio;
                return duracao.Days;
            }
        }

        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;


    }
}