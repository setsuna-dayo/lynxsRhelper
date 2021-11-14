
namespace lynxsRhelper
{
    partial class formatter
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxspace = new System.Windows.Forms.CheckBox();
            this.checkBoxr = new System.Windows.Forms.CheckBox();
            this.checkBoxt = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(339, 383);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "处理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxspace
            // 
            this.checkBoxspace.AutoSize = true;
            this.checkBoxspace.Checked = true;
            this.checkBoxspace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxspace.Location = new System.Drawing.Point(358, 14);
            this.checkBoxspace.Name = "checkBoxspace";
            this.checkBoxspace.Size = new System.Drawing.Size(89, 19);
            this.checkBoxspace.TabIndex = 2;
            this.checkBoxspace.Text = "清除空格";
            this.checkBoxspace.UseVisualStyleBackColor = true;
            // 
            // checkBoxr
            // 
            this.checkBoxr.AutoSize = true;
            this.checkBoxr.Checked = true;
            this.checkBoxr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxr.Location = new System.Drawing.Point(358, 40);
            this.checkBoxr.Name = "checkBoxr";
            this.checkBoxr.Size = new System.Drawing.Size(89, 19);
            this.checkBoxr.TabIndex = 3;
            this.checkBoxr.Text = "清除换行";
            this.checkBoxr.UseVisualStyleBackColor = true;
            // 
            // checkBoxt
            // 
            this.checkBoxt.AutoSize = true;
            this.checkBoxt.Checked = true;
            this.checkBoxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxt.Location = new System.Drawing.Point(358, 66);
            this.checkBoxt.Name = "checkBoxt";
            this.checkBoxt.Size = new System.Drawing.Size(104, 19);
            this.checkBoxt.TabIndex = 4;
            this.checkBoxt.Text = "清除制表符";
            this.checkBoxt.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(358, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 34);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "处理后\r\n自动复制";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(358, 280);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 34);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "处理前\r\n自动粘贴";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "效果预览窗：";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(358, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 34);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "替换为\r\n中文符号";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(358, 164);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 34);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "替换为\r\n英文符号";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // formatter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(481, 440);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxt);
            this.Controls.Add(this.checkBoxr);
            this.Controls.Add(this.checkBoxspace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "formatter";
            this.Text = "从pdf里面复制出来的文字的格式化小工具";
            this.Load += new System.EventHandler(this.formatter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxspace;
        private System.Windows.Forms.CheckBox checkBoxr;
        private System.Windows.Forms.CheckBox checkBoxt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}