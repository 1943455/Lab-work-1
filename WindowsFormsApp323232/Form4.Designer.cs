
namespace WindowsFormsApp323232
{
    partial class Form4
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
            this.buttoshose = new System.Windows.Forms.Button();
            this.buttoreby = new System.Windows.Forms.Button();
            this.buttorebynmbr = new System.Windows.Forms.Button();
            this.buttorelast = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttoshose
            // 
            this.buttoshose.Location = new System.Drawing.Point(269, 25);
            this.buttoshose.Name = "buttoshose";
            this.buttoshose.Size = new System.Drawing.Size(185, 84);
            this.buttoshose.TabIndex = 0;
            this.buttoshose.Text = "Show select";
            this.buttoshose.UseVisualStyleBackColor = true;
            this.buttoshose.Click += new System.EventHandler(this.buttoshose_Click);
            // 
            // buttoreby
            // 
            this.buttoreby.Location = new System.Drawing.Point(269, 125);
            this.buttoreby.Name = "buttoreby";
            this.buttoreby.Size = new System.Drawing.Size(185, 84);
            this.buttoreby.TabIndex = 1;
            this.buttoreby.Text = "Remove by name";
            this.buttoreby.UseVisualStyleBackColor = true;
            this.buttoreby.Click += new System.EventHandler(this.buttoreby_Click);
            // 
            // buttorebynmbr
            // 
            this.buttorebynmbr.Location = new System.Drawing.Point(269, 320);
            this.buttorebynmbr.Name = "buttorebynmbr";
            this.buttorebynmbr.Size = new System.Drawing.Size(185, 84);
            this.buttorebynmbr.TabIndex = 2;
            this.buttorebynmbr.Text = "Remove by number";
            this.buttorebynmbr.UseVisualStyleBackColor = true;
            this.buttorebynmbr.Click += new System.EventHandler(this.buttorebynmbr_Click);
            // 
            // buttorelast
            // 
            this.buttorelast.Location = new System.Drawing.Point(269, 228);
            this.buttorelast.Name = "buttorelast";
            this.buttorelast.Size = new System.Drawing.Size(185, 69);
            this.buttorelast.TabIndex = 3;
            this.buttorelast.Text = "Remove last";
            this.buttorelast.UseVisualStyleBackColor = true;
            this.buttorelast.Click += new System.EventHandler(this.buttorelast_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(113, 302);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 48);
            this.buttonback.TabIndex = 4;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(77, 214);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 27);
            this.comboBox11.TabIndex = 5;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttorelast);
            this.Controls.Add(this.buttorebynmbr);
            this.Controls.Add(this.buttoreby);
            this.Controls.Add(this.buttoshose);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoshose;
        private System.Windows.Forms.Button buttoreby;
        private System.Windows.Forms.Button buttorebynmbr;
        private System.Windows.Forms.Button buttorelast;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ComboBox comboBox11;
    }
}