
namespace LabControls
{
    partial class ColorControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cprBlue = new LabControls.ColorParameter(this.components);
            this.cprGreen = new LabControls.ColorParameter(this.components);
            this.cprRed = new LabControls.ColorParameter(this.components);
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.lbBlue = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cprBlue);
            this.splitContainer1.Panel1.Controls.Add(this.cprGreen);
            this.splitContainer1.Panel1.Controls.Add(this.cprRed);
            this.splitContainer1.Panel1.Controls.Add(this.rbHex);
            this.splitContainer1.Panel1.Controls.Add(this.rbDec);
            this.splitContainer1.Panel1.Controls.Add(this.lbBlue);
            this.splitContainer1.Panel1.Controls.Add(this.lbGreen);
            this.splitContainer1.Panel1.Controls.Add(this.lbRed);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbColor);
            this.splitContainer1.Size = new System.Drawing.Size(339, 167);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 0;
            // 
            // cprBlue
            // 
            this.cprBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cprBlue.IsDigit = true;
            this.cprBlue.Location = new System.Drawing.Point(91, 90);
            this.cprBlue.Name = "cprBlue";
            this.cprBlue.Size = new System.Drawing.Size(66, 22);
            this.cprBlue.TabIndex = 11;
            this.cprBlue.Text = "0";
            this.cprBlue.TextChanged += new System.EventHandler(this.cprBlue_TextChanged);
            // 
            // cprGreen
            // 
            this.cprGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cprGreen.IsDigit = true;
            this.cprGreen.Location = new System.Drawing.Point(91, 47);
            this.cprGreen.Name = "cprGreen";
            this.cprGreen.Size = new System.Drawing.Size(66, 22);
            this.cprGreen.TabIndex = 10;
            this.cprGreen.Text = "0";
            this.cprGreen.TextChanged += new System.EventHandler(this.cprGreen_TextChanged);
            // 
            // cprRed
            // 
            this.cprRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cprRed.IsDigit = true;
            this.cprRed.Location = new System.Drawing.Point(91, 6);
            this.cprRed.Name = "cprRed";
            this.cprRed.Size = new System.Drawing.Size(66, 22);
            this.cprRed.TabIndex = 9;
            this.cprRed.Text = "0";
            this.cprRed.TextChanged += new System.EventHandler(this.cprRed_TextChanged);
            // 
            // rbHex
            // 
            this.rbHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(91, 130);
            this.rbHex.Margin = new System.Windows.Forms.Padding(4);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(53, 21);
            this.rbHex.TabIndex = 8;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbDec
            // 
            this.rbDec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDec.AutoSize = true;
            this.rbDec.Checked = true;
            this.rbDec.Location = new System.Drawing.Point(16, 130);
            this.rbDec.Margin = new System.Windows.Forms.Padding(4);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(54, 21);
            this.rbDec.TabIndex = 7;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "Dec";
            this.rbDec.UseVisualStyleBackColor = true;
            this.rbDec.CheckedChanged += new System.EventHandler(this.rbDec_CheckedChanged);
            // 
            // lbBlue
            // 
            this.lbBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBlue.AutoSize = true;
            this.lbBlue.Location = new System.Drawing.Point(4, 90);
            this.lbBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(49, 17);
            this.lbBlue.TabIndex = 6;
            this.lbBlue.Text = "Синий";
            // 
            // lbGreen
            // 
            this.lbGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGreen.AutoSize = true;
            this.lbGreen.Location = new System.Drawing.Point(4, 53);
            this.lbGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(67, 17);
            this.lbGreen.TabIndex = 5;
            this.lbGreen.Text = "Зеленый";
            // 
            // lbRed
            // 
            this.lbRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(4, 11);
            this.lbRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(66, 17);
            this.lbRed.TabIndex = 4;
            this.lbRed.Text = "Красный";
            // 
            // pbColor
            // 
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbColor.Location = new System.Drawing.Point(0, 0);
            this.pbColor.Margin = new System.Windows.Forms.Padding(4);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(170, 167);
            this.pbColor.TabIndex = 7;
            this.pbColor.TabStop = false;
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ColorControl";
            this.Size = new System.Drawing.Size(339, 167);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ColorParameter cprBlue;
        private ColorParameter cprGreen;
        private ColorParameter cprRed;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.PictureBox pbColor;
    }
}
