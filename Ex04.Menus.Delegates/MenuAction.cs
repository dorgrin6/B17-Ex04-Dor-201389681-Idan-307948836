namespace Ex04.Menus.Delegates
{
    public delegate void ActionNotifier();

    public class MenuAction : MenuItem
    {
        public MenuAction(string i_Title)
            : base(i_Title)
        {
        }

        public event ActionNotifier ActionDone;

        public override void Show()
        {
            onActionDone();
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