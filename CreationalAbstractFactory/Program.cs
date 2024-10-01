// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
UI Elements for Windows and MacOS - buttons and checkboxes
*/

using Factories;
using ApplicationNamespace;

class Program
{
    static void Main(string[] args)
    {
        //factory for Windows UI components
        UIFactory windowsFactory = new WindowsFactory();
        Application app = new Application(windowsFactory);
        app.Render();

        Console.WriteLine();

        //factory for MacOS UI components
        UIFactory macFactory = new MacOSFactory();
        app = new Application(macFactory);
        app.Render();
    }
}





