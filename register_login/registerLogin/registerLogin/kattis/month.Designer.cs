namespace registerLogin.kattis
{
    partial class month
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
            this.txt_user_input = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_user_input
            // 
            this.txt_user_input.Location = new System.Drawing.Point(325, 51);
            this.txt_user_input.Name = "txt_user_input";
            this.txt_user_input.Size = new System.Drawing.Size(132, 22);
            this.txt_user_input.TabIndex = 0;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(359, 104);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.txt_user_input);
            this.Name = "month";
            this.Text = "month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user_input;
        private System.Windows.Forms.Button btn_click;
    }
}