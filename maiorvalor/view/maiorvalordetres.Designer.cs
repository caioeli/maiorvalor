
namespace maiorvalor.view
{
    partial class maiorvalordetres
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
            this.labelvalor1 = new System.Windows.Forms.Label();
            this.labelvalor2 = new System.Windows.Forms.Label();
            this.labelvalor3 = new System.Windows.Forms.Label();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelvalor1
            // 
            this.labelvalor1.AutoSize = true;
            this.labelvalor1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvalor1.Location = new System.Drawing.Point(48, 56);
            this.labelvalor1.Name = "labelvalor1";
            this.labelvalor1.Size = new System.Drawing.Size(85, 18);
            this.labelvalor1.TabIndex = 0;
            this.labelvalor1.Text = "Valor 1 :";
            this.labelvalor1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelvalor2
            // 
            this.labelvalor2.AutoSize = true;
            this.labelvalor2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvalor2.Location = new System.Drawing.Point(48, 113);
            this.labelvalor2.Name = "labelvalor2";
            this.labelvalor2.Size = new System.Drawing.Size(85, 18);
            this.labelvalor2.TabIndex = 1;
            this.labelvalor2.Text = "Valor 2 :";
            // 
            // labelvalor3
            // 
            this.labelvalor3.AutoSize = true;
            this.labelvalor3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvalor3.Location = new System.Drawing.Point(48, 167);
            this.labelvalor3.Name = "labelvalor3";
            this.labelvalor3.Size = new System.Drawing.Size(85, 18);
            this.labelvalor3.TabIndex = 2;
            this.labelvalor3.Text = "Valor 3 :";
            // 
            // nud3
            // 
            this.nud3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud3.Location = new System.Drawing.Point(129, 165);
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(120, 25);
            this.nud3.TabIndex = 3;
            // 
            // nud2
            // 
            this.nud2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud2.Location = new System.Drawing.Point(129, 111);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 25);
            this.nud2.TabIndex = 4;
            // 
            // nud1
            // 
            this.nud1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud1.Location = new System.Drawing.Point(129, 54);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 25);
            this.nud1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox1.Location = new System.Drawing.Point(48, 262);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 149);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite Três valores";
            // 
            // maiorvalordetres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.labelvalor3);
            this.Controls.Add(this.labelvalor2);
            this.Controls.Add(this.labelvalor1);
            this.Name = "maiorvalordetres";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Exibir Maior valor de três";
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelvalor1;
        private System.Windows.Forms.Label labelvalor2;
        private System.Windows.Forms.Label labelvalor3;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}