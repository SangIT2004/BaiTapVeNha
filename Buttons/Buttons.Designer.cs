namespace Buttons
{
    partial class Buttons
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButtonFlat = new System.Windows.Forms.Button();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.ckbMauNen = new System.Windows.Forms.CheckBox();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.rbPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.ForeColor = System.Drawing.Color.Red;
            this.btnButton.Location = new System.Drawing.Point(83, 70);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(131, 36);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnButtonFlat
            // 
            this.btnButtonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonFlat.ForeColor = System.Drawing.Color.Black;
            this.btnButtonFlat.Location = new System.Drawing.Point(58, 198);
            this.btnButtonFlat.Name = "btnButtonFlat";
            this.btnButtonFlat.Size = new System.Drawing.Size(182, 36);
            this.btnButtonFlat.TabIndex = 1;
            this.btnButtonFlat.Text = "Button Flat";
            this.btnButtonFlat.UseVisualStyleBackColor = true;
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Checked = true;
            this.ckbMauChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMauChu.Location = new System.Drawing.Point(358, 59);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(163, 24);
            this.ckbMauChu.TabIndex = 2;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // ckbMauNen
            // 
            this.ckbMauNen.AutoSize = true;
            this.ckbMauNen.Checked = true;
            this.ckbMauNen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMauNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMauNen.Location = new System.Drawing.Point(358, 98);
            this.ckbMauNen.Name = "ckbMauNen";
            this.ckbMauNen.Size = new System.Drawing.Size(163, 24);
            this.ckbMauNen.TabIndex = 3;
            this.ckbMauNen.Text = "Thay đổi màu nền";
            this.ckbMauNen.UseVisualStyleBackColor = true;
            this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Checked = true;
            this.rbFlat.Location = new System.Drawing.Point(358, 189);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(79, 20);
            this.rbFlat.TabIndex = 4;
            this.rbFlat.Text = "Kiểu Flat";
            this.rbFlat.UseVisualStyleBackColor = true;
            this.rbFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
            // 
            // rbPopup
            // 
            this.rbPopup.AutoSize = true;
            this.rbPopup.Location = new System.Drawing.Point(358, 228);
            this.rbPopup.Name = "rbPopup";
            this.rbPopup.Size = new System.Drawing.Size(97, 20);
            this.rbPopup.TabIndex = 5;
            this.rbPopup.Text = "Kiểu Popup";
            this.rbPopup.UseVisualStyleBackColor = true;
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 305);
            this.Controls.Add(this.rbPopup);
            this.Controls.Add(this.rbFlat);
            this.Controls.Add(this.ckbMauNen);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.btnButtonFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "Buttons";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButtonFlat;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.CheckBox ckbMauNen;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.RadioButton rbPopup;
    }
}

