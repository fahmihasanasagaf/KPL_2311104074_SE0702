namespace Tp3_kpl_GUI
{
    partial class Form1
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
            textBoxInput = new TextBox();
            buttonSubmit = new Button();
            labelOutput = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(284, 78);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            textBoxInput.Text = "INPUT";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(435, 77);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(93, 24);
            buttonSubmit.TabIndex = 1;
            buttonSubmit.Text = "KIRIM";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(379, 119);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(53, 15);
            labelOutput.TabIndex = 2;
            labelOutput.Text = "OUTPUT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOutput);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonSubmit;
        private Label labelOutput;
    }
}
