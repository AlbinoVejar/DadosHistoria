using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosDibujos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarHistoria(object sender, EventArgs e)
        {
            var numeroRandom = new Random().Next(1, 6);
            //MessageBox.Show(numeroRandom.ToString());
            GetImageTool(numeroRandom);
            //pnlHerramienta.BackgroundImage = GetPathTool(numeroRandom.ToString());
        }
        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetImageTool(int name)
        {
            switch (name)
            {
                case 1:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t1;break;
                case 2:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t2;break;
                case 3:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t3; break;
                case 4:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t4; break;
                case 5:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t5; break;
                case 6:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t6; break;
                default:
                    pnlHerramienta.BackgroundImage = Properties.Resources.t1; break;
            }
            //string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            //return string.Format("{0}Resources\\t{1}.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")), name);
        }

        private void Animacion()
        {
            
        }
    }
}
