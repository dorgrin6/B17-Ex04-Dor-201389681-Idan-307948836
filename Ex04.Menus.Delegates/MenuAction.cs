using System;

namespace Ex04.Menus.Delegates
{
    public delegate void ActionNotifier();

    public class MenuAction : MenuItem
    {
        public event ActionNotifier ActionDone;

        public MenuAction(string i_Title)
            : base(i_Title)
        {
        }

        public override void Show()
        {
            this.onActionDone();
        }

        protected virtual void onActionDone()
        {
            if (ActionDone != null)
            {
                ActionDone.Invoke();
            }
        }
    }
}
