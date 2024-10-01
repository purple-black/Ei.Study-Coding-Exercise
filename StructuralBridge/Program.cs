// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
a scenario where we have different types of remote controls (e.g., BasicRemote and AdvancedRemote)
and different types of devices (e.g., TV, Radio).
Using the Bridge pattern, we can create a flexible system where any remote can control any device
*/

using StructuralBridge.Abstractions;
using StructuralBridge.Implementations;

namespace StructuralBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            IRemote basicRemote = new BasicRemote(tv);

            basicRemote.Power();
            basicRemote.VolumeUp();
            basicRemote.VolumeDown();
            basicRemote.Power();

            IDevice radio = new Radio();
            IRemote advancedRemote = new AdvancedRemote(radio);

            advancedRemote.Power();
            advancedRemote.VolumeUp();

            if (advancedRemote is AdvancedRemote advRemote)
            {
                advRemote.Mute();
            }
            else
            {
                System.Console.WriteLine("This remote does not support mute functionality.");
            }

            advancedRemote.Power();

            System.Console.ReadLine();
        }
    }
}


