using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SemaforoEquipo5
{
    class PuertoParalelo
    {
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int address, int value);
    }
}
