namespace projeto_final
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nome2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.confirmar1 = new System.Windows.Forms.TextBox();
            this.passe1 = new System.Windows.Forms.TextBox();
            this.email1 = new System.Windows.Forms.TextBox();
            this.nome1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 25);
            this.toolStripMenuItem1.Text = "Sair";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(106, 25);
            this.toolStripMenuItem3.Text = "Retroceder";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 47);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 125);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gestor de Salas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.button2.Location = new System.Drawing.Point(387, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 125);
            this.button2.TabIndex = 4;
            this.button2.Text = "Criar Conta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.button3.Location = new System.Drawing.Point(12, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(330, 125);
            this.button3.TabIndex = 6;
            this.button3.Text = "Tópicos de Assunto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nome2
            // 
            this.nome2.Location = new System.Drawing.Point(634, 32);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(86, 22);
            this.nome2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.confirmar1);
            this.panel1.Controls.Add(this.passe1);
            this.panel1.Controls.Add(this.email1);
            this.panel1.Controls.Add(this.nome1);
            this.panel1.Location = new System.Drawing.Point(387, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 364);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(80, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Guardar Registo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // confirmar1
            // 
            this.confirmar1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.confirmar1.Location = new System.Drawing.Point(24, 225);
            this.confirmar1.Name = "confirmar1";
            this.confirmar1.Size = new System.Drawing.Size(278, 35);
            this.confirmar1.TabIndex = 3;
            this.confirmar1.Text = "Confirmar Palavra-Passe...";
            this.confirmar1.Click += new System.EventHandler(this.confirmar1_Click);
            this.confirmar1.TextChanged += new System.EventHandler(this.confirmar1_TextChanged);
            // 
            // passe1
            // 
            this.passe1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.passe1.Location = new System.Drawing.Point(24, 160);
            this.passe1.Name = "passe1";
            this.passe1.Size = new System.Drawing.Size(278, 35);
            this.passe1.TabIndex = 2;
            this.passe1.Text = "Palavra-Passe...";
            this.passe1.Click += new System.EventHandler(this.passe1_Click);
            this.passe1.TextChanged += new System.EventHandler(this.passe1_TextChanged);
            // 
            // email1
            // 
            this.email1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.email1.Location = new System.Drawing.Point(24, 94);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(278, 35);
            this.email1.TabIndex = 1;
            this.email1.Text = "Email...";
            this.email1.Click += new System.EventHandler(this.email1_Click);
            // 
            // nome1
            // 
            this.nome1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.nome1.Location = new System.Drawing.Point(24, 37);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(278, 35);
            this.nome1.TabIndex = 0;
            this.nome1.Text = "Nome de Utilizador...";
            this.nome1.Click += new System.EventHandler(this.nome1_Click);
            this.nome1.TextChanged += new System.EventHandler(this.nome1_TextChanged);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nome2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox confirmar1;
        private System.Windows.Forms.TextBox passe1;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.TextBox nome1;
        private System.Windows.Forms.Button button4;
    }
}