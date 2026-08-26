using RunCalc;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace Runcalc
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();

            if (args.Length == 0)
            {
                answerLabel.Text = "No expression";
                return;
            }

            string expr = string.Join("", args);

            try
            {
                var result = new DataTable().Compute(expr, null);
                answerLabel.Text = result.ToString();
                Clipboard.SetText(result.ToString());
            }
            catch
            {
                answerLabel.Text = "Error";
            }

            // ボタンイベント
            closeButton.Click += CloseButton_Click;
            morecalcButton.Click += MorecalcButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MorecalcButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void cp_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(answerLabel.Text);
            cp_btn.Text = "Copied!";
        }
    }
}