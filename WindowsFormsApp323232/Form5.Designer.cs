
namespace WindowsFormsApp323232
{
    partial class Form5
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
            this.buttorannum = new System.Windows.Forms.Button();
            this.buttoBack12 = new System.Windows.Forms.Button();
            this.buttogerc = new System.Windows.Forms.Button();
            this.label1rgb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttorannum
            // 
            this.buttorannum.Location = new System.Drawing.Point(266, 239);
            this.buttorannum.Name = "buttorannum";
            this.buttorannum.Size = new System.Drawing.Size(209, 75);
            this.buttorannum.TabIndex = 0;
            this.buttorannum.Text = "Random Number";
            this.buttorannum.UseVisualStyleBackColor = true;
            this.buttorannum.Click += new System.EventHandler(this.buttorannum_Click);
            // 
            // buttoBack12
            // 
            this.buttoBack12.Location = new System.Drawing.Point(266, 363);
            this.buttoBack12.Name = "buttoBack12";
            this.buttoBack12.Size = new System.Drawing.Size(209, 45);
            this.buttoBack12.TabIndex = 1;
            this.buttoBack12.Text = "Back";
            this.buttoBack12.UseVisualStyleBackColor = true;
            this.buttoBack12.Click += new System.EventHandler(this.buttoBack12_Click);
            // 
            // buttogerc
            // 
            this.buttogerc.Location = new System.Drawing.Point(266, 79);
            this.buttogerc.Name = "buttogerc";
            this.buttogerc.Size = new System.Drawing.Size(209, 66);
            this.buttogerc.TabIndex = 2;
            this.buttogerc.Text = "Generate Random Color\r\n\r\n";
            this.buttogerc.UseVisualStyleBackColor = true;
            this.buttogerc.Click += new System.EventHandler(this.buttogerc_Click);
            // 
            // label1rgb
            // 
            this.label1rgb.AutoSize = true;
            this.label1rgb.Location = new System.Drawing.Point(329, 186);
            this.label1rgb.Name = "label1rgb";
            this.label1rgb.Size = new System.Drawing.Size(45, 19);
            this.label1rgb.TabIndex = 3;
            this.label1rgb.Text = "r-g-b\r\n";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1rgb);
            this.Controls.Add(this.buttogerc);
            this.Controls.Add(this.buttoBack12);
            this.Controls.Add(this.buttorannum);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttorannum;
        private System.Windows.Forms.Button buttoBack12;
        private System.Windows.Forms.Button buttogerc;
        private System.Windows.Forms.Label label1rgb;
    }
}