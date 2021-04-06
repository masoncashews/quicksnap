using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace QuickSnap
{
    public partial class Main : Form
    {
        private Point _upperCorner;
        private Point _lowerCorner;
        private QuickSnap.Settings currentSettings;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string strRegionFieldsToolTip = "Ctrl+X to set upper corner.\r\nCtrl+Y to set lower corner.\r\nCtrl+S to save to set the fields.";

            toolTipMain.SetToolTip(txtUpperCorner, strRegionFieldsToolTip);
            toolTipMain.SetToolTip(txtSize, strRegionFieldsToolTip);            
            
            QuickSnap.GetSettings(ref currentSettings);

            if (currentSettings == null)
            {
                currentSettings = new QuickSnap.Settings();
                currentSettings.Prefix = "ET";
                currentSettings.UpperCorner = "600,100";
                currentSettings.Size = "1670,940";
                currentSettings.Name = "TEST";
                currentSettings.Suffix = "1";
                currentSettings.Path = @"C:\Users\jason\Google Drive\Training\AZ900\acg\quicksnap";
                currentSettings.AutoIncrementSuffix = false;

                QuickSnap.SaveSettings(ref currentSettings);
                //txtScreen.Text = "1";
                //txtPrefix.Text = "ET";
                //txtUpperCorner.Text = "600,100";
                //txtSize.Text = "1670,940";
                //txtName.Text = "TEST";
                //cboSuffix.Text = "1";
            }

            for (int i = 1; i <= 500; i++)
                cboSuffix.Items.Add(i);

            txtPrefix.Text = currentSettings.Prefix;
            txtUpperCorner.Text = currentSettings.UpperCorner;
            txtSize.Text = currentSettings.Size;
            txtName.Text = currentSettings.Name;
            cboSuffix.Text = currentSettings.Suffix;
            txtPath.Text = currentSettings.Path;
            chkAutoIncrementSuffix.Checked = currentSettings.AutoIncrementSuffix;     
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            char splitchar = ",".ToCharArray()[0];
            int upperCornerX = Convert.ToInt32(txtUpperCorner.Text.Split(splitchar)[0]);
            int upperCornerY= Convert.ToInt32(txtUpperCorner.Text.Split(splitchar)[1]);
            int capWidth= Convert.ToInt32(txtSize.Text.Split(splitchar)[0]);
            int capHeight= Convert.ToInt32(txtSize.Text.Split(splitchar)[1]);

            string newFilePath = string.Format("{0}\\{1}-{2}-{3}.jpg", txtPath.Text, txtPrefix.Text, txtName.Text, cboSuffix.Text);

            bool DoSave = false;

            Rectangle scrnZone = new Rectangle(upperCornerX, upperCornerY, capWidth, capHeight);
            using (Bitmap bp = new Bitmap(capWidth, capHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                using (Graphics cap = Graphics.FromImage(bp))
                {
                    cap.CopyFromScreen(scrnZone.Left, scrnZone.Top, 0,0, scrnZone.Size);
                    if (File.Exists(newFilePath))
                     {
                         if (MessageBox.Show(
                                this,
                                String.Format("File Already Exists!\r\n Overwrite {0}?", newFilePath),
                                "Error",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error) == DialogResult.Yes) 
                            DoSave = true;
                    }
                    else
                    {
                        DoSave = true;
                    }

                    if (DoSave)
                    {
                        bp.Save(newFilePath, ImageFormat.Jpeg);
                        currentSettings.Name = txtName.Text;
                        currentSettings.Path = txtPath.Text;
                        currentSettings.Prefix = txtPrefix.Text;
                        currentSettings.Size = txtSize.Text;
                        currentSettings.Suffix = cboSuffix.Text;
                        currentSettings.UpperCorner = txtUpperCorner.Text;
                        currentSettings.AutoIncrementSuffix = chkAutoIncrementSuffix.Checked;

                        if (chkAutoIncrementSuffix.Checked)
                        {
                            try
                            {
                                var curVal = Convert.ToInt32(cboSuffix.Text);
                                curVal++;
                                cboSuffix.Text = curVal.ToString();
                            }
                            finally { }
                        }
                        QuickSnap.SaveSettings(ref currentSettings);
                    }
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            cboSuffix.Text = "1";
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            cboSuffix.Text = "1";
        }

        private void lnkDecrementSuffix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var curVal = Convert.ToInt32(cboSuffix.Text);
                curVal--;
                cboSuffix.Text = curVal.ToString();
            }
            finally { }
        }

        private void btnFindMouse_Click(object sender, EventArgs e)
         {
            Debug.Print(System.Windows.Forms.Control.MousePosition.ToString()); 
        }

        private void RegionFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.X)
                {
                    _upperCorner = System.Windows.Forms.Control.MousePosition;
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Y)
                {
                    _lowerCorner = System.Windows.Forms.Control.MousePosition;
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.S)
                {
                    if (_upperCorner != null && _lowerCorner != null)
                    {
                        string regionSize;
                        string regionCorner;
                        regionCorner = string.Format("{0},{1}", _upperCorner.X.ToString(), _upperCorner.Y.ToString());
                        regionSize = string.Format("{0},{1}", (_lowerCorner.X - _upperCorner.X).ToString(), (_lowerCorner.Y - _upperCorner.Y).ToString());


                        if (MessageBox.Show(
                               this,
                               String.Format("Set Quicksnap size to {0}\r\n And Quicksnap upper corner to {1}?", regionSize, regionCorner),
                               "Change Size",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            txtSize.Text = regionSize;
                            txtUpperCorner.Text = regionCorner;
                        }
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
    }
}
