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
            txtOutput = new TextBox();
            div_btn = new Button();
            mul_btn = new Button();
            add_btn = new Button();
            sub_btn = new Button();
            clear_btn = new Button();
            back_btn = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            equal_btn = new Button();
            btn_0 = new Button();
            point_btn = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(27, 49);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(290, 27);
            txtOutput.TabIndex = 0;
            // 
            // div_btn
            // 
            div_btn.BackColor = Color.DarkOrange;
            div_btn.Location = new Point(249, 98);
            div_btn.Name = "div_btn";
            div_btn.Size = new Size(68, 74);
            div_btn.TabIndex = 4;
            div_btn.Text = "/";
            div_btn.UseVisualStyleBackColor = false;
            div_btn.Click += add_div;
            // 
            // mul_btn
            // 
            mul_btn.BackColor = Color.DarkOrange;
            mul_btn.Location = new Point(249, 178);
            mul_btn.Name = "mul_btn";
            mul_btn.Size = new Size(68, 74);
            mul_btn.TabIndex = 5;
            mul_btn.Text = "X";
            mul_btn.UseVisualStyleBackColor = false;
            mul_btn.Click += add_mul;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.DarkOrange;
            add_btn.Location = new Point(249, 258);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(68, 74);
            add_btn.TabIndex = 6;
            add_btn.Text = "+";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_sum;
            // 
            // sub_btn
            // 
            sub_btn.BackColor = Color.DarkOrange;
            sub_btn.Location = new Point(249, 338);
            sub_btn.Name = "sub_btn";
            sub_btn.Size = new Size(68, 74);
            sub_btn.TabIndex = 7;
            sub_btn.Text = "-";
            sub_btn.UseVisualStyleBackColor = false;
            sub_btn.Click += add_sub;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(27, 98);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(68, 74);
            clear_btn.TabIndex = 1;
            clear_btn.Text = "C";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(101, 98);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(142, 74);
            back_btn.TabIndex = 2;
            back_btn.Text = "CE";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_9.Location = new Point(175, 178);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(68, 74);
            btn_9.TabIndex = 10;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += add_number;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_8.Location = new Point(101, 178);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(68, 74);
            btn_8.TabIndex = 9;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += add_number;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_7.Location = new Point(27, 178);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(68, 74);
            btn_7.TabIndex = 8;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += add_number;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_6.Location = new Point(175, 258);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(68, 74);
            btn_6.TabIndex = 13;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += add_number;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_5.Location = new Point(101, 258);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(68, 74);
            btn_5.TabIndex = 12;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += add_number;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_4.Location = new Point(27, 258);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(68, 74);
            btn_4.TabIndex = 11;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += add_number;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_3.Location = new Point(175, 338);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(68, 74);
            btn_3.TabIndex = 16;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += add_number;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_2.Location = new Point(101, 338);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(68, 74);
            btn_2.TabIndex = 15;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += add_number;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_1.Location = new Point(27, 338);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(68, 74);
            btn_1.TabIndex = 14;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += add_number;
            // 
            // equal_btn
            // 
            equal_btn.BackColor = Color.DarkOrange;
            equal_btn.Location = new Point(175, 418);
            equal_btn.Name = "equal_btn";
            equal_btn.Size = new Size(142, 74);
            equal_btn.TabIndex = 18;
            equal_btn.Text = "=";
            equal_btn.UseVisualStyleBackColor = false;
            equal_btn.Click += equals;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_0.Location = new Point(27, 418);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(68, 74);
            btn_0.TabIndex = 17;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += add_number;
            // 
            // point_btn
            // 
            point_btn.Location = new Point(101, 418);
            point_btn.Name = "point_btn";
            point_btn.Size = new Size(68, 74);
            point_btn.TabIndex = 19;
            point_btn.Text = ".";
            point_btn.UseVisualStyleBackColor = true;
            point_btn.Click += add_point;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(349, 516);
            Controls.Add(point_btn);
            Controls.Add(equal_btn);
            Controls.Add(btn_0);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(sub_btn);
            Controls.Add(add_btn);
            Controls.Add(mul_btn);
            Controls.Add(div_btn);
            Controls.Add(back_btn);
            Controls.Add(clear_btn);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button div_btn;
        private Button mul_btn;
        private Button add_btn;
        private Button sub_btn;
        private Button clear_btn;
        private Button back_btn;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button equal_btn;
        private Button btn_0;
        private Button point_btn;
    }
}
