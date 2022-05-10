using EJOGOS.Controllers.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{

    //Herança = colocando dois pontos e o nome da outra classe
    //Equipe agora herda as caracteristicas de EquipeBase
    public class Equipe : EquipeBase, IEquipe
    {

        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }


        //variavel de dados

        private const string camimhobd = "Database/equipe.csv";

        //construtor
        public Equipe()
        {
            //metodo da classe de herança EquipeBase
            CriarPastaOuArquivo(camimhobd);
        }

        //criar uma função que vai receber o obj equipe
        //e vai retornar no formato CSV (String)

        string Preparar(Equipe e)
        {

            return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;

        }

        public void Criar(Equipe novaequipe)
        {
            //array de strings = na posicao 0 temos o retorno do Preparar
            string[] equipe_texto = { Preparar(novaequipe) };

            //arquivo adicionar uma nova linha
            //caminho do arquivo, string em formato de array
            File.AppendAllLines(camimhobd, equipe_texto);
        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(camimhobd);

            foreach(string item in linhas)
            {

                //1; nome da equipe; caminho da imagem
                string [] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];      
                equipeAtual.Imagem = linhaEquipe[2];    

                listaEquipes.Add(equipeAtual);

            }
            return listaEquipes;

        }
    }
}
