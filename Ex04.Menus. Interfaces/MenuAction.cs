namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class MenuAction : MenuItem
    {
        private readonly List<IActionObserver> m_ActionObservers = new List<IActionObserver>();

        private readonly IAction r_Action;

        /*
        public MenuAction(string i_Title) : base(i_Title)
        {
        }*/

        public MenuAction(IAction i_Action, string i_Title)
            : base(i_Title)
        {
            r_Action = i_Action;
        }

        public void AttachObserver(IActionObserver i_ActionObserver)
        {
            m_ActionObservers.Add(i_ActionObserver);
        }

        public void DetachObserver(IActionObserver i_ActionObserver)
        {
            m_ActionObservers.Remove(i_ActionObserver);
        }

        public override void Show()
        {
            r_Action.DoAction();
        }

        private void notifyActionObservers()
        {
            foreach (IActionObserver observer in m_ActionObservers)
            {
                observer.ReportExecutingAction(this.r_Action);
                //observer.ReportExecutingAction(Title);
            }
        }
    }
}