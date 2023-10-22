namespace Classes
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
            lbxStudents = new ListBox();
            dgrwStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).BeginInit();
            SuspendLayout();
            // 
            // lbxStudents
            // 
            lbxStudents.FormattingEnabled = true;
            lbxStudents.ItemHeight = 25;
            lbxStudents.Location = new Point(24, 72);
            lbxStudents.Name = "lbxStudents";
            lbxStudents.Size = new Size(180, 229);
            lbxStudents.TabIndex = 0;
            lbxStudents.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dgrwStudents
            // 
            dgrwStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwStudents.Location = new Point(344, 72);
            dgrwStudents.Name = "dgrwStudents";
            dgrwStudents.RowHeadersWidth = 62;
            dgrwStudents.RowTemplate.Height = 33;
            dgrwStudents.Size = new Size(360, 229);
            dgrwStudents.TabIndex = 1;
            dgrwStudents.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrwStudents);
            Controls.Add(lbxStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxStudents;
        private DataGridView dgrwStudents;
    }
}