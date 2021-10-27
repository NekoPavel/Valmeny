
namespace Valmeny
{
    partial class ColourChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourChanger));
            this.backgroundPickerButton = new System.Windows.Forms.Button();
            this.textPickerButton = new System.Windows.Forms.Button();
            this.foregroundPickerButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.themeSelector = new System.Windows.Forms.ListBox();
            this.themeNameTextBox = new System.Windows.Forms.TextBox();
            this.removeThemeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundPickerButton
            // 
            this.backgroundPickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.backgroundPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundPickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundPickerButton.Location = new System.Drawing.Point(214, 12);
            this.backgroundPickerButton.Name = "backgroundPickerButton";
            this.backgroundPickerButton.Size = new System.Drawing.Size(148, 40);
            this.backgroundPickerButton.TabIndex = 0;
            this.backgroundPickerButton.Text = "Välj bakgrundsfärg";
            this.backgroundPickerButton.UseVisualStyleBackColor = false;
            this.backgroundPickerButton.Click += new System.EventHandler(this.backgroundPickerButton_Click);
            // 
            // textPickerButton
            // 
            this.textPickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textPickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPickerButton.Location = new System.Drawing.Point(214, 58);
            this.textPickerButton.Name = "textPickerButton";
            this.textPickerButton.Size = new System.Drawing.Size(148, 40);
            this.textPickerButton.TabIndex = 1;
            this.textPickerButton.Text = "Välj textfärg";
            this.textPickerButton.UseVisualStyleBackColor = false;
            this.textPickerButton.Click += new System.EventHandler(this.textPickerButton_Click);
            // 
            // foregroundPickerButton
            // 
            this.foregroundPickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.foregroundPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foregroundPickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foregroundPickerButton.Location = new System.Drawing.Point(214, 104);
            this.foregroundPickerButton.Name = "foregroundPickerButton";
            this.foregroundPickerButton.Size = new System.Drawing.Size(148, 40);
            this.foregroundPickerButton.TabIndex = 2;
            this.foregroundPickerButton.Text = "Välj knapp/textruta-färg";
            this.foregroundPickerButton.UseVisualStyleBackColor = false;
            this.foregroundPickerButton.Click += new System.EventHandler(this.foregroundPickerButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(275, 192);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // themeSelector
            // 
            this.themeSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.themeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.themeSelector.FormattingEnabled = true;
            this.themeSelector.ItemHeight = 16;
            this.themeSelector.Location = new System.Drawing.Point(12, 12);
            this.themeSelector.Name = "themeSelector";
            this.themeSelector.Size = new System.Drawing.Size(196, 210);
            this.themeSelector.TabIndex = 4;
            this.themeSelector.SelectedIndexChanged += new System.EventHandler(this.themeSelector_SelectedIndexChanged);
            // 
            // themeNameTextBox
            // 
            this.themeNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.themeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.themeNameTextBox.Location = new System.Drawing.Point(214, 165);
            this.themeNameTextBox.Name = "themeNameTextBox";
            this.themeNameTextBox.Size = new System.Drawing.Size(148, 21);
            this.themeNameTextBox.TabIndex = 5;
            this.themeNameTextBox.Text = "TEXT";
            // 
            // removeThemeButton
            // 
            this.removeThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.removeThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeThemeButton.Location = new System.Drawing.Point(214, 192);
            this.removeThemeButton.Name = "removeThemeButton";
            this.removeThemeButton.Size = new System.Drawing.Size(55, 30);
            this.removeThemeButton.TabIndex = 6;
            this.removeThemeButton.Text = "Ta bort";
            this.removeThemeButton.UseVisualStyleBackColor = false;
            this.removeThemeButton.Click += new System.EventHandler(this.removeThemeButton_Click);
            // 
            // ColourChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(372, 229);
            this.Controls.Add(this.removeThemeButton);
            this.Controls.Add(this.themeNameTextBox);
            this.Controls.Add(this.themeSelector);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.foregroundPickerButton);
            this.Controls.Add(this.textPickerButton);
            this.Controls.Add(this.backgroundPickerButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColourChanger";
            this.Text = "Temaväljare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backgroundPickerButton;
        private System.Windows.Forms.Button textPickerButton;
        private System.Windows.Forms.Button foregroundPickerButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox themeSelector;
        private System.Windows.Forms.TextBox themeNameTextBox;
        private System.Windows.Forms.Button removeThemeButton;
    }
}