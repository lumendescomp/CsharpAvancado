using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEventos
{
    class GerenciadorLatidos
    {
        private int latido;
        public delegate void ExcDecibeis(object sender, CustomEvent e);
        public event ExcDecibeis ExcDecibeisEvent;
 
        public GerenciadorLatidos()
        {
            latido = 0;
        }
        
        public int Latir()
        {
            latido += 10;
            if (latido > 80)
            {
                CustomEvent custom = new CustomEvent
                {
                    IntensidadeLatido = latido
                };
                OnExcDecibeis(custom);
            }
            return latido;
        }

        protected virtual void OnExcDecibeis(CustomEvent e)
        {
            if (ExcDecibeisEvent != null)
            {
                ExcDecibeisEvent(this, e);
            }
        }
    }
}
