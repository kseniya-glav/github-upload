
namespace TestControlApplication
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorControl1 = new LabControls.ColorControl();
            this.colorControl2 = new LabControls.ColorControl();
            this.SuspendLayout();
            // 
            // colorControl1
            // 
            this.colorControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorControl1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorControl1.Location = new System.Drawing.Point(12, 12);
            this.colorControl1.Name = "colorControl1";
            this.colorControl1.Size = new System.Drawing.Size(630, 167);
            this.colorControl1.TabIndex = 0;
            // 
            // colorControl2
            // 
            this.colorControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorControl2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.colorControl2.Location = new System.Drawing.Point(12, 204);
            this.colorControl2.Name = "colorControl2";
            this.colorControl2.Size = new System.Drawing.Size(630, 167);
            this.colorControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 406);
            this.Controls.Add(this.colorControl2);
            this.Controls.Add(this.colorControl1);
            this.Name = "Form1";
            this.Text = "RGB";
            this.ResumeLayout(false);

        }

        #endregion

        private LabControls.ColorControl colorControl1;
        private LabControls.ColorControl colorControl2;
    }
}

