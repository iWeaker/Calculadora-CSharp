namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.equalBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.closeEcBtn = new System.Windows.Forms.Button();
            this.openEcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(28, 148);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 35);
            this.num7.TabIndex = 0;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.setNum);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(109, 148);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 35);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.setNum);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(190, 148);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 35);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.setNum);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(28, 189);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 36);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.setNum);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(109, 189);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 36);
            this.num5.TabIndex = 4;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.setNum);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(190, 189);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 36);
            this.num6.TabIndex = 5;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.setNum);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(28, 231);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 37);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.setNum);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(109, 231);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 37);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.setNum);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(190, 231);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 37);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.setNum);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(28, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(327, 35);
            this.textBox1.TabIndex = 10;
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(190, 274);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(75, 37);
            this.equalBtn.TabIndex = 11;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.totalFunction);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(280, 274);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 37);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.typeFunction);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(280, 231);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 37);
            this.subBtn.TabIndex = 13;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.typeFunction);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(280, 106);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 36);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearFunction);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(28, 274);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 37);
            this.num0.TabIndex = 15;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.setNum);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Location = new System.Drawing.Point(109, 274);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(75, 37);
            this.decimalBtn.TabIndex = 16;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalFunction);
            // 
            // multiBtn
            // 
            this.multiBtn.Location = new System.Drawing.Point(280, 189);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(75, 36);
            this.multiBtn.TabIndex = 17;
            this.multiBtn.Text = "*";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.typeFunction);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(280, 148);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 35);
            this.divBtn.TabIndex = 18;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.typeFunction);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(190, 106);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 36);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Atras";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backFunction);
            // 
            // closeEcBtn
            // 
            this.closeEcBtn.Location = new System.Drawing.Point(109, 106);
            this.closeEcBtn.Name = "closeEcBtn";
            this.closeEcBtn.Size = new System.Drawing.Size(75, 36);
            this.closeEcBtn.TabIndex = 20;
            this.closeEcBtn.Text = ")";
            this.closeEcBtn.UseVisualStyleBackColor = true;
            // 
            // openEcBtn
            // 
            this.openEcBtn.Location = new System.Drawing.Point(28, 106);
            this.openEcBtn.Name = "openEcBtn";
            this.openEcBtn.Size = new System.Drawing.Size(75, 36);
            this.openEcBtn.TabIndex = 21;
            this.openEcBtn.Text = "(";
            this.openEcBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 335);
            this.Controls.Add(this.openEcBtn);
            this.Controls.Add(this.closeEcBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button num7;
        private Button num8;
        private Button num9;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button num1;
        private Button num2;
        private Button num3;
        private TextBox textBox1;
        private Button equalBtn;
        private Button addBtn;
        private Button subBtn;
        private Button clearBtn;
        private Button num0;
        private Button decimalBtn;
        private Button multiBtn;
        private Button divBtn;
        private Button backBtn;
        private Button closeEcBtn;
        private Button openEcBtn;
    }
}