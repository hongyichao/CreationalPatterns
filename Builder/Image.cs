using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Image: IElement
    {
        private String source;

        public Image(String source)
        {
            this.source = source;
        }

        public String getSource()
        {
            return source;
        }
    }
}
