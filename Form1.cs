using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Langenshtras_ant_alg
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Gray, 1);
        double A = 0.7;
        int N = 10;
        
        public Form1()
        {
          //  int[] bestTrail = antColonyProgram.bestTrail;
            //  AntColonyProgram antColonyProgram = new AntColonyProgram(N, 4);

            InitializeComponent();

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            AntColonyProgram antColonyProgram = new AntColonyProgram(N, 10);
            int m = 0;
            int k = 0;
            Graphics gr = e.Graphics;
            for (int i = 0; i < N; i++)
            {
                //    Button button = new System.Windows.Forms.Button();
                //    button.Location = new System.Drawing.Point((int)(A * 350 * Math.Sin(6.28 / N * i) + 317-18), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * i) + 317-18));
              //  gr.FillEllipse(new SolidBrush(Color.Gray), (int)(A * 350 * Math.Sin(6.28 / N * i) + 317 - 18), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * i) + 317 - 18), 35, 35);
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        
                        Point p1 = new Point((int)(A * 350 * Math.Sin(6.28 / N * i) + 317), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * i) + 317));// первая точка
                        Point p2 = new Point((int)(A * 350 * Math.Sin(6.28 / N * j) + 317), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * j) + 317));// вторая точка
                                                                                                                                                   //  g.DrawLine(pen, p1, p2);// рисуем линию
                        gr.DrawLine(p, p1, p2);// рисуем линию
                        

                    }

                }

                
                //   button.Size = new System.Drawing.Size(35, 35);
                //   button.TabIndex = i;
                //   button.Text = i.ToString();
                //   button.UseVisualStyleBackColor = true;
                //   this.panel1.Controls.Add(button);

            }
            while (k < antColonyProgram.bestTrail.Length - 1)
            {
                //  for (m = 0; m < N; m++)
                //   if (m == antColonyProgram.bestTrail[k])
                //  {
                p = new Pen(Color.Red, 2);
                Point p1 = new Point((int)(A * 350 * Math.Sin(6.28 / N * antColonyProgram.bestTrail[k]) + 317), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * antColonyProgram.bestTrail[k]) + 317));// первая точка
                Point p2 = new Point((int)(A * 350 * Math.Sin(6.28 / N * antColonyProgram.bestTrail[k + 1]) + 317), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * antColonyProgram.bestTrail[k + 1]) + 317));// вторая точка
                                                                                                                                                                                                           //  g.DrawLine(pen, p1, p2);// рисуем линию
                gr.DrawLine(p, p1, p2);// рисуем линию
                k++;
                //      break;// 
                // }


                p = new Pen(Color.Gray, 1);
            }
            for (int i = 0; i < N; i++)
            {
                gr.FillEllipse(new SolidBrush(Color.Gray), (int)(A * 350 * Math.Sin(6.28 / N * i) + 317 - 18), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * i) + 317 - 18), 35, 35);
                Label label = new System.Windows.Forms.Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label.ForeColor = System.Drawing.Color.Black;
                label.Location = new System.Drawing.Point((int)(A * 350 * Math.Sin(6.28 / N * i) + 317-9), (int)((A + 0.1) * 350 * Math.Cos(6.28 / N * i) + 317-9));
                label.Size = new System.Drawing.Size(18, 18);
                label.TabIndex = i;
                label.Text = i.ToString();
                this.panel1.Controls.Add(label);
            }
        //    int[] bestTrail = antColonyProgram.bestTrail;
            gr.Dispose();
        }

        private void AddVertex_Click(object sender, EventArgs e)
        {
            N++;
            panel1.Controls.Clear();
            this.Refresh(); // обновление конкретного элемента на форме
        }

        private void DeleteVertex_Click(object sender, EventArgs e)
        {
            if (N >4)
            N--;
            panel1.Controls.Clear();
            this.Refresh(); // обновление конкретного элемента на форме
        }
    }
}
