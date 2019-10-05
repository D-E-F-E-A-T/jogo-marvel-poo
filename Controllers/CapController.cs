using System;
using ving_certo.Models;

namespace ving_certo.Controllers
{
    public class CapController : BaseController
    {
        CapModel capModel = new CapModel();
        
        public string LancarEscudo(){
            return "Capitão América lançou o escudo";
        }

        public string DefenderComEscudo(){
            return "Capitão América defendeu-se";
        }

        public ConsoleColor MudaCor(){
            return ConsoleColor.Blue;
        }
    }
}