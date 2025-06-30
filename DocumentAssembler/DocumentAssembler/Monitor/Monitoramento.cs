using DocumentAssembler.Modelos;
using DocumentAssembler.Printers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentAssembler.Monitor
{
    public static class Monitoramento
    {
        private const string NAO_DEFINIDO = "Não definido";
        #region Funções
        public static string TempoExecucao()
        {
            return $"Horário de execução: {DateTime.Now.ToString()}";
        }
        public static string TipoNode(Node node)
        {
            return $"Tipo do nó {node.GetType().ToString()}";
        }
        public static string TempoCriacao(Node node)
        {
            return $"Horario Criação: {node.HorarioCriacao}";
        }
        public static string TextoNode(Node node)
        {
            string texto = NAO_DEFINIDO;
            if (node is Folha folha)
            {
                texto = folha.Texto;
            }
            return $"Texto do nó: {texto}";
        }
        public static string Profundidade(int profundidade)
        {
            return $"Profundidade: {profundidade}";
        }
        public static string TipoPrinter(IPrinter printer)
        {
            return $"Tipo de printer {printer.GetType().ToString()}";
        }
        #endregion Funções
    }
}
