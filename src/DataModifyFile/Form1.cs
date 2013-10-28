using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataModifyFile
{
    public partial class Form1 : Form
    {
        string UseDirectory = "";
        CancellationTokenSource cts = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void bStart_Click(object sender, EventArgs e)
        {
            if (tbDirectory.Text == "")
                return;

            try 
            {
                Start();

                int tmp = await Task<int>.Run(() =>
                {
                    int result = 0;

                    string[] filePaths = Directory.GetFiles(UseDirectory);
                    foreach (var el in filePaths)
                    {
                        var dt = File.GetLastWriteTime(el);
                        SetText("\n\t" + Path.GetFileName(el) + "\t-->\t" + dt);
                        cts.Token.ThrowIfCancellationRequested();
                    }

                    return result;
                });
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка во время выполнения программ:\n" + 
                                err.Message.ToString(), 
                                "Ошибка", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            finally
            {
                End();
            }
        }

        private void End()
        {
            pbWatch.Visible = false;
            bStart.Enabled = true;
            bStart.Visible = true;
            bCancel.Visible = false;
            bCancel.Enabled = false;
            if (cts != null)
            {
                cts.Dispose();
                cts = null;
            }
        }

        private void Start()
        {
            UseDirectory = "";
            rtbResult.Text = "";
            pbWatch.Visible = true;
            cts = new CancellationTokenSource();
            bStart.Enabled = false;
            bStart.Visible = false;
            bCancel.Visible = true;
            bCancel.Enabled = true;

            UseDirectory = tbDirectory.Text;
            rtbResult.Text = "\n" + "Файл\t-->\tДата последней модификации\n\n";
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.rtbResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtbResult.Text += text;
            }
        }

        private void btDll_Click(object sender, EventArgs e)
        {
            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbDirectory.Text = fbdDirectory.SelectedPath;
                }
                catch (Exception err)
                {
                    tbDirectory.Text = "";
                    MessageBox.Show("Hе возможно считать директорию: " + 
                                    err.Message, 
                                    "Ошибка", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
            }
            Refresh();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
