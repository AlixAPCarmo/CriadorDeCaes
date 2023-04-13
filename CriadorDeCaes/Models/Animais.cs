﻿namespace CriadorDeCaes.Models
{/// <summary>
/// descrição dos animais
/// </summary>
    public class Animais
    {

        public Animais() { 
            ListaFotografias = new HashSet<Fotografias>();
        }    
        /// <summary>
        /// pk
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// nome do cao/cadela
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// data e nascimento
        /// </summary>
        public DateTime DataNascimento { get; set;}

        /// <summary>
        /// data em q foi adquirido
        /// </summary>
        public DateTime DataCompra { get; set;}
        
        /// <summary>
        /// sexo do animal
        /// F-Femea
        /// M-Macho
        /// </summary>
        public string Sexo  { get; set;}

        /// <summary>
        /// Numero de registo no LOP
        /// </summary>
        public string NumLOP { get; set;}  

        //***********************************************
        public ICollection<Fotografias> ListaFotografias { get; set;}
    }
}
