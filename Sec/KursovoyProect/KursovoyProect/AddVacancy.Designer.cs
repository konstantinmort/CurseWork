namespace KursovoyProect
{
    partial class AddVacancy
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
            this.Addbutton2 = new System.Windows.Forms.Button();
            this.Cancelbutton2 = new System.Windows.Forms.Button();
            this.vacancytextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.zptextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addbutton2
            // 
            this.Addbutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton2.Location = new System.Drawing.Point(32, 134);
            this.Addbutton2.Margin = new System.Windows.Forms.Padding(2);
            this.Addbutton2.Name = "Addbutton2";
            this.Addbutton2.Size = new System.Drawing.Size(118, 25);
            this.Addbutton2.TabIndex = 4;
            this.Addbutton2.Text = "Добавить";
            this.Addbutton2.UseVisualStyleBackColor = false;
            this.Addbutton2.Click += new System.EventHandler(this.Addbutton2_Click);
            // 
            // Cancelbutton2
            // 
            this.Cancelbutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelbutton2.Location = new System.Drawing.Point(193, 134);
            this.Cancelbutton2.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton2.Name = "Cancelbutton2";
            this.Cancelbutton2.Size = new System.Drawing.Size(118, 25);
            this.Cancelbutton2.TabIndex = 5;
            this.Cancelbutton2.Text = "Отмена";
            this.Cancelbutton2.UseVisualStyleBackColor = false;
            this.Cancelbutton2.Click += new System.EventHandler(this.Cancelbutton2_Click);
            // 
            // vacancytextBox1
            // 
            this.vacancytextBox1.Location = new System.Drawing.Point(32, 58);
            this.vacancytextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.vacancytextBox1.Name = "vacancytextBox1";
            this.vacancytextBox1.Size = new System.Drawing.Size(119, 20);
            this.vacancytextBox1.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Стоимость аренды в день";
            // 
            // zptextbox
            // 
            this.zptextbox.Location = new System.Drawing.Point(32, 96);
            this.zptextbox.Margin = new System.Windows.Forms.Padding(2);
            this.zptextbox.Name = "zptextbox";
            this.zptextbox.Size = new System.Drawing.Size(119, 20);
            this.zptextbox.TabIndex = 102;
            this.zptextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Zptextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Этаж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Площадь";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 105;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.BackgroundImage = global::KursovoyProect.Properties.Resources.minus_drop;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Location = new System.Drawing.Point(298, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 16);
            this.button4.TabIndex = 95;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox1.Location = new System.Drawing.Point(192, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Кондиционер";
            // 
            // AddVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(345, 187);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vacancytextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zptextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Cancelbutton2);
            this.Controls.Add(this.Addbutton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVacancy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление вакансий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Addbutton2;
        private System.Windows.Forms.Button Cancelbutton2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox vacancytextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zptextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}