namespace registerLogin.kattis
{
    partial class ggez
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
            this.txt_text_box = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_text_box
            // 
            this.txt_text_box.Location = new System.Drawing.Point(309, 37);
            this.txt_text_box.Name = "txt_text_box";
            this.txt_text_box.Size = new System.Drawing.Size(151, 22);
            this.txt_text_box.TabIndex = 0;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(347, 103);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "button1";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // ggez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.txt_text_box);
            this.Name = "ggez";
            this.Text = "ggez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_text_box;
        private System.Windows.Forms.Button btn_click;
    }
}