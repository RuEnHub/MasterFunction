namespace masterF
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
            this.function = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.МенюБар = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.Сохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.Открыть = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.AnimBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.center = new System.Windows.Forms.ToolStripMenuItem();
            this.tableBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.graph = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.zoombar = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sizeLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordinateLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordinateLbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.zoomLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.ColomnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableClear = new System.Windows.Forms.Button();
            this.tableCreate = new System.Windows.Forms.Button();
            this.МенюБар.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoombar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.SuspendLayout();
            // 
            // function
            // 
            this.function.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.function.Location = new System.Drawing.Point(41, 3);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(165, 24);
            this.function.TabIndex = 1;
            this.function.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "f(x)=";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(119, 112);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(87, 27);
            this.create.TabIndex = 17;
            this.create.Text = "построить";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "X∈[";
            // 
            // minBox
            // 
            this.minBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minBox.Location = new System.Drawing.Point(41, 37);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(28, 24);
            this.minBox.TabIndex = 21;
            this.minBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = ";";
            // 
            // maxBox
            // 
            this.maxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxBox.Location = new System.Drawing.Point(75, 37);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(28, 24);
            this.maxBox.TabIndex = 23;
            this.maxBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "]";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(9, 112);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(87, 27);
            this.clear.TabIndex = 25;
            this.clear.Text = "очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear);
            // 
            // МенюБар
            // 
            this.МенюБар.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл,
            this.SpeedGraph,
            this.справкаToolStripMenuItem});
            this.МенюБар.Location = new System.Drawing.Point(0, 0);
            this.МенюБар.Name = "МенюБар";
            this.МенюБар.Size = new System.Drawing.Size(1090, 24);
            this.МенюБар.TabIndex = 27;
            this.МенюБар.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Сохранить,
            this.Открыть,
            this.печатьToolStripMenuItem1});
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(48, 20);
            this.Файл.Text = "Файл";
            // 
            // Сохранить
            // 
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Сохранить.Size = new System.Drawing.Size(180, 22);
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.Click += new System.EventHandler(this.Save);
            // 
            // Открыть
            // 
            this.Открыть.Name = "Открыть";
            this.Открыть.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Открыть.Size = new System.Drawing.Size(180, 22);
            this.Открыть.Text = "Открыть";
            this.Открыть.Click += new System.EventHandler(this.Open);
            // 
            // печатьToolStripMenuItem1
            // 
            this.печатьToolStripMenuItem1.Name = "печатьToolStripMenuItem1";
            this.печатьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.печатьToolStripMenuItem1.Text = "Печать";
            this.печатьToolStripMenuItem1.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // SpeedGraph
            // 
            this.SpeedGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnimBtn,
            this.center,
            this.tableBtn,
            this.размерToolStripMenuItem1});
            this.SpeedGraph.Name = "SpeedGraph";
            this.SpeedGraph.Size = new System.Drawing.Size(79, 20);
            this.SpeedGraph.Text = "Настройки";
            // 
            // AnimBtn
            // 
            this.AnimBtn.CheckOnClick = true;
            this.AnimBtn.Name = "AnimBtn";
            this.AnimBtn.Size = new System.Drawing.Size(176, 22);
            this.AnimBtn.Text = "Анимация";
            this.AnimBtn.Click += new System.EventHandler(this.Anim);
            // 
            // center
            // 
            this.center.CheckOnClick = true;
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(176, 22);
            this.center.Text = "Привязка к центру";
            this.center.Click += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tableBtn
            // 
            this.tableBtn.CheckOnClick = true;
            this.tableBtn.Name = "tableBtn";
            this.tableBtn.Size = new System.Drawing.Size(176, 22);
            this.tableBtn.Text = "Таблица";
            this.tableBtn.Click += new System.EventHandler(this.Table);
            // 
            // размерToolStripMenuItem1
            // 
            this.размерToolStripMenuItem1.Name = "размерToolStripMenuItem1";
            this.размерToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.размерToolStripMenuItem1.Text = "Размер";
            this.размерToolStripMenuItem1.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.function);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.minBox);
            this.panel2.Controls.Add(this.maxBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 79);
            this.panel2.TabIndex = 29;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Быстро",
            "Средне",
            "Медленно"});
            this.comboBox.Location = new System.Drawing.Point(109, 38);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(97, 23);
            this.comboBox.TabIndex = 39;
            this.comboBox.Text = "Скорость";
            this.comboBox.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 72);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Толщина пера";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 27);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(214, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.graph);
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 543);
            this.panel1.TabIndex = 30;
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.SystemColors.Control;
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(200, 100);
            this.graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.graph.TabIndex = 0;
            this.graph.TabStop = false;
            this.graph.MouseLeave += new System.EventHandler(this.graph_MouseLeave);
            this.graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graph_Move);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GraphColor);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AxisColor);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(0, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 133);
            this.panel4.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(53, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Фон";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(10, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BackgroundColor);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(53, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Цвет осей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(53, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Цвет графика";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // zoombar
            // 
            this.zoombar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoombar.LargeChange = 1;
            this.zoombar.Location = new System.Drawing.Point(885, 546);
            this.zoombar.Minimum = 1;
            this.zoombar.Name = "zoombar";
            this.zoombar.Size = new System.Drawing.Size(168, 45);
            this.zoombar.TabIndex = 34;
            this.toolTip1.SetToolTip(this.zoombar, "Масштаб");
            this.zoombar.Value = 4;
            this.zoombar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeLbl,
            this.coordinateLbl,
            this.coordinateLbl2,
            this.ProgressBar,
            this.zoomLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1090, 25);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = false;
            this.sizeLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sizeLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sizeLbl.Image = global::masterF.Properties.Resources.size;
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(130, 20);
            this.sizeLbl.Text = "Размер";
            this.sizeLbl.ToolTipText = "Размер";
            // 
            // coordinateLbl
            // 
            this.coordinateLbl.AutoSize = false;
            this.coordinateLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.coordinateLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.coordinateLbl.Image = global::masterF.Properties.Resources.coordinates;
            this.coordinateLbl.Name = "coordinateLbl";
            this.coordinateLbl.Size = new System.Drawing.Size(130, 20);
            this.coordinateLbl.Text = "Координаты";
            // 
            // coordinateLbl2
            // 
            this.coordinateLbl2.AutoSize = false;
            this.coordinateLbl2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.coordinateLbl2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.coordinateLbl2.Image = global::masterF.Properties.Resources.coordinates;
            this.coordinateLbl2.Name = "coordinateLbl2";
            this.coordinateLbl2.Size = new System.Drawing.Size(130, 20);
            this.coordinateLbl2.Text = "Координаты2";
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(200, 19);
            this.ProgressBar.Visible = false;
            // 
            // zoomLbl
            // 
            this.zoomLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zoomLbl.Margin = new System.Windows.Forms.Padding(0, 3, 210, 2);
            this.zoomLbl.Name = "zoomLbl";
            this.zoomLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zoomLbl.Size = new System.Drawing.Size(475, 20);
            this.zoomLbl.Spring = true;
            this.zoomLbl.Text = "100%";
            this.zoomLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plus
            // 
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plus.Image = global::masterF.Properties.Resources.plus;
            this.plus.Location = new System.Drawing.Point(1050, 546);
            this.plus.Margin = new System.Windows.Forms.Padding(0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(18, 18);
            this.plus.TabIndex = 36;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.IncZoom);
            // 
            // minus
            // 
            this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minus.Image = global::masterF.Properties.Resources.minus;
            this.minus.Location = new System.Drawing.Point(868, 546);
            this.minus.Margin = new System.Windows.Forms.Padding(0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(18, 18);
            this.minus.TabIndex = 37;
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.DecZoom);
            // 
            // table1
            // 
            this.table1.AllowUserToResizeColumns = false;
            this.table1.AllowUserToResizeRows = false;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColomnX,
            this.Y});
            this.table1.Location = new System.Drawing.Point(0, 325);
            this.table1.Name = "table1";
            this.table1.RowHeadersVisible = false;
            this.table1.Size = new System.Drawing.Size(220, 184);
            this.table1.TabIndex = 1;
            this.table1.Visible = false;
            // 
            // ColomnX
            // 
            this.ColomnX.HeaderText = "X";
            this.ColomnX.MinimumWidth = 100;
            this.ColomnX.Name = "ColomnX";
            this.ColomnX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 117;
            this.Y.Name = "Y";
            this.Y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y.Width = 117;
            // 
            // tableClear
            // 
            this.tableClear.Location = new System.Drawing.Point(0, 515);
            this.tableClear.Name = "tableClear";
            this.tableClear.Size = new System.Drawing.Size(121, 23);
            this.tableClear.TabIndex = 40;
            this.tableClear.Text = "Очистить таблицу";
            this.tableClear.UseVisualStyleBackColor = true;
            this.tableClear.Visible = false;
            this.tableClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableCreate
            // 
            this.tableCreate.Location = new System.Drawing.Point(133, 515);
            this.tableCreate.Name = "tableCreate";
            this.tableCreate.Size = new System.Drawing.Size(87, 23);
            this.tableCreate.TabIndex = 41;
            this.tableCreate.Text = "построить";
            this.tableCreate.UseVisualStyleBackColor = true;
            this.tableCreate.Visible = false;
            this.tableCreate.Click += new System.EventHandler(this.tableCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1090, 568);
            this.Controls.Add(this.tableCreate);
            this.Controls.Add(this.tableClear);
            this.Controls.Add(this.create);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.zoombar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.МенюБар);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.МенюБар;
            this.MinimumSize = new System.Drawing.Size(1106, 606);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Clear);
            this.МенюБар.ResumeLayout(false);
            this.МенюБар.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoombar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MenuStrip МенюБар;
        private System.Windows.Forms.ToolStripMenuItem Файл;
        private System.Windows.Forms.ToolStripMenuItem Сохранить;
        private System.Windows.Forms.ToolStripMenuItem Открыть;
        private System.Windows.Forms.ToolStripMenuItem SpeedGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TrackBar zoombar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem center;
        private System.Windows.Forms.ToolStripStatusLabel sizeLbl;
        private System.Windows.Forms.ToolStripStatusLabel coordinateLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel zoomLbl;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.ToolStripStatusLabel coordinateLbl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem AnimBtn;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.ToolStripMenuItem tableBtn;
        private System.Windows.Forms.Button tableClear;
        private System.Windows.Forms.Button tableCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColomnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}