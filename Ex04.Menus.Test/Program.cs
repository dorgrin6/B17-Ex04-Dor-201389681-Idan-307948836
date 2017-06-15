using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{ 
    public class Program
    {
        public static void Main()
        {
            TestInterface MainMenuInterface = new TestInterface();
            MainMenuInterface.Run();

            //same here with TestDelegetes
        }

    }
}
