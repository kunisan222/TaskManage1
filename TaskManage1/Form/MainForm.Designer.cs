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
            listBox1 = new ListBox();
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
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(114, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 253);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "登録タスク一覧";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(412, 231);
            listBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 313);
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
        private ListBox listBox1;
    }
}