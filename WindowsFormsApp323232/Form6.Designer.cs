
namespace WindowsFormsApp323232
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtogreat = new System.Windows.Forms.RadioButton();
            this.radioButtoless = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttorest = new System.Windows.Forms.Button();
            this.button1B = new System.Windows.Forms.Button();
            this.buttoback112 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtogreat);
            this.groupBox1.Controls.Add(this.radioButtoless);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.buttorest);
            this.groupBox1.Controls.Add(this.button1B);
            this.groupBox1.Location = new System.Drawing.Point(33, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtogreat
            // 
            this.radioButtogreat.AutoSize = true;
            this.radioButtogreat.Location = new System.Drawing.Point(207, 177);
            this.radioButtogreat.Name = "radioButtogreat";
            this.radioButtogreat.Size = new System.Drawing.Size(154, 23);
            this.radioButtogreat.TabIndex = 4;
            this.radioButtogreat.TabStop = true;
            this.radioButtogreat.Text = "Greater than 500";
            this.radioButtogreat.UseVisualStyleBackColor = true;
            // 
            // radioButtoless
            // 
            this.radioButtoless.AutoSize = true;
            this.radioButtoless.Location = new System.Drawing.Point(207, 105);
            this.radioButtoless.Name = "radioButtoless";
            this.radioButtoless.Size = new System.Drawing.Size(132, 23);
            this.radioButtoless.TabIndex = 3;
            this.radioButtoless.TabStop = true;
            this.radioButtoless.Text = "Less than 500";
            this.radioButtoless.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 2;
            // 
            // buttorest
            // 
            this.buttorest.Location = new System.Drawing.Point(234, 250);
            this.buttorest.Name = "buttorest";
            this.buttorest.Size = new System.Drawing.Size(75, 36);
            this.buttorest.TabIndex = 1;
            this.buttorest.Text = "Rest";
            this.buttorest.UseVisualStyleBackColor = true;
            // 
            // button1B
            // 
            this.button1B.Location = new System.Drawing.Point(224, 39);
            this.button1B.Name = "button1B";
            this.button1B.Size = new System.Drawing.Size(75, 27);
            this.button1B.TabIndex = 0;
            this.button1B.Text = "B";
            this.button1B.UseVisualStyleBackColor = true;
            this.button1B.Click += new System.EventHandler(this.button1B_Click);
            // 
            // buttoback112
            // 
            this.buttoback112.Location = new System.Drawing.Point(488, 328);
            this.buttoback112.Name = "buttoback112";
            this.buttoback112.Size = new System.Drawing.Size(75, 42);
            this.buttoback112.TabIndex = 5;
            this.buttoback112.Text = "Back";
            this.buttoback112.UseVisualStyleBackColor = true;
            this.buttoback112.Click += new System.EventHandler(this.buttoback112_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoback112);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtogreat;
        private System.Windows.Forms.RadioButton radioButtoless;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttorest;
        private System.Windows.Forms.Button button1B;
        private System.Windows.Forms.Button buttoback112;
    }
}