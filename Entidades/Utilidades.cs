using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entidades
{
    internal class Utilidades
    {
        public static bool Validacion(string texto)
        // FUNCIO N PARA validar campos en blanco
        {
            if (texto == "")
           {
               return false;
           }
            return true;
        }
    }

  
    }
