using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PerawatanIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string MyVersion = "Perawatan IT v1.0";


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static void ClearText(Control x)
        {
            foreach (Control c in x.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
        }

        public static void MsgInfo(string Message)
        {
            MessageBox.Show(Message, "Information",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static void MsgError(string Message)
        {
            MessageBox.Show(Message, "Error",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void MsgWarning(string Message)
        {
            MessageBox.Show(Message, "Warning",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public static void ShowBox(Form x)
        {
//            System.Drawing.Icon ic = new System.Drawing.Icon(".\\icon.ico");
//            x.Icon = ic;
            x.MaximizeBox = false;
            x.MinimizeBox = false;
            x.MaximumSize = x.Size;
            x.MinimumSize = x.Size;
            x.SizeGripStyle = SizeGripStyle.Hide;
            x.StartPosition = FormStartPosition.CenterParent;
            x.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            x.KeyPreview = true;
            x.ShowDialog();
        }

        public static DialogResult MsgYesNo(string Message)
        {
            return MessageBox.Show(Message, "Confirmation",
                System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }

    }
}
