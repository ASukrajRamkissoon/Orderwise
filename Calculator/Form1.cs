using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// -----------------------------------------------------------------------------
// Author: Ajna Sukraj-Ramkissoon
// Created: 2025-05-23
// Description: Windows Forms Calculator Application. 
// See documentation and unit tests included.
// -----------------------------------------------------------------------------


namespace OrderwiseTest
{
  public partial class Form1 : Form
  {

    private Calculator calc = new Calculator();
    private bool newEntry = true;

    public Form1()
    {
      InitializeComponent();
      this.KeyDown += new KeyEventHandler(Form1_KeyDown);

    }

    private void Form1_Load(object sender, EventArgs e)
    {

      textBox1.Text = "";

    }

    private void Number_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;

      if (newEntry)
        textBox1.Text = "";

      textBox1.Text += btn.Text;
      newEntry = false;
    }

    private void Operator_Click(object sender, EventArgs e)
    {
      if (double.TryParse(textBox1.Text, out double num))
      {
        calc.SetNumber(num);

        if (calc.IsOperationSet())
        {
          double result = calc.Calculate();
          textBox1.Text = result.ToString();
        }

        calc.SetOperation((sender as Button).Text);
        newEntry = true;
      }
    }


    private void btn_equals_Click(object sender, EventArgs e)
    {
      if (double.TryParse(textBox1.Text, out double num))
      {
        calc.SetNumber(num);

        try
        {
          double result = calc.Calculate();
          textBox1.Text = result.ToString();
        }
        catch (Exception ex)
        {
          textBox1.Text = "Error: " + ex.Message;
        }

        newEntry = true;
      }
    }
    private void btn_clear_Click(object sender, EventArgs e)
    {
      textBox1.Text = "";
      calc.Clear();
      newEntry = true;
    }

    //ALLOWS FOR KEYBOARD ENTRIES
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.D0:
        case Keys.NumPad0:
          Number_Click(btn_0, EventArgs.Empty);
          break;
        case Keys.D1:
        case Keys.NumPad1:
          Number_Click(btn_1, EventArgs.Empty);
          break;
        case Keys.D2:
        case Keys.NumPad2:
          Number_Click(btn_2, EventArgs.Empty);
          break;
        case Keys.D3:
        case Keys.NumPad3:
          Number_Click(btn_3, EventArgs.Empty);
          break;
        case Keys.D4:
        case Keys.NumPad4:
          Number_Click(btn_4, EventArgs.Empty);
          break;
        case Keys.D5:
        case Keys.NumPad5:
          Number_Click(btn_5, EventArgs.Empty);
          break;
        case Keys.D6:
        case Keys.NumPad6:
          Number_Click(btn_6, EventArgs.Empty);
          break;
        case Keys.D7:
        case Keys.NumPad7:
          Number_Click(btn_7, EventArgs.Empty);
          break;
        case Keys.D8:
        case Keys.NumPad8:
          Number_Click(btn_8, EventArgs.Empty);
          break;
        case Keys.D9:
        case Keys.NumPad9:
          Number_Click(btn_9, EventArgs.Empty);
          break;
        case Keys.Add:
        case Keys.Oemplus when e.Shift:
          Operator_Click(btn_add, EventArgs.Empty);
          break;
        case Keys.Subtract:
        case Keys.OemMinus:
          Operator_Click(btn_subtract, EventArgs.Empty);
          break;
        case Keys.Multiply:
          Operator_Click(btn_multiply, EventArgs.Empty);
          break;
        case Keys.Divide:
        case Keys.OemQuestion:
          Operator_Click(btn_divide, EventArgs.Empty);
          break;
        case Keys.Enter:
          btn_equals_Click(btn_equals, EventArgs.Empty);
          break;
        case Keys.Back:
          btn_clear_Click(btn_clear, EventArgs.Empty);
          break;
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("You just found Orderwise’s next best developer! 🚀", "Secret Signature");
    }


  }
}
