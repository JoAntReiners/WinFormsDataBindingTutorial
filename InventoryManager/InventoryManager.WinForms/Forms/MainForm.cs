using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;

namespace InventoryManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                MainTabControl.Enabled = mIsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {

                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    ViewModel.Players.Add(player);
                }
            }
        }

        private void PlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeletePlayerButton.Enabled = PlayersListBox.SelectedItem != null;
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Players.Remove((Player)PlayersListBox.SelectedItem);
                PlayersListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            using(AddItemForm addItemForm = new AddItemForm())
            {
                if(addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item { Name = addItemForm.ItemName };
                    ViewModel.Items.Add(item);
                }
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDeleteButton.Enabled = ItemsListBox.SelectedItem != null;
        }

        private void ItemDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Items.Remove((Item)ItemsListBox.SelectedItem);
                ItemsListBox.SelectedItem = ViewModel.Items.FirstOrDefault();
            }
        }

        #region Main Menu

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();
        
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = SaveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        #endregion

        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;

    }
}
