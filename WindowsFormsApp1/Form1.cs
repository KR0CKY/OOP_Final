using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ShapesInterface;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IShape Shape =  null;
        private Graphics graphics;
        private Image img = null;
        private Assembly assembly = Assembly.GetExecutingAssembly();
        private List<IShape> ReturnListShapes = new List<IShape>();
        private List<IShape> RedoListShapes = new List<IShape>();

        private List<Type> FiguresType = new List<Type> { typeof(Ellipse), typeof(BrokenLine),typeof(Line), typeof(Polygon),typeof(Rectangle) };
        
        LinkedList<ICreator> Creators = new LinkedList<ICreator>();

        
        private Type GetFigure(int n)
        {
            return FiguresType[n];
        }
        
        private bool LoadModules()
        {
            Type mainInterface = typeof(ICreator);
            bool FiguresExist = false;
            try
            {

                Assembly assembly = Assembly.GetExecutingAssembly();
                Type[] types = assembly.GetExportedTypes();
                int k = 0;
                for (int i = 0; i < types.Length; i++)
                {

                    if (mainInterface.IsAssignableFrom(types[i]))
                    {

                        Creators.AddLast((ICreator)Activator.CreateInstance(types[i]));

                        shapeToolStripMenuItem.Items.Add(Creators.ElementAt<ICreator>(k).Name);

                        FiguresExist = true;
                        k++;
                    }
                }
            }
            catch
            {
                FiguresExist = false;
            }
            return FiguresExist;
        }
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = Size;
            pictureBox1.Location = new Point(0, 27);
            img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            FieldRefresh();
            pictureBox1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            if (!LoadModules())
            {
                MessageBox.Show("Error. No figures modules found.");
                Application.Exit();
            }

            shapeToolStripMenuItem.SelectedIndex = 2;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form.MouseButtons == MouseButtons.Left)
            {
                if (Shape == null)
                {
                    Type type = GetFigure(shapeToolStripMenuItem.SelectedIndex);
                    Shape = Activator.CreateInstance(type) as IShape;

                    Point point = new Point();
                    point.X = e.X;
                    point.Y = e.Y;
                    Shape.Initialization(point, Decimal.ToInt32(thicknessUpDown.Value) , penColorView.BackColor, fillColorView.BackColor);
                }
                else
                {
                    FieldRefresh();

                    Point point = new Point();
                    point.X = e.X;
                    point.Y = e.Y;
                    if (Shape.IsSimpleShape())
                    {
                        Shape.SetPoint(point);
                    }
                    else
                    {
                        Shape.AddPoint(point);
                    }
                    Shape.Draw(graphics);
                    pictureBox1.Refresh();
                }
            }
            else if (Form.MouseButtons == MouseButtons.Right)
            {
                if (Shape != null)
                {

                    Shape.EndOfCurrentShape();
                    
                    if (!Shape.IsSimpleShape())
                    {
                        AddFigure();
                        
                        Shape = null;

                        FieldRefresh();
                        pictureBox1.Refresh();
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Shape != null)
            {
                if (Shape.IsSimpleShape())
                {
                    if (Form.MouseButtons == MouseButtons.Left)
                    {
                        FieldRefresh();

                        Point point = new Point();
                        point.X = e.X;
                        point.Y = e.Y;
                        Shape.SetPoint(point);
                        Shape.Draw(graphics);
                        pictureBox1.Refresh();
                    }
                }
                else
                {
                    FieldRefresh();
                    
                    Point point = new Point();
                    point.X = e.X;
                    point.Y = e.Y;
                    Shape.SetPoint(point);
                    Shape.Draw(graphics);
                    pictureBox1.Refresh();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Shape != null)
            {
                if (Shape.IsSimpleShape())
                {
                    AddFigure();
                    
                    Shape = null;

                    FieldRefresh();
                    pictureBox1.Refresh();
                }
            }
        }
        
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RemoveShape();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ReturnShape();
        }
        
        
        public void FieldRefresh()
        {
            Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            graphics = Graphics.FromImage(pictureBox1.Image);

            for (int i = 0; i < ReturnListShapes.Count; i++)
            {
                ReturnListShapes[i].Draw(graphics);
            }
        }
        
        public void RemoveShape()
        {
            if (ReturnListShapes.Count > 0)
            {
                RedoListShapes.Add(ReturnListShapes[ReturnListShapes.Count - 1]);
                ReturnListShapes.RemoveAt(ReturnListShapes.Count - 1);
                FieldRefresh();
                pictureBox1.Refresh();
            }
        }

        public void ReturnShape()
        {
            if (RedoListShapes.Count > 0)
            {
                ReturnListShapes.Add(RedoListShapes[RedoListShapes.Count - 1]);
                RedoListShapes.RemoveAt(RedoListShapes.Count - 1);
                FieldRefresh();
                pictureBox1.Refresh();
            }
        }

        public void AddFigure()
        {
            ReturnListShapes.Add(Shape);
            ClearRedoList();
            FieldRefresh();
        }
        
        public void ClearRedoList()
        {
            for (int i = RedoListShapes.Count - 1; i >= 0; i--)
            {
                RedoListShapes.RemoveAt(i);
            }
        }

        private void penColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                penColorView.BackColor = colorDialog1.Color;
            }
        }

        private void fillColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fillColorView.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            openFileDialog1.CheckFileExists = false;
            
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog1.FileName;
            
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, RedoListShapes);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, ReturnListShapes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog1.FileName;
            
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    ReturnListShapes = (List<IShape>)formatter.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    RedoListShapes = (List<IShape>)formatter.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            FieldRefresh();
        }
        
        
        public void LoadPlugin()
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Assembly asm = Assembly.LoadFrom(open_dialog.FileName);

                    Type[] types = asm.GetTypes();
                    foreach (Type t in types)
                    {
                        PluginAttribute attr = Attribute.GetCustomAttribute(t, typeof(PluginAttribute)) as PluginAttribute;
                        if (attr != null)
                        {
                            FiguresType.Add(t);
                            this.shapeToolStripMenuItem.Items.Add(attr.Name);
                        }
                    }
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPlugin();
        }
    }
}
