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
            TaskItemListBox = new ListBox();
            TaskItemPropertyGrid = new PropertyGrid();
            DeleteTaskButton = new Button();
            EditTaskButton = new Button();
            SaveDataButton = new Button();
            LoadDataButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            groupBox1.Text = "登録タスク一覧";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TaskItemListBox);
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
            // TaskItemListBox
            // 
            TaskItemListBox.Dock = DockStyle.Fill;
            TaskItemListBox.FormattingEnabled = true;
            TaskItemListBox.ItemHeight = 15;
            TaskItemListBox.Location = new Point(10, 10);
            TaskItemListBox.Name = "TaskItemListBox";
            TaskItemListBox.Size = new Size(294, 325);
            TaskItemListBox.TabIndex = 4;
            TaskItemListBox.SelectedIndexChanged += TaskItemListBox_SelectedIndexChanged;
            TaskItemListBox.Format += TaskItemListBox_Format;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 427);
            Controls.Add(LoadDataButton);
            Controls.Add(SaveDataButton);
            Controls.Add(EditTaskButton);
            Controls.Add(DeleteTaskButton);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(RegistTaskButton);
            Name = "MainForm";
            Text = "メイン画面";
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
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
        private ListBox TaskItemListBox;
        private PropertyGrid TaskItemPropertyGrid;
    }
}