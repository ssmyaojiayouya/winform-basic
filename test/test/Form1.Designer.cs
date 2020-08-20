namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jizhumima_checkBox1 = new System.Windows.Forms.CheckBox();
            this.zhuce = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.zhanghao_comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mima
            // 
            this.mima.Location = new System.Drawing.Point(346, 158);
            this.mima.Name = "mima";
            this.mima.PasswordChar = '*';
            this.mima.Size = new System.Drawing.Size(121, 25);
            this.mima.TabIndex = 2;
            this.mima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mima_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // jizhumima_checkBox1
            // 
            this.jizhumima_checkBox1.AutoSize = true;
            this.jizhumima_checkBox1.Location = new System.Drawing.Point(276, 212);
            this.jizhumima_checkBox1.Name = "jizhumima_checkBox1";
            this.jizhumima_checkBox1.Size = new System.Drawing.Size(89, 19);
            this.jizhumima_checkBox1.TabIndex = 5;
            this.jizhumima_checkBox1.Text = "记住密码";
            this.jizhumima_checkBox1.UseVisualStyleBackColor = true;
            // 
            // zhuce
            // 
            this.zhuce.AutoSize = true;
            this.zhuce.Location = new System.Drawing.Point(425, 212);
            this.zhuce.Name = "zhuce";
            this.zhuce.Size = new System.Drawing.Size(37, 15);
            this.zhuce.TabIndex = 6;
            this.zhuce.TabStop = true;
            this.zhuce.Text = "注册";
            this.zhuce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zhuce_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zhanghao_comboBox1
            // 
            this.zhanghao_comboBox1.FormattingEnabled = true;
            this.zhanghao_comboBox1.Location = new System.Drawing.Point(346, 121);
            this.zhanghao_comboBox1.Name = "zhanghao_comboBox1";
            this.zhanghao_comboBox1.Size = new System.Drawing.Size(121, 23);
            this.zhanghao_comboBox1.TabIndex = 8;
            this.zhanghao_comboBox1.SelectedValueChanged += new System.EventHandler(this.zhanghao_comboBox1_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.zhanghao_comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zhuce);
            this.Controls.Add(this.jizhumima_checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox mima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox jizhumima_checkBox1;
        private System.Windows.Forms.LinkLabel zhuce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox zhanghao_comboBox1;
    }
}

