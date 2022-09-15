// See https://aka.ms/new-console-template for more information

using Prototype;

var timeline = new Timeline();

var text = new Text("Hello World!");
timeline.add(text);

var clip = new Clip("some image");
timeline.add(clip);

var audio = new Audio("some audio");
timeline.add(audio);

var context = new ContextMenu(timeline);

context.Play();

var newText = text.Duplicate();

context.duplicate(newText);

context.Play();







