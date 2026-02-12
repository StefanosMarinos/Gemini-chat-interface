using System.Windows.Forms;

namespace telikiergasia2
{
    internal class textboxes
    {
        private TextBox textBox1;

        private RichTextBox richTextBox1;
        public textboxes(TextBox tb, RichTextBox rtb)
        {
            textBox1 = tb;      
            richTextBox1 = rtb; 
        }

        // Property για το κείμενο που γράφει ο χρήστης
        public string UserText
        {
            get { return textBox1.Text; }         
            set { textBox1.Text = value; }         
        }

        // Property που επιστρέφει όλο το κείμενο του chat
        public string ChatText
        {
            get { return richTextBox1.Text; }
        }

        // Επιστρέφει το chat χωρισμένο σε γραμμές (πίνακας string)
        public string[] ChatLines
        {
            get { return richTextBox1.Lines; }
        }

        // Προσθέτει κείμενο στο RichTextBox (στο τέλος)
        public void AppendChat(string text)
        {
            richTextBox1.AppendText(text);
        }

        // Καθαρίζει το TextBox εισαγωγής
        public void ClearInput()
        {
            textBox1.Clear();
        }

        // Καθαρίζει όλο το chat
        public void ClearChat()
        {
            richTextBox1.Clear();
        }

        // Ενεργοποιεί ή απενεργοποιεί το TextBox
        public void EnableInput(bool state)
        {
            textBox1.Enabled = state;
        }
    }
}
