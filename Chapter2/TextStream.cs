using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2
{
    public partial class TextStream : Form
    {
        public TextStream()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            fs.Close();
            MessageBox.Show("There are " + lineCount + " lines in " + ofd.FileName);
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            int[] myArray = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                myArray[i] = i;
                bw.Write(myArray[i]);
            }
            bw.Close();
        }

    }
}
