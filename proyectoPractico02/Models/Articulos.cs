namespace proyectoPractico02.Models
{
    public class Articulos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int PrecioUnitario { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, PrecioUnitario: {PrecioUnitario}";
        }
    }
}
