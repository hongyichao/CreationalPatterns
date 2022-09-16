using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Builder.HTML
{
    public class HtmlDocumentBuilder : IDocumentBuilder
    {
        public string BuildDocument(List<IElement> elements)
        {
            var document = new HtmlDocument();

            foreach (IElement element in elements)
            {
                if (element is Text)
                {
                    var text = ((Text)element).getContent();
                    document.add(new HtmlParagraph(text));
                }
                else if (element is Image)
                {
                    var source = ((Image)element).getSource();
                    document.add(new HtmlImage(source));
                }
            }

            return document.ToString();
        }
    }
}
