
namespace WindowsFormsApp323232
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
            this.label1log = new System.Windows.Forms.Label();
            this.label2user = new System.Windows.Forms.Label();
            this.label3pass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1log = new System.Windows.Forms.Button();
            this.button1radio = new System.Windows.Forms.Button();
            this.button2food = new System.Windows.Forms.Button();
            this.button3combo = new System.Windows.Forms.Button();
            this.button4array = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button2randcombo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1log
            // 
            this.label1log.AutoSize = true;
            this.label1log.Location = new System.Drawing.Point(51, 44);
            this.label1log.Name = "label1log";
            this.label1log.Size = new System.Drawing.Size(44, 38);
            this.label1log.TabIndex = 0;
            this.label1log.Text = "login\r\n\r\n";
            // 
            // label2user
            // 
            this.label2user.AutoSize = true;
            this.label2user.Location = new System.Drawing.Point(51, 99);
            this.label2user.Name = "label2user";
            this.label2user.Size = new System.Drawing.Size(78, 19);
            this.label2user.TabIndex = 1;
            this.label2user.Text = "username";
            // 
            // label3pass
            // 
            this.label3pass.AutoSize = true;
            this.label3pass.Location = new System.Drawing.Point(51, 165);
            this.label3pass.Name = "label3pass";
            this.label3pass.Size = new System.Drawing.Size(76, 19);
            this.label3pass.TabIndex = 2;
            this.label3pass.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 4;
            // 
            // button1log
            // 
            this.button1log.Location = new System.Drawing.Point(188, 300);
            this.button1log.Name = "button1log";
            this.button1log.Size = new System.Drawing.Size(75, 31);
            this.button1log.TabIndex = 5;
            this.button1log.Text = "login\r\n";
            this.button1log.UseVisualStyleBackColor = true;
            this.button1log.Click += new System.EventHandler(this.button1log_Click);
            // 
            // button1radio
            // 
            this.button1radio.Location = new System.Drawing.Point(393, 29);
            this.button1radio.Name = "button1radio";
            this.button1radio.Size = new System.Drawing.Size(170, 30);
            this.button1radio.TabIndex = 6;
            this.button1radio.Text = "Radio\r\n";
            this.button1radio.UseVisualStyleBackColor = true;
            this.button1radio.Click += new System.EventHandler(this.button1radio_Click);
            // 
            // button2food
            // 
            this.button2food.Location = new System.Drawing.Point(393, 96);
            this.button2food.Name = "button2food";
            this.button2food.Size = new System.Drawing.Size(170, 32);
            this.button2food.TabIndex = 7;
            this.button2food.Text = "Food";
            this.button2food.UseVisualStyleBackColor = true;
            this.button2food.Click += new System.EventHandler(this.button2food_Click);
            // 
            // button3combo
            // 
            this.button3combo.Location = new System.Drawing.Point(393, 182);
            this.button3combo.Name = "button3combo";
            this.button3combo.Size = new System.Drawing.Size(170, 35);
            this.button3combo.TabIndex = 8;
            this.button3combo.Text = "Combo";
            this.button3combo.UseVisualStyleBackColor = true;
            this.button3combo.Click += new System.EventHandler(this.button3combo_Click);
            // 
            // button4array
            // 
            this.button4array.Location = new System.Drawing.Point(393, 384);
            this.button4array.Name = "button4array";
            this.button4array.Size = new System.Drawing.Size(170, 48);
            this.button4array.TabIndex = 9;
            this.button4array.Text = "Array";
            this.button4array.UseVisualStyleBackColor = true;
            this.button4array.Click += new System.EventHandler(this.button4array_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(393, 258);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(170, 36);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Random\r\n";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1random_Click);
            // 
            // button2randcombo
            // 
            this.button2randcombo.Location = new System.Drawing.Point(393, 325);
            this.button2randcombo.Name = "button2randcombo";
            this.button2randcombo.Size = new System.Drawing.Size(170, 35);
            this.button2randcombo.TabIndex = 11;
            this.button2randcombo.Text = "Random Combo";
            this.button2randcombo.UseVisualStyleBackColor = true;
            this.button2randcombo.Click += new System.EventHandler(this.button2randcombo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2randcombo);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.button4array);
            this.Controls.Add(this.button3combo);
            this.Controls.Add(this.button2food);
            this.Controls.Add(this.button1radio);
            this.Controls.Add(this.button1log);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3pass);
            this.Controls.Add(this.label2user);
            this.Controls.Add(this.label1log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1log;
        private System.Windows.Forms.Label label2user;
        private System.Windows.Forms.Label label3pass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1log;
        private System.Windows.Forms.Button button1radio;
        private System.Windows.Forms.Button button2food;
        private System.Windows.Forms.Button button3combo;
        private System.Windows.Forms.Button button4array;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button2randcombo;
    }
}

