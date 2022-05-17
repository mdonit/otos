using LottoSzimulator.Data;
using LottoSzimulator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSzimulator
{
    public partial class Form1 : Form
    {
        List<int> tippek = new List<int>();
        LottoAdatContext db = new LottoAdatContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tippek.Add(Convert.ToInt32(box.Text));
                if (tippek.Count() == 5)
                {
                    foreach (CheckBox item in tarolo.Controls)
                    {
                        if (!item.Checked) item.Enabled = false;
                    }
                    btnSorsol.Enabled = true;
                    //MessageBox.Show(string.Join("/", tippek.OrderBy(x => x)));
                }
            }
            else
            {
                tippek.Remove(Convert.ToInt32(box.Text));
                if (tippek.Count() == 4)
                {
                    btnSorsol.Enabled = false;
                    foreach(CheckBox item in tarolo.Controls)
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        void btnSorsol_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            HashSet<int> halmaz = new HashSet<int>();
            do
            {
                halmaz.Add(rand.Next(1, 91));
            } while (halmaz.Count != 5);
            MessageBox.Show("Eltaláltál " + halmaz.Intersect(tippek).Count() + " db számot {" + string.Join("; ", halmaz.Intersect(tippek).OrderBy(x => x)) + "}");

            db.Otos.Add(new Huzas(string.Join(";", tippek)));
            db.SaveChanges();
        }

        void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            btnSorsol.Enabled = false;
            //this.Size = new Size(800, 800);
            tarolo.Size = new Size(580, 500);
            for (int i = 0; i < 90; i++)
            {
                CheckBox box = new CheckBox();
                box.Location = new Point( 50+(i%10)*50, 50 + i / 10 * 50);
                box.Text = (i + 1).ToString();
                box.AutoSize = true;
                box.CheckedChanged += checkBox1_CheckedChanged;
                tarolo.Controls.Add(box);
            }
        }
    }
}
