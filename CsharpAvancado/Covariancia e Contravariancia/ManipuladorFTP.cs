﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Covariancia_e_Contravariancia
{
    public class ManipuladorFTP<T> : IArmazenador<T>, IRecuperador<T>
    {
        private List<T> _lista = new List<T>();
        public void Armazenar(T item) 
        {
            _lista.Add(item);
        }

        public T Recuperar(int codigo)
        {
            return _lista[codigo];
        }
    }
}
