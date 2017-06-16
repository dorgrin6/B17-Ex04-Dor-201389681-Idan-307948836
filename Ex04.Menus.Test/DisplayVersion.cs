using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DisplayVersion : IAction
    {
        private const string k_Version = "App Version: 17.2.4.0";

        public void DoAction()
        {
            Console.WriteLine(k_Version);
        }
    }
}