namespace WinFormsWelcomeApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHello = new Label();
            txtName = new TextBox();
            btnHello = new Button();
            SuspendLayout();
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHello.Location = new Point(295, 38);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(208, 37);
            lblHello.TabIndex = 0;
            lblHello.Text = "Как вас зовут?";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20F);
            txtName.Location = new Point(197, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(408, 43);
            txtName.TabIndex = 1;
            // 
            // btnHello
            // 
            btnHello.BackColor = Color.Lime;
            btnHello.Font = new Font("Segoe UI", 20F);
            btnHello.Location = new Point(197, 197);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(408, 72);
            btnHello.TabIndex = 2;
            btnHello.Text = "Привет";
            btnHello.UseVisualStyleBackColor = false;
            btnHello.Click += btnHello_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHello);
            Controls.Add(txtName);
            Controls.Add(lblHello);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "Первая программа на WinForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHello;
        private TextBox txtName;
        private Button btnHello;
    }
}
