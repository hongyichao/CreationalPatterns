using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Text: IComponent
    {
        private String content;

        public Text(String content)
        {
            this.content = content;
        }

        public IComponent Duplicate()
        {   
            Text newText = new Text(content);
            return newText;
        }

        public String GetContent()
        {
            return content;
        }
    }
}
