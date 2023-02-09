namespace Flags.cs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USARadioButton = new System.Windows.Forms.RadioButton();
            this.ColombiaRadioButton = new System.Windows.Forms.RadioButton();
            this.PhilippinesRadioButton = new System.Windows.Forms.RadioButton();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProgrammerCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryNameCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButtonFrance = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonFrance);
            this.groupBox1.Controls.Add(this.USARadioButton);
            this.groupBox1.Controls.Add(this.ColombiaRadioButton);
            this.groupBox1.Controls.Add(this.PhilippinesRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(95, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // USARadioButton
            // 
            this.USARadioButton.AutoSize = true;
            this.USARadioButton.Location = new System.Drawing.Point(18, 75);
            this.USARadioButton.Name = "USARadioButton";
            this.USARadioButton.Size = new System.Drawing.Size(47, 19);
            this.USARadioButton.TabIndex = 2;
            this.USARadioButton.TabStop = true;
            this.USARadioButton.Text = "USA";
            this.USARadioButton.UseVisualStyleBackColor = true;
            this.USARadioButton.CheckedChanged += new System.EventHandler(this.USARadioButton_CheckedChanged);
            // 
            // ColombiaRadioButton
            // 
            this.ColombiaRadioButton.AutoSize = true;
            this.ColombiaRadioButton.Location = new System.Drawing.Point(18, 53);
            this.ColombiaRadioButton.Name = "ColombiaRadioButton";
            this.ColombiaRadioButton.Size = new System.Drawing.Size(77, 19);
            this.ColombiaRadioButton.TabIndex = 1;
            this.ColombiaRadioButton.TabStop = true;
            this.ColombiaRadioButton.Text = "Colombia";
            this.ColombiaRadioButton.UseVisualStyleBackColor = true;
            this.ColombiaRadioButton.CheckedChanged += new System.EventHandler(this.ColombiaRadioButton_CheckedChanged);
            // 
            // PhilippinesRadioButton
            // 
            this.PhilippinesRadioButton.AutoSize = true;
            this.PhilippinesRadioButton.Location = new System.Drawing.Point(18, 28);
            this.PhilippinesRadioButton.Name = "PhilippinesRadioButton";
            this.PhilippinesRadioButton.Size = new System.Drawing.Size(83, 19);
            this.PhilippinesRadioButton.TabIndex = 0;
            this.PhilippinesRadioButton.TabStop = true;
            this.PhilippinesRadioButton.Text = "Philippines";
            this.PhilippinesRadioButton.UseVisualStyleBackColor = true;
            this.PhilippinesRadioButton.CheckedChanged += new System.EventHandler(this.PhilippinesRadioButton_CheckedChanged);
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountryNameLabel.Location = new System.Drawing.Point(373, 229);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(0, 25);
            this.CountryNameLabel.TabIndex = 1;
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgrammerLabel.Location = new System.Drawing.Point(129, 317);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(0, 25);
            this.ProgrammerLabel.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProgrammerCheckBox);
            this.groupBox2.Controls.Add(this.CountryNameCheckBox);
            this.groupBox2.Controls.Add(this.TitleCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(516, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // ProgrammerCheckBox
            // 
            this.ProgrammerCheckBox.AutoSize = true;
            this.ProgrammerCheckBox.Location = new System.Drawing.Point(25, 81);
            this.ProgrammerCheckBox.Name = "ProgrammerCheckBox";
            this.ProgrammerCheckBox.Size = new System.Drawing.Size(93, 19);
            this.ProgrammerCheckBox.TabIndex = 2;
            this.ProgrammerCheckBox.Text = "Programmer";
            this.ProgrammerCheckBox.UseVisualStyleBackColor = true;
            this.ProgrammerCheckBox.CheckedChanged += new System.EventHandler(this.ProgrammerCheckBox_CheckedChanged);
            // 
            // CountryNameCheckBox
            // 
            this.CountryNameCheckBox.AutoSize = true;
            this.CountryNameCheckBox.Location = new System.Drawing.Point(25, 51);
            this.CountryNameCheckBox.Name = "CountryNameCheckBox";
            this.CountryNameCheckBox.Size = new System.Drawing.Size(107, 19);
            this.CountryNameCheckBox.TabIndex = 1;
            this.CountryNameCheckBox.Text = "Country Name ";
            this.CountryNameCheckBox.UseVisualStyleBackColor = true;
            this.CountryNameCheckBox.CheckedChanged += new System.EventHandler(this.CountryNameCheckBox_CheckedChanged);
            // 
            // TitleCheckBox
            // 
            this.TitleCheckBox.AutoSize = true;
            this.TitleCheckBox.Location = new System.Drawing.Point(25, 26);
            this.TitleCheckBox.Name = "TitleCheckBox";
            this.TitleCheckBox.Size = new System.Drawing.Size(48, 19);
            this.TitleCheckBox.TabIndex = 0;
            this.TitleCheckBox.Text = "Title";
            this.TitleCheckBox.UseVisualStyleBackColor = true;
            this.TitleCheckBox.CheckedChanged += new System.EventHandler(this.TitleCheckBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(257, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flag Viewer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country Name: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RadioButtonFrance
            // 
            this.RadioButtonFrance.AutoSize = true;
            this.RadioButtonFrance.Location = new System.Drawing.Point(18, 100);
            this.RadioButtonFrance.Name = "RadioButtonFrance";
            this.RadioButtonFrance.Size = new System.Drawing.Size(60, 19);
            this.RadioButtonFrance.TabIndex = 3;
            this.RadioButtonFrance.TabStop = true;
            this.RadioButtonFrance.Text = "France";
            this.RadioButtonFrance.UseVisualStyleBackColor = true;
            this.RadioButtonFrance.CheckedChanged += new System.EventHandler(this.RadioButtonFrance_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton PhilippinesRadioButton;
        private Label CountryNameLabel;
        private RadioButton USARadioButton;
        private RadioButton ColombiaRadioButton;
        private Label ProgrammerLabel;
        private GroupBox groupBox2;
        private CheckBox TitleCheckBox;
        private CheckBox checkBox1;
        private CheckBox CountryNameCheckBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private CheckBox ProgrammerCheckBox;
        private RadioButton RadioButtonFrance;
    }
}