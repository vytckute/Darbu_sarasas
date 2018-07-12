namespace Darbu_sarasas
{
    partial class Form1
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
            this.darbau_DBDataSet = new Darbu_sarasas.Darbau_DBDataSet();
            this.atliktiToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.visiToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.darbaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.darbaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Darbu_sarasas.Darbau_DBDataSetTableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).BeginInit();
            this.atliktiToolStrip.SuspendLayout();
            this.visiToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // darbau_DBDataSet
            // 
            this.darbau_DBDataSet.DataSetName = "Darbau_DBDataSet";
            this.darbau_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atliktiToolStrip
            // 
            this.atliktiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel3});
            this.atliktiToolStrip.Location = new System.Drawing.Point(0, 0);
            this.atliktiToolStrip.Name = "atliktiToolStrip";
            this.atliktiToolStrip.Size = new System.Drawing.Size(693, 25);
            this.atliktiToolStrip.TabIndex = 1;
            this.atliktiToolStrip.Text = "atliktiToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Atlikti";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel3.Text = "Visi";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // visiToolStrip
            // 
            this.visiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.visiToolStrip.Location = new System.Drawing.Point(0, 25);
            this.visiToolStrip.Name = "visiToolStrip";
            this.visiToolStrip.Size = new System.Drawing.Size(693, 25);
            this.visiToolStrip.TabIndex = 2;
            this.visiToolStrip.Text = "visiToolStrip";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "Neatlikti";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Darbų įvedimas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Baigti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // darbaiBindingSource1
            // 
            this.darbaiBindingSource1.DataMember = "Darbai";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ataskaitų siuntimas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 253);
            this.dataGridView1.TabIndex = 8;
            // 
            // darbaiBindingSource
            // 
            this.darbaiBindingSource.DataMember = "Darbai";
            this.darbaiBindingSource.DataSource = this.darbau_DBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DarbaiTableAdapter = null;
            this.tableAdapterManager.DarbuotojaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Darbu_sarasas.Darbau_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Darbų redagavimas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 421);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.visiToolStrip);
            this.Controls.Add(this.atliktiToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).EndInit();
            this.atliktiToolStrip.ResumeLayout(false);
            this.atliktiToolStrip.PerformLayout();
            this.visiToolStrip.ResumeLayout(false);
            this.visiToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Darbau_DBDataSet darbau_DBDataSet;
        private System.Windows.Forms.BindingSource darbaiBindingSource;
        private Darbau_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip atliktiToolStrip;
        private System.Windows.Forms.ToolStrip visiToolStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
      //  private Darbau_DBDataSet1 darbau_DBDataSet1;
        private System.Windows.Forms.BindingSource darbaiBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button button3;
    }
}

