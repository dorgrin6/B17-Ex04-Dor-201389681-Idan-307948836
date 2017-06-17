namespace Ex04.Menus.Test
{
    using System;
    using Ex04.Menus.Interfaces;

    public class DisplayVersion : IAction
    {
        private const string k_Version = "App Version: 17.2.4.0";

        public void DoAction()
        {
            Console.WriteLine(k_Version);
        }
    }
}