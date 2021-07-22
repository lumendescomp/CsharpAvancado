using System;
using System.Collections.Generic;
using System.Text;

namespace Covariancia_e_Contravariancia
{
    interface IRecuperador<out T>
    {
        T Recuperar(int codigo);
    }
}
