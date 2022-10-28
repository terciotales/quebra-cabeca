namespace quebra_cabeca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starWarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theWitcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godOfWarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fácilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tentativas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.dificuldadeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starWarsToolStripMenuItem,
            this.theWitcherToolStripMenuItem,
            this.godOfWarToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // starWarsToolStripMenuItem
            // 
            this.starWarsToolStripMenuItem.Checked = true;
            this.starWarsToolStripMenuItem.CheckOnClick = true;
            this.starWarsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.starWarsToolStripMenuItem.Name = "starWarsToolStripMenuItem";
            this.starWarsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.starWarsToolStripMenuItem.Text = "Star Wars";
            this.starWarsToolStripMenuItem.Click += new System.EventHandler(this.starWarsToolStripMenuItem_Click);
            // 
            // theWitcherToolStripMenuItem
            // 
            this.theWitcherToolStripMenuItem.CheckOnClick = true;
            this.theWitcherToolStripMenuItem.Name = "theWitcherToolStripMenuItem";
            this.theWitcherToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.theWitcherToolStripMenuItem.Text = "The Witcher";
            this.theWitcherToolStripMenuItem.Click += new System.EventHandler(this.theWitcherToolStripMenuItem_Click);
            // 
            // godOfWarToolStripMenuItem
            // 
            this.godOfWarToolStripMenuItem.CheckOnClick = true;
            this.godOfWarToolStripMenuItem.Name = "godOfWarToolStripMenuItem";
            this.godOfWarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.godOfWarToolStripMenuItem.Text = "God Of War";
            this.godOfWarToolStripMenuItem.Click += new System.EventHandler(this.godOfWarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dificuldadeToolStripMenuItem
            // 
            this.dificuldadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fácilToolStripMenuItem,
            this.médioToolStripMenuItem,
            this.difícilToolStripMenuItem});
            this.dificuldadeToolStripMenuItem.Name = "dificuldadeToolStripMenuItem";
            this.dificuldadeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.dificuldadeToolStripMenuItem.Text = "Dificuldade";
            // 
            // fácilToolStripMenuItem
            // 
            this.fácilToolStripMenuItem.Name = "fácilToolStripMenuItem";
            this.fácilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.fácilToolStripMenuItem.Text = "Fácil";
            this.fácilToolStripMenuItem.Click += new System.EventHandler(this.fácilToolStripMenuItem_Click);
            // 
            // médioToolStripMenuItem
            // 
            this.médioToolStripMenuItem.Name = "médioToolStripMenuItem";
            this.médioToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.médioToolStripMenuItem.Text = "Médio";
            this.médioToolStripMenuItem.Click += new System.EventHandler(this.médioToolStripMenuItem_Click);
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.difícilToolStripMenuItem.Text = "Difícil";
            this.difícilToolStripMenuItem.Click += new System.EventHandler(this.difícilToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(700, 620);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quebra-cabeça";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(725, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(540, 480);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peças";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1138, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1138, 538);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Embaralhar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tentativas:";
            // 
            // tentativas
            // 
            this.tentativas.AutoSize = true;
            this.tentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tentativas.Location = new System.Drawing.Point(731, 553);
            this.tentativas.Name = "tentativas";
            this.tentativas.Size = new System.Drawing.Size(32, 33);
            this.tentativas.TabIndex = 5;
            this.tentativas.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 677);
            this.Controls.Add(this.tentativas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Quebra Cabeça";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private ToolStripMenuItem starWarsToolStripMenuItem;
        private ToolStripMenuItem theWitcherToolStripMenuItem;
        private ToolStripMenuItem godOfWarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button button2;
        private Label label1;
        private Label tentativas;
        private ToolStripMenuItem dificuldadeToolStripMenuItem;
        private ToolStripMenuItem fácilToolStripMenuItem;
        private ToolStripMenuItem médioToolStripMenuItem;
        private ToolStripMenuItem difícilToolStripMenuItem;
    }
}