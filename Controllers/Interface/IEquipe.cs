using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Controllers.Interface
{
    public interface IEquipe
    {
        //Contrato 
        //Representa os métodos que são obrigatórios em uma outra classe

        void Criar(Equipe novaequipe);

        List<Equipe>LerEquipes();



    }
}
