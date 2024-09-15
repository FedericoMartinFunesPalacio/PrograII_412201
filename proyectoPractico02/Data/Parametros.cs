namespace proyectoPractico02.Data
{
    public class Parametros
    {
        //ATRIBUTOS Y PROPIEDADES
        public string Parametro { get; set; }
        public object Objeto { get; set; }
        //CONSTRUCTOR
        public Parametros(string parametro, object objeto)
        {
            Parametro = parametro;
            Objeto = objeto;
        }
    }
}
