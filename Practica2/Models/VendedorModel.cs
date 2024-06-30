using Microsoft.Ajax.Utilities;
using Practica2.BaseDatos;
using Practica2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Practica2.Models
{
    public class VendedorModel
    {
        public bool RegistroVendedor(Vendedor vendedor)
        {

            var rowsAffected = 0;

            var tabla = new Vendedores();
            tabla.IdVendedor = vendedor.IdVendedor;
            tabla.Cedula = vendedor.Cedula;
            tabla.Nombre = vendedor.Nombre;
            tabla.Correo = vendedor.Correo;
            tabla.Estado = true;

            using (var context = new Practica2Entities1())
            {
                context.Vendedores.Add(tabla);
                context.SaveChanges();
            }
            using (var context = new Practica2Entities1())

                return (rowsAffected > 0 ? true : false);
        }
    }
}