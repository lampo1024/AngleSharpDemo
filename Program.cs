using AngleSharp.Parser.Html;
using System;

namespace AngleSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a (re-usable) parser front-end
            var parser = new HtmlParser();
            //Source to be pared
            var source = "<h1>Some example source</h1><p>This is a paragraph element <img src=\"http://google.com\"></p>";
            //Parse source to document
            var document = parser.Parse(source);
            //Do something with document like the following

            var elements = document.QuerySelectorAll("img");
            foreach (var element in elements)
            {
                var src = element.Attributes["src"].Value;
                element.SetAttribute("src", "loading.gif");
                element.SetAttribute("data-src", src);
            }

            Console.WriteLine(document.Body.InnerHtml);


            Console.ReadKey();
        }
    }
}
