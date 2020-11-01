using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Test.DB
{
    class WrongFormat
    {
        private TextBox textBox;

        public WrongFormat(TextBox textBox)
        {
            this.textBox = textBox;
        }
        public bool TooALong(int MaxTextLength)
        {
            if (textBox.Text.Length > MaxTextLength) { return false; } else { return true; }
        }
        public bool NotNull()
        {
            if (textBox.Text.Length == 0) { return false; } else { return true; }
        }

    }
}
