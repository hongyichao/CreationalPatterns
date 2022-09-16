using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.HTML
{
    public class HtmlImage : HtmlElement
    {
    private String source;

    public HtmlImage(String source)
    {
        this.source = source;
    }

    
    public override String ToString()
    {
        return String.Format($"<img src=\"{source}\" />");
    }
}
}
