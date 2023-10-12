namespace Windows_Forms
{
    partial class Form6
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
            textBoxDate = new TextBox();
            textBoxResult = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(284, 211);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(203, 27);
            textBoxDate.TabIndex = 0;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(284, 259);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(203, 27);
            textBoxResult.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(345, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += btnCheckDay_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxDate);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDate;
        private TextBox textBoxResult;
        private Button button1;
    }
}