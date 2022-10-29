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
            this.quebraCabeca = new System.Windows.Forms.GroupBox();
            this.pecas = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tentativas = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Button();
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
            this.fácilToolStripMenuItem.Checked = true;
            this.fácilToolStripMenuItem.CheckOnClick = true;
            this.fácilToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // quebraCabeca
            // 
            this.quebraCabeca.BackColor = System.Drawing.Color.White;
            this.quebraCabeca.Location = new System.Drawing.Point(10, 37);
            this.quebraCabeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quebraCabeca.Name = "quebraCabeca";
            this.quebraCabeca.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quebraCabeca.Size = new System.Drawing.Size(700, 620);
            this.quebraCabeca.TabIndex = 1;
            this.quebraCabeca.TabStop = false;
            this.quebraCabeca.Text = "Quebra-cabeça";
            // 
            // pecas
            // 
            this.pecas.BackColor = System.Drawing.Color.Transparent;
            this.pecas.Location = new System.Drawing.Point(725, 37);
            this.pecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pecas.Name = "pecas";
            this.pecas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pecas.Size = new System.Drawing.Size(540, 480);
            this.pecas.TabIndex = 2;
            this.pecas.TabStop = false;
            this.pecas.Text = "Peças";
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::quebra_cabeca.Properties.Resources.close;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(1158, 604);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 65);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // restart
            // 
            this.restart.BackgroundImage = global::quebra_cabeca.Properties.Resources.restart;
            this.restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restart.Location = new System.Drawing.Point(1157, 530);
            this.restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(108, 70);
            this.restart.TabIndex = 3;
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(725, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "TENTATIVAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tentativas
            // 
            this.tentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tentativas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tentativas.Location = new System.Drawing.Point(725, 580);
            this.tentativas.Name = "tentativas";
            this.tentativas.Size = new System.Drawing.Size(145, 52);
            this.tentativas.TabIndex = 5;
            this.tentativas.Text = "0";
            this.tentativas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tip
            // 
            this.tip.BackgroundImage = global::quebra_cabeca.Properties.Resources.tip;
            this.tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tip.Location = new System.Drawing.Point(1096, 530);
            this.tip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(55, 70);
            this.tip.TabIndex = 6;
            this.tip.UseVisualStyleBackColor = true;
            this.tip.MouseEnter += new System.EventHandler(this.tip_MouseEnter);
            this.tip.MouseLeave += new System.EventHandler(this.tip_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 676);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.tentativas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pecas);
            this.Controls.Add(this.quebraCabeca);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private GroupBox quebraCabeca;
        private GroupBox pecas;
        private Button exit;
        private ToolStripMenuItem starWarsToolStripMenuItem;
        private ToolStripMenuItem theWitcherToolStripMenuItem;
        private ToolStripMenuItem godOfWarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button restart;
        private Label label1;
        private Label tentativas;
        private ToolStripMenuItem dificuldadeToolStripMenuItem;
        private ToolStripMenuItem fácilToolStripMenuItem;
        private ToolStripMenuItem médioToolStripMenuItem;
        private ToolStripMenuItem difícilToolStripMenuItem;
        private Button tip;
    }
}