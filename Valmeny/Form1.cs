using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valmeny
{
    public partial class Form1 : Form
    {
        public string savePath;
        public string userName;
        public Form1(string[] args)
        {
            InitializeComponent();
            InitializeTheme();
            if (args.Count() > 0)
            {
                defaulDirectoryDialog.SelectedPath = FindADObjects("user", $"(sAMAccountName={args[0]})", "homeDirectory")[0].GetDirectoryEntry().Properties["homeDirectory"].Value.ToString();
            }
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                if (rk.OpenSubKey("NekoPavel", true) != null && rk.OpenSubKey("NekoPavel", true).GetValue("SavePath") != null)
                {
                    savePath = rk.OpenSubKey("NekoPavel", true).GetValue("SavePath").ToString();
                    defaultSelectorLabel.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    defaultSelectorLabel.Text = $"Standardmapp är: {savePath}";
                    defaultSelectorLabel.Size = new Size(372, 23);
                    openDialogButton.Size = new Size(76, 23);
                    openDialogButton.Location = new Point(390, 197);
                    openDialogButton.Text = "Byt standard";
                }
                else
                {
                    defaultSelectorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    defaultSelectorLabel.Text = "Du har inte satt en standardmapp för filer!";
                    defaultSelectorLabel.Size = new Size(308, 23);
                    openDialogButton.Size = new Size(140, 23);
                    openDialogButton.Location = new Point(326, 197);
                    openDialogButton.Text = "Välj standard";
                    tableLayoutPanel1.Enabled = false;
                }
            }
            userName = FindADObjects("user", $"sAMAccountName={WindowsIdentity.GetCurrent().Name.Substring(11)}", "givenName")[0].GetDirectoryEntry().Properties["givenName"].Value.ToString();
            //userTextbox.Text = GetWelcomeMessage();
        }
        private void InitializeTheme()
        {
            if (ThemeExists())
            {
                SetColours(OpenTheme(GetSelectedTheme()));
            }
        }

        private string GetSelectedTheme()
        {
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                return rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName").ToString();
            }
        }

        private Color[] OpenTheme(string themeName)
        {
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                Color[] colours = {
                Color.FromArgb((int)rk.OpenSubKey($"NekoPavel\\{themeName}").GetValue("BackColour")),
                Color.FromArgb((int)rk.OpenSubKey($"NekoPavel\\{themeName}").GetValue("ForeColour")),
                Color.FromArgb((int)rk.OpenSubKey($"NekoPavel\\{themeName}").GetValue("TextColour"))
                };
                return colours;
            }
        }

        private bool ThemeExists()
        {
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                return (rk.OpenSubKey("NekoPavel", true) != null && rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName") != null && rk.OpenSubKey("NekoPavel", true).OpenSubKey(rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName").ToString()) != null);
            }
        }

        private void SetColours(Color[] colours)
        {
            foreach (var control in Controls)
            {
                ((Control)control).BackColor = colours[1];
                ((Control)control).ForeColor = colours[2];
            }
            foreach (var control in tableLayoutPanel1.Controls)
            {
                ((Control)control).BackColor = colours[1];
                ((Control)control).ForeColor = colours[2];
            }
            BackColor = colours[0];
            ForeColor = colours[2];
            userTextbox.BackColor = colours[0];
            tableLayoutPanel1.BackColor = BackColor;
        }
        private string GetWelcomeMessage()
        {
            string message;
            switch (DateTime.Now.Hour)
            {
                case int i when i > 5 && i <= 9:
                    message = "Godmorgon";
                    break;
                case int i when i > 9 && i <= 12:
                    message = "God dag";
                    break;
                case int i when i > 12 && i <= 17:
                    message = "God eftermiddag";
                    break;
                case int i when i > 17 && i <= 22:
                    message = "God kväll";
                    break;
                case int i when i > 22 && i <= 5:
                    message = "God natt";
                    break;
                default:
                    message = "Hej";
                    break;
            }
            message += " " + userName;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    message += Environment.NewLine + "Det är snart helg!";
                    break;
                default:
                    break;
            }
            message += Environment.NewLine + "Vad vill du göra idag?";
            return message;
        }

        static SearchResultCollection FindADObjects(string adClass, string filter, string attributes = "distinguishedName")
        {
            DirectoryContext dc = new DirectoryContext(DirectoryContextType.Domain, "gaia");
            Domain dn = Domain.GetDomain(dc);
            DirectorySearcher ds = new DirectorySearcher(dn.GetDirectoryEntry(), $"(&(objectCategory={adClass}){filter})");
            ds.SearchScope = SearchScope.Subtree;
            ds.PageSize = 1024;
            ds.PropertiesToLoad.AddRange(attributes.Split(','));
            SearchResultCollection result = ds.FindAll();
            ds.Dispose();

            return result;
        }


        private void openDialogButton_Click(object sender, EventArgs e)
        {
            DialogResult result = defaulDirectoryDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = defaulDirectoryDialog.SelectedPath;
                using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
                {
                    if (rk.OpenSubKey("NekoPavel", true) != null)
                    {
                        rk.OpenSubKey("NekoPavel", true).SetValue("SavePath", savePath);
                        defaultSelectorLabel.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        defaultSelectorLabel.Text = $"Standardmapp är: {savePath}";
                        defaultSelectorLabel.Size = new Size(372, 23);
                        openDialogButton.Size = new Size(76, 23);
                        openDialogButton.Location = new Point(390, 197);
                        openDialogButton.Text = "Byt standard";
                    }
                    else
                    {
                        rk.CreateSubKey("NekoPavel\\");
                        rk.OpenSubKey("NekoPavel", true).SetValue("SavePath", savePath);
                        tableLayoutPanel1.Enabled = true;
                        defaultSelectorLabel.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        defaultSelectorLabel.Text = $"Standardmapp är: {savePath}";
                        defaultSelectorLabel.Size = new Size(372, 23);
                        openDialogButton.Size = new Size(76, 23);
                        openDialogButton.Location = new Point(390, 197);
                        openDialogButton.Text = "Byt standard";
                    }
                }
            }
        }
        private void rensaOSDButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\G55\LCH-W10\RensaOsd\RensaOSD.exe";
            proc.Arguments = "ValmenyBoot";
            Process.Start(proc);
        }
        private void charonButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\G55\Charon\Charon.exe";
            proc.Arguments = "ValmenyBoot";
            Process.Start(proc);
        }

        private void hittaDatorButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\G55\HittaPC\HittaDator.exe";
            proc.Arguments = "ValmenyBoot";
            Process.Start(proc);
        }

        private void printerClientButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\G55\LCH-W10\PrinterClient\PrinterClient.exe";
            proc.Arguments = "ValmenyBoot";
            Process.Start(proc);
        }

        private void changeThemeButton_Click(object sender, EventArgs e)
        {
            ColourChanger colourChanger = new ColourChanger();
            colourChanger.ShowDialog();
            InitializeTheme();
        }

        private void rensaOSDHelp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\Fabriken Solna\Pavels Program\RensaOSD-Readme.docx";
            Process.Start(proc);
        }

        private void charonHelp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\Fabriken Solna\Pavels Program\Charon-Readme.docx";
            Process.Start(proc);
        }

        private void hittaDatorHelp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = @"\\dfs\gem$\Lit\IT-Service\Fabriken Solna\Pavels Program\HittaDator-Readme.docx";
            Process.Start(proc);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            userTextbox.Text = GetWelcomeMessage();
        }

        private void printerClientHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detta program används av Fabriken Solna för att skriva ut datoretiketter.", "PrinterClient", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
