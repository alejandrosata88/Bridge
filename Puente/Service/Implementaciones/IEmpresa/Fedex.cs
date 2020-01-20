
using Puente.Interfaces;

namespace Puente.Controlador
{
    class Fedex : IEmpresa
    {
        string cEmpresa;
        protected ITransporte ITransporte;

        public Fedex(ITransporte _ITransporte)
        {
            cEmpresa = "FEDEX";
            this.ITransporte = _ITransporte;
        }

        public string EntregarPedido()
        {
            return string.Format("{0} {1}", cEmpresa, ITransporte.EntregarPaquete());
        }

        public string EnviarPedido()
        {
            return string.Format("{0} {1}", cEmpresa, ITransporte.EnviarPaquete());
        }

        public string RecogerPedido()
        {
            return string.Format("{0} {1}", cEmpresa, ITransporte.CargarPaquete());
        }
    }
}
