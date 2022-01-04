
namespace WindowsFormsApp323232
{
    partial class Form7
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
            this.buttshow = new System.Windows.Forms.Button();
            this.buttforeach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttshow
            // 
            this.buttshow.Location = new System.Drawing.Point(183, 58);
            this.buttshow.Name = "buttshow";
            this.buttshow.Size = new System.Drawing.Size(151, 36);
            this.buttshow.TabIndex = 0;
            this.buttshow.Text = "Show";
            this.buttshow.UseVisualStyleBackColor = true;
            this.buttshow.Click += new System.EventHandler(this.buttshow_Click);
            // 
            // buttforeach
            // 
            this.buttforeach.Location = new System.Drawing.Point(183, 235);
            this.buttforeach.Name = "buttforeach";
            this.buttforeach.Size = new System.Drawing.Size(151, 36);
            this.buttforeach.TabIndex = 1;
            this.buttforeach.Text = "foreach";
            this.buttforeach.UseVisualStyleBackColor = true;
            this.buttforeach.Click += new System.EventHandler(this.buttforeach_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttforeach);
            this.Controls.Add(this.buttshow);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttshow;
        private System.Windows.Forms.Button buttforeach;
        private System.Windows.Forms.Button button1;
    }
}