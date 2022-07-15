using System.ComponentModel;

namespace DLLTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 426);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.ExitButton.Location = new System.Drawing.Point(68, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(174, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SendButton);
            this.panel2.Controls.Add(this.TextBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 200);
            this.panel2.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Gray;
            this.SendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.SendButton.Location = new System.Drawing.Point(65, 141);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(174, 40);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Gray;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Location = new System.Drawing.Point(3, 3);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(300, 132);
            this.TextBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(354, 489);
            this.MinimumSize = new System.Drawing.Size(354, 489);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ExitButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button SendButton;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox1;

        #endregion
    }
}