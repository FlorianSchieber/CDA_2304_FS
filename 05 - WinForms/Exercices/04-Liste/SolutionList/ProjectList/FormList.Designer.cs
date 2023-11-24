namespace ProjectList
{
    partial class FormList
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
            components = new System.ComponentModel.Container();
            labelNewElement = new Label();
            textBoxNewElement = new TextBox();
            buttonAddToList = new Button();
            labelElementIndex = new Label();
            textBoxElementIndex = new TextBox();
            buttonSelect = new Button();
            buttonEmptyList = new Button();
            listBox = new ListBox();
            labelList = new Label();
            labelProperties = new Label();
            labelItemsCount = new Label();
            textBoxItemsCount = new TextBox();
            labelSelectedIndex = new Label();
            textBoxSelectedIndex = new TextBox();
            labelText = new Label();
            textBoxText = new TextBox();
            errorProviderElementIndex = new ErrorProvider(components);
            errorProviderNewElement = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderElementIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNewElement).BeginInit();
            SuspendLayout();
            // 
            // labelNewElement
            // 
            labelNewElement.AutoSize = true;
            labelNewElement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewElement.Location = new Point(12, 9);
            labelNewElement.Name = "labelNewElement";
            labelNewElement.Size = new Size(96, 15);
            labelNewElement.TabIndex = 0;
            labelNewElement.Text = "Nouvel Elément";
            // 
            // textBoxNewElement
            // 
            textBoxNewElement.Location = new Point(12, 27);
            textBoxNewElement.Name = "textBoxNewElement";
            textBoxNewElement.Size = new Size(166, 23);
            textBoxNewElement.TabIndex = 1;
            // 
            // buttonAddToList
            // 
            buttonAddToList.Location = new Point(12, 56);
            buttonAddToList.Name = "buttonAddToList";
            buttonAddToList.Size = new Size(166, 23);
            buttonAddToList.TabIndex = 2;
            buttonAddToList.Text = "Ajout Liste";
            buttonAddToList.UseVisualStyleBackColor = true;
            buttonAddToList.Click += buttonAddToList_Click;
            // 
            // labelElementIndex
            // 
            labelElementIndex.AutoSize = true;
            labelElementIndex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelElementIndex.Location = new Point(220, 9);
            labelElementIndex.Name = "labelElementIndex";
            labelElementIndex.Size = new Size(88, 15);
            labelElementIndex.TabIndex = 3;
            labelElementIndex.Text = "Index Elément";
            // 
            // textBoxElementIndex
            // 
            textBoxElementIndex.Location = new Point(220, 27);
            textBoxElementIndex.Name = "textBoxElementIndex";
            textBoxElementIndex.Size = new Size(47, 23);
            textBoxElementIndex.TabIndex = 4;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(320, 27);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(145, 23);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "Sélectionner";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonEmptyList
            // 
            buttonEmptyList.Location = new Point(320, 56);
            buttonEmptyList.Name = "buttonEmptyList";
            buttonEmptyList.Size = new Size(145, 23);
            buttonEmptyList.TabIndex = 6;
            buttonEmptyList.Text = "Vider la Liste";
            buttonEmptyList.UseVisualStyleBackColor = true;
            buttonEmptyList.Click += buttonEmptyList_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.HorizontalScrollbar = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 134);
            listBox.Name = "listBox";
            listBox.Size = new Size(166, 94);
            listBox.TabIndex = 7;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelList.Location = new Point(12, 116);
            labelList.Name = "labelList";
            labelList.Size = new Size(49, 15);
            labelList.TabIndex = 8;
            labelList.Text = "LstListe";
            // 
            // labelProperties
            // 
            labelProperties.AutoSize = true;
            labelProperties.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProperties.Location = new Point(220, 116);
            labelProperties.Name = "labelProperties";
            labelProperties.Size = new Size(65, 15);
            labelProperties.TabIndex = 9;
            labelProperties.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            labelItemsCount.AutoSize = true;
            labelItemsCount.Location = new Point(220, 141);
            labelItemsCount.Name = "labelItemsCount";
            labelItemsCount.Size = new Size(72, 15);
            labelItemsCount.TabIndex = 10;
            labelItemsCount.Text = "Items.Count";
            // 
            // textBoxItemsCount
            // 
            textBoxItemsCount.BackColor = SystemColors.Control;
            textBoxItemsCount.Location = new Point(319, 138);
            textBoxItemsCount.Name = "textBoxItemsCount";
            textBoxItemsCount.ReadOnly = true;
            textBoxItemsCount.Size = new Size(54, 23);
            textBoxItemsCount.TabIndex = 11;
            // 
            // labelSelectedIndex
            // 
            labelSelectedIndex.AutoSize = true;
            labelSelectedIndex.Location = new Point(220, 170);
            labelSelectedIndex.Name = "labelSelectedIndex";
            labelSelectedIndex.Size = new Size(80, 15);
            labelSelectedIndex.TabIndex = 12;
            labelSelectedIndex.Text = "SelectedIndex";
            // 
            // textBoxSelectedIndex
            // 
            textBoxSelectedIndex.BackColor = SystemColors.Control;
            textBoxSelectedIndex.Location = new Point(319, 167);
            textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            textBoxSelectedIndex.ReadOnly = true;
            textBoxSelectedIndex.Size = new Size(54, 23);
            textBoxSelectedIndex.TabIndex = 13;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(220, 199);
            labelText.Name = "labelText";
            labelText.Size = new Size(28, 15);
            labelText.TabIndex = 14;
            labelText.Text = "Text";
            // 
            // textBoxText
            // 
            textBoxText.BackColor = SystemColors.Control;
            textBoxText.Location = new Point(319, 196);
            textBoxText.Name = "textBoxText";
            textBoxText.ReadOnly = true;
            textBoxText.Size = new Size(99, 23);
            textBoxText.TabIndex = 15;
            // 
            // errorProviderElementIndex
            // 
            errorProviderElementIndex.ContainerControl = this;
            // 
            // errorProviderNewElement
            // 
            errorProviderNewElement.ContainerControl = this;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 239);
            Controls.Add(textBoxText);
            Controls.Add(labelText);
            Controls.Add(textBoxSelectedIndex);
            Controls.Add(labelSelectedIndex);
            Controls.Add(textBoxItemsCount);
            Controls.Add(labelItemsCount);
            Controls.Add(labelProperties);
            Controls.Add(labelList);
            Controls.Add(listBox);
            Controls.Add(buttonEmptyList);
            Controls.Add(buttonSelect);
            Controls.Add(textBoxElementIndex);
            Controls.Add(labelElementIndex);
            Controls.Add(buttonAddToList);
            Controls.Add(textBoxNewElement);
            Controls.Add(labelNewElement);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormList";
            Text = "FormList";
            ((System.ComponentModel.ISupportInitialize)errorProviderElementIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNewElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewElement;
        private TextBox textBoxNewElement;
        private Button buttonAddToList;
        private Label labelElementIndex;
        private TextBox textBoxElementIndex;
        private Button buttonSelect;
        private Button buttonEmptyList;
        private ListBox listBox;
        private Label labelList;
        private Label labelProperties;
        private Label labelItemsCount;
        private TextBox textBoxItemsCount;
        private Label labelSelectedIndex;
        private TextBox textBoxSelectedIndex;
        private Label labelText;
        private TextBox textBoxText;
        private ErrorProvider errorProviderElementIndex;
        private ErrorProvider errorProviderNewElement;
    }
}