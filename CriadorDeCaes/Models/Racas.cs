namespace CriadorDeCaes.Models
{
    public class Racas
    {

        public Racas(){
            ListaAnimais = new HashSet<Animais>();
            ListaCriadores = new HashSet<Criadores>();
            }

        /// <summary>
        /// pk
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Designação da Raça
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Lista dos animais que são de uma raça 
        /// </summary>
        public ICollection<Animais> ListaAnimais { get;}

        public ICollection<Criadores> ListaCriadores{ get; }



    }
}
