using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null; // Form it's not activeted now
        private void openChildForm(Form ChildForm) // openChildForm is class - ChildForm is Form inside Main form 
        {
            if (activeForm != null) // in case that activet form is activeted(not null) Close it, because its supose to be null(be closed) when we open the main form.
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;   // Top-level statements are executed in the order they appear in the file. Top-level statements can only be used in one source file in your application. The compiler generates an error if you use them in more than one file - that's whay we put (false).
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(ChildForm); // The Panel Control is a container control to host a group of similar child controls.
            PanelMain.Tag = ChildForm; // Tag property stores an object reference - is a simple way to link a certain object to a certain control.
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void Автор_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void Книга_Click(object sender, EventArgs e)
        {
            openChildForm(new BooksForm());
        }

        private void Полка_Click(object sender, EventArgs e)
        {
            openChildForm(new ShelvesForm());
        }

        private void Расстановка_Click(object sender, EventArgs e)
        {
            openChildForm(new ArrangementfForm());
        }
    }
}
