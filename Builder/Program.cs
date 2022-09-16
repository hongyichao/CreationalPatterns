using Builder;
using Builder.HTML;

var document = new Document();
document.Add(new Text("Hello World"));
document.Add(new Image("pic1.jpg"));

document.Export(new HtmlDocumentBuilder(), "export.html");

// Only writes the text elements to the file
document.Export(new TextDocumentBuilder(), "export.txt");