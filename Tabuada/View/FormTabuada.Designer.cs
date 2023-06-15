namespace Tabuada.View
{
    partial class FormTabuada
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
            this.label1 = new System.Windows.Forms.Label();
            this.txboxnumero = new System.Windows.Forms.TextBox();
            this.listBoxresul = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(292, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "tabuada";
            // 
            // txboxnumero
            // 
            this.txboxnumero.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txboxnumero.Location = new System.Drawing.Point(285, 157);
            this.txboxnumero.Name = "txboxnumero";
            this.txboxnumero.Size = new System.Drawing.Size(100, 31);
            this.txboxnumero.TabIndex = 1;
            this.txboxnumero.TextChanged += new System.EventHandler(this.txboxnumero_TextChanged);
            // 
            // listBoxresul
            // 
            this.listBoxresul.FormattingEnabled = true;
            this.listBoxresul.ItemHeight = 15;
            this.listBoxresul.Location = new System.Drawing.Point(176, 254);
            this.listBoxresul.Name = "listBoxresul";
            this.listBoxresul.Size = new System.Drawing.Size(315, 184);
            this.listBoxresul.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o numero da tabuada";
            // 
            // FormTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxresul);
            this.Controls.Add(this.txboxnumero);
            this.Controls.Add(this.label1);
            this.Name = "FormTabuada";
            this.Text = "FormTabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txboxnumero;
        private ListBox listBoxresul;
        private Label label2;
    }
}