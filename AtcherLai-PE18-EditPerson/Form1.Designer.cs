namespace EditPerson
{
    partial class PersonEditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonEditForm));
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.licLabel = new System.Windows.Forms.Label();
            this.licText = new System.Windows.Forms.TextBox();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.specText = new System.Windows.Forms.TextBox();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.themRadioButton = new System.Windows.Forms.RadioButton();
            this.herRadioButton = new System.Windows.Forms.RadioButton();
            this.himRadioButton = new System.Windows.Forms.RadioButton();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.classOfLabel = new System.Windows.Forms.Label();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophRadioButton = new System.Windows.Forms.RadioButton();
            this.froshRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.genderGroupBox.SuspendLayout();
            this.classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.typeLabel.Location = new System.Drawing.Point(24, 48);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(84, 31);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Person type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.typeComboBox.Location = new System.Drawing.Point(213, 43);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(311, 39);
            this.typeComboBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.nameLabel.Location = new System.Drawing.Point(24, 131);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.Location = new System.Drawing.Point(213, 126);
            this.nameText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(545, 38);
            this.nameText.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.emailLabel.Location = new System.Drawing.Point(24, 219);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(84, 31);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailText.Location = new System.Drawing.Point(213, 212);
            this.emailText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(932, 38);
            this.emailText.TabIndex = 2;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.ageLabel.Location = new System.Drawing.Point(24, 312);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(187, 31);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age:";
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageText.Location = new System.Drawing.Point(213, 305);
            this.ageText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(153, 38);
            this.ageText.TabIndex = 3;
            // 
            // licLabel
            // 
            this.licLabel.BackColor = System.Drawing.Color.Transparent;
            this.licLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.licLabel.Location = new System.Drawing.Point(24, 408);
            this.licLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.licLabel.Name = "licLabel";
            this.licLabel.Size = new System.Drawing.Size(187, 31);
            this.licLabel.TabIndex = 4;
            this.licLabel.Text = "License Id:";
            // 
            // licText
            // 
            this.licText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licText.Location = new System.Drawing.Point(213, 403);
            this.licText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.licText.Name = "licText";
            this.licText.Size = new System.Drawing.Size(311, 38);
            this.licText.TabIndex = 4;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialtyLabel.Location = new System.Drawing.Point(24, 501);
            this.specialtyLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(187, 31);
            this.specialtyLabel.TabIndex = 5;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // specText
            // 
            this.specText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.specText.Location = new System.Drawing.Point(213, 494);
            this.specText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.specText.Name = "specText";
            this.specText.Size = new System.Drawing.Size(932, 38);
            this.specText.TabIndex = 5;
            // 
            // gpaLabel
            // 
            this.gpaLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpaLabel.Location = new System.Drawing.Point(24, 501);
            this.gpaLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(160, 31);
            this.gpaLabel.TabIndex = 6;
            this.gpaLabel.Text = "GPA:";
            // 
            // gpaText
            // 
            this.gpaText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpaText.Location = new System.Drawing.Point(213, 494);
            this.gpaText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(153, 38);
            this.gpaText.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(749, 579);
            this.okButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(149, 57);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(1003, 579);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 57);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.themRadioButton);
            this.genderGroupBox.Controls.Add(this.herRadioButton);
            this.genderGroupBox.Controls.Add(this.himRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(1211, 126);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.genderGroupBox.Size = new System.Drawing.Size(240, 215);
            this.genderGroupBox.TabIndex = 6;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Gender";
            // 
            // themRadioButton
            // 
            this.themRadioButton.AutoSize = true;
            this.themRadioButton.Location = new System.Drawing.Point(16, 155);
            this.themRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.themRadioButton.Name = "themRadioButton";
            this.themRadioButton.Size = new System.Drawing.Size(101, 35);
            this.themRadioButton.TabIndex = 2;
            this.themRadioButton.TabStop = true;
            this.themRadioButton.Text = "Them";
            this.themRadioButton.UseVisualStyleBackColor = true;
            // 
            // herRadioButton
            // 
            this.herRadioButton.AutoSize = true;
            this.herRadioButton.Location = new System.Drawing.Point(16, 100);
            this.herRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.herRadioButton.Name = "herRadioButton";
            this.herRadioButton.Size = new System.Drawing.Size(76, 35);
            this.herRadioButton.TabIndex = 1;
            this.herRadioButton.TabStop = true;
            this.herRadioButton.Text = "Her";
            this.herRadioButton.UseVisualStyleBackColor = true;
            // 
            // himRadioButton
            // 
            this.himRadioButton.AutoSize = true;
            this.himRadioButton.Location = new System.Drawing.Point(16, 45);
            this.himRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.himRadioButton.Name = "himRadioButton";
            this.himRadioButton.Size = new System.Drawing.Size(80, 35);
            this.himRadioButton.TabIndex = 0;
            this.himRadioButton.TabStop = true;
            this.himRadioButton.Text = "Him";
            this.himRadioButton.UseVisualStyleBackColor = true;
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.classOfLabel);
            this.classGroupBox.Controls.Add(this.seniorRadioButton);
            this.classGroupBox.Controls.Add(this.juniorRadioButton);
            this.classGroupBox.Controls.Add(this.sophRadioButton);
            this.classGroupBox.Controls.Add(this.froshRadioButton);
            this.classGroupBox.Location = new System.Drawing.Point(1536, 126);
            this.classGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.classGroupBox.Size = new System.Drawing.Size(413, 324);
            this.classGroupBox.TabIndex = 7;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Class";
            // 
            // classOfLabel
            // 
            this.classOfLabel.AutoSize = true;
            this.classOfLabel.Location = new System.Drawing.Point(96, 277);
            this.classOfLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.classOfLabel.Name = "classOfLabel";
            this.classOfLabel.Size = new System.Drawing.Size(180, 31);
            this.classOfLabel.TabIndex = 10;
            this.classOfLabel.Text = "Class of 9999";
            this.classOfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(16, 210);
            this.seniorRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(110, 35);
            this.seniorRadioButton.TabIndex = 6;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(16, 155);
            this.juniorRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(106, 35);
            this.juniorRadioButton.TabIndex = 5;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophRadioButton
            // 
            this.sophRadioButton.AutoSize = true;
            this.sophRadioButton.Location = new System.Drawing.Point(16, 100);
            this.sophRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sophRadioButton.Name = "sophRadioButton";
            this.sophRadioButton.Size = new System.Drawing.Size(171, 35);
            this.sophRadioButton.TabIndex = 4;
            this.sophRadioButton.TabStop = true;
            this.sophRadioButton.Text = "Sophomore";
            this.sophRadioButton.UseVisualStyleBackColor = true;
            // 
            // froshRadioButton
            // 
            this.froshRadioButton.AutoSize = true;
            this.froshRadioButton.Location = new System.Drawing.Point(16, 45);
            this.froshRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.froshRadioButton.Name = "froshRadioButton";
            this.froshRadioButton.Size = new System.Drawing.Size(154, 35);
            this.froshRadioButton.TabIndex = 3;
            this.froshRadioButton.TabStop = true;
            this.froshRadioButton.Text = "Freshman";
            this.froshRadioButton.UseVisualStyleBackColor = true;
            // 
            // PersonEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(2192, 1037);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.specText);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.licText);
            this.Controls.Add(this.licLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.gpaLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2212, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2212, 1080);
            this.Name = "PersonEditForm";
            this.Opacity = 0.8D;
            this.Text = "Edit Person";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label licLabel;
        private System.Windows.Forms.TextBox licText;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.TextBox specText;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label classOfLabel;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton themRadioButton;
        private System.Windows.Forms.RadioButton herRadioButton;
        private System.Windows.Forms.RadioButton himRadioButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophRadioButton;
        private System.Windows.Forms.RadioButton froshRadioButton;
    }
}

