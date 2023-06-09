﻿namespace CriadorDeCaes.Models
{ 
    /// <summary>
    /// descrição dos criadores
    /// </summary>
    public class Criadores
    {
        public Criadores() { 
            ListaAnimais = new HashSet<Animais>();
            ListaRacas = new HashSet<Racas>(); 
        }  


        /// <summary>
        /// pk
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nome do criador
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// nome comercial do criar de ces
        /// </summary>
        public string NomeCriador { get; set; }
        /// <summary>
        /// mmorada
        /// </summary>
        public string Morada { get; set; }
        /// <summary>
        /// codPostal
        /// </summary>
        public string CodPostal { get; set; }   
        /// <summary>
        /// telemovel do criador
        /// </summary>
        public string Telemovel { get; set; }
        /// <summary>
        /// email do criador
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Lista de animais
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; } 

        public ICollection<Racas> ListaRacas {get; set; }   

    }
}
