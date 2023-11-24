namespace ProjectCombo
{
    partial class FormCombo
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
            labelSource = new Label();
            comboBoxSource = new ComboBox();
            buttonAdd = new Button();
            buttonAddAll = new Button();
            buttonRemove = new Button();
            buttonRemoveAll = new Button();
            listBoxTarget = new ListBox();
            LabelTarget = new Label();
            buttonUp = new Button();
            buttonDown = new Button();
            SuspendLayout();
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(12, 9);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(43, 15);
            labelSource.TabIndex = 0;
            labelSource.Text = "Source";
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(12, 27);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(173, 23);
            comboBoxSource.Sorted = true;
            comboBoxSource.TabIndex = 1;
            comboBoxSource.DropDown += comboBoxSource_DropDown;
            comboBoxSource.TextChanged += comboBoxSource_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Enabled = false;
            buttonAdd.Location = new Point(191, 27);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = ">";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonAddAll
            // 
            buttonAddAll.Location = new Point(191, 56);
            buttonAddAll.Name = "buttonAddAll";
            buttonAddAll.Size = new Size(75, 23);
            buttonAddAll.TabIndex = 3;
            buttonAddAll.Text = ">>";
            buttonAddAll.UseVisualStyleBackColor = true;
            buttonAddAll.Click += buttonAddAll_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(191, 171);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "<";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.Enabled = false;
            buttonRemoveAll.Location = new Point(191, 200);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(75, 23);
            buttonRemoveAll.TabIndex = 5;
            buttonRemoveAll.Text = "<<";
            buttonRemoveAll.UseVisualStyleBackColor = true;
            buttonRemoveAll.Click += buttonRemoveAll_Click;
            // 
            // listBoxTarget
            // 
            listBoxTarget.FormattingEnabled = true;
            listBoxTarget.ItemHeight = 15;
            listBoxTarget.Location = new Point(272, 27);
            listBoxTarget.Name = "listBoxTarget";
            listBoxTarget.Size = new Size(168, 199);
            listBoxTarget.TabIndex = 6;
            listBoxTarget.SelectedIndexChanged += listBoxTarget_SelectedIndexChanged;
            // 
            // LabelTarget
            // 
            LabelTarget.AutoSize = true;
            LabelTarget.Location = new Point(272, 9);
            LabelTarget.Name = "LabelTarget";
            LabelTarget.Size = new Size(34, 15);
            LabelTarget.TabIndex = 7;
            LabelTarget.Text = "Cible";
            // 
            // buttonUp
            // 
            buttonUp.Enabled = false;
            buttonUp.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUp.Location = new Point(312, 232);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(38, 49);
            buttonUp.TabIndex = 8;
            buttonUp.Text = "⇧";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Enabled = false;
            buttonDown.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDown.Location = new Point(356, 232);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(38, 49);
            buttonDown.TabIndex = 9;
            buttonDown.Text = "⇩";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // FormCombo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 291);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(LabelTarget);
            Controls.Add(listBoxTarget);
            Controls.Add(buttonRemoveAll);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAddAll);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxSource);
            Controls.Add(labelSource);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCombo";
            Text = "FormCombo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSource;
        private ComboBox comboBoxSource;
        private Button buttonAdd;
        private Button buttonAddAll;
        private Button buttonRemove;
        private Button buttonRemoveAll;
        private ListBox listBoxTarget;
        private Label LabelTarget;
        private Button buttonUp;
        private Button buttonDown;
    }
}