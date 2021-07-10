using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace masterF
{
    public partial class Form1 : Form
    {
        int m = 4 * 5;
        Image img_graph;
        Graphics g;
        Graphics l;
        int zoom = 4;
        double speed; //скорость отрисовки
        Pen penGraph = new Pen(Color.Green, 3);
        Pen penAxis = new Pen(Color.Orange, 3);

        string func;
        int min;
        int max;

        Bitmap map = new Bitmap(DataBank.width, DataBank.height);
        public Form1()
        {
            InitializeComponent();
            penGraph.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            penGraph.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            l = Graphics.FromImage(map);
            DataBank.width = Screen.PrimaryScreen.Bounds.Width;
            DataBank.height = Screen.PrimaryScreen.Bounds.Height;
            sizeLbl.Text = DataBank.width + " × " + DataBank.height + "пкс";
        }
        static void Opn(ref string[] a, string arg)                 //перевод в обратную польскую запись
        {
            Stack<string> s = new Stack<string>();
            int j = 0;
            for (int i = 0; i < arg.Length; i++) //читаем выражение(слово)
            {
                double num;
                bool isNum = double.TryParse(arg[i].ToString(), out num); //проверяем является ли символ слова числом и записываем символ в нум
                if (isNum)//если символ-число
                {
                    a[j] = X10(ref i, arg).ToString();
                    j++;
                    continue;
                }
                if (arg[i] == 'e')
                {
                    a[j] = "e";
                    j++;
                    continue;
                }
                if (arg[i] == 'x')
                {
                    a[j] = "x";
                    j++;
                    continue;
                }
                if (arg[i] == 'p')
                {
                    i++;
                    if (arg[i] == 'i')
                    {
                        a[j] = "pi";
                        j++;
                        continue;
                    }
                }
                
                if (arg[i] == 'c')
                {
                    i++;
                    if (arg[i] == 'o')
                    {
                        i++;
                        if (arg[i] == 's')
                        {
                            try
                            {
                                while (Priority("cos") <= Priority(s.Peek()))
                                {
                                    a[j] = s.Pop().ToString();
                                    j++;
                                }
                            }
                            catch { }
                            s.Push("cos");
                            continue;
                        }
                    }
                }
                if (arg[i] == 's')
                {
                    i++;
                    if (arg[i] == 'i')
                    {
                        i++;
                        if (arg[i] == 'n')
                        {
                            try
                            {
                                while (Priority("sin") <= Priority(s.Peek()))
                                {
                                    a[j] = s.Pop().ToString();
                                    j++;
                                }
                            }
                            catch { }
                            s.Push("sin");
                            continue;
                        }
                    }
                    if (arg[i] == 'q')
                    {
                        i++;
                        if (arg[i] == 'r')
                        {
                            i++;
                            if (arg[i] == 't')
                            {
                                try
                                {
                                    while (Priority("sqrt") <= Priority(s.Peek()))
                                    {
                                        a[j] = s.Pop().ToString();
                                        j++;
                                    }
                                }
                                catch { }
                                s.Push("sqrt");
                                continue;
                            }
                        }
                    }
                }
                if (arg[i] == 'l')
                {
                    i++;
                    if (arg[i] == 'n')
                    {
                        try
                        {
                            while (Priority("ln") <= Priority(s.Peek()))
                            {
                                a[j] = s.Pop().ToString();
                                j++;
                            }
                        }
                        catch { }
                        s.Push("ln");
                        continue;
                    }
                }
                if (arg[i] == '(') s.Push("(");
                if (arg[i] == ')')
                {
                    while (s.Peek() != "(")
                    {
                        a[j] = s.Pop().ToString();
                        j++;
                    }
                    s.Pop();
                    continue;
                }
                if (arg[i] == '+' || arg[i] == '-' || arg[i] == '*' || arg[i] == '/' || arg[i] == '^')
                {
                    try
                    {
                        while (Priority(arg[i].ToString()) <= Priority(s.Peek()))
                        {
                            a[j] = s.Pop().ToString();
                            j++;
                        }
                    }
                    catch { }
                    s.Push(arg[i].ToString());
                }  
            }
            while (s.Count > 0) { a[j] = s.Pop().ToString(); j++; }
        }
        static double Priority(string x)                                  //получение приоритета операции
        {
            switch (x)
            {
                case "+":   return 1;
                case "-":   return 1;
                case "*":   return 2;
                case "/":   return 2;
                case "^":   return 3;
                case "sin": return 4;
                case "cos": return 4;
                case "ln":  return 4;
                case "sqrt": return 5;
                default:    return 0;
            }
        }
        static double X10(ref int i, string arg)                    //считывание многозначных чисел
        {
            double o;
            double k = Convert.ToDouble(arg[i].ToString());
            if (i + 1 < arg.Length && double.TryParse(arg[i + 1].ToString(), out o))
                while (double.TryParse(arg[i + 1].ToString(), out o))
                {
                    k = k * 10 + Convert.ToDouble(arg[i + 1].ToString());
                    i++;
                    if (i + 1 == arg.Length) break;
                }
            if (i + 1 < arg.Length && arg[i + 1] == '.')
            {
                i++;
                if (i + 1 < arg.Length && double.TryParse(arg[i + 1].ToString(), out o))
                {
                    int b = 1;
                    while (double.TryParse(arg[i + 1].ToString(), out o))
                    {
                        k = k + Convert.ToDouble(arg[i + 1].ToString()) / Math.Pow(10,b);
                        i++;
                        if (i + 1 == arg.Length) break;
                        b++;
                    }
                }
            }
            return k;
        }
        static double Opn_res(string[] a, double x = 0)             //обратная польская запись -> результат
        {
            Stack<double> st = new Stack<double>();
            for (int i = 0; i < a.Length; i++)
            {
                double num;
                bool isNum = double.TryParse(a[i], out num);
                if (isNum)
                    st.Push(num);
                else
                {
                    double op2;
                    switch (a[i])
                    {
                        case "e":
                            st.Push(Math.E);
                            break;
                        case "x":
                            st.Push(x);
                            break;
                        case "pi":
                            st.Push(Math.PI);
                            break;
                        case "+":
                            st.Push(st.Pop() + st.Pop());
                            break;
                        case "*":
                            st.Push(st.Pop() * st.Pop());
                            break;
                        case "-":
                            op2 = st.Pop();
                            if (st.Count != 0) st.Push(st.Pop() - op2);
                            else st.Push(0 - op2);
                            break;
                        case "/":
                            op2 = st.Pop();
                            if (op2 != 0.0)
                                st.Push(st.Pop() / op2);
                            else return Double.NaN;
                            break;
                        case "^":
                            op2 = st.Pop();
                            st.Push(Math.Pow(st.Pop(), op2));
                            break;
                        case "sin":
                            if (st.Peek() % Math.PI == 0)
                                st.Push(0);
                            else
                                st.Push(Math.Sin(st.Pop()));
                            break;
                        case "cos":
                            if ((st.Peek() + Math.PI / 2) % Math.PI == 0)
                                st.Push(0);
                            else
                                st.Push(Math.Cos(st.Pop()));
                            break;
                        case "ln":
                            if (st.Peek() < 0) { return 0; }
                            else st.Push(Math.Log(st.Pop()));
                            break;
                        case "sqrt":
                            if (st.Peek() < 0) { st.Pop();st.Push(0); }//фикс
                            else
                            st.Push(Math.Pow(st.Pop(),0.5));
                            break;
                    }
                }
            }
            return st.Pop();
        }
        private void Save(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (graph.Image != null)
                {
                    
                    img_graph.Save(saveFileDialog1.FileName);
                    SaveDate(Path.GetDirectoryName(saveFileDialog1.FileName) + "\\"
                        + Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + ".никулин");
                }
            }
        }
        private void SaveDate(string FileName)
        {
            table1.EndEdit();
            Stream myStream = new FileStream(FileName, FileMode.Create);
                if ((myStream) != null)
                {
                    StreamWriter myWriter = new StreamWriter(myStream);
                    try
                    {
                        myWriter.Write(func);
                        myWriter.WriteLine();
                        myWriter.Write(min);
                        myWriter.WriteLine();
                        myWriter.Write(max);
                        myWriter.WriteLine();
                        for (int i = 0; i < table1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < table1.ColumnCount; j++)
                            {
                                var value = table1.Rows[i].Cells[j].Value;
                                string str = (value == null ? "0" : value.ToString());
                                myWriter.Write(str);
                                myWriter.WriteLine();
                            }
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWriter.Close();
                    }
                    myStream.Close();
                }
        }
        private void OpenDate(string FileName)
        {
            Stream myStream = null;
            table1.EndEdit();
            try { myStream = new FileStream(FileName, FileMode.Open); } catch { }
                if (myStream != null)
                {
                    StreamReader myread = new StreamReader(myStream);
                    try
                    {
                        string[] str = myread.ReadToEnd().Split('\n');
                        table1.RowCount = (str.Count() - 4) / 2 + 1;

                        func = str[0];
                        function.Text = func;
                        min = int.Parse(str[1]);
                        minBox.Text = (min == -DataBank.width / m / 2 ? "" : min.ToString());
                        max = int.Parse(str[2]);
                        maxBox.Text = (max == DataBank.width / m / 2 ? "" : max.ToString());

                        for (int i = 0; i < table1.RowCount; i++)
                        {
                            for (int j = 0; j < table1.ColumnCount; j++)
                            {
                                try
                                {
                                    table1.Rows[i].Cells[j].Value = str[2 * i + j + 3];
                                } catch{ }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                    myStream.Close();
                }
        }
        private void Open(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG|*.png";
            openFileDialog1.ValidateNames = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_graph = Image.FromFile(openFileDialog1.FileName);
                trackBar2_Scroll(this, new EventArgs());

                OpenDate(Path.GetDirectoryName(openFileDialog1.FileName) + "\\"
                +Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + ".никулин");
            }
        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try { printDocument1.Print(); } catch { }
            }
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(DataBank.width, DataBank.height);
            graph.DrawToBitmap(bm, new Rectangle(0, 0, DataBank.width, DataBank.height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 WH = new Form2();
            if (WH.ShowDialog() == DialogResult.OK)
            {
                sizeLbl.Text = DataBank.width + " × " + DataBank.height + "пкс";
                Clear(this, new EventArgs());
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penAxis.Width = trackBar1.Value;
            penGraph.Width = penAxis.Width;
        }
        private void GraphColor(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                penGraph.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void AxisColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                penAxis.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
                Clear(this, new EventArgs());
            }
        }

        private void BackgroundColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                graph.BackColor = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
                Clear(this, new EventArgs());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        //МАСШТАБ
        Image Zoom(Image img, Size size)
        {
            map = new Bitmap(img, DataBank.width * size.Width / 4, DataBank.height * size.Height / 4);
            l.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return map;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if(zoombar.Value > 0)
            {
                zoom = zoombar.Value;
                graph.Image = Zoom(img_graph, new Size(zoombar.Value, zoombar.Value));
                l = Graphics.FromImage(map);
                zoomLbl.Text = (zoombar.Value * 25).ToString() + "%";
            }
            if (center.Checked) CenterPosition(); //привязка к центру
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(graph.Image != null)
            {
                graph.Dispose();
            }
        }

        private void CenterPosition()
        {
            HScrollProperties H = panel1.HorizontalScroll;
            H.Value = (H.Maximum - H.LargeChange) / 2;
            VScrollProperties V = panel1.VerticalScroll;
            V.Value = (V.Maximum - V.LargeChange) / 2;
            panel1.PerformLayout();
        }

        private void graph_Move(object sender, MouseEventArgs e)
        {
            int MousePX = e.X / zoombar.Value * 4;
            int MousePY = e.Y / zoombar.Value * 4;
            coordinateLbl.Text = MousePX.ToString() + ", " + MousePY.ToString() + "пкс";
            string MouseX = string.Format("{0:N2}", (MousePX - DataBank.width / 2) / (float)m);
            string MouseY = string.Format("{0:N2}", -(MousePY - DataBank.height / 2) / (float)m);
            coordinateLbl2.Text = "X= " + MouseX + ", Y= " + MouseY;
        }

        private void DecZoom(object sender, EventArgs e)
        {
            if (zoombar.Value > zoombar.Minimum)
            {
                zoombar.Value--;
                trackBar2_Scroll(this, new EventArgs());
            }
        }

        private void IncZoom(object sender, EventArgs e)
        {
            if (zoombar.Value < zoombar.Maximum)
            {
                zoombar.Value++;
                trackBar2_Scroll(this, new EventArgs());
            }
        }

        private void graph_MouseLeave(object sender, EventArgs e)
        {
            coordinateLbl.Text = "Координаты";
            coordinateLbl2.Text = "Координаты";
        }
        private void create_Click(object sender, EventArgs e)
        {
            if (AnimBtn.Checked)
            {
                zoombar.Value = 4;
                trackBar2_Scroll(this, new EventArgs());
            } else
                img_graph = Zoom(img_graph, new Size(4, 4)); //100% масштаб

            min = -DataBank.width / m / 2; //область определения функции
            max = DataBank.width / m / 2;
            try
            {
                min = int.Parse(minBox.Text);
            }
            catch { }
            try
            {
                max = int.Parse(maxBox.Text);
            }
            catch { }
            string[] g1;
            g1 = new string[function.Text.Length]; //считываем функцию
            func = function.Text;
            Opn(ref g1, function.Text); //переводим в обратную польскую запись
            
            g = Graphics.FromImage(map);//-----------------БЕЗ АНИМАЦИИ
            
            speed = 0.007;
            if (AnimBtn.Checked)
            {
                ProgressBar.Visible = true;
                ProgressBar.Maximum = (max - min);
                l = graph.CreateGraphics();//--------------------АНИМАЦИЯ
                if (comboBox.Text == "Быстро") speed = 0.007;
                if (comboBox.Text == "Средне") speed = 0.004;
                if (comboBox.Text == "Медленно") speed = 0.001;

            }
            table1.Rows.Clear();
            bool Vis;
            for (double i = min; i < max; i += speed * (11 - m / 5))
            {
                try
                {
                    double y = Opn_res(g1, i);
                    double y1 = Opn_res(g1, i + speed * (11 - m / 5));
                    if (Double.IsNaN(y)&&Double.IsNaN(y1))
                    {
                        MessageBox.Show("Ошибка. Деление на ноль");
                        break;
                    }
                    float px = (Convert.ToInt64(i * m) + DataBank.width / 2);
                    float py = (DataBank.height / 2 - Convert.ToInt64(y * m));
                    float px1 = (Convert.ToInt64((i + speed * (11 - m / 5)) * m) + DataBank.width / 2);
                    float py1 = (DataBank.height / 2 - Convert.ToInt64(y1 * m));
                    
                    if (((py > 0) && (py < DataBank.height)) || ((py1 > 0) && (py1 < DataBank.height)))
                        Vis = true;
                    else Vis = false;
                    ProgressBar.Value = (int)(i - min + 1);
                    if ((py1-py < 500)&&Vis)
                    {
                        if ((AnimBtn.Checked) && (comboBox.Text != "Скорость"))
                        {
                            l.DrawLine(penGraph, px, py, px1, py1);
                        }
                        g.DrawLine(penGraph, px, py, px1, py1);
                        table1.Rows.Add(Convert.ToSingle(i), Convert.ToSingle(y));
                    }
                }
                catch { }
            }
            ProgressBar.Visible = false;
            img_graph = map;
            trackBar2_Scroll(this, new EventArgs());
        }
        private void Clear(object sender, EventArgs e)
        {
            min = -DataBank.width / m / 2; ;
            max = DataBank.width / m / 2; ;
            func = "";
            
            map = new Bitmap(DataBank.width, DataBank.height);
            l = Graphics.FromImage(map);
            l.Clear(graph.BackColor);

            l.DrawLine(penAxis, 0, DataBank.height / 2, DataBank.width, DataBank.height / 2); //оси
            l.DrawLine(penAxis, DataBank.width / 2, 0, DataBank.width / 2, DataBank.height);
            for (int i = -DataBank.height / m; i < DataBank.height / m; i += 1) //штрихи на осях
            {
                l.DrawLine(new Pen(penAxis.Color, 1),
                           DataBank.width / 2 - 5,
                           DataBank.height / 2 - (i * m),
                           DataBank.width / 2 + 5,
                           DataBank.height / 2 - (i * m));
            }
            for (int i = -DataBank.width / m; i < DataBank.width / m; i += 1)
            {
                l.DrawLine(new Pen(penAxis.Color, 1),
                           DataBank.width / 2 + (i * m),
                           DataBank.height / 2 - 5,
                           DataBank.width / 2 + (i * m),
                           DataBank.height / 2 + 5);
            }
            img_graph = map;
            trackBar2_Scroll(this, new EventArgs());
            CenterPosition();
        }
        private void Anim(object sender, EventArgs e)
        {
            if (AnimBtn.Checked)
            {
                comboBox.Visible = true;
            } else
            {
                comboBox.Visible = false;
            }
        }

        private void Table(object sender, EventArgs e)
        {
            if (tableBtn.Checked)
            {
                table1.Visible = true;
                tableClear.Visible = true;
                tableCreate.Visible = true;
            } else
            {
                table1.Visible = false;
                tableClear.Visible = false;
                tableCreate.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table1.Rows.Clear();
        }

        private void tableCreate_Click(object sender, EventArgs e)
        {
            
            img_graph = Zoom(img_graph, new Size(4, 4)); //100% масштаб
            g = Graphics.FromImage(map);//-----------------БЕЗ АНИМАЦИИ
            int kol = table1.Rows.Count - 1;

            for (int i = 0; i < kol; i++)
            {
                try
                {
                    table1[1, i].Value = Convert.ToSingle(table1[1, i].Value);
                    table1[0, i].Value = Convert.ToSingle(table1[0, i].Value);
                }
                catch { }
            }
            table1.Sort(table1.Columns[0], ListSortDirection.Ascending);

            float px = (Convert.ToInt64(Convert.ToSingle(table1[0, 0].Value) * m) + DataBank.width / 2) * zoom / 4;
            float py = (DataBank.height / 2 - Convert.ToInt64(Convert.ToSingle(table1[1, 0].Value) * m)) * zoom / 4;
            g.DrawRectangle(penGraph, px, py, 1, 1);

            for (int i = 0; i < kol - 1; i++)
            {
                try
                {
                    px = (Convert.ToInt64(Convert.ToSingle(table1[0, i].Value) * m) + DataBank.width / 2) * zoom / 4;
                    py = (DataBank.height / 2 - Convert.ToInt64(Convert.ToSingle(table1[1, i].Value) * m)) * zoom / 4;
                    g.DrawLine(penGraph, px, py,
                        (Convert.ToInt64(Convert.ToSingle(table1[0, i + 1].Value) * m) + DataBank.width / 2) * zoom / 4,
                        (DataBank.height / 2 - Convert.ToInt64(Convert.ToSingle(table1[1, i + 1].Value) * m)) * zoom / 4
                        );
                } catch { }
            }
            img_graph = map;
            trackBar2_Scroll(this, new EventArgs());
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ФАЙЛ\nСохраниение - сохраняет файл\nОткрыть - открывает файл\nПечать - печатает файл\n\nНАСТРОЙКИ\n" +
                "Анимация - добавляет выбор скорость\nПривязка к центру - при совершении действий располагает координату (0; 0) в " +
                "центре экрана\nТаблица - показывает таблицу\nРазмер - вызывает окно для изменения размера холста\n\nСПРАВКА\nвывод справки\n" +
                "\nДОСТУПНЫЕ ФУНКЦИИ\n+ сложение\n- вычитание\n* умножение\n/ деление\ne = 2,718281\npi = 3,1415926\nx^2 - степень\n" +
                "sqrt(x) - корень\nsin(x) - синус\ncos(x) - косинус\nln(x) - натуральный логарифм"
            );
        }

        private void EnterClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                create_Click(this, new EventArgs());
        }
    }
}