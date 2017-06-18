using System;
using System.Security.Principal;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Hello {WindowsIdentity.GetCurrent().Name}!");
        }
    }
}
