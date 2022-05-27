using System;

namespace TP3
{
    public class Personal
    {
        protected int id;
        protected string nombre;
        protected int legajo;
        protected string password;

        protected int Id { get => id; set => id = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected int Legajo { get => legajo; set => legajo = value; }
        protected string Password { get => password; set => password = value; }

        public Personal(int id, string nombre, int legajo,string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.legajo = legajo;
            this.Password = password;
        }


    }
}
