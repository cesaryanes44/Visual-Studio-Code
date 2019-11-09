using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.ModelosP;

namespace Ventas.ClientesBL
{
   public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Villanueva");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");

            var cliente1 = new Cliente(1, "Alejandra", 8773432, ciudad1);
            var cliente2 = new Cliente(2, "Martha", 9876899, ciudad2);
            var cliente3 = new Cliente(3, "Carlos",8656432,ciudad1);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }

    }
}
