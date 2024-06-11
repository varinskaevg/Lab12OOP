using System.Reflection.Metadata;
using Word = Microsoft.Office.Interop.Word;

namespace Lab12OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }

        private Word.Application wordApp;
        private Word.Document doc;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (doc != null)
            {
                doc.Close(false);
                doc = null;
            }
            if (wordApp != null)
            {
                wordApp.Quit();
                wordApp = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string data = txtData.Text;
            string street = txtStreet.Text;
            string time = txtTime.Text;

            string templatePath = @"E:\dr.docx";

            UpdateDocument(templatePath, name, data, street, time);
        }

        private void UpdateDocument(string templatePath, string name, string data, string street, string time)
        {
            wordApp = new Word.Application();
            doc = null;

            try
            {
                doc = wordApp.Documents.Open(templatePath);

                ReplaceText("{Name}", name, doc);
                ReplaceText("{Data}", data, doc);
                ReplaceText("{Street}", street, doc);
                ReplaceText("{Time}", time, doc);

                doc.Save();
                MessageBox.Show("Запрошення успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час оновлення запрошення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(false);
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                }
            }
        }

        private void ReplaceText(string placeholder, string newValue, Word.Document doc)
        {
            foreach (Word.Range range in doc.StoryRanges)
            {
                Word.Find find = range.Find;
                find.Text = placeholder;
                find.Replacement.Text = newValue;
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);
            }
        }
    }
}
