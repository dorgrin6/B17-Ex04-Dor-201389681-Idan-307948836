namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private MenuItem m_ParentMenuItem;

        private string m_Title;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        public MenuItem ParentMenuItem
        {
            get
            {
                return m_ParentMenuItem;
            }
            set
            {
                m_ParentMenuItem = value;
            }
        }

        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
    }
}
