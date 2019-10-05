using System;

namespace ving_certo.Models
{
    public class BaseModel
    {
        public double Vida { get; set; } = 100;
        public string Equipe { get; set; }
        public ConsoleColor Cor { get; set; }
    }
}