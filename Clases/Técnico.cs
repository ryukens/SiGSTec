using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPantalla.Clases
{
    public class Tecnico
    {
        String nombre;
        String correo;
        String identificacion;
        String sector;
        String alcance;
        String estado;

        public Tecnico(String nombre, String correo, String identificacion, String sector, String alcance, String estado)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.identificacion = identificacion;
            this.sector = sector;
            this.alcance = alcance;
            this.estado = estado;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getCorreo()
        {
            return correo;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        public String getIdentificacion()
        {
            return identificacion;
        }

        public void setIdentificacion(String identificacion)
        {
            this.identificacion = identificacion;
        }

        public String getSector()
        {
            return sector;
        }

        public void setSector(String sector)
        {
            this.sector = sector;
        }

        public String getAlcance()
        {
            return alcance;
        }

        public void setAlcance(String alcance)
        {
            this.alcance = alcance;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }
    }
}
