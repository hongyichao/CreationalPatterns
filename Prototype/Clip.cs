using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Clip : IComponent
    {
        private String content;

        public Clip(string content) 
        { 
            this.content = content;
        }

        public IComponent Duplicate()
        {
            return new Clip(content);
        }

        public String GetContent()
        {
            return content;
        }
    }
}
