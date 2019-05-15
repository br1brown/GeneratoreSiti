using GeneratoreSit.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratoreSit
{
    public partial class Form1 : Form
    {
        private int _font;
        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.DoWork += (obj, e) => WorkerDoWork(
                txtName.Text,
                txtPath.Text,
                txtUser.Text,
                pColor.BackColor.R,
                pColor.BackColor.G,
                pColor.BackColor.B,
                pColor.BackColor.A,
                _font,
                (int)numCol.Value,
                txttitolo.Text,
                cbtn.Checked,
                txtContent.Text
                );

            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPath.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            try
            {
                txtUser.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            }
            catch
            {
                txtUser.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }

            txtContent.Text = Resources.txt;
            drpdFont.Items.AddRange(TheGEN.FONT);
            drpdFont.SelectedIndex = 0;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            ScegliPercorso();
        }

        private void ScegliPercorso()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Dove Generare il sito";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                pColor.BackColor = colorDlg.Color;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnGenera.Enabled = !string.IsNullOrEmpty(txtName.Text.Trim());
            txtName.BackColor = Color.OrangeRed;
            if (btnGenera.Enabled)
                txtName.BackColor = Color.White;
        }

        private void WorkerDoWork(string txtName,
            string txtPath,
            string user,
            int R,
            int G,
            int B,
            int A,
            int Nfont,
            int numCol,
            string titleIndex,
            bool bBtn,
            string content
            )
        {
            var g = new TheGEN(txtName, txtPath);
            g.Author = user;
            backgroundWorker1.ReportProgress(1);
            g.CREATEsweetalert();
            backgroundWorker1.ReportProgress(2);
            g.CREATEsweetalertJS();
            backgroundWorker1.ReportProgress(3);
            g.CREATEcss(R, G, B, A, Nfont);
            backgroundWorker1.ReportProgress(4);
            string str = null;
            if (!string.IsNullOrEmpty(content.Trim()))
                str = content;
            g.CREATEindex(titleIndex, str, numCol, bBtn);
            backgroundWorker1.ReportProgress(5);
            MessageBox.Show("Generazione Completata");
            backgroundWorker1.ReportProgress(0);
            Process.Start(g.ToString());
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progr.Value = e.ProgressPercentage;
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void drpdFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            _font = drpdFont.SelectedIndex;
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                txtContent.Text = Resources.txt;
            }

        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text.Equals(Resources.txt))
            {
                txtContent.Text = "";
            }
        }
    }
}
