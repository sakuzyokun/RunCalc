using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RunCalc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void wcalc_btn_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            var expr = numBox.Text?.Trim();
            if (string.IsNullOrEmpty(expr))
                return;

            try
            {
                var dt = new System.Data.DataTable();
                // Evaluate the expression using DataTable.Compute
                var value = dt.Compute(expr, "");
                anserBox.AppendText($"{expr} = {value}{Environment.NewLine}");
                // 成功したら入力欄の内容を消す
                this.numBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "式を評価できません: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // ビープ音を防ぐ
                // Enter が押されたら計算ボタンの処理を呼ぶ
                calcButton_Click(this.calcButton, EventArgs.Empty);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // フォームを閉じたらアプリケーション全体を終了する
            Application.Exit();
        }
    }
}
