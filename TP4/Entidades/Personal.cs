using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Entidades
{
    [XmlInclude(typeof(Medico))]
    [XmlInclude(typeof(Operador))]
    public abstract class Personal:iDarBajaTurno
    {
        protected int id;
        protected string nombre;
        protected string password;

      

        public Personal() { }
        public Personal(int id, string nombre, string password):this()
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
            
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }

        public bool DarBajaTurno(int nroTurno)
        {
            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if (nroTurno+item)
                { 
                    ManejadorDeDatos.TurnosList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        



       

    }
}
