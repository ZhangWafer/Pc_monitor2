namespace Pc_monitor
{
    partial class login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(556, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(640, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 21);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pc_monitor.Properties.Resources.login_bg2;
            this.button1.Font = new System.Drawing.Font("宋体", 30F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(561, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(557, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Pc_monitor.Properties.Resources.login_bg2;
            this.button2.Font = new System.Drawing.Font("宋体", 30F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(892, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 94);
            this.button2.TabIndex = 6;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pc_monitor.Properties.Resources.login_bg2;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}