namespace projeto_final
{
    partial class notificações
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notificações));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Docente = new System.Windows.Forms.Label();
            this.Sala = new System.Windows.Forms.Label();
            this.Assunto = new System.Windows.Forms.Label();
            this.Comentário = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nome2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(52, 25);
            this.toolStripMenuItem4.Text = "Sair";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 25);
            this.toolStripMenuItem2.Text = "Log Out";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 25);
            this.toolStripMenuItem1.Text = "Retroceder";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 25);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status1
            // 
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 47);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Docente
            // 
            this.Docente.AutoSize = true;
            this.Docente.BackColor = System.Drawing.Color.Transparent;
            this.Docente.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docente.Location = new System.Drawing.Point(70, 150);
            this.Docente.Name = "Docente";
            this.Docente.Size = new System.Drawing.Size(109, 40);
            this.Docente.TabIndex = 3;
            this.Docente.Text = "Docente:";
            // 
            // Sala
            // 
            this.Sala.AutoSize = true;
            this.Sala.BackColor = System.Drawing.Color.Transparent;
            this.Sala.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Sala.Location = new System.Drawing.Point(70, 200);
            this.Sala.Name = "Sala";
            this.Sala.Size = new System.Drawing.Size(70, 40);
            this.Sala.TabIndex = 4;
            this.Sala.Text = "Sala:";
            // 
            // Assunto
            // 
            this.Assunto.AutoSize = true;
            this.Assunto.BackColor = System.Drawing.Color.Transparent;
            this.Assunto.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Assunto.Location = new System.Drawing.Point(70, 250);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(109, 40);
            this.Assunto.TabIndex = 5;
            this.Assunto.Text = "Assunto:";
            // 
            // Comentário
            // 
            this.Comentário.AutoSize = true;
            this.Comentário.BackColor = System.Drawing.Color.Transparent;
            this.Comentário.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Comentário.Location = new System.Drawing.Point(70, 300);
            this.Comentário.Name = "Comentário";
            this.Comentário.Size = new System.Drawing.Size(148, 40);
            this.Comentário.TabIndex = 6;
            this.Comentário.Text = "Comentário:";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Data.Location = new System.Drawing.Point(70, 450);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(71, 40);
            this.Data.TabIndex = 7;
            this.Data.Text = "Data:";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Hora.Location = new System.Drawing.Point(70, 400);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(72, 40);
            this.Hora.TabIndex = 8;
            this.Hora.Text = "Hora:";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.Estado.Location = new System.Drawing.Point(70, 500);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(93, 40);
            this.Estado.TabIndex = 9;
            this.Estado.Text = "Estado:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.textBox2.Location = new System.Drawing.Point(200, 200);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 41);
            this.textBox2.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 300);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(256, 89);
            this.textBox4.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.textBox7.Location = new System.Drawing.Point(200, 500);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(295, 41);
            this.textBox7.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(200, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.label1.Location = new System.Drawing.Point(197, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Clique para aparecer a hora!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.label2.Location = new System.Drawing.Point(197, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Clique para aparecer a data!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.button1.Location = new System.Drawing.Point(200, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 55);
            this.button1.TabIndex = 20;
            this.button1.Text = "Enviar Notificação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F);
            this.textBox1.Location = new System.Drawing.Point(200, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 41);
            this.textBox1.TabIndex = 23;
            // 
            // nome2
            // 
            this.nome2.Location = new System.Drawing.Point(810, 44);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(139, 22);
            this.nome2.TabIndex = 22;
            this.nome2.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // notificações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Comentário);
            this.Controls.Add(this.Assunto);
            this.Controls.Add(this.Sala);
            this.Controls.Add(this.Docente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "notificações";
            this.Text = "Notificações";
            this.Load += new System.EventHandler(this.notificações_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel status1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Docente;
        private System.Windows.Forms.Label Sala;
        private System.Windows.Forms.Label Assunto;
        private System.Windows.Forms.Label Comentário;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nome2;
    }
}