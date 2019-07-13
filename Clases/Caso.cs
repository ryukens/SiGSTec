using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPantalla.Clases
{
    public class Caso
    {
        String numero;
        String date;
        String sla;
        String informe_Inicial;
        String sector;
        String estado;
        String parte_Path;
        String informe_Final;

        public Caso(String numero, String date, String sla, String informe_Inicial, String sector, String estado, String parte_Path, String informe_Final)
        {
            this.numero = numero;
            this.date = date;
            this.sla = sla;
            this.informe_Inicial = informe_Inicial;
            this.sector = sector;
            this.estado = estado;
            this.parte_Path = parte_Path;
            this.informe_Final = informe_Final;
        }

        public String getNumero()
        {
            return numero;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public String getDate()
        {
            return date;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getSla()
        {
            return sla;
        }

        public void setSla(String sla)
        {
            this.sla = sla;
        }

        public String getInforme_Inicial()
        {
            return informe_Inicial;
        }

        public void setInforme_Inicial(String informe_Inicial)
        {
            this.informe_Inicial = informe_Inicial;
        }

        public String getSector()
        {
            return sector;
        }

        public void setSector(String sector)
        {
            this.sector = sector;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public String getParte_Path()
        {
            return parte_Path;
        }

        public void setParte_Path(String parte_Path)
        {
            this.parte_Path = parte_Path;
        }

        public String getInforme_Final()
        {
            return informe_Final;
        }

        public void setInforme_Final(String informe_Final)
        {
            this.informe_Final = informe_Final;
        }
    }
}
