namespace OmegaTeslaFejl
{
    partial class Form3
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
            textBox5 = new TextBox();
            colorDialog1 = new ColorDialog();
            textBox4 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(45, 167);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(685, 34);
            textBox5.TabIndex = 6;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(45, 226);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Heslo pro zobrazení či smazání jízdy";
            textBox4.Size = new Size(685, 34);
            textBox4.TabIndex = 18;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(732, 121);
            label1.TabIndex = 19;
            label1.Text = "Příhlašte se pro získání detailů vaší Tesla Experience";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(264, 324);
            button1.Name = "button1";
            button1.Size = new Size(250, 76);
            button1.TabIndex = 20;
            button1.Text = "Přihlásit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlText;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(305, 425);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(180, 67);
            button9.TabIndex = 21;
            button9.Text = "Zpět";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(782, 553);
            Controls.Add(button9);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            ForeColor = SystemColors.Control;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private ColorDialog colorDialog1;
        private TextBox textBox4;
        private Label label1;
        private Button button1;
        private Button button9;
    }
}