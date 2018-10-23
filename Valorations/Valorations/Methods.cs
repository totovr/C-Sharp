using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    class Methods
    {
        // if I know that is not going to return nothinh
        // Just in this assambly
        internal void MethodExample(int i, string s, float f)
        {
            value = i;
        }

        // Is possible to access from other assambly
        public void MethodExample(int i, float f)
        {
            value = i;
        }

        // Just is able to access in this class
        private void MethodExample()
        {
            value = 5;
        }
        // This is the scope
        int value = 0;
    }
}
