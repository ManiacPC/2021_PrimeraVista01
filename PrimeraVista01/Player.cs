using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVista01
{
    class Player
    {
        // UN COMENTARIO NUEVO, HICE UN CAMBIO EN EL CÓDIGO

        // atributos
        private string nickname;
        private int hp = 100; // health points = puntos de vida
        private int mp = 50; // mana points = 50 por default
        // EVENTO AÑO CHINO: SE REGALA DOBLE MP

        // propiedades
        public string Nickname { get => nickname; set => nickname = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Mp { 
            get => mp; 
            set {
                mp = value * 2; 
            }
        }

        // constructor
        public Player(string nombre)
        {
            this.nickname = nombre;
            Console.WriteLine(nombre);
            Mp = 50;
            Console.WriteLine("Magia:" + mp);
        }

        // métodos
        public bool atacar()
        {
            Random random = new Random();
            int failChance = random.Next(0,1);

            /*if(failChance == 0)
            {
                return true;
            } else
            {
                return false;
            }*/

            bool resultado = (failChance == 0 ? true : false); // operador ternario

            return resultado; 
        }        
    }
}
