using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenAcademy
{
     class Desafio1
     {
        private int naturais, unidade, dezena, centena;    
        public Desafio1(int naturais, int unidade, int dezena, int centena)
        {
            this.naturais = naturais;           
            this.unidade = unidade;
            this.dezena = dezena;
            this.centena = centena;
            
        }
        public void SetNaturais(int naturais)
        {
            this.naturais = naturais;
        }
        public int GetNaturais()
        {
            return this.naturais;
        }       
        public void SetUnidade(int unidade)
        {
            this.unidade = unidade;
        }
        public int GetUnidade()
        {
            return this.unidade;
        }
        public void SetDezena(int dezena)
        {
            this.dezena = dezena;
        }
        public int GetDezena()
        {
            return this.dezena;
        }
        public void SetCentena(int centena)
        {
            this.centena = centena;
        }
        public int GetCentena()
        {
            return centena;
        }
       
     }
}
