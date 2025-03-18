namespace rabota2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Cascadia Code", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 381);
            button1.Name = "button1";
            button1.Size = new Size(391, 117);
            button1.TabIndex = 0;
            button1.Text = "Расчёт";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 594);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.Font = new Font("Cascadia Code", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(293, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 117);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.Font = new Font("Cascadia Code", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(293, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(391, 117);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 538);
            label2.Name = "label2";
            label2.Size = new Size(603, 117);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 5;
            label3.Text = "Сумма:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 179);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 6;
            label4.Text = "Срок:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 501);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 7;
            label5.Text = "Сброс:";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 664);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Приложение 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}