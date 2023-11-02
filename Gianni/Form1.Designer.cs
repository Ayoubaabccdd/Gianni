namespace Gianni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Sot = new System.Windows.Forms.Button();
            this.Mol = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Sempl = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(110, 135);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(119, 55);
            this.Add.TabIndex = 0;
            this.Add.Text = "Addizione";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sot
            // 
            this.Sot.Location = new System.Drawing.Point(235, 135);
            this.Sot.Name = "Sot";
            this.Sot.Size = new System.Drawing.Size(119, 54);
            this.Sot.TabIndex = 1;
            this.Sot.Text = "Sottrazione";
            this.Sot.UseVisualStyleBackColor = true;
            this.Sot.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mol
            // 
            this.Mol.Location = new System.Drawing.Point(110, 211);
            this.Mol.Name = "Mol";
            this.Mol.Size = new System.Drawing.Size(119, 54);
            this.Mol.TabIndex = 2;
            this.Mol.Text = "Moltiplicazione";
            this.Mol.UseVisualStyleBackColor = true;
            this.Mol.Click += new System.EventHandler(this.Mol_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(235, 211);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(119, 54);
            this.Div.TabIndex = 3;
            this.Div.Text = "Divisione";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Sempl
            // 
            this.Sempl.Location = new System.Drawing.Point(171, 271);
            this.Sempl.Name = "Sempl";
            this.Sempl.Size = new System.Drawing.Size(119, 54);
            this.Sempl.TabIndex = 4;
            this.Sempl.Text = "Semplifica frazione";
            this.Sempl.UseVisualStyleBackColor = true;
            this.Sempl.Click += new System.EventHandler(this.Sempl_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(401, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 226);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(110, 99);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(100, 20);
            this.N1.TabIndex = 6;
            this.N1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(235, 99);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(100, 20);
            this.N2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Sempl);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mol);
            this.Controls.Add(this.Sot);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sot;
        private System.Windows.Forms.Button Mol;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Sempl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

