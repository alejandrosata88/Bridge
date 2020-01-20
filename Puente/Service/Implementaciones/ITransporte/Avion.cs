using Puente.Entidad;
using Puente.Interfaces;

namespace Puente.Controlador
{
    class Avion : ITransporte
    {
        public Acciones Accciones { get; set; }

        public string sVehiculo { get; set; }

        public Avion(Acciones _Accciones)
        {
            this.sVehiculo = "avion\n";
            Accciones = _Accciones;
        }

        public string EntregarPaquete()
        {
            return string.Format("{0} {1}", Accciones.cAccionEntregar, sVehiculo);
        }

        public string EnviarPaquete()
        {
            return string.Format("{0} {1}", Accciones.cAccionEnviar, sVehiculo);
        }

        public string CargarPaquete()
        {
            return string.Format("{0} {1}", Accciones.cAccionRecolectar, sVehiculo);
        }
    }
}
