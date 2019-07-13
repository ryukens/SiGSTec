using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPantalla.Clases
{
    public class Producto
    {
        String codigo;
        String descripcion;
        int cantidad;
        float precio;

        public Producto(String codigo, String descripcion, int cantidad, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public float getPrecio()
        {
            return precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
    }
}
