using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTestuale
{
    public class ScrollEventArgs : EventArgs
    {
        public ScrollEventArgs(IntPtr s)
        {
            MyTextBoxHandle = s;
        }
        private IntPtr MyTextBoxHandle;

        public IntPtr myTextBoxHandle
        {
            get { return MyTextBoxHandle; }
            set { MyTextBoxHandle = value; }
        }
    }
}
