namespace WinFormsAppIDValidator
{
    partial class IDValidatorForm
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
            label1 = new Label();
            txtIDNumber = new TextBox();
            btnValidate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 54);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter ID Number";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(152, 84);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(226, 23);
            txtIDNumber.TabIndex = 1;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(211, 125);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click_1;
            // 
            // IDValidatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnValidate);
            Controls.Add(txtIDNumber);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "IDValidatorForm";
            Text = "ID Number Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDNumber;
        private Button btnValidate;
    }
}