using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.WinForms.Forms
{
    public partial class AddItemForm : Form
    {
        public string ItemName
        {
            get => NameTextbox.Text;
            set => NameTextbox.Text = value;
        }

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = !string.IsNullOrEmpty(ItemName);
        }
    }
}
