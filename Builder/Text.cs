using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Text: IElement
    {
        private String content;

        public Text(String content)
        {
            this.content = content;
        }

        public String getContent()
        {
            return content;
        }
    }
}
