namespace KT_TaskManage
{
    partial class RegistTaskForm
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
            TaskNameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            TaskIdNumericUpDown = new NumericUpDown();
            CloseButton = new Button();
            RegistButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskIdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TaskNameTextBox
            // 
            TaskNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TaskNameTextBox.Location = new Point(150, 52);
            TaskNameTextBox.Name = "TaskNameTextBox";
            TaskNameTextBox.Size = new Size(271, 23);
            TaskNameTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(150, 90);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(271, 66);
            DescriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Task ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Task Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 51);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "TaskType";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(153, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Deactive";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Active";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // TaskIdNumericUpDown
            // 
            TaskIdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TaskIdNumericUpDown.Location = new Point(150, 15);
            TaskIdNumericUpDown.Name = "TaskIdNumericUpDown";
            TaskIdNumericUpDown.Size = new Size(271, 23);
            TaskIdNumericUpDown.TabIndex = 7;
            // 
            // CancelButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.Location = new Point(346, 219);
            CloseButton.Name = "CancelButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CancelButton_Click;
            // 
            // RegistButton
            // 
            RegistButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegistButton.Location = new Point(265, 219);
            RegistButton.Name = "RegistButton";
            RegistButton.Size = new Size(75, 23);
            RegistButton.TabIndex = 9;
            RegistButton.Text = "Regist";
            RegistButton.UseVisualStyleBackColor = true;
            RegistButton.Click += RegistButton_Click;
            // 
            // RegistTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 251);
            Controls.Add(RegistButton);
            Controls.Add(CloseButton);
            Controls.Add(TaskIdNumericUpDown);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(TaskNameTextBox);
            Name = "RegistTaskForm";
            Text = "タスク登録画面";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaskIdNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TaskNameTextBox;
        private TextBox DescriptionTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private NumericUpDown TaskIdNumericUpDown;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button CloseButton;
        private Button RegistButton;
    }
}