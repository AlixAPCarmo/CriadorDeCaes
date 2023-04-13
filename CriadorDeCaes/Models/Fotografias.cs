using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorDeCaes.Models
{
    public class Fotografias
    {

        /// <summary>
        /// pk
        /// </summary>
        public int Id { get; set; } 

        /// <summary>
        /// nome da fotografia
        /// </summary>
        public string NomeFicheiro { get; set; }
        /// <summary>
        /// data em qu e afotografia foi tirada
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set; }

        //******************************************************************
        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; }
        
        public Animais Animal { get; set; }
    }
}
