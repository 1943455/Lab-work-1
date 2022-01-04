
namespace WindowsFormsApp323232
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
            this.button1Show = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkCoffee = new System.Windows.Forms.CheckBox();
            this.checkDount = new System.Windows.Forms.CheckBox();
            this.checkBrownie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1Show
            // 
            this.button1Show.Location = new System.Drawing.Point(124, 39);
            this.button1Show.Name = "button1Show";
            this.button1Show.Size = new System.Drawing.Size(105, 42);
            this.button1Show.TabIndex = 0;
            this.button1Show.Text = "Show";
            this.button1Show.UseVisualStyleBackColor = true;
            this.button1Show.Click += new System.EventHandler(this.button1Show_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(124, 302);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 32);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // checkCoffee
            // 
            this.checkCoffee.AutoSize = true;
            this.checkCoffee.Location = new System.Drawing.Point(23, 184);
            this.checkCoffee.Name = "checkCoffee";
            this.checkCoffee.Size = new System.Drawing.Size(80, 23);
            this.checkCoffee.TabIndex = 2;
            this.checkCoffee.Text = "Coffee";
            this.checkCoffee.UseVisualStyleBackColor = true;
            // 
            // checkDount
            // 
            this.checkDount.AutoSize = true;
            this.checkDount.Location = new System.Drawing.Point(151, 184);
            this.checkDount.Name = "checkDount";
            this.checkDount.Size = new System.Drawing.Size(78, 23);
            this.checkDount.TabIndex = 3;
            this.checkDount.Text = "Dount";
            this.checkDount.UseVisualStyleBackColor = true;
            // 
            // checkBrownie
            // 
            this.checkBrownie.AutoSize = true;
            this.checkBrownie.Location = new System.Drawing.Point(284, 184);
            this.checkBrownie.Name = "checkBrownie";
            this.checkBrownie.Size = new System.Drawing.Size(92, 23);
            this.checkBrownie.TabIndex = 4;
            this.checkBrownie.Text = "Brownie";
            this.checkBrownie.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBrownie);
            this.Controls.Add(this.checkDount);
            this.Controls.Add(this.checkCoffee);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button1Show);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Show;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckBox checkCoffee;
        private System.Windows.Forms.CheckBox checkDount;
        private System.Windows.Forms.CheckBox checkBrownie;
    }
}