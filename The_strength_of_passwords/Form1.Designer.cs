
namespace The_strength_of_passwords
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcSavedPasswords = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.lPasswordLength = new System.Windows.Forms.Label();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMainData = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbTransformationNotepad = new System.Windows.Forms.RichTextBox();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.NotepadSave = new System.Windows.Forms.Button();
            this.NotepadClear = new System.Windows.Forms.Button();
            this.tsmAddDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcSavedPasswords.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSavedPasswords
            // 
            this.tcSavedPasswords.Controls.Add(this.tabPage1);
            this.tcSavedPasswords.Controls.Add(this.tabPage2);
            this.tcSavedPasswords.Controls.Add(this.tabPage3);
            this.tcSavedPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSavedPasswords.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSavedPasswords.Location = new System.Drawing.Point(0, 27);
            this.tcSavedPasswords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcSavedPasswords.Name = "tcSavedPasswords";
            this.tcSavedPasswords.SelectedIndex = 0;
            this.tcSavedPasswords.Size = new System.Drawing.Size(494, 241);
            this.tcSavedPasswords.TabIndex = 2;
            this.tcSavedPasswords.Click += new System.EventHandler(this.tcSavedPasswords_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::The_strength_of_passwords.Properties.Resources.LockerPass;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnCopy);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.btnCreatePassword);
            this.tabPage1.Controls.Add(this.nudPasswordLength);
            this.tabPage1.Controls.Add(this.lPasswordLength);
            this.tabPage1.Controls.Add(this.clbPassword);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(486, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(243, 154);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(12, 154);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(222, 30);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(12, 120);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(451, 24);
            this.tbPassword.TabIndex = 9;
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePassword.Location = new System.Drawing.Point(12, 82);
            this.btnCreatePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(171, 30);
            this.btnCreatePassword.TabIndex = 8;
            this.btnCreatePassword.Text = "Create";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudPasswordLength.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPasswordLength.Location = new System.Drawing.Point(342, 85);
            this.nudPasswordLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(123, 24);
            this.nudPasswordLength.TabIndex = 7;
            this.nudPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lPasswordLength
            // 
            this.lPasswordLength.AutoSize = true;
            this.lPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(180)))), ((int)(((byte)(232)))));
            this.lPasswordLength.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswordLength.Location = new System.Drawing.Point(203, 89);
            this.lPasswordLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPasswordLength.Name = "lPasswordLength";
            this.lPasswordLength.Size = new System.Drawing.Size(94, 17);
            this.lPasswordLength.TabIndex = 6;
            this.lPasswordLength.Text = "Password length";
            // 
            // clbPassword
            // 
            this.clbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(151)))), ((int)(((byte)(220)))));
            this.clbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "The Numbers",
            "Lowercase letters",
            "Capital letters"});
            this.clbPassword.Location = new System.Drawing.Point(12, 8);
            this.clbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(157, 57);
            this.clbPassword.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::The_strength_of_passwords.Properties.Resources.LockerPass;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btnFullScreen);
            this.tabPage2.Controls.Add(this.btnSaveChanges);
            this.tabPage2.Controls.Add(this.btnClearAll);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.rtbMainData);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(486, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saved passwords";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackgroundImage = global::The_strength_of_passwords.Properties.Resources.icons9;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullScreen.Location = new System.Drawing.Point(436, 4);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(32, 26);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Location = new System.Drawing.Point(305, 4);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(59, 26);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.No;
            this.btnClearAll.Location = new System.Drawing.Point(372, 4);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(59, 26);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your passwords:";
            // 
            // rtbMainData
            // 
            this.rtbMainData.Location = new System.Drawing.Point(12, 34);
            this.rtbMainData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMainData.Name = "rtbMainData";
            this.rtbMainData.Size = new System.Drawing.Size(455, 157);
            this.rtbMainData.TabIndex = 0;
            this.rtbMainData.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::The_strength_of_passwords.Properties.Resources.LockerPass;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.NotepadClear);
            this.tabPage3.Controls.Add(this.NotepadSave);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.rtbTransformationNotepad);
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(486, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notepad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbTransformationNotepad
            // 
            this.rtbTransformationNotepad.Location = new System.Drawing.Point(466, 199);
            this.rtbTransformationNotepad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbTransformationNotepad.Name = "rtbTransformationNotepad";
            this.rtbTransformationNotepad.Size = new System.Drawing.Size(24, 16);
            this.rtbTransformationNotepad.TabIndex = 1;
            this.rtbTransformationNotepad.Text = "";
            this.rtbTransformationNotepad.Visible = false;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.BackColor = System.Drawing.Color.White;
            this.rtbNotepad.Location = new System.Drawing.Point(12, 34);
            this.rtbNotepad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(455, 157);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(494, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutAuthor,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F1)));
            this.AboutAuthor.Size = new System.Drawing.Size(196, 22);
            this.AboutAuthor.Text = "About";
            this.AboutAuthor.Click += new System.EventHandler(this.AboutAuthor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F3)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "It`s your fast notepad!";
            // 
            // NotepadSave
            // 
            this.NotepadSave.Location = new System.Drawing.Point(343, 5);
            this.NotepadSave.Name = "NotepadSave";
            this.NotepadSave.Size = new System.Drawing.Size(59, 26);
            this.NotepadSave.TabIndex = 3;
            this.NotepadSave.Text = "Save";
            this.NotepadSave.UseVisualStyleBackColor = true;
            this.NotepadSave.Click += new System.EventHandler(this.NotepadSave_Click);
            // 
            // NotepadClear
            // 
            this.NotepadClear.Location = new System.Drawing.Point(408, 5);
            this.NotepadClear.Name = "NotepadClear";
            this.NotepadClear.Size = new System.Drawing.Size(59, 26);
            this.NotepadClear.TabIndex = 4;
            this.NotepadClear.Text = "Clear";
            this.NotepadClear.UseVisualStyleBackColor = true;
            this.NotepadClear.Click += new System.EventHandler(this.NotepadClear_Click);
            // 
            // tsmAddDate
            // 
            this.tsmAddDate.Name = "tsmAddDate";
            this.tsmAddDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmAddDate.Size = new System.Drawing.Size(204, 22);
            this.tsmAddDate.Text = "Add date";
            this.tsmAddDate.Click += new System.EventHandler(this.tsmAddDate_Click);
            // 
            // tsmAddTime
            // 
            this.tsmAddTime.Name = "tsmAddTime";
            this.tsmAddTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmAddTime.Size = new System.Drawing.Size(204, 22);
            this.tsmAddTime.Text = "Add time";
            this.tsmAddTime.Click += new System.EventHandler(this.tsmAddTime_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddDate,
            this.tsmAddTime});
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 268);
            this.Controls.Add(this.tcSavedPasswords);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Castle Passwords";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcSavedPasswords.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tcSavedPasswords;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.Button btnCreatePassword;
        public System.Windows.Forms.NumericUpDown nudPasswordLength;
        public System.Windows.Forms.Label lPasswordLength;
        public System.Windows.Forms.CheckedListBox clbPassword;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ToolStripMenuItem AboutAuthor;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.RichTextBox rtbNotepad;
        public System.Windows.Forms.RichTextBox rtbMainData;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.RichTextBox rtbTransformationNotepad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NotepadClear;
        private System.Windows.Forms.Button NotepadSave;
        public System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tsmAddDate;
        public System.Windows.Forms.ToolStripMenuItem tsmAddTime;
    }
}

