using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Runtime.InteropServices;

namespace EditorTestuale
{
    public partial class EditorTestuale : Form
    {
        ScrollTextBox sTxbRighe;
        public EditorTestuale()
        {
            InitializeComponent();
            sTxbRighe = new ScrollTextBox();
            sTxbRighe.BackColor = System.Drawing.SystemColors.Window;
            sTxbRighe.Enabled = false;
            sTxbRighe.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTxbRighe.Location = new System.Drawing.Point(72, 10);
            sTxbRighe.Multiline = true;
            sTxbRighe.Name = "sTxbRighe";
            sTxbRighe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            sTxbRighe.Size = new System.Drawing.Size(304, 260);
            sTxbRighe.TabIndex = 0;
            sTxbRighe.TextChanged += new System.EventHandler(this.txtBEditor_TextChanged);
            sTxbRighe.KeyUp += STxbRighe_KeyUp;
            sTxbRighe.MyTextBoxScrollEvent += STxbRighe_MyTextBoxScrollEvent;
            this.Controls.Add(sTxbRighe);
        }


        #region  Events Management
        private void STxbRighe_KeyUp(object sender, KeyEventArgs e)
        {
            syncScroll();
        }

        private void STxbRighe_MyTextBoxScrollEvent(object sender, EventArgs e)
        {
            syncScroll();
        }
        private void BtnIndenta_Click(object sender, EventArgs e)
        {
            sTxbRighe.Text = IndentaCSharp(sTxbRighe.Text);
        }

        private void BtnScelta_Click(object sender, EventArgs e)
        {
            sTxbRighe.Text = ReadCSFile();
            sTxbRighe.Enabled = true;
            lblNomefile.Text = "Percorso file: " + _currentFilePath;
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            SaveFileInPath();
        }

        private void txtBEditor_TextChanged(object sender, EventArgs e)
        {
            ContaRighe();
            syncScroll();
        }

        #endregion

        #region Business Logic
        public string IndentaCSharp(string text)
        {
            return CSharpSyntaxTree.ParseText(text).GetRoot().NormalizeWhitespace().ToFullString();
        }

        #region File Management
        private string _currentFilePath = string.Empty;

        private string ReadCSFile()
        {
            string csText = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "CS Files|*.cs",
                Title = "Select a CS File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentFilePath = openFileDialog1.FileName;              
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                csText = sr.ReadToEnd();
                sr.Close();
            }

            return csText;
        }

        private void SaveFileInPath()
        {
            using (StreamWriter writer = new StreamWriter(_currentFilePath, false))
            {
                writer.Write(sTxbRighe.Text);
            }
        }
        #endregion
        #region ContaRighe
        private void ContaRighe()
        {
            StringReader reader = new StringReader(sTxbRighe.Text);
            string riga;
            int n = 1, nBlanck = 1;
            txbRighe.Text = String.Empty;
            while ((riga = reader.ReadLine()) != null)
            {
                txbRighe.Text += (n.ToString() + "\r\n");
                if (riga.Length >= 40)
                {
                    nBlanck = (riga.Length / 40);
                    if (riga.Length % 40 != 0)
                        txbRighe.Text += "\r\n";
                    for (int i = 1; i < nBlanck; i++)
                        txbRighe.Text += "\r\n";
                }
                n++;
            }
        }

        #endregion

        #region scorriIndicatoreRighe
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

        [DllImport("user32.dll")]
        static extern int SetScrollInfo(IntPtr hwnd, int fnBar, [In] ref SCROLLINFO lpsi, bool fRedraw);

        const int EM_LINESCROLL = 0x00B6;

        public enum ScrollInfoMask : uint
        {
            SIF_RANGE = 0x1,
            SIF_PAGE = 0x2,
            SIF_POS = 0x4,
            SIF_DISABLENOSCROLL = 0x8,
            SIF_TRACKPOS = 0x10,
            SIF_ALL = (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS),
        }
        public enum SBOrientation : int
        {
            SB_HORZ = 0x0,
            SB_VERT = 0x1,
            SB_CTL = 0x2,
            SB_BOTH = 0x3
        }
        [Serializable, StructLayout(LayoutKind.Sequential)]
        struct SCROLLINFO
        {
            public int cbSize; // (uint) int is because of Marshal.SizeOf
            public uint fMask;
            public int nMin;
            public int nMax;
            public uint nPage;
            public int nPos;
            public int nTrackPos;
        }
        private void syncScroll()
        {
            SCROLLINFO si = new SCROLLINFO();
            si.cbSize = Marshal.SizeOf(si);
            si.fMask = (int)ScrollInfoMask.SIF_ALL;
            GetScrollInfo(sTxbRighe.Handle, (int)SBOrientation.SB_VERT, ref si);
            //SetScrollInfo(txbRighe.Handle, (int)SBOrientation.SB_VERT, ref si, true);
            txbRighe.SelectionStart = 0;
            txbRighe.SelectionLength = 1;
            txbRighe.ScrollToCaret();
            SendMessage(txbRighe.Handle, EM_LINESCROLL, 0, si.nPos);
        }
        #endregion
        #endregion


    }
}
