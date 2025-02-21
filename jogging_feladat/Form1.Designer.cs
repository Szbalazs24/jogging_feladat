namespace jogging_feladat
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.o_ki = new System.Windows.Forms.Label();
            this.kiiras = new System.Windows.Forms.Label();
            this.tallozas = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ázsia országai",
            "Afrika országai",
            "Európa országai"});
            this.comboBox1.Location = new System.Drawing.Point(28, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // o_ki
            // 
            this.o_ki.AutoSize = true;
            this.o_ki.Location = new System.Drawing.Point(330, 18);
            this.o_ki.Name = "o_ki";
            this.o_ki.Size = new System.Drawing.Size(54, 13);
            this.o_ki.TabIndex = 2;
            this.o_ki.Text = "Kontinens";
            // 
            // kiiras
            // 
            this.kiiras.AutoSize = true;
            this.kiiras.Location = new System.Drawing.Point(256, 170);
            this.kiiras.Name = "kiiras";
            this.kiiras.Size = new System.Drawing.Size(159, 13);
            this.kiiras.TabIndex = 3;
            this.kiiras.Text = "Jelenleg nincs választva ország!";
            // 
            // tallozas
            // 
            this.tallozas.Location = new System.Drawing.Point(144, 69);
            this.tallozas.Name = "tallozas";
            this.tallozas.Size = new System.Drawing.Size(75, 23);
            this.tallozas.TabIndex = 4;
            this.tallozas.Text = "Tallózás";
            this.tallozas.UseVisualStyleBackColor = true;
            this.tallozas.Click += new System.EventHandler(this.tallozas_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tallozas);
            this.Controls.Add(this.kiiras);
            this.Controls.Add(this.o_ki);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label o_ki;
        private System.Windows.Forms.Label kiiras;
        private System.Windows.Forms.Button tallozas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

