namespace EmployeeClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.positionInfoLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.deptInfoLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.idNumLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.positionInfoLabel);
            this.groupBox1.Controls.Add(this.positionLabel);
            this.groupBox1.Controls.Add(this.deptInfoLabel);
            this.groupBox1.Controls.Add(this.deptLabel);
            this.groupBox1.Controls.Add(this.idNumLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(284, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // positionInfoLabel
            // 
            this.positionInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionInfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.positionInfoLabel.Location = new System.Drawing.Point(126, 109);
            this.positionInfoLabel.Name = "positionInfoLabel";
            this.positionInfoLabel.Size = new System.Drawing.Size(133, 23);
            this.positionInfoLabel.TabIndex = 6;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.positionLabel.Location = new System.Drawing.Point(34, 114);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(75, 18);
            this.positionLabel.TabIndex = 5;
            this.positionLabel.Text = "Position:";
            // 
            // deptInfoLabel
            // 
            this.deptInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deptInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptInfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deptInfoLabel.Location = new System.Drawing.Point(126, 68);
            this.deptInfoLabel.Name = "deptInfoLabel";
            this.deptInfoLabel.Size = new System.Drawing.Size(133, 23);
            this.deptInfoLabel.TabIndex = 4;
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deptLabel.Location = new System.Drawing.Point(9, 68);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(100, 18);
            this.deptLabel.TabIndex = 3;
            this.deptLabel.Text = "Department:";
            // 
            // idNumLabel
            // 
            this.idNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idNumLabel.Location = new System.Drawing.Point(126, 25);
            this.idNumLabel.Name = "idNumLabel";
            this.idNumLabel.Size = new System.Drawing.Size(133, 23);
            this.idNumLabel.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idLabel.Location = new System.Drawing.Point(16, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(93, 18);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID Number:";
            // 
            // nameListBox
            // 
            this.nameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 16;
            this.nameListBox.Location = new System.Drawing.Point(33, 71);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(169, 148);
            this.nameListBox.TabIndex = 1;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instructionLabel.Location = new System.Drawing.Point(123, 21);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(310, 18);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Select an Employee to Display the Data.";
            // 
            // getInfoButton
            // 
            this.getInfoButton.BackgroundImage = global::EmployeeClass.Properties.Resources.button;
            this.getInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInfoButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getInfoButton.Location = new System.Drawing.Point(69, 256);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(133, 70);
            this.getInfoButton.TabIndex = 3;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clearButton.Image = global::EmployeeClass.Properties.Resources.button;
            this.clearButton.Location = new System.Drawing.Point(239, 256);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 70);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exitButton.Image = global::EmployeeClass.Properties.Resources.button;
            this.exitButton.Location = new System.Drawing.Point(410, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 70);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(625, 338);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Employee Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label positionInfoLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label deptInfoLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label idNumLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

