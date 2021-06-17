
namespace WindowsFormsApp5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pgtextbox = new System.Windows.Forms.TextBox();
            this.polabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pklabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.epstextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pgtextBox2 = new System.Windows.Forms.TextBox();
            this.pglabel = new System.Windows.Forms.Label();
            this.pclabel = new System.Windows.Forms.Label();
            this.ptlabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pgtext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ectext = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pgtext2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.wgtext2 = new System.Windows.Forms.TextBox();
            this.eglabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.etext = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mtext = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttoncalc1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources._388;
            this.pictureBox1.Location = new System.Drawing.Point(37, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Гидравлическое сопротивление скруббера Вентури (ΔP0) находят как \r\nсумму гидравли" +
        "ческих сопротивлений трубы Вентури (ΔPг) и циклона-каплеуловителя (ΔPк):\r\n");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp5.Properties.Resources._389;
            this.pictureBox2.Location = new System.Drawing.Point(32, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 38);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Потеря давления в трубе Вентури (АрТ) ");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp5.Properties.Resources._390;
            this.pictureBox3.Location = new System.Drawing.Point(35, 194);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 63);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip"));
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp5.Properties.Resources._391;
            this.pictureBox4.Location = new System.Drawing.Point(316, 11);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(184, 63);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip"));
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp5.Properties.Resources._392;
            this.pictureBox5.Location = new System.Drawing.Point(316, 273);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(184, 38);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Для определения коэффициента сопротивления, обусловленного вводом жидкости εж для" +
        " нормализованных \r\nтруб с центральным вводом жидкости в конфузор, можно воспольз" +
        "оваться эмпирическим выражением");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp5.Properties.Resources._393;
            this.pictureBox6.Location = new System.Drawing.Point(37, 210);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(197, 68);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "где ε, — коэффициент сопротивления циклона принимается: = 30—33 — для прямоточных" +
        " циклонов,\r\n = 70 — для циклонов ЦН24; wu — скорость газов в циклоне, должна нах" +
        "одиться в пределах 2,5—4,5 м/с.");
            // 
            // pgtextbox
            // 
            this.pgtextbox.Location = new System.Drawing.Point(88, 130);
            this.pgtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.pgtextbox.Name = "pgtextbox";
            this.pgtextbox.Size = new System.Drawing.Size(132, 22);
            this.pgtextbox.TabIndex = 7;
            this.pgtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pgtextbox_KeyPress);
            // 
            // polabel
            // 
            this.polabel.AutoSize = true;
            this.polabel.Location = new System.Drawing.Point(33, 91);
            this.polabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.polabel.Name = "polabel";
            this.polabel.Size = new System.Drawing.Size(50, 17);
            this.polabel.TabIndex = 8;
            this.polabel.Text = "ΔP0 = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ΔPг =";
            // 
            // pklabel
            // 
            this.pklabel.AutoSize = true;
            this.pklabel.Location = new System.Drawing.Point(33, 180);
            this.pklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pklabel.Name = "pklabel";
            this.pklabel.Size = new System.Drawing.Size(49, 17);
            this.pklabel.TabIndex = 10;
            this.pklabel.Text = "ΔPк = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ε = ";
            // 
            // epstextbox
            // 
            this.epstextbox.Location = new System.Drawing.Point(101, 310);
            this.epstextbox.Margin = new System.Windows.Forms.Padding(4);
            this.epstextbox.Name = "epstextbox";
            this.epstextbox.Size = new System.Drawing.Size(132, 22);
            this.epstextbox.TabIndex = 11;
            this.epstextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epstextbox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ѡц = ";
            // 
            // wtextBox
            // 
            this.wtextBox.Location = new System.Drawing.Point(101, 353);
            this.wtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wtextBox.Name = "wtextBox";
            this.wtextBox.Size = new System.Drawing.Size(132, 22);
            this.wtextBox.TabIndex = 13;
            this.wtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wtextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Рг = ";
            // 
            // pgtextBox2
            // 
            this.pgtextBox2.Location = new System.Drawing.Point(101, 396);
            this.pgtextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pgtextBox2.Name = "pgtextBox2";
            this.pgtextBox2.Size = new System.Drawing.Size(132, 22);
            this.pgtextBox2.TabIndex = 15;
            this.pgtextBox2.TextChanged += new System.EventHandler(this.pgtextBox2_TextChanged);
            this.pgtextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pgtextBox2_KeyPress);
            // 
            // pglabel
            // 
            this.pglabel.AutoSize = true;
            this.pglabel.Location = new System.Drawing.Point(31, 159);
            this.pglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pglabel.Name = "pglabel";
            this.pglabel.Size = new System.Drawing.Size(51, 17);
            this.pglabel.TabIndex = 20;
            this.pglabel.Text = "ΔPж = ";
            // 
            // pclabel
            // 
            this.pclabel.AutoSize = true;
            this.pclabel.Location = new System.Drawing.Point(31, 113);
            this.pclabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pclabel.Name = "pclabel";
            this.pclabel.Size = new System.Drawing.Size(45, 17);
            this.pclabel.TabIndex = 19;
            this.pclabel.Text = "ΔPс =";
            // 
            // ptlabel
            // 
            this.ptlabel.AutoSize = true;
            this.ptlabel.Location = new System.Drawing.Point(31, 70);
            this.ptlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ptlabel.Name = "ptlabel";
            this.ptlabel.Size = new System.Drawing.Size(49, 17);
            this.ptlabel.TabIndex = 18;
            this.ptlabel.Text = "ΔPт = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 343);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Рг = ";
            // 
            // pgtext
            // 
            this.pgtext.Location = new System.Drawing.Point(81, 339);
            this.pgtext.Margin = new System.Windows.Forms.Padding(4);
            this.pgtext.Name = "pgtext";
            this.pgtext.Size = new System.Drawing.Size(132, 22);
            this.pgtext.TabIndex = 25;
            this.pgtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pgtext_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 293);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "εс = ";
            // 
            // ectext
            // 
            this.ectext.Location = new System.Drawing.Point(81, 289);
            this.ectext.Margin = new System.Windows.Forms.Padding(4);
            this.ectext.Name = "ectext";
            this.ectext.Size = new System.Drawing.Size(132, 22);
            this.ectext.TabIndex = 21;
            this.ectext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ectext_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Рж = ";
            // 
            // pgtext2
            // 
            this.pgtext2.Location = new System.Drawing.Point(367, 183);
            this.pgtext2.Margin = new System.Windows.Forms.Padding(4);
            this.pgtext2.Name = "pgtext2";
            this.pgtext2.Size = new System.Drawing.Size(132, 22);
            this.pgtext2.TabIndex = 31;
            this.pgtext2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pgtext2_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 144);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Ѡг = ";
            // 
            // wgtext2
            // 
            this.wgtext2.Location = new System.Drawing.Point(367, 140);
            this.wgtext2.Margin = new System.Windows.Forms.Padding(4);
            this.wgtext2.Name = "wgtext2";
            this.wgtext2.Size = new System.Drawing.Size(132, 22);
            this.wgtext2.TabIndex = 29;
            this.wgtext2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wgtext2_KeyPress);
            // 
            // eglabel
            // 
            this.eglabel.AutoSize = true;
            this.eglabel.Location = new System.Drawing.Point(317, 101);
            this.eglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eglabel.Name = "eglabel";
            this.eglabel.Size = new System.Drawing.Size(40, 17);
            this.eglabel.TabIndex = 28;
            this.eglabel.Text = "εж = ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(317, 338);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "ε = ";
            // 
            // etext
            // 
            this.etext.Location = new System.Drawing.Point(367, 334);
            this.etext.Margin = new System.Windows.Forms.Padding(4);
            this.etext.Name = "etext";
            this.etext.Size = new System.Drawing.Size(132, 22);
            this.etext.TabIndex = 35;
            this.etext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etext_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(317, 381);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "m = ";
            // 
            // mtext
            // 
            this.mtext.Location = new System.Drawing.Point(367, 378);
            this.mtext.Margin = new System.Windows.Forms.Padding(4);
            this.mtext.Name = "mtext";
            this.mtext.Size = new System.Drawing.Size(132, 22);
            this.mtext.TabIndex = 37;
            this.mtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtext_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 554);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.mtext);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.etext);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.ptlabel);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.pclabel);
            this.tabPage2.Controls.Add(this.pgtext2);
            this.tabPage2.Controls.Add(this.pglabel);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.ectext);
            this.tabPage2.Controls.Add(this.wgtext2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.eglabel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.pgtext);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(752, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Потеря давления в турбе Вентури";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttoncalc1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.pgtextbox);
            this.tabPage1.Controls.Add(this.polabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pklabel);
            this.tabPage1.Controls.Add(this.epstextbox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.wtextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pgtextBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(752, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Гидравлическое сопротивление скруббера";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttoncalc1
            // 
            this.buttoncalc1.Location = new System.Drawing.Point(37, 454);
            this.buttoncalc1.Margin = new System.Windows.Forms.Padding(4);
            this.buttoncalc1.Name = "buttoncalc1";
            this.buttoncalc1.Size = new System.Drawing.Size(203, 38);
            this.buttoncalc1.TabIndex = 17;
            this.buttoncalc1.Text = "Вычислить";
            this.buttoncalc1.UseVisualStyleBackColor = true;
            this.buttoncalc1.Click += new System.EventHandler(this.buttoncalc1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 38);
            this.button1.TabIndex = 41;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Вентури";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox pgtextbox;
        private System.Windows.Forms.Label polabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pklabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epstextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pgtextBox2;
        private System.Windows.Forms.Label pglabel;
        private System.Windows.Forms.Label pclabel;
        private System.Windows.Forms.Label ptlabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pgtext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ectext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pgtext2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox wgtext2;
        private System.Windows.Forms.Label eglabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox etext;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox mtext;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttoncalc1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

