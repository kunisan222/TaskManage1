namespace KT_TaskManage
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistTaskButton = new Button();
            CloseButton = new Button();
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            TaskListTabControl = new TabControl();
            tabPage1 = new TabPage();
            ActiveTaskItemListBox = new ListBox();
            tabPage2 = new TabPage();
            DeactiveTaskItemListBox = new ListBox();
            TaskItemPropertyGrid = new PropertyGrid();
            DeleteTaskButton = new Button();
            EditTaskButton = new Button();
            SaveDataButton = new Button();
            LoadDataButton = new Button();
            EndTaskButton = new Button();
            MainMenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            読み込みToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            TaskListTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // RegistTaskButton
            // 
            RegistTaskButton.Location = new Point(20, 24);
            RegistTaskButton.Name = "RegistTaskButton";
            RegistTaskButton.Size = new Size(75, 23);
            RegistTaskButton.TabIndex = 0;
            RegistTaskButton.Text = "タスク追加";
            RegistTaskButton.UseVisualStyleBackColor = true;
            RegistTaskButton.Click += RegistTaskButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.Location = new Point(724, 397);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "閉じる";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(splitContainer1);
            groupBox1.Location = new Point(114, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 367);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "タスク一覧";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TaskListTabControl);
            splitContainer1.Panel1.Padding = new Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TaskItemPropertyGrid);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(679, 345);
            splitContainer1.SplitterDistance = 314;
            splitContainer1.TabIndex = 4;
            // 
            // TaskListTabControl
            // 
            TaskListTabControl.Controls.Add(tabPage1);
            TaskListTabControl.Controls.Add(tabPage2);
            TaskListTabControl.Dock = DockStyle.Fill;
            TaskListTabControl.Location = new Point(10, 10);
            TaskListTabControl.Name = "TaskListTabControl";
            TaskListTabControl.SelectedIndex = 0;
            TaskListTabControl.Size = new Size(294, 325);
            TaskListTabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ActiveTaskItemListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(286, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "残タスク一覧";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ActiveTaskItemListBox
            // 
            ActiveTaskItemListBox.Dock = DockStyle.Fill;
            ActiveTaskItemListBox.FormattingEnabled = true;
            ActiveTaskItemListBox.ItemHeight = 15;
            ActiveTaskItemListBox.Location = new Point(3, 3);
            ActiveTaskItemListBox.Name = "ActiveTaskItemListBox";
            ActiveTaskItemListBox.Size = new Size(280, 291);
            ActiveTaskItemListBox.TabIndex = 4;
            ActiveTaskItemListBox.SelectedIndexChanged += TaskItemListBox_SelectedIndexChanged;
            ActiveTaskItemListBox.Format += TaskItemListBox_Format;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DeactiveTaskItemListBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(286, 297);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "完了タスク一覧";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeactiveTaskItemListBox
            // 
            DeactiveTaskItemListBox.Dock = DockStyle.Fill;
            DeactiveTaskItemListBox.FormattingEnabled = true;
            DeactiveTaskItemListBox.ItemHeight = 15;
            DeactiveTaskItemListBox.Location = new Point(3, 3);
            DeactiveTaskItemListBox.Name = "DeactiveTaskItemListBox";
            DeactiveTaskItemListBox.Size = new Size(280, 291);
            DeactiveTaskItemListBox.TabIndex = 5;
            DeactiveTaskItemListBox.SelectedIndexChanged += TaskItemListBox_SelectedIndexChanged;
            DeactiveTaskItemListBox.Format += TaskItemListBox_Format;
            // 
            // TaskItemPropertyGrid
            // 
            TaskItemPropertyGrid.Dock = DockStyle.Fill;
            TaskItemPropertyGrid.Location = new Point(10, 10);
            TaskItemPropertyGrid.Name = "TaskItemPropertyGrid";
            TaskItemPropertyGrid.Size = new Size(341, 325);
            TaskItemPropertyGrid.TabIndex = 0;
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.Location = new Point(20, 62);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(75, 23);
            DeleteTaskButton.TabIndex = 4;
            DeleteTaskButton.Text = "タスク削除";
            DeleteTaskButton.UseVisualStyleBackColor = true;
            DeleteTaskButton.Click += DeleteTaskButton_Click;
            // 
            // EditTaskButton
            // 
            EditTaskButton.Location = new Point(20, 102);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(75, 23);
            EditTaskButton.TabIndex = 5;
            EditTaskButton.Text = "タスク編集";
            EditTaskButton.UseVisualStyleBackColor = true;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // SaveDataButton
            // 
            SaveDataButton.Location = new Point(20, 219);
            SaveDataButton.Name = "SaveDataButton";
            SaveDataButton.Size = new Size(75, 23);
            SaveDataButton.TabIndex = 6;
            SaveDataButton.Text = "データ保存";
            SaveDataButton.UseVisualStyleBackColor = true;
            SaveDataButton.Click += SaveDataButton_Click;
            // 
            // LoadDataButton
            // 
            LoadDataButton.Location = new Point(20, 254);
            LoadDataButton.Name = "LoadDataButton";
            LoadDataButton.Size = new Size(75, 23);
            LoadDataButton.TabIndex = 7;
            LoadDataButton.Text = "データ読出";
            LoadDataButton.UseVisualStyleBackColor = true;
            LoadDataButton.Click += LoadDataButton_Click;
            // 
            // EndTaskButton
            // 
            EndTaskButton.Location = new Point(20, 140);
            EndTaskButton.Name = "EndTaskButton";
            EndTaskButton.Size = new Size(75, 23);
            EndTaskButton.TabIndex = 8;
            EndTaskButton.Text = "タスク完了";
            EndTaskButton.UseVisualStyleBackColor = true;
            EndTaskButton.Click += EndTaskButton_Click;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(811, 24);
            MainMenuStrip.TabIndex = 9;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 保存ToolStripMenuItem, 読み込みToolStripMenuItem, 終了ToolStripMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(67, 20);
            FileMenuItem.Text = "ファイル(&F)";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存";
            // 
            // 読み込みToolStripMenuItem
            // 
            読み込みToolStripMenuItem.Name = "読み込みToolStripMenuItem";
            読み込みToolStripMenuItem.Size = new Size(180, 22);
            読み込みToolStripMenuItem.Text = "読み込み";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(180, 22);
            終了ToolStripMenuItem.Text = "終了";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 427);
            Controls.Add(EndTaskButton);
            Controls.Add(LoadDataButton);
            Controls.Add(SaveDataButton);
            Controls.Add(EditTaskButton);
            Controls.Add(DeleteTaskButton);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(RegistTaskButton);
            Controls.Add(MainMenuStrip);
            MainMenuStrip = MainMenuStrip;
            Name = "MainForm";
            Text = "メイン画面";
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            TaskListTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistTaskButton;
        private Button CloseButton;
        private GroupBox groupBox1;
        private Button DeleteTaskButton;
        private Button EditTaskButton;
        private Button SaveDataButton;
        private Button LoadDataButton;
        private SplitContainer splitContainer1;
        private ListBox ActiveTaskItemListBox;
        private PropertyGrid TaskItemPropertyGrid;
        private Button EndTaskButton;
        private TabControl TaskListTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox DeactiveTaskItemListBox;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 読み込みToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
    }
}