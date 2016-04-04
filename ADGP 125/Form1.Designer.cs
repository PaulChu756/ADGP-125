namespace ADGP_125
{
    partial class Form1
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.AnimalBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(34, 78);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(130, 20);
            this.UserName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(77, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Location = new System.Drawing.Point(49, 167);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(96, 23);
            this.createPlayerButton.TabIndex = 2;
            this.createPlayerButton.Text = "Create Player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // AnimalBox
            // 
            this.AnimalBox.FormattingEnabled = true;
            this.AnimalBox.Items.AddRange(new object[] {
            "Panda",
            "Red Panda",
            "Fox",
            "Brown Bear",
            "Polar Bear",
            "Wolverine "});
            this.AnimalBox.Location = new System.Drawing.Point(34, 123);
            this.AnimalBox.Name = "AnimalBox";
            this.AnimalBox.Size = new System.Drawing.Size(121, 21);
            this.AnimalBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Animal Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnimalBox);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.ComboBox AnimalBox;
        private System.Windows.Forms.Label label1;
    }
}

