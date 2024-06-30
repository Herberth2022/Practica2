using Practica2.BaseDatos;
using Practica2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica2.Models
{
    public class VehiculoModel
    {
        public bool RegistroVehiculo(Vehiculo vehiculo)
        {

            var rowsAffected = 0;

            var tabla = new Vehiculos();
            tabla.IdVehiculo = vehiculo.IdVehiculo;
            tabla.Marca = vehiculo.Marca;
            tabla.Modelo = vehiculo.Modelo;
            tabla.Color = vehiculo.Color;
            tabla.Precio = vehiculo.Precio;
            tabla.IdVendedor = vehiculo.IdVendedor;

            using (var context = new Practica2Entities1())
            {
                context.Vehiculos.Add(tabla);
                context.SaveChanges();
            }
            using (var context = new Practica2Entities1())

            return (rowsAffected > 0 ? true : false);
        }
    }

}
