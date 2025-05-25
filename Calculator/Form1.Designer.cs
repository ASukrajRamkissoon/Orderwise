using System.Windows.Forms;

namespace OrderwiseTest
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
      this.btn_add = new System.Windows.Forms.Button();
      this.btn_subtract = new System.Windows.Forms.Button();
      this.btn_multiply = new System.Windows.Forms.Button();
      this.btn_divide = new System.Windows.Forms.Button();
      this.btn_equals = new System.Windows.Forms.Button();
      this.btn_1 = new System.Windows.Forms.Button();
      this.btn_2 = new System.Windows.Forms.Button();
      this.btn_3 = new System.Windows.Forms.Button();
      this.btn_4 = new System.Windows.Forms.Button();
      this.btn_5 = new System.Windows.Forms.Button();
      this.btn_6 = new System.Windows.Forms.Button();
      this.btn_7 = new System.Windows.Forms.Button();
      this.btn_8 = new System.Windows.Forms.Button();
      this.btn_9 = new System.Windows.Forms.Button();
      this.btn_0 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btn_clear = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btn_add
      // 
      this.btn_add.Location = new System.Drawing.Point(38, 127);
      this.btn_add.Name = "btn_add";
      this.btn_add.Size = new System.Drawing.Size(124, 72);
      this.btn_add.TabIndex = 0;
      this.btn_add.Text = "+";
      this.btn_add.UseVisualStyleBackColor = true;
      this.btn_add.Click += new System.EventHandler(this.Operator_Click);
      // 
      // btn_subtract
      // 
      this.btn_subtract.Location = new System.Drawing.Point(188, 127);
      this.btn_subtract.Name = "btn_subtract";
      this.btn_subtract.Size = new System.Drawing.Size(124, 72);
      this.btn_subtract.TabIndex = 1;
      this.btn_subtract.Text = "-";
      this.btn_subtract.UseVisualStyleBackColor = true;
      this.btn_subtract.Click += new System.EventHandler(this.Operator_Click);
      // 
      // btn_multiply
      // 
      this.btn_multiply.Location = new System.Drawing.Point(340, 127);
      this.btn_multiply.Name = "btn_multiply";
      this.btn_multiply.Size = new System.Drawing.Size(124, 72);
      this.btn_multiply.TabIndex = 2;
      this.btn_multiply.Text = "*";
      this.btn_multiply.UseVisualStyleBackColor = true;
      this.btn_multiply.Click += new System.EventHandler(this.Operator_Click);
      // 
      // btn_divide
      // 
      this.btn_divide.Location = new System.Drawing.Point(495, 127);
      this.btn_divide.Name = "btn_divide";
      this.btn_divide.Size = new System.Drawing.Size(124, 72);
      this.btn_divide.TabIndex = 3;
      this.btn_divide.Text = "/";
      this.btn_divide.UseVisualStyleBackColor = true;
      this.btn_divide.Click += new System.EventHandler(this.Operator_Click);
      // 
      // btn_equals
      // 
      this.btn_equals.Location = new System.Drawing.Point(648, 127);
      this.btn_equals.Name = "btn_equals";
      this.btn_equals.Size = new System.Drawing.Size(124, 253);
      this.btn_equals.TabIndex = 4;
      this.btn_equals.Text = "=";
      this.btn_equals.UseVisualStyleBackColor = true;
      this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
      // 
      // btn_1
      // 
      this.btn_1.Location = new System.Drawing.Point(188, 217);
      this.btn_1.Name = "btn_1";
      this.btn_1.Size = new System.Drawing.Size(124, 72);
      this.btn_1.TabIndex = 5;
      this.btn_1.Text = "1";
      this.btn_1.UseVisualStyleBackColor = true;
      this.btn_1.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_2
      // 
      this.btn_2.Location = new System.Drawing.Point(340, 217);
      this.btn_2.Name = "btn_2";
      this.btn_2.Size = new System.Drawing.Size(124, 72);
      this.btn_2.TabIndex = 6;
      this.btn_2.Text = "2";
      this.btn_2.UseVisualStyleBackColor = true;
      this.btn_2.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_3
      // 
      this.btn_3.Location = new System.Drawing.Point(495, 217);
      this.btn_3.Name = "btn_3";
      this.btn_3.Size = new System.Drawing.Size(124, 72);
      this.btn_3.TabIndex = 7;
      this.btn_3.Text = "3";
      this.btn_3.UseVisualStyleBackColor = true;
      this.btn_3.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_4
      // 
      this.btn_4.Location = new System.Drawing.Point(188, 308);
      this.btn_4.Name = "btn_4";
      this.btn_4.Size = new System.Drawing.Size(124, 72);
      this.btn_4.TabIndex = 8;
      this.btn_4.Text = "4";
      this.btn_4.UseVisualStyleBackColor = true;
      this.btn_4.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_5
      // 
      this.btn_5.Location = new System.Drawing.Point(340, 308);
      this.btn_5.Name = "btn_5";
      this.btn_5.Size = new System.Drawing.Size(124, 72);
      this.btn_5.TabIndex = 9;
      this.btn_5.Text = "5";
      this.btn_5.UseVisualStyleBackColor = true;
      this.btn_5.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_6
      // 
      this.btn_6.Location = new System.Drawing.Point(495, 308);
      this.btn_6.Name = "btn_6";
      this.btn_6.Size = new System.Drawing.Size(124, 72);
      this.btn_6.TabIndex = 10;
      this.btn_6.Text = "6";
      this.btn_6.UseVisualStyleBackColor = true;
      this.btn_6.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_7
      // 
      this.btn_7.Location = new System.Drawing.Point(188, 402);
      this.btn_7.Name = "btn_7";
      this.btn_7.Size = new System.Drawing.Size(124, 72);
      this.btn_7.TabIndex = 11;
      this.btn_7.Text = "7";
      this.btn_7.UseVisualStyleBackColor = true;
      this.btn_7.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_8
      // 
      this.btn_8.Location = new System.Drawing.Point(340, 402);
      this.btn_8.Name = "btn_8";
      this.btn_8.Size = new System.Drawing.Size(124, 72);
      this.btn_8.TabIndex = 12;
      this.btn_8.Text = "8";
      this.btn_8.UseVisualStyleBackColor = true;
      this.btn_8.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_9
      // 
      this.btn_9.Location = new System.Drawing.Point(495, 402);
      this.btn_9.Name = "btn_9";
      this.btn_9.Size = new System.Drawing.Size(124, 72);
      this.btn_9.TabIndex = 13;
      this.btn_9.Text = "9";
      this.btn_9.UseVisualStyleBackColor = true;
      this.btn_9.Click += new System.EventHandler(this.Number_Click);
      // 
      // btn_0
      // 
      this.btn_0.Location = new System.Drawing.Point(38, 402);
      this.btn_0.Name = "btn_0";
      this.btn_0.Size = new System.Drawing.Size(124, 72);
      this.btn_0.TabIndex = 14;
      this.btn_0.Text = "0";
      this.btn_0.UseVisualStyleBackColor = true;
      this.btn_0.Click += new System.EventHandler(this.Number_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(38, 30);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(734, 70);
      this.textBox1.TabIndex = 15;
      // 
      // btn_clear
      // 
      this.btn_clear.Location = new System.Drawing.Point(648, 402);
      this.btn_clear.Name = "btn_clear";
      this.btn_clear.Size = new System.Drawing.Size(124, 72);
      this.btn_clear.TabIndex = 16;
      this.btn_clear.Text = "CLR";
      this.btn_clear.UseVisualStyleBackColor = true;
      this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(491, 531);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(274, 20);
      this.label1.TabIndex = 17;
      this.label1.Text = "@AjnaSukraj-Ramkisson <- click here";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 583);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btn_clear);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btn_0);
      this.Controls.Add(this.btn_9);
      this.Controls.Add(this.btn_8);
      this.Controls.Add(this.btn_7);
      this.Controls.Add(this.btn_6);
      this.Controls.Add(this.btn_5);
      this.Controls.Add(this.btn_4);
      this.Controls.Add(this.btn_3);
      this.Controls.Add(this.btn_2);
      this.Controls.Add(this.btn_1);
      this.Controls.Add(this.btn_equals);
      this.Controls.Add(this.btn_divide);
      this.Controls.Add(this.btn_multiply);
      this.Controls.Add(this.btn_subtract);
      this.Controls.Add(this.btn_add);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.Button btn_subtract;
    private System.Windows.Forms.Button btn_multiply;
    private System.Windows.Forms.Button btn_divide;
    private System.Windows.Forms.Button btn_equals;
    private System.Windows.Forms.Button btn_1;
    private System.Windows.Forms.Button btn_2;
    private System.Windows.Forms.Button btn_3;
    private System.Windows.Forms.Button btn_4;
    private System.Windows.Forms.Button btn_5;
    private System.Windows.Forms.Button btn_6;
    private System.Windows.Forms.Button btn_7;
    private System.Windows.Forms.Button btn_8;
    private System.Windows.Forms.Button btn_9;
    private System.Windows.Forms.Button btn_0;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btn_clear;
    private System.Windows.Forms.Label label1;
  }
}

