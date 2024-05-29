namespace WinFormsApp1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            GridBuilding = new DataGridView();
            tabControl1 = new TabControl();
            tabBuildings = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)GridBuilding).BeginInit();
            tabControl1.SuspendLayout();
            tabBuildings.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(304, 139);
            button1.Name = "button1";
            button1.Size = new Size(97, 56);
            button1.TabIndex = 0;
            button1.Text = "Test get All Buildings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GridBuilding
            // 
            GridBuilding.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBuilding.Location = new Point(6, 6);
            GridBuilding.Name = "GridBuilding";
            GridBuilding.Size = new Size(292, 189);
            GridBuilding.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBuildings);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 2;
            // 
            // tabBuildings
            // 
            tabBuildings.Controls.Add(GridBuilding);
            tabBuildings.Controls.Add(button1);
            tabBuildings.Location = new Point(4, 24);
            tabBuildings.Name = "tabBuildings";
            tabBuildings.Padding = new Padding(3);
            tabBuildings.Size = new Size(768, 398);
            tabBuildings.TabIndex = 0;
            tabBuildings.Text = "Buildings";
            tabBuildings.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridBuilding).EndInit();
            tabControl1.ResumeLayout(false);
            tabBuildings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private DataGridView GridBuilding;
        private TabControl tabControl1;
        private TabPage tabBuildings;
        private TabPage tabPage2;
    }
}
