namespace WindowsFormsApp1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.fillColorView = new System.Windows.Forms.Button();
            this.penColorButton = new System.Windows.Forms.Button();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.penColorView = new System.Windows.Forms.Button();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.instrumentalPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.thicknessUpDown)).BeginInit();
            this.instrumentalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1, this.shapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1206, 32);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem2, this.toolStripMenuItem4, this.toolStripMenuItem5, this.toolStripMenuItem6, this.loadPluginToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 28);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItem2.Text = "Открыть";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItem4.Text = "Сохранить как";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItem5.Text = "Отменить";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItem6.Text = "Вернуть";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // loadPluginToolStripMenuItem
            // 
            this.loadPluginToolStripMenuItem.Name = "loadPluginToolStripMenuItem";
            this.loadPluginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.loadPluginToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.loadPluginToolStripMenuItem.Text = "Загрузить плагин";
            this.loadPluginToolStripMenuItem.Click += new System.EventHandler(this.loadPluginToolStripMenuItem_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.shapeToolStripMenuItem.Text = "Фигура";
            // 
            // fillColorView
            // 
            this.fillColorView.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fillColorView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillColorView.Location = new System.Drawing.Point(832, 9);
            this.fillColorView.Margin = new System.Windows.Forms.Padding(4);
            this.fillColorView.Name = "fillColorView";
            this.fillColorView.Size = new System.Drawing.Size(52, 24);
            this.fillColorView.TabIndex = 15;
            this.fillColorView.UseVisualStyleBackColor = false;
            // 
            // penColorButton
            // 
            this.penColorButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penColorButton.Location = new System.Drawing.Point(436, 9);
            this.penColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(160, 24);
            this.penColorButton.TabIndex = 21;
            this.penColorButton.Text = "Цвет линии";
            this.penColorButton.UseVisualStyleBackColor = true;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // fillColorButton
            // 
            this.fillColorButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fillColorButton.Location = new System.Drawing.Point(664, 9);
            this.fillColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(160, 24);
            this.fillColorButton.TabIndex = 22;
            this.fillColorButton.Text = "Цвет заливки";
            this.fillColorButton.UseVisualStyleBackColor = true;
            this.fillColorButton.Click += new System.EventHandler(this.fillColorButton_Click);
            // 
            // penColorView
            // 
            this.penColorView.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penColorView.BackColor = System.Drawing.Color.Black;
            this.penColorView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.penColorView.Location = new System.Drawing.Point(604, 9);
            this.penColorView.Margin = new System.Windows.Forms.Padding(4);
            this.penColorView.Name = "penColorView";
            this.penColorView.Size = new System.Drawing.Size(52, 24);
            this.penColorView.TabIndex = 25;
            this.penColorView.UseVisualStyleBackColor = false;
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thicknessLabel.Location = new System.Drawing.Point(4, 13);
            this.thicknessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(148, 21);
            this.thicknessLabel.TabIndex = 27;
            this.thicknessLabel.Text = "Толщина линии";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1206, 643);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // thicknessUpDown
            // 
            this.thicknessUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thicknessUpDown.Location = new System.Drawing.Point(160, 11);
            this.thicknessUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.thicknessUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.thicknessUpDown.Name = "thicknessUpDown";
            this.thicknessUpDown.Size = new System.Drawing.Size(52, 22);
            this.thicknessUpDown.TabIndex = 30;
            this.thicknessUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // instrumentalPanel
            // 
            this.instrumentalPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.instrumentalPanel.Controls.Add(this.thicknessLabel);
            this.instrumentalPanel.Controls.Add(this.thicknessUpDown);
            this.instrumentalPanel.Controls.Add(this.fillColorButton);
            this.instrumentalPanel.Controls.Add(this.penColorView);
            this.instrumentalPanel.Controls.Add(this.fillColorView);
            this.instrumentalPanel.Controls.Add(this.penColorButton);
            this.instrumentalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.instrumentalPanel.Location = new System.Drawing.Point(0, 32);
            this.instrumentalPanel.Name = "instrumentalPanel";
            this.instrumentalPanel.Size = new System.Drawing.Size(1206, 37);
            this.instrumentalPanel.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bif";
            this.openFileDialog1.FileName = "Unnamed.bif";
            this.openFileDialog1.Filter = "Binary Image Format (*.bif)|*.bif";
            this.openFileDialog1.InitialDirectory = "/../../Saved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 675);
            this.Controls.Add(this.instrumentalPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.thicknessUpDown)).EndInit();
            this.instrumentalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem loadPluginToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.ToolStripComboBox shapeToolStripMenuItem;

        private System.Windows.Forms.Panel instrumentalPanel;

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button fillColorView;
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Button fillColorButton;
        private System.Windows.Forms.Button penColorView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown thicknessUpDown;
    }
}

