
namespace WindowsFormsApp323232
{
    partial class Form2
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
            this.button1Rest = new System.Windows.Forms.Button();
            this.radiobRed = new System.Windows.Forms.RadioButton();
            this.radiobGreen = new System.Windows.Forms.RadioButton();
            this.radiobBlue = new System.Windows.Forms.RadioButton();
            this.radiobYellow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.buttonback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Rest
            // 
            this.button1Rest.Location = new System.Drawing.Point(246, 40);
            this.button1Rest.Name = "button1Rest";
            this.button1Rest.Size = new System.Drawing.Size(75, 35);
            this.button1Rest.TabIndex = 0;
            this.button1Rest.Text = "Rest";
            this.button1Rest.UseVisualStyleBackColor = true;
            this.button1Rest.Click += new System.EventHandler(this.button1Rest_Click);
            // 
            // radiobRed
            // 
            this.radiobRed.AutoSize = true;
            this.radiobRed.Location = new System.Drawing.Point(117, 121);
            this.radiobRed.Name = "radiobRed";
            this.radiobRed.Size = new System.Drawing.Size(61, 23);
            this.radiobRed.TabIndex = 1;
            this.radiobRed.TabStop = true;
            this.radiobRed.Text = "Red";
            this.radiobRed.UseVisualStyleBackColor = true;
            this.radiobRed.CheckedChanged += new System.EventHandler(this.radiobRed_CheckedChanged);
            // 
            // radiobGreen
            // 
            this.radiobGreen.AutoSize = true;
            this.radiobGreen.Location = new System.Drawing.Point(117, 172);
            this.radiobGreen.Name = "radiobGreen";
            this.radiobGreen.Size = new System.Drawing.Size(76, 23);
            this.radiobGreen.TabIndex = 2;
            this.radiobGreen.TabStop = true;
            this.radiobGreen.Text = "Green";
            this.radiobGreen.UseVisualStyleBackColor = true;
            this.radiobGreen.CheckedChanged += new System.EventHandler(this.radiobGreen_CheckedChanged);
            // 
            // radiobBlue
            // 
            this.radiobBlue.AutoSize = true;
            this.radiobBlue.Location = new System.Drawing.Point(117, 226);
            this.radiobBlue.Name = "radiobBlue";
            this.radiobBlue.Size = new System.Drawing.Size(64, 23);
            this.radiobBlue.TabIndex = 3;
            this.radiobBlue.TabStop = true;
            this.radiobBlue.Text = "Blue\r\n";
            this.radiobBlue.UseVisualStyleBackColor = true;
            this.radiobBlue.CheckedChanged += new System.EventHandler(this.radiobBlue_CheckedChanged);
            // 
            // radiobYellow
            // 
            this.radiobYellow.AutoSize = true;
            this.radiobYellow.Location = new System.Drawing.Point(117, 280);
            this.radiobYellow.Name = "radiobYellow";
            this.radiobYellow.Size = new System.Drawing.Size(81, 23);
            this.radiobYellow.TabIndex = 4;
            this.radiobYellow.TabStop = true;
            this.radiobYellow.Text = "Yellow";
            this.radiobYellow.UseVisualStyleBackColor = true;
            this.radiobYellow.CheckedChanged += new System.EventHandler(this.radiobYellow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonYellow);
            this.groupBox1.Controls.Add(this.radioButtonBlue);
            this.groupBox1.Controls.Add(this.radioButtonGreen);
            this.groupBox1.Controls.Add(this.radioButtonRed);
            this.groupBox1.Location = new System.Drawing.Point(352, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "group radio";
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Location = new System.Drawing.Point(19, 159);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(81, 23);
            this.radioButtonYellow.TabIndex = 3;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yellow";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            this.radioButtonYellow.CheckedChanged += new System.EventHandler(this.radioButtonYellow_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(19, 105);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(64, 23);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(19, 64);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(76, 23);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(19, 27);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(61, 23);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(399, 376);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 31);
            this.buttonback.TabIndex = 6;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radiobYellow);
            this.Controls.Add(this.radiobBlue);
            this.Controls.Add(this.radiobGreen);
            this.Controls.Add(this.radiobRed);
            this.Controls.Add(this.button1Rest);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Rest;
        private System.Windows.Forms.RadioButton radiobRed;
        private System.Windows.Forms.RadioButton radiobGreen;
        private System.Windows.Forms.RadioButton radiobBlue;
        private System.Windows.Forms.RadioButton radiobYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Button buttonback;
    }
}