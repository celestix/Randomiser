
namespace Randomiser
{
    partial class MainForm
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
            this.MainTitle = new System.Windows.Forms.Label();
            this.randomize = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.ChoicesInputBox = new System.Windows.Forms.TextBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.srcCodeLink = new System.Windows.Forms.LinkLabel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.controlBar = new System.Windows.Forms.Panel();
            this.InputPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.MainTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.MainTitle.Location = new System.Drawing.Point(109, 10);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(215, 45);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Randomiser";
            // 
            // randomize
            // 
            this.randomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.randomize.FlatAppearance.BorderSize = 0;
            this.randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomize.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.randomize.Location = new System.Drawing.Point(240, 175);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(94, 29);
            this.randomize.TabIndex = 3;
            this.randomize.Text = "Randomize";
            this.randomize.UseVisualStyleBackColor = false;
            this.randomize.Click += new System.EventHandler(this.randomize_button);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.aboutButton.Location = new System.Drawing.Point(119, 175);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(94, 29);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.about_button);
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.InputTextLabel.Location = new System.Drawing.Point(37, 17);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(61, 25);
            this.InputTextLabel.TabIndex = 0;
            this.InputTextLabel.Text = "Text:";
            // 
            // ChoicesInputBox
            // 
            this.ChoicesInputBox.Location = new System.Drawing.Point(105, 18);
            this.ChoicesInputBox.Name = "ChoicesInputBox";
            this.ChoicesInputBox.Size = new System.Drawing.Size(291, 27);
            this.ChoicesInputBox.TabIndex = 1;
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.InputPanel.Controls.Add(this.ChoicesInputBox);
            this.InputPanel.Controls.Add(this.InputTextLabel);
            this.InputPanel.Location = new System.Drawing.Point(0, 67);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(401, 41);
            this.InputPanel.TabIndex = 1;
            // 
            // srcCodeLink
            // 
            this.srcCodeLink.AutoSize = true;
            this.srcCodeLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.srcCodeLink.LinkColor = System.Drawing.Color.Red;
            this.srcCodeLink.Location = new System.Drawing.Point(163, 216);
            this.srcCodeLink.Name = "srcCodeLink";
            this.srcCodeLink.Size = new System.Drawing.Size(129, 20);
            this.srcCodeLink.TabIndex = 5;
            this.srcCodeLink.TabStop = true;
            this.srcCodeLink.Text = "View Source Code";
            this.srcCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.srclinkclick);
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BodyPanel.Controls.Add(this.MainTitle);
            this.BodyPanel.Controls.Add(this.InputPanel);
            this.BodyPanel.Location = new System.Drawing.Point(10, 42);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(431, 206);
            this.BodyPanel.TabIndex = 6;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Maroon;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closebtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.closebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closebtn.Location = new System.Drawing.Point(381, 7);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(60, 29);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.close_button);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.Location = new System.Drawing.Point(346, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 29);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.Text = "🗕";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.minimize_button);
            // 
            // controlBar
            // 
            this.controlBar.Location = new System.Drawing.Point(1, -2);
            this.controlBar.Name = "controlBar";
            this.controlBar.Size = new System.Drawing.Size(450, 44);
            this.controlBar.TabIndex = 9;
            this.controlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_bar);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(453, 258);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.srcCodeLink);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.controlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomiser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label InputTextLabel;
        private System.Windows.Forms.TextBox ChoicesInputBox;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.LinkLabel srcCodeLink;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel controlBar;
    }
}

