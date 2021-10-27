
namespace Valmeny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hittaDatorButton = new System.Windows.Forms.Button();
            this.printerClientButton = new System.Windows.Forms.Button();
            this.rensaOSDButton = new System.Windows.Forms.Button();
            this.charonButton = new System.Windows.Forms.Button();
            this.changeThemeButton = new System.Windows.Forms.Button();
            this.userTextbox = new System.Windows.Forms.Label();
            this.openDialogButton = new System.Windows.Forms.Button();
            this.defaulDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.defaultSelectorLabel = new System.Windows.Forms.Label();
            this.printerClientHelp = new System.Windows.Forms.Button();
            this.hittaDatorHelp = new System.Windows.Forms.Button();
            this.charonHelp = new System.Windows.Forms.Button();
            this.rensaOSDHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.hittaDatorButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.printerClientButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rensaOSDButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.charonButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 217);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // hittaDatorButton
            // 
            this.hittaDatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.hittaDatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hittaDatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hittaDatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.hittaDatorButton.Location = new System.Drawing.Point(3, 111);
            this.hittaDatorButton.Name = "hittaDatorButton";
            this.hittaDatorButton.Size = new System.Drawing.Size(221, 102);
            this.hittaDatorButton.TabIndex = 3;
            this.hittaDatorButton.Text = "HittaDator";
            this.hittaDatorButton.UseVisualStyleBackColor = false;
            this.hittaDatorButton.Click += new System.EventHandler(this.hittaDatorButton_Click);
            // 
            // printerClientButton
            // 
            this.printerClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.printerClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printerClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.printerClientButton.Location = new System.Drawing.Point(230, 111);
            this.printerClientButton.Name = "printerClientButton";
            this.printerClientButton.Size = new System.Drawing.Size(221, 102);
            this.printerClientButton.TabIndex = 2;
            this.printerClientButton.Text = "PrinterClient";
            this.printerClientButton.UseVisualStyleBackColor = false;
            this.printerClientButton.Click += new System.EventHandler(this.printerClientButton_Click);
            // 
            // rensaOSDButton
            // 
            this.rensaOSDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rensaOSDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rensaOSDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rensaOSDButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.rensaOSDButton.Location = new System.Drawing.Point(3, 3);
            this.rensaOSDButton.Name = "rensaOSDButton";
            this.rensaOSDButton.Size = new System.Drawing.Size(221, 102);
            this.rensaOSDButton.TabIndex = 0;
            this.rensaOSDButton.Text = "RensaOSD";
            this.rensaOSDButton.UseVisualStyleBackColor = false;
            this.rensaOSDButton.Click += new System.EventHandler(this.rensaOSDButton_Click);
            // 
            // charonButton
            // 
            this.charonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.charonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.charonButton.Location = new System.Drawing.Point(230, 3);
            this.charonButton.Name = "charonButton";
            this.charonButton.Size = new System.Drawing.Size(221, 102);
            this.charonButton.TabIndex = 1;
            this.charonButton.Text = "Charon";
            this.charonButton.UseVisualStyleBackColor = false;
            this.charonButton.Click += new System.EventHandler(this.charonButton_Click);
            // 
            // changeThemeButton
            // 
            this.changeThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.changeThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeThemeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.changeThemeButton.Location = new System.Drawing.Point(390, 9);
            this.changeThemeButton.Name = "changeThemeButton";
            this.changeThemeButton.Size = new System.Drawing.Size(76, 29);
            this.changeThemeButton.TabIndex = 9;
            this.changeThemeButton.Text = "Byt tema";
            this.changeThemeButton.UseVisualStyleBackColor = false;
            this.changeThemeButton.Click += new System.EventHandler(this.changeThemeButton_Click);
            // 
            // userTextbox
            // 
            this.userTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.userTextbox.Location = new System.Drawing.Point(12, 9);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(454, 188);
            this.userTextbox.TabIndex = 1;
            this.userTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openDialogButton
            // 
            this.openDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.openDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDialogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.openDialogButton.Location = new System.Drawing.Point(390, 197);
            this.openDialogButton.Name = "openDialogButton";
            this.openDialogButton.Size = new System.Drawing.Size(76, 23);
            this.openDialogButton.TabIndex = 2;
            this.openDialogButton.Text = "Byt standard";
            this.openDialogButton.UseVisualStyleBackColor = false;
            this.openDialogButton.Click += new System.EventHandler(this.openDialogButton_Click);
            // 
            // defaulDirectoryDialog
            // 
            this.defaulDirectoryDialog.SelectedPath = "C:";
            // 
            // defaultSelectorLabel
            // 
            this.defaultSelectorLabel.AutoEllipsis = true;
            this.defaultSelectorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.defaultSelectorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultSelectorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultSelectorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.defaultSelectorLabel.Location = new System.Drawing.Point(12, 197);
            this.defaultSelectorLabel.Name = "defaultSelectorLabel";
            this.defaultSelectorLabel.Size = new System.Drawing.Size(372, 23);
            this.defaultSelectorLabel.TabIndex = 4;
            this.defaultSelectorLabel.Text = "Du har inte satt en standardmapp för filer!";
            this.defaultSelectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printerClientHelp
            // 
            this.printerClientHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.printerClientHelp.BackgroundImage = global::Valmeny.Properties.Resources.help2;
            this.printerClientHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printerClientHelp.FlatAppearance.BorderSize = 0;
            this.printerClientHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printerClientHelp.ForeColor = System.Drawing.Color.Transparent;
            this.printerClientHelp.Location = new System.Drawing.Point(427, 343);
            this.printerClientHelp.Margin = new System.Windows.Forms.Padding(0);
            this.printerClientHelp.Name = "printerClientHelp";
            this.printerClientHelp.Size = new System.Drawing.Size(30, 30);
            this.printerClientHelp.TabIndex = 8;
            this.printerClientHelp.UseVisualStyleBackColor = false;
            this.printerClientHelp.Click += new System.EventHandler(this.printerClientHelp_Click);
            // 
            // hittaDatorHelp
            // 
            this.hittaDatorHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.hittaDatorHelp.BackgroundImage = global::Valmeny.Properties.Resources.help2;
            this.hittaDatorHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hittaDatorHelp.FlatAppearance.BorderSize = 0;
            this.hittaDatorHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hittaDatorHelp.ForeColor = System.Drawing.Color.Transparent;
            this.hittaDatorHelp.Location = new System.Drawing.Point(200, 343);
            this.hittaDatorHelp.Margin = new System.Windows.Forms.Padding(0);
            this.hittaDatorHelp.Name = "hittaDatorHelp";
            this.hittaDatorHelp.Size = new System.Drawing.Size(30, 30);
            this.hittaDatorHelp.TabIndex = 7;
            this.hittaDatorHelp.UseVisualStyleBackColor = false;
            this.hittaDatorHelp.Click += new System.EventHandler(this.hittaDatorHelp_Click);
            // 
            // charonHelp
            // 
            this.charonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.charonHelp.BackgroundImage = global::Valmeny.Properties.Resources.help2;
            this.charonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charonHelp.FlatAppearance.BorderSize = 0;
            this.charonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charonHelp.ForeColor = System.Drawing.Color.Transparent;
            this.charonHelp.Location = new System.Drawing.Point(427, 235);
            this.charonHelp.Margin = new System.Windows.Forms.Padding(0);
            this.charonHelp.Name = "charonHelp";
            this.charonHelp.Size = new System.Drawing.Size(30, 30);
            this.charonHelp.TabIndex = 6;
            this.charonHelp.UseVisualStyleBackColor = false;
            this.charonHelp.Click += new System.EventHandler(this.charonHelp_Click);
            // 
            // rensaOSDHelp
            // 
            this.rensaOSDHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rensaOSDHelp.BackgroundImage = global::Valmeny.Properties.Resources.help2;
            this.rensaOSDHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rensaOSDHelp.FlatAppearance.BorderSize = 0;
            this.rensaOSDHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rensaOSDHelp.ForeColor = System.Drawing.Color.Transparent;
            this.rensaOSDHelp.Location = new System.Drawing.Point(200, 235);
            this.rensaOSDHelp.Margin = new System.Windows.Forms.Padding(0);
            this.rensaOSDHelp.Name = "rensaOSDHelp";
            this.rensaOSDHelp.Size = new System.Drawing.Size(30, 30);
            this.rensaOSDHelp.TabIndex = 5;
            this.rensaOSDHelp.UseVisualStyleBackColor = false;
            this.rensaOSDHelp.Click += new System.EventHandler(this.rensaOSDHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(478, 452);
            this.Controls.Add(this.changeThemeButton);
            this.Controls.Add(this.printerClientHelp);
            this.Controls.Add(this.hittaDatorHelp);
            this.Controls.Add(this.charonHelp);
            this.Controls.Add(this.rensaOSDHelp);
            this.Controls.Add(this.defaultSelectorLabel);
            this.Controls.Add(this.openDialogButton);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valmeny";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rensaOSDButton;
        private System.Windows.Forms.Label userTextbox;
        private System.Windows.Forms.Button openDialogButton;
        private System.Windows.Forms.FolderBrowserDialog defaulDirectoryDialog;
        private System.Windows.Forms.Label defaultSelectorLabel;
        private System.Windows.Forms.Button hittaDatorButton;
        private System.Windows.Forms.Button printerClientButton;
        private System.Windows.Forms.Button charonButton;
        private System.Windows.Forms.Button rensaOSDHelp;
        private System.Windows.Forms.Button charonHelp;
        private System.Windows.Forms.Button hittaDatorHelp;
        private System.Windows.Forms.Button printerClientHelp;
        private System.Windows.Forms.Button changeThemeButton;
    }
}

