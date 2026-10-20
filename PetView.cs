using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace Tugas_pak_okta_lagi.Views
{
    public partial class PetView : Form, IPetView
    {
        private bool isEdit;
        private string message;
        private bool isSuccessful;  

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetId  { get { return txtPetId.Text; } set { txtPetId.Text = value; } } 
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetName { get { return txtPetName.Text; } set { txtPetName.Text = value; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetType { get { return txtPetType.Text; } set { txtPetType.Text = value; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetColour { get {return txtPetColour.Text; } set { txtPetColour.Text = value; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SearchValue { get { return txtSearch.Text; } set { txtSearch.Text = value; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsEdit { get { return isEdit; } set { isEdit = value;  } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSuccessful { get { return isSuccessful; } set { isSuccessful = value; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Message { get { return message; } set { message = value; } }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        public void show()
        {
            throw new NotImplementedException();
        }

        private void PetView_Load(object sender, EventArgs e)
        {

        }
    }
}
