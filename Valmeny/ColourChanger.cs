using Cyotek.Windows.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valmeny
{
    public partial class ColourChanger : Form
    {
        public List<Theme> themes = new List<Theme>();
        public BindingList<Theme> themesBinding = new BindingList<Theme>();
        public List<Theme> themesDefault = new List<Theme>();
        public Color backColour;
        public Color textColour;
        public Color foreColour;
        public ColourChanger()
        {
            InitializeComponent();
            InitializeThemes();
        }
        private void InitializeThemes()
        {
            themesDefault.Add(new Theme("Dark", Color.FromArgb(29, 29, 29), Color.FromArgb(51, 51, 51), Color.FromArgb(239, 244, 255)));
            themesDefault.Add(new Theme("Light", Color.FromArgb(239, 244, 255), Color.FromArgb(218, 220, 230), Color.FromArgb(29, 29, 29)));
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                if (rk.OpenSubKey("NekoPavel") != null) //Custom key exists
                {
                    ReadThemes(rk);
                }
                else //Custom key is missing
                {
                    rk.CreateSubKey("NekoPavel\\");
                }
                ProcessThemes(rk);
            }
        }
        private void ProcessThemes(RegistryKey rk)
        {
            if (themes.Count == 0)
            {
                RegisterThemes(rk);
            }
            themeSelector.DataSource = themesBinding;
            themeSelector.DisplayMember = "visibleName";
            if (rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName") != null) //Default theme is set
            {
                SelectDefaultTheme(rk);
                SetColours();
            }
            else //Default theme isn't set
            {
                ResetDefaultTheme(rk);
                SelectDefaultTheme(rk);
                SetColours();
            }
        }
        private void ResetDefaultTheme(RegistryKey rk)
        {
            rk.OpenSubKey("NekoPavel", true).SetValue("ThemeName", "Dark");
        }
        private void SelectDefaultTheme(RegistryKey rk)
        {
            if (themes.Exists(x => x.visibleName == rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName").ToString())) //Selected theme exists
            {
                themeSelector.SelectedItem = themes.Find(x => x.visibleName == rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName").ToString());
            }
            else //Selected theme doesn't exist
            {
                ResetDefaultTheme(rk);
                themeSelector.SelectedItem = themes.Find(x => x.visibleName == rk.OpenSubKey("NekoPavel", true).GetValue("ThemeName").ToString());
            }
        }
        private void ReadThemes(RegistryKey rk)
        {
            foreach (string themeName in rk.OpenSubKey("NekoPavel").GetSubKeyNames())
            {
                Theme tempTheme = new Theme(
                themeName,
                Color.FromArgb((int)rk.OpenSubKey($"NekoPavel\\{themeName}").GetValue("BackColour")),
                Color.FromArgb((int)rk.OpenSubKey($"NekoPavel\\{themeName}").GetValue("ForeColour")),
                Color.FromArgb((int)rk.OpenSubKey($"NekoPavel\\{themeName}").GetValue("TextColour"))
                );
                themes.Add(tempTheme);
                themesBinding.Add(tempTheme);
            }
        }
        private void RegisterThemes(RegistryKey rk)
        {
            foreach (Theme tempTheme in CreateDefaultThemeList())
            {
                rk.OpenSubKey("NekoPavel", true).CreateSubKey(tempTheme.visibleName);
                rk.OpenSubKey("NekoPavel", true).OpenSubKey(tempTheme.visibleName, true).SetValue("BackColour", tempTheme.colours[0].ToArgb(), RegistryValueKind.DWord);
                rk.OpenSubKey("NekoPavel", true).OpenSubKey(tempTheme.visibleName, true).SetValue("ForeColour", tempTheme.colours[1].ToArgb(), RegistryValueKind.DWord);
                rk.OpenSubKey("NekoPavel", true).OpenSubKey(tempTheme.visibleName, true).SetValue("TextColour", tempTheme.colours[2].ToArgb(), RegistryValueKind.DWord);
            }
        }
        private List<Theme> CreateDefaultThemeList()
        {
            themes.Add(new Theme("Dark", Color.FromArgb(29, 29, 29), Color.FromArgb(51, 51, 51), Color.FromArgb(239, 244, 255)));
            themes.Add(new Theme("Light", Color.FromArgb(239, 244, 255), Color.FromArgb(218, 220, 230), Color.FromArgb(29, 29, 29)));
            themesBinding.Add(new Theme("Dark", Color.FromArgb(29, 29, 29), Color.FromArgb(51, 51, 51), Color.FromArgb(239, 244, 255)));
            themesBinding.Add(new Theme("Light", Color.FromArgb(239, 244, 255), Color.FromArgb(218, 220, 230), Color.FromArgb(29, 29, 29)));
            return themes;
        }
        private void ExportThemes()
        {
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                foreach (Theme tempTheme in themes)
                {
                    rk.OpenSubKey("NekoPavel", true).CreateSubKey(tempTheme.visibleName);
                    rk.OpenSubKey("NekoPavel", true).OpenSubKey(tempTheme.visibleName, true).SetValue("BackColour", tempTheme.colours[0].ToArgb(), RegistryValueKind.DWord);
                    rk.OpenSubKey("NekoPavel", true).OpenSubKey(tempTheme.visibleName, true).SetValue("ForeColour", tempTheme.colours[1].ToArgb(), RegistryValueKind.DWord);
                    rk.OpenSubKey("NekoPavel", true).OpenSubKey(tempTheme.visibleName, true).SetValue("TextColour", tempTheme.colours[2].ToArgb(), RegistryValueKind.DWord);
                }
            }
        }
        private void SetDefaultTheme(Theme tempTheme)
        {
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
            {
                rk.OpenSubKey("NekoPavel", true).SetValue("ThemeName", tempTheme.visibleName);
            }
        }

        private void SetColours()
        {
            foreach (var control in Controls)
            {
                ((Control)control).BackColor = foreColour;
                ((Control)control).ForeColor = textColour;
            }
            BackColor = backColour;
            ForeColor = textColour;
        }
        private void backgroundPickerDialogColorChangedHandler(object sender, EventArgs e)
        {
            backColour = ((ColorPickerDialog)sender).Color;
            SetColours();
        }
        private void backgroundPickerButton_Click(object sender, EventArgs e)
        {
            using (ColorPickerDialog dialog = new ColorPickerDialog())
            {
                Color savedColour = backColour;
                dialog.Color = backColour;
                dialog.ShowAlphaChannel = false;

                dialog.PreviewColorChanged += this.backgroundPickerDialogColorChangedHandler;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    backColour = dialog.Color;
                    SetColours();
                }
                else
                {
                    backColour = savedColour;
                    SetColours();
                }

                dialog.PreviewColorChanged -= this.backgroundPickerDialogColorChangedHandler;
            }
        }
        private void textPickerDialogColorChangedHandler(object sender, EventArgs e)
        {
            textColour = ((ColorPickerDialog)sender).Color;
            SetColours();
        }
        private void textPickerButton_Click(object sender, EventArgs e)
        {
            using (ColorPickerDialog dialog = new ColorPickerDialog())
            {
                Color savedColour = textColour;
                dialog.Color = textColour;
                dialog.ShowAlphaChannel = false;

                dialog.PreviewColorChanged += this.textPickerDialogColorChangedHandler;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    textColour = dialog.Color;
                    SetColours();
                }
                else
                {
                    textColour = savedColour;
                    SetColours();
                }

                dialog.PreviewColorChanged -= this.textPickerDialogColorChangedHandler;
            }
        }
        private void foregroundPickerDialogColorChangedHandler(object sender, EventArgs e)
        {
            foreColour = ((ColorPickerDialog)sender).Color;
            SetColours();
        }
        private void foregroundPickerButton_Click(object sender, EventArgs e)
        {
            using (ColorPickerDialog dialog = new ColorPickerDialog())
            {
                Color savedColour = foreColour;
                dialog.Color = foreColour;
                dialog.ShowAlphaChannel = false;

                dialog.PreviewColorChanged += this.foregroundPickerDialogColorChangedHandler;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    foreColour = dialog.Color;
                    SetColours();
                }
                else
                {
                    foreColour = savedColour;
                    SetColours();
                }
                dialog.PreviewColorChanged -= this.foregroundPickerDialogColorChangedHandler;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string themeSaveName = themeNameTextBox.Text.Trim();
            if (((Theme)themeSelector.SelectedItem).visibleName == themeSaveName && ((Theme)themeSelector.SelectedItem).colours[0] == backColour && ((Theme)themeSelector.SelectedItem).colours[1] == foreColour && ((Theme)themeSelector.SelectedItem).colours[2] == textColour)
            {
                SetDefaultTheme((Theme)themeSelector.SelectedItem);
            }
            else
            {
                if (!themesDefault.Exists(x => x.visibleName == themeSaveName))
                {
                    themeSelector.BeginUpdate();
                    Theme tempTheme = new Theme(themeSaveName, backColour, foreColour, textColour);
                    if (themes.Exists(x => x.visibleName == tempTheme.visibleName))
                    {
                        //themesBinding.Remove(themes.Find(x => x.visibleName == tempTheme.visibleName));
                        //themes.Remove(themes.Find(x => x.visibleName == tempTheme.visibleName));
                        themesBinding[themesBinding.IndexOf(themes.Find(x => x.visibleName == tempTheme.visibleName))].colours = tempTheme.colours;
                        themes[themes.IndexOf(themes.Find(x => x.visibleName == tempTheme.visibleName))].colours = tempTheme.colours;
                    }
                    else
                    {
                        themes.Add(tempTheme);
                        themesBinding.Add(tempTheme);
                        themeSelector.SelectedItem = themes.Find(x => x.visibleName == themeSaveName);
                    }
                    //themeNameTextBox.Text = tempTheme.visibleName;
                    //themeSelector.SelectedItem = themes.Find(x => x.visibleName == themeNameTextBox.Text);
                    ExportThemes();
                    SetDefaultTheme((Theme)themeSelector.SelectedItem);
                    themeSelector.EndUpdate();
                }
                else
                {
                    MessageBox.Show("Du kan inte överskriva standardteman!" + Environment.NewLine + "Skriv ett annat namn.", "Skyddat tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void themeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            themeNameTextBox.Text = ((Theme)themeSelector.SelectedItem).visibleName;
            backColour = ((Theme)themeSelector.SelectedItem).colours[0];
            foreColour = ((Theme)themeSelector.SelectedItem).colours[1];
            textColour = ((Theme)themeSelector.SelectedItem).colours[2];
            SetColours();
        }

        private void removeThemeButton_Click(object sender, EventArgs e)
        {
            string themeRemoveName = themeNameTextBox.Text.Trim();
            if (themes.Exists(x => x.visibleName == themeRemoveName))
            {
                if (!themesDefault.Exists(x => x.visibleName == themeRemoveName))
                {
                    if (MessageBox.Show("Är du säker på att du vill ta bort temat?", "Bekräftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE", true))
                        {
                            if (themeRemoveName == rk.OpenSubKey("NekoPavel").GetValue("ThemeName").ToString())
                            {
                                SetDefaultTheme(themes.Find(x => x.visibleName == "Dark"));
                            }
                            themesBinding.Remove(themes.Find(x => x.visibleName == themeRemoveName));
                            themes.Remove(themes.Find(x => x.visibleName == themeRemoveName));
                            rk.OpenSubKey("NekoPavel", true).DeleteSubKey(themeRemoveName);
                        }
                        themeSelector.SelectedItem = themes.Find(x => x.visibleName == "Dark");
                    }
                }
                else
                {
                    MessageBox.Show("Du kan inte ta bort standardteman!", "Skyddat tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Du kan inte ta bort ett tema som inte existerar!", "Felaktigt tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
