namespace OmegaTeslaFejl
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            textBox4 = new TextBox();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(868, 88);
            label1.TabIndex = 0;
            label1.Text = "Vyberte si Tesla Experience";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(103, 116);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Jméno";
            textBox1.Size = new Size(685, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(103, 163);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Příjmení";
            textBox2.Size = new Size(685, 34);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(103, 209);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Adresa";
            textBox3.Size = new Size(685, 34);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(103, 303);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(685, 34);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(103, 256);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Telefon";
            textBox6.Size = new Size(685, 34);
            textBox6.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(106, 398);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(343, 80);
            button1.TabIndex = 7;
            button1.Text = "ŘIDIČ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(449, 398);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(343, 80);
            button2.TabIndex = 8;
            button2.Text = "SPOLUJEZDEC";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(449, 486);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(343, 80);
            button3.TabIndex = 9;
            button3.Text = "Tesla model S";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(106, 486);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(343, 80);
            button4.TabIndex = 10;
            button4.Text = "Tesla model 3 Performance";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 589);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 5, 11, 0, 0, 0, 0);
            dateTimePicker1.MinimumSize = new Size(685, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(685, 40);
            dateTimePicker1.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(106, 658);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(229, 80);
            button5.TabIndex = 12;
            button5.Text = "SPŠE Ječná";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(563, 658);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(229, 80);
            button6.TabIndex = 13;
            button6.Text = "Fortuna Arena";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(332, 658);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(238, 80);
            button7.TabIndex = 14;
            button7.Text = "Nádraží Libeň";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(332, 746);
            label2.Name = "label2";
            label2.Size = new Size(229, 67);
            label2.TabIndex = 15;
            label2.Text = "Cena: 2100Kč";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(232, 817);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(434, 67);
            button8.TabIndex = 16;
            button8.Text = "Závazně objednat";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(103, 350);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Heslo pro zobrazení či smazání jízdy";
            textBox4.Size = new Size(685, 34);
            textBox4.TabIndex = 17;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlText;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(359, 895);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(180, 67);
            button9.TabIndex = 18;
            button9.Text = "Zpět";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(894, 1004);
            Controls.Add(button9);
            Controls.Add(textBox4);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(912, 1051);
            MinimumSize = new Size(912, 1028);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label2;
        private Button button8;
        private TextBox textBox4;
        private Button button9;
    }
}