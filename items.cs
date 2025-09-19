using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pan
{
    internal class items
    {
        private string nombreDelObjecto;
        private float precio;

        public items (string nombreDelObjecto, float precio)
        {
            this.nombreDelObjecto = nombreDelObjecto;
            this.precio = precio;
        }

        string nombreItem()
        {
            return nombreDelObjecto;
        }
    }
}
