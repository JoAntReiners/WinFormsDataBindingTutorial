namespace InventoryManager.WinForms.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PlayersTabPage = new System.Windows.Forms.TabPage();
            this.PlayerScoreTextbox = new System.Windows.Forms.TextBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.PlayerHealthTextbox = new System.Windows.Forms.TextBox();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextbox = new System.Windows.Forms.TextBox();
            this.PlayerNameLable = new System.Windows.Forms.Label();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemDeleteButton = new System.Windows.Forms.Button();
            this.ItemAddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.PlayersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.ItemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*.json)|*.json";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PlayersTabPage);
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(15, 27);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(517, 391);
            this.MainTabControl.TabIndex = 3;
            // 
            // PlayersTabPage
            // 
            this.PlayersTabPage.Controls.Add(this.PlayerScoreTextbox);
            this.PlayersTabPage.Controls.Add(this.PlayerScoreLabel);
            this.PlayersTabPage.Controls.Add(this.PlayerHealthTextbox);
            this.PlayersTabPage.Controls.Add(this.PlayerHealthLabel);
            this.PlayersTabPage.Controls.Add(this.PlayerNameTextbox);
            this.PlayersTabPage.Controls.Add(this.PlayerNameLable);
            this.PlayersTabPage.Controls.Add(this.DeletePlayerButton);
            this.PlayersTabPage.Controls.Add(this.AddPlayerButton);
            this.PlayersTabPage.Controls.Add(this.PlayersListBox);
            this.PlayersTabPage.Location = new System.Drawing.Point(4, 22);
            this.PlayersTabPage.Name = "PlayersTabPage";
            this.PlayersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTabPage.Size = new System.Drawing.Size(509, 365);
            this.PlayersTabPage.TabIndex = 0;
            this.PlayersTabPage.Text = "Players";
            this.PlayersTabPage.UseVisualStyleBackColor = true;
            // 
            // PlayerScoreTextbox
            // 
            this.PlayerScoreTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Score", true));
            this.PlayerScoreTextbox.Location = new System.Drawing.Point(188, 99);
            this.PlayerScoreTextbox.Name = "PlayerScoreTextbox";
            this.PlayerScoreTextbox.Size = new System.Drawing.Size(78, 20);
            this.PlayerScoreTextbox.TabIndex = 8;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(188, 83);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.PlayerScoreLabel.TabIndex = 7;
            this.PlayerScoreLabel.Text = "Score";
            // 
            // PlayerHealthTextbox
            // 
            this.PlayerHealthTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Health", true));
            this.PlayerHealthTextbox.Location = new System.Drawing.Point(188, 60);
            this.PlayerHealthTextbox.Name = "PlayerHealthTextbox";
            this.PlayerHealthTextbox.Size = new System.Drawing.Size(78, 20);
            this.PlayerHealthTextbox.TabIndex = 6;
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Location = new System.Drawing.Point(188, 44);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(38, 13);
            this.PlayerHealthLabel.TabIndex = 5;
            this.PlayerHealthLabel.Text = "Health";
            // 
            // PlayerNameTextbox
            // 
            this.PlayerNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true));
            this.PlayerNameTextbox.Location = new System.Drawing.Point(188, 19);
            this.PlayerNameTextbox.Name = "PlayerNameTextbox";
            this.PlayerNameTextbox.Size = new System.Drawing.Size(168, 20);
            this.PlayerNameTextbox.TabIndex = 4;
            // 
            // PlayerNameLable
            // 
            this.PlayerNameLable.AutoSize = true;
            this.PlayerNameLable.Location = new System.Drawing.Point(188, 3);
            this.PlayerNameLable.Name = "PlayerNameLable";
            this.PlayerNameLable.Size = new System.Drawing.Size(35, 13);
            this.PlayerNameLable.TabIndex = 3;
            this.PlayerNameLable.Text = "Name";
            // 
            // DeletePlayerButton
            // 
            this.DeletePlayerButton.Location = new System.Drawing.Point(81, 332);
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePlayerButton.TabIndex = 2;
            this.DeletePlayerButton.Text = "&Delete";
            this.DeletePlayerButton.UseVisualStyleBackColor = true;
            this.DeletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(0, 332);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 1;
            this.AddPlayerButton.Text = "&Add...";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.DataSource = this.playersBindingSource;
            this.PlayersListBox.DisplayMember = "Name";
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.Location = new System.Drawing.Point(0, 0);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(182, 329);
            this.PlayersListBox.TabIndex = 0;
            this.PlayersListBox.ValueMember = "Health";
            this.PlayersListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemDeleteButton);
            this.ItemsTabPage.Controls.Add(this.ItemAddButton);
            this.ItemsTabPage.Controls.Add(this.ItemsListBox);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(509, 361);
            this.ItemsTabPage.TabIndex = 1;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemDeleteButton
            // 
            this.ItemDeleteButton.Location = new System.Drawing.Point(85, 328);
            this.ItemDeleteButton.Name = "ItemDeleteButton";
            this.ItemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ItemDeleteButton.TabIndex = 4;
            this.ItemDeleteButton.Text = "&Delete";
            this.ItemDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ItemAddButton
            // 
            this.ItemAddButton.Location = new System.Drawing.Point(4, 328);
            this.ItemAddButton.Name = "ItemAddButton";
            this.ItemAddButton.Size = new System.Drawing.Size(75, 23);
            this.ItemAddButton.TabIndex = 3;
            this.ItemAddButton.Text = "&Add...";
            this.ItemAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.DataSource = this.itemsBindingSource;
            this.ItemsListBox.DisplayMember = "Name";
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 6);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(120, 316);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.ValueMember = "Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(535, 24);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 420);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.PlayersTabPage.ResumeLayout(false);
            this.PlayersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ItemsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PlayersTabPage;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.Button DeletePlayerButton;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Button ItemDeleteButton;
        private System.Windows.Forms.Button ItemAddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TextBox PlayerScoreTextbox;
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.TextBox PlayerHealthTextbox;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.TextBox PlayerNameTextbox;
        private System.Windows.Forms.Label PlayerNameLable;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
    }
}

