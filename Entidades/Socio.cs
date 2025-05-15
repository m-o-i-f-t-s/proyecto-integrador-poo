using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entidades
{
    internal class Socio: NoSocio
    {
        public DateTime vencimintoCuota { get; set; }
        public bool carnet { get; set; }
    }
}
