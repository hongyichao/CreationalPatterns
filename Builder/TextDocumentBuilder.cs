using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TextDocumentBuilder : IDocumentBuilder
    {
        private List<IElement> _elements;
        public string BuildDocument(List<IElement> elements)
        {
            _elements = elements;

            var builder = new StringBuilder();

            foreach (IElement element in elements)
            {
                if (element is Text)
                {
                    var text = ((Text)element).getContent();
                    builder.Append(text);
                }
            }

            var content = builder.ToString();

            return content;
        }
    }
}
