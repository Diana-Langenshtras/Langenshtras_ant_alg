namespace Langenshtras_ant_alg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AddVertex = new System.Windows.Forms.Button();
            this.ConnectVertex = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AntAlg = new System.Windows.Forms.Button();
            this.DeleteVertex = new System.Windows.Forms.Button();
            this.DisconnectVertex = new System.Windows.Forms.Button();
            this.DeleteGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(163, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 634);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // AddVertex
            // 
            this.AddVertex.Location = new System.Drawing.Point(7, 12);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(147, 34);
            this.AddVertex.TabIndex = 1;
            this.AddVertex.Text = "Добавить вершину";
            this.AddVertex.UseVisualStyleBackColor = true;
            this.AddVertex.Click += new System.EventHandler(this.AddVertex_Click);
            // 
            // ConnectVertex
            // 
            this.ConnectVertex.Location = new System.Drawing.Point(6, 193);
            this.ConnectVertex.Name = "ConnectVertex";
            this.ConnectVertex.Size = new System.Drawing.Size(147, 34);
            this.ConnectVertex.TabIndex = 2;
            this.ConnectVertex.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Алгоритм А*";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AntAlg
            // 
            this.AntAlg.Location = new System.Drawing.Point(7, 132);
            this.AntAlg.Name = "AntAlg";
            this.AntAlg.Size = new System.Drawing.Size(147, 34);
            this.AntAlg.TabIndex = 4;
            this.AntAlg.Text = "Муравьиный алгоритм";
            this.AntAlg.UseVisualStyleBackColor = true;
            // 
            // DeleteVertex
            // 
            this.DeleteVertex.Location = new System.Drawing.Point(6, 52);
            this.DeleteVertex.Name = "DeleteVertex";
            this.DeleteVertex.Size = new System.Drawing.Size(147, 34);
            this.DeleteVertex.TabIndex = 5;
            this.DeleteVertex.Text = "Уменьшить вершины";
            this.DeleteVertex.UseVisualStyleBackColor = true;
            this.DeleteVertex.Click += new System.EventHandler(this.DeleteVertex_Click);
            // 
            // DisconnectVertex
            // 
            this.DisconnectVertex.Location = new System.Drawing.Point(7, 233);
            this.DisconnectVertex.Name = "DisconnectVertex";
            this.DisconnectVertex.Size = new System.Drawing.Size(147, 34);
            this.DisconnectVertex.TabIndex = 6;
            this.DisconnectVertex.UseVisualStyleBackColor = true;
            // 
            // DeleteGraph
            // 
            this.DeleteGraph.Location = new System.Drawing.Point(6, 302);
            this.DeleteGraph.Name = "DeleteGraph";
            this.DeleteGraph.Size = new System.Drawing.Size(147, 34);
            this.DeleteGraph.TabIndex = 7;
            this.DeleteGraph.Text = "Удалить граф";
            this.DeleteGraph.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 2);
            this.label2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteGraph);
            this.Controls.Add(this.DisconnectVertex);
            this.Controls.Add(this.DeleteVertex);
            this.Controls.Add(this.AntAlg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConnectVertex);
            this.Controls.Add(this.AddVertex);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddVertex;
        private System.Windows.Forms.Button ConnectVertex;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AntAlg;
        private System.Windows.Forms.Button DeleteVertex;
        private System.Windows.Forms.Button DisconnectVertex;
        private System.Windows.Forms.Button DeleteGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

