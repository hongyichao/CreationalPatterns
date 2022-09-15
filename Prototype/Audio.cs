using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Audio : IComponent
    {
        private String content;

        public Audio(string content)
        {
            this.content = content;
        }

        public IComponent Duplicate()
        {
            return new Audio(content);
        }

        public string GetContent()
        {
            return content;
        }
    }
}
