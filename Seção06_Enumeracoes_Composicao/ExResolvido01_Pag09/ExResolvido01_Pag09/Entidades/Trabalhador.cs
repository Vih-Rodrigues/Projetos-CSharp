// CLASSE 

using ExResolvido01_Pag09.Entidades.Enumerados;
using System.Collections.Generic; // Namespace da classe List

namespace ExResolvido01_Pag09.Entidades
{
    internal class Trabalhador
    {
        // Propriedades - Nome do trabalhador
        public string Nome { get; set; }

        // Propriedade da enumeração
        public ClassificacaoTrabalhador Classificacao { get; set; }
        
        public double SalarioBase { get; set; }

        // propriedade do tipo Departamento
        public Departamento Departamento { get; set; }


        // O trabalhador possue associação com os contratos;
        // 1 trabalhador pode ter vários contratos
        // Portanto, tem-se a propriedade "Contratos" do tipo lista
        public List<ContratoDeHora> Contratos { get; private set; } = new List<ContratoDeHora>();


        // Construtor padrão
        public Trabalhador()
        {

        }


        // Construtor com argumentos
        // Por via de REGRA, não se deve passar listas para o construtor, logo não se passa a propriedade "Contratos"
        public Trabalhador(string nome, ClassificacaoTrabalhador classificacao, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Classificacao = classificacao;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }


        // Métodos

        public void AdicionaContrato(ContratoDeHora contrato)
        {
            Contratos.Add(contrato); // Adiciona contrato na lista
        }

        public void RemoverContrato(ContratoDeHora contrato)
        {
            Contratos.Remove(contrato); // Remove contrato da lista
        }

        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
            
            // Laço para percorrer a lista de contratos = "Para cada objeto contrato do tipo "Contrato de hora" na lista de contratos "Contratos"
            foreach (ContratoDeHora contrato in Contratos)
            {
                if (contrato.DataDoContrato.Year == ano && contrato.DataDoContrato.Month == mes)
                {
                    soma = soma + contrato.ValorTotal(); // ValorTotal é a operação que retorna o valor do contrato
                }
            }
           
            return soma;
        }
    }
}
