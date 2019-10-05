using ving_certo.Models;

namespace ving_certo.Controllers
{
    public class BaseController
    {
        BaseModel baseModel = new BaseModel();

        public string MostraInfo(){
            return $"Informações do personagem: \n HP:  {baseModel.Vida}";
        }

        public string Pular(){
            return "Personagem pulando";
        }
    }
}