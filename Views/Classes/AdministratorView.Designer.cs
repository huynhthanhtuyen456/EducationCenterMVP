namespace EducationCenter.Views.Classes
{
    partial class AdministratorView
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
            panel1 = new Panel();
            AdminTitleLbl = new Label();
            CloseAdministratorViewBtn = new Label();
            AdminTabControl = new TabControl();
            AdminListTabPage = new TabPage();
            AdminDetailTabPage = new TabPage();
            AdminListDgv = new DataGridView();
            AddAdminBtn = new Button();
            EditAdminBtn = new Button();
            DeleteAdminBtn = new Button();
            SearchAdminTxb = new TextBox();
            SearchAdminBtn = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            AdminTabControl.SuspendLayout();
            AdminListTabPage.SuspendLayout();
            AdminDetailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminListDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseAdministratorViewBtn);
            panel1.Controls.Add(AdminTitleLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // AdminTitleLbl
            // 
            AdminTitleLbl.AutoSize = true;
            AdminTitleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminTitleLbl.Location = new Point(308, 34);
            AdminTitleLbl.Name = "AdminTitleLbl";
            AdminTitleLbl.Size = new Size(174, 32);
            AdminTitleLbl.TabIndex = 0;
            AdminTitleLbl.Text = "Administrator";
            // 
            // CloseAdministratorViewBtn
            // 
            CloseAdministratorViewBtn.AutoSize = true;
            CloseAdministratorViewBtn.Cursor = Cursors.Hand;
            CloseAdministratorViewBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseAdministratorViewBtn.Location = new Point(761, 9);
            CloseAdministratorViewBtn.Name = "CloseAdministratorViewBtn";
            CloseAdministratorViewBtn.Size = new Size(27, 30);
            CloseAdministratorViewBtn.TabIndex = 1;
            CloseAdministratorViewBtn.Text = "X";
            // 
            // AdminTabControl
            // 
            AdminTabControl.Controls.Add(AdminListTabPage);
            AdminTabControl.Controls.Add(AdminDetailTabPage);
            AdminTabControl.Dock = DockStyle.Fill;
            AdminTabControl.Location = new Point(0, 100);
            AdminTabControl.Name = "AdminTabControl";
            AdminTabControl.SelectedIndex = 0;
            AdminTabControl.Size = new Size(800, 350);
            AdminTabControl.TabIndex = 1;
            // 
            // AdminListTabPage
            // 
            AdminListTabPage.Controls.Add(SearchAdminBtn);
            AdminListTabPage.Controls.Add(SearchAdminTxb);
            AdminListTabPage.Controls.Add(DeleteAdminBtn);
            AdminListTabPage.Controls.Add(EditAdminBtn);
            AdminListTabPage.Controls.Add(AddAdminBtn);
            AdminListTabPage.Controls.Add(AdminListDgv);
            AdminListTabPage.Location = new Point(4, 24);
            AdminListTabPage.Name = "AdminListTabPage";
            AdminListTabPage.Padding = new Padding(3);
            AdminListTabPage.Size = new Size(792, 322);
            AdminListTabPage.TabIndex = 0;
            AdminListTabPage.Text = "Admin List";
            AdminListTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminDetailTabPage
            // 
            AdminDetailTabPage.Controls.Add(groupBox1);
            AdminDetailTabPage.Location = new Point(4, 24);
            AdminDetailTabPage.Name = "AdminDetailTabPage";
            AdminDetailTabPage.Padding = new Padding(3);
            AdminDetailTabPage.Size = new Size(792, 322);
            AdminDetailTabPage.TabIndex = 1;
            AdminDetailTabPage.Text = "Admin Detail";
            AdminDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminListDgv
            // 
            AdminListDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdminListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminListDgv.Location = new Point(6, 35);
            AdminListDgv.Name = "AdminListDgv";
            AdminListDgv.Size = new Size(697, 279);
            AdminListDgv.TabIndex = 0;
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddAdminBtn.BackColor = Color.Lime;
            AddAdminBtn.FlatAppearance.BorderSize = 0;
            AddAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            AddAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            AddAdminBtn.FlatStyle = FlatStyle.Flat;
            AddAdminBtn.Location = new Point(709, 35);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(75, 23);
            AddAdminBtn.TabIndex = 1;
            AddAdminBtn.Text = "Add";
            AddAdminBtn.UseVisualStyleBackColor = false;
            // 
            // EditAdminBtn
            // 
            EditAdminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditAdminBtn.BackColor = Color.Yellow;
            EditAdminBtn.FlatAppearance.BorderSize = 0;
            EditAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            EditAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            EditAdminBtn.FlatStyle = FlatStyle.Flat;
            EditAdminBtn.Location = new Point(709, 64);
            EditAdminBtn.Name = "EditAdminBtn";
            EditAdminBtn.Size = new Size(75, 23);
            EditAdminBtn.TabIndex = 2;
            EditAdminBtn.Text = "Edit";
            EditAdminBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteAdminBtn
            // 
            DeleteAdminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteAdminBtn.BackColor = Color.Red;
            DeleteAdminBtn.FlatAppearance.BorderSize = 0;
            DeleteAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            DeleteAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            DeleteAdminBtn.FlatStyle = FlatStyle.Flat;
            DeleteAdminBtn.Location = new Point(709, 93);
            DeleteAdminBtn.Name = "DeleteAdminBtn";
            DeleteAdminBtn.Size = new Size(75, 23);
            DeleteAdminBtn.TabIndex = 3;
            DeleteAdminBtn.Text = "Delete";
            DeleteAdminBtn.UseVisualStyleBackColor = false;
            // 
            // SearchAdminTxb
            // 
            SearchAdminTxb.Location = new Point(6, 6);
            SearchAdminTxb.Name = "SearchAdminTxb";
            SearchAdminTxb.Size = new Size(211, 23);
            SearchAdminTxb.TabIndex = 4;
            // 
            // SearchAdminBtn
            // 
            SearchAdminBtn.BackColor = Color.FromArgb(255, 128, 0);
            SearchAdminBtn.FlatAppearance.BorderSize = 0;
            SearchAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            SearchAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            SearchAdminBtn.FlatStyle = FlatStyle.Flat;
            SearchAdminBtn.Location = new Point(223, 5);
            SearchAdminBtn.Name = "SearchAdminBtn";
            SearchAdminBtn.Size = new Size(75, 23);
            SearchAdminBtn.TabIndex = 5;
            SearchAdminBtn.Text = "Search";
            SearchAdminBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // AdministratorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminTabControl);
            Controls.Add(panel1);
            Name = "AdministratorView";
            Text = "AdministratorView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AdminTabControl.ResumeLayout(false);
            AdminListTabPage.ResumeLayout(false);
            AdminListTabPage.PerformLayout();
            AdminDetailTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminListDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AdminTitleLbl;
        private Label CloseAdministratorViewBtn;
        private TabControl AdminTabControl;
        private TabPage AdminListTabPage;
        private TabPage AdminDetailTabPage;
        private Button DeleteAdminBtn;
        private Button EditAdminBtn;
        private Button AddAdminBtn;
        private DataGridView AdminListDgv;
        private Button SearchAdminBtn;
        private TextBox SearchAdminTxb;
        private GroupBox groupBox1;
    }
}