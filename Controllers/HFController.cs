using System;
using ving_certo.Models;

namespace ving_certo.Controllers
{
    public class HFController : BaseController
    {
        HFModel hfModel = new HFModel();
        
        public string Voar(){
            return "Homem de Ferro voando";
        }

        public string Atirar(){
            return "Homem de Ferro atirando";
        }

        public ConsoleColor MudaCor(){
            return ConsoleColor.Red;
        }
    }
}