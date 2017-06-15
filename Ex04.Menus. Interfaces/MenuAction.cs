using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuAction :  MenuItem
    {
        private readonly List<IActionObserver> m_ActionObservers = new List<IActionObserver>();

        public MenuAction(string i_Title) : base(i_Title)
        {
        }

        public void AttachObserver(IActionObserver i_ActionObserver)
        {
            m_ActionObservers.Add(i_ActionObserver);
        }

        public void DetachObserver(IActionObserver i_ActionObserver)
        {
            m_ActionObservers.Remove(i_ActionObserver);
        }

        private void notifyActionObservers()
        {
            foreach (IActionObserver observer in m_ActionObservers)
            {
                observer.ReportExecutingAction(Title);
            }
        }
    }
}
