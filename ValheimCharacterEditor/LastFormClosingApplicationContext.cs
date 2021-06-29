using System;
using System.Windows.Forms;

namespace ValheimCharacterEditor
{
    public class LastFormClosingApplicationContext : ApplicationContext
    {
        public LastFormClosingApplicationContext(Form mainForm) : base(mainForm) { }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form currentForm = Application.OpenForms[i];

                if (ReferenceEquals(currentForm, MainForm)) continue;

                MainForm = currentForm;
                return;
            }

            base.OnMainFormClosed(sender, e);
        }
    }
}
