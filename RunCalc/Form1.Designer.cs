namespace Runcalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.answerLabel = new System.Windows.Forms.Label();
            this.ansisLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.morecalcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cp_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.answerLabel.Location = new System.Drawing.Point(0, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(126, 64);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "Ans";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansisLabel
            // 
            this.ansisLabel.AutoSize = true;
            this.ansisLabel.Location = new System.Drawing.Point(12, 64);
            this.ansisLabel.Name = "ansisLabel";
            this.ansisLabel.Size = new System.Drawing.Size(58, 12);
            this.ansisLabel.TabIndex = 1;
            this.ansisLabel.Text = "Anser is ...";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(153, 170);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // morecalcButton
            // 
            this.morecalcButton.Location = new System.Drawing.Point(72, 170);
            this.morecalcButton.Name = "morecalcButton";
            this.morecalcButton.Size = new System.Drawing.Size(75, 23);
            this.morecalcButton.TabIndex = 3;
            this.morecalcButton.Text = "Calc ...";
            this.morecalcButton.UseVisualStyleBackColor = true;
            this.morecalcButton.Click += new System.EventHandler(this.MorecalcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Can be extended to the right →→";
            // 
            // cp_btn
            // 
            this.cp_btn.Location = new System.Drawing.Point(11, 141);
            this.cp_btn.Name = "cp_btn";
            this.cp_btn.Size = new System.Drawing.Size(75, 23);
            this.cp_btn.TabIndex = 5;
            this.cp_btn.Text = "Copy";
            this.cp_btn.UseVisualStyleBackColor = true;
            this.cp_btn.Click += new System.EventHandler(this.cp_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.cp_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.morecalcButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ansisLabel);
            this.Controls.Add(this.answerLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(32768, 256);
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label ansisLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button morecalcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cp_btn;
    }
}

