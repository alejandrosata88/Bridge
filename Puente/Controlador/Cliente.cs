using Puente.Entidad;
using Puente.Interfaces;
using System;

namespace Puente.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cTexto = string.Empty;
            Acciones acciones = new Acciones()
            {
                cAccionRecolectar = "recolecto el paquete por",
                cAccionEnviar = "envio el paquete por",
                cAccionEntregar = "entrego el paquete por",
            };
            ITransporte ITransporte = new Barco(acciones);
            IEmpresa IEmpresa = new Fedex(ITransporte);
            cTexto =IEmpresa.RecogerPedido();
            cTexto += IEmpresa.EnviarPedido();
            cTexto += IEmpresa.EntregarPedido();
            Console.Write(cTexto);

            ITransporte = new Avion(acciones);
            IEmpresa = new DHL(ITransporte);
            cTexto = IEmpresa.RecogerPedido();
            cTexto += IEmpresa.EnviarPedido();
            cTexto += IEmpresa.EntregarPedido();
            Console.Write(cTexto);

            ITransporte = new Barco(acciones);
            IEmpresa = new DHL(ITransporte);
            cTexto = IEmpresa.RecogerPedido();
            cTexto += IEmpresa.EnviarPedido();
            cTexto += IEmpresa.EntregarPedido();
            Console.Write(cTexto);

            ITransporte = new Tren(acciones);
            IEmpresa = new ESTAFETA(ITransporte);
            cTexto = IEmpresa.RecogerPedido();
            cTexto += IEmpresa.EnviarPedido();
            cTexto += IEmpresa.EntregarPedido();
            Console.Write(cTexto);

            Console.ReadLine();

        }
    }
}
