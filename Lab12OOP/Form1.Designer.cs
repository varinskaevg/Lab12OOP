namespace Lab12OOP
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtData = new TextBox();
            button1 = new Button();
            txtStreet = new TextBox();
            label3 = new Label();
            txtTime = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 27);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 73);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Коли";
            // 
            // txtName
            // 
            txtName.Location = new Point(307, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 27);
            txtName.TabIndex = 3;
            // 
            // txtData
            // 
            txtData.Location = new Point(307, 70);
            txtData.Name = "txtData";
            txtData.Size = new Size(188, 27);
            txtData.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(262, 220);
            button1.Name = "button1";
            button1.Size = new Size(233, 55);
            button1.TabIndex = 5;
            button1.Text = "Отримати запрошення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(307, 121);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(188, 27);
            txtStreet.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 124);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 6;
            label3.Text = "Де";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(307, 171);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(188, 27);
            txtTime.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 174);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 8;
            label4.Text = "Час";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 287);
            Controls.Add(txtTime);
            Controls.Add(label4);
            Controls.Add(txtStreet);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtData);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Привітання";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtData;
        private Button button1;
        private TextBox txtStreet;
        private Label label3;
        private TextBox txtTime;
        private Label label4;
    }
}
