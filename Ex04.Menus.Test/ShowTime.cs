using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IAction
    {
        public void DoAction()
        {
            DateTime time = DateTime.Now;

            Console.WriteLine("The time now is: {0}:{1}:{2}", time.Hour, time.Minute, time.Second);
        }
    }
}