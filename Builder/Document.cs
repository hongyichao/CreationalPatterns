using Builder;
using Builder.HTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Builder
{
    //the document knows how to construct the document
    public class Document
    {
        private List<IElement> elements = new List<IElement>();

        public void Add(IElement element)
        {
            elements.Add(element);
        }

        //constructing the document
        public void Export(IDocumentBuilder documentBuilder, string fileName)
        {            
            //get the presentation of the document
            string content = documentBuilder.BuildDocument(elements);

            //process the presentation of the document
            Console.WriteLine($"file content: {content}");
        }
    }
}
