namespace RunCalc
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.calcButton = new System.Windows.Forms.Button();
            this.numBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.anserBox = new System.Windows.Forms.TextBox();
            this.wcalc_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(283, 312);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calc";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(12, 316);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(265, 19);
            this.numBox.TabIndex = 1;
            this.numBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numBox_KeyDown);
            // 
            // anserBox
            // 
            this.anserBox.Location = new System.Drawing.Point(12, 41);
            this.anserBox.Multiline = true;
            this.anserBox.Name = "anserBox";
            this.anserBox.ReadOnly = true;
            this.anserBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.anserBox.Size = new System.Drawing.Size(346, 265);
            this.anserBox.TabIndex = 2;
            // 
            // wcalc_btn
            // 
            this.wcalc_btn.Location = new System.Drawing.Point(12, 12);
            this.wcalc_btn.Name = "wcalc_btn";
            this.wcalc_btn.Size = new System.Drawing.Size(96, 23);
            this.wcalc_btn.TabIndex = 3;
            this.wcalc_btn.Text = "Windows Calc";
            this.wcalc_btn.UseVisualStyleBackColor = true;
            this.wcalc_btn.Click += new System.EventHandler(this.wcalc_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(114, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Close";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 347);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.wcalc_btn);
            this.Controls.Add(this.anserBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.calcButton);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunCalc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox anserBox;
        private System.Windows.Forms.Button wcalc_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}