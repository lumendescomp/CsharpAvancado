using System;
using System.Collections.Generic;
using System.Text;

namespace Covariancia_e_Contravariancia
{
    interface IArmazenador<in T>
    {
        void Armazenar(T item);
    }
}
