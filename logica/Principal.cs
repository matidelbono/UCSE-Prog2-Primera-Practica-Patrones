namespace logica
{
    public class Principal
    {
        List<Persona>personas=new List<Persona>();
        List<Cobertura> coberturas=new List<Cobertura>();
        public Persona BuscarPersonaPorDNI(int DNI)
	{
            foreach (var item in personas)
            {
                if (item.DNI==DNI)
                    return item;
            }
            return null;
	}
        public bool PuedeAcceder(Cobertura cobertura, int DNI)
        {
            Persona PersonaEncontrada = BuscarPersonaPorDNI(DNI);
                if (cobertura.CostoBase<=PersonaEncontrada.IngresosNetos)
                return true;
                return false;
        }
        
        
        public decimal RegistrarAtencion(int DNI, string tipo, Cobertura cobertura )
        {
            int Autoincr = 0;
            bool Valido = cobertura.EsValidoParaAtenciones();
            if (Valido==true)
            {
                Autoincr += 1;
                DateTime fechaAtencion = DateTime.today;
                Enfermedad enfermedadAtendida = new Enfermedad();
                Persona personaAtendida = new Persona();
                decimal precio = enfermedadAtendida.Costo;
                string TipoAtendido = enfermedadAtendida.Tipo;
                string NombreAtendido = enfermedadAtendida.Nombre;
                return precio;

            }
            return 0;
        }

        public sealed class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance=new Singleton();

                }
                return instance;
            }

        }
    }
}
}
