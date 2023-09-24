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
            TaskItemListBox = new ListBox();
            DeketeTaskButton = new Button();
            groupBox1.SuspendLayout();
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
            CloseButton.Location = new Point(457, 283);
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
            groupBox1.Controls.Add(TaskItemListBox);
            groupBox1.Location = new Point(114, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 253);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "登録タスク一覧";
            // 
            // TaskItemListBox
            // 
            TaskItemListBox.Dock = DockStyle.Fill;
            TaskItemListBox.FormattingEnabled = true;
            TaskItemListBox.ItemHeight = 15;
            TaskItemListBox.Location = new Point(3, 19);
            TaskItemListBox.Name = "TaskItemListBox";
            TaskItemListBox.Size = new Size(412, 231);
            TaskItemListBox.TabIndex = 3;
            // 
            // DeketeTaskButton
            // 
            DeketeTaskButton.Location = new Point(20, 62);
            DeketeTaskButton.Name = "DeketeTaskButton";
            DeketeTaskButton.Size = new Size(75, 23);
            DeketeTaskButton.TabIndex = 4;
            DeketeTaskButton.Text = "タスク削除";
            DeketeTaskButton.UseVisualStyleBackColor = true;
            DeketeTaskButton.Click += DeketeTaskButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 313);
            Controls.Add(DeketeTaskButton);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(RegistTaskButton);
            Name = "MainForm";
            Text = "メイン画面";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button RegistTaskButton;
        private Button CloseButton;
        private GroupBox groupBox1;
        private ListBox TaskItemListBox;
        private Button DeketeTaskButton;
    }
}