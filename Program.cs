using System;
using ving_certo.Models;
using ving_certo.Controllers;

namespace ving_certo
{
    class Program
    {
        static void Main(string[] args)
        {
           string personagem;

           Console.WriteLine("Digite \n 1-Homem de Ferro \n 2-Capitão América");
           personagem = Console.ReadLine();

           HFController hfControl = new HFController();
           CapController capControl = new CapController();

           if(personagem == "1"){
               Console.ForegroundColor = hfControl.MudaCor();

               Console.WriteLine(hfControl.MostraInfo());
               Console.WriteLine("Você está jogando com o Homem De Ferro");
               Console.WriteLine(hfControl.Atirar());
               Console.WriteLine(hfControl.Pular());
               Console.WriteLine(hfControl.Voar());
           }
           else if(personagem == "2"){
               Console.ForegroundColor = capControl.MudaCor();

               Console.WriteLine(capControl.MostraInfo());
               Console.WriteLine("Você está jogando com o Capitão América");
               Console.WriteLine(capControl.LancarEscudo());
               Console.WriteLine(capControl.Pular());
               Console.WriteLine(capControl.DefenderComEscudo());
           }
           else{
               Console.WriteLine("Personagem inválido D:");
           }

           Console.ResetColor();
        }
    }
}
