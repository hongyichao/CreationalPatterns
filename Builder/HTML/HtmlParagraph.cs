using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.HTML
{
    public class HtmlParagraph: HtmlElement
    {
        private String text;

        public HtmlParagraph(String text)
        {
            this.text = text;
        }

        public override String ToString()
        {
            return String.Format($"<p>{text}</p>");
        }
    }
}
