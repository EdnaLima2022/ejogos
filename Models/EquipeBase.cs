using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {

        public void CriarPastaOuArquivo(string caminho)
        {
            //Diretorio = pasta / Arquivo  = caminho
            //nome da pasta / nome do arquivo.csv, e começar posição zero na pasta
            string pasta = caminho.Split('/')[0];  

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

            }

            if (File.Exists(caminho))
            {
                File.Create(caminho).Close();
            }

        }



    }
}
