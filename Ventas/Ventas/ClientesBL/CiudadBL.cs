﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.ModelosP;

namespace Ventas.ClientesBL
{
    public class CiudadBL
    {
        public List<Ciudad> ListadeCiudades { get; set; }

        public CiudadBL()
        {
            ListadeCiudades = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Villanueva");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");

            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
        }

    }
}
