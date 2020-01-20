using Puente.Interfaces;

namespace Puente.Controlador
{
    class ESTAFETA : IEmpresa
    {
        string cEmpresa;
        protected ITransporte ITransporte;

        public ESTAFETA(ITransporte _ITransporte)
        {
            cEmpresa = "ESTAFETA";
            this.ITransporte = _ITransporte;
        }

        public string RecogerPedido()
        {
            return string.Format("{0} {1}", cEmpresa, ITransporte.CargarPaquete());
        }

        public string EnviarPedido()
        {
            return string.Format("{0} {1}", cEmpresa, ITransporte.EnviarPaquete());
        }

        public string EntregarPedido()
        {
            return string.Format("{0} {1}", cEmpresa, ITransporte.EntregarPaquete());
        }
    }
}
