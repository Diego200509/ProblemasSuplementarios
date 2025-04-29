using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Protection
{
    // POO: Definición de interfaz (abstracción)
    public interface ICheckFormatter
    {
        string FormatAmount(decimal amount);
    }
    }