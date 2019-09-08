namespace SiteLibrary
{
    public class Invitation
    {
        public string Text { get; }
        public string Style { get; }

        public Invitation(string text, string style)
        {
            Text = text;
            Style = style;
        }
    }
}