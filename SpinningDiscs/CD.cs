using System;
namespace SpinningDiscs
{
    public class CD : DiscStorage, ISpin
    {
        public CD(string name, int capacity, string content, string type) : base(name, capacity, content, type)
        {
            Name = name;
            Capacity = capacity;
            Content = content;
            Type = type;
        }

        public void SpinDisk()
        {
            Console.WriteLine("Disk is spinning!");
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

    }
}
