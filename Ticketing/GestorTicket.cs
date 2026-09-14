using System;

namespace SoporteTicket.Logica { 
    public class GestorTicket
    {
        public List<Ticket> lstTecnicos { get; set; }
        public List<Solicitante> lstSolicitantes { get; set; }
        public List<Ticket> lstTickets { get; set; }
        public GestorTicket()
        {
            lstSolicitantes = new List<Solicitante>();
            lstTecnicos = new List<Tecnico>();
            lstTickets = new List<Ticket>();
        }
        public Ticket CrearTicket(int intNumero, string Asunto, string Descripcion, string strCategoria, string strPrioridad, Solicitante objSolicitante)
        {

        //Validaciones

            Ticket objTicket = new Ticket(intNumero, Asunto, Descripcion, strCategoria, strPrioridad, objSolicitante);
            objTicket.asignarTecnico(objTecnico);
            lstTickets.add(objTicket);
            retur objticket;
        }
        public Ticket BuscarTicket(int intTicket)
        {
        Ticket objTicket;
        lstTickets.Find
            (testc => t.intNumero == intTicket);
            if (objTicket == null)
            {
            Console.WriteLine("Ticket NO existe");
                return objTicket;
            }
        }
    } 
}
    