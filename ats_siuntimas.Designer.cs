namespace Darbu_sarasas
{
    partial class ats_siuntimas
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
            System.Windows.Forms.Label darbuotojo_IdLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.darbuotojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbau_DBDataSet = new Darbu_sarasas.Darbau_DBDataSet();
            this.darbuotojaiTableAdapter = new Darbu_sarasas.Darbau_DBDataSetTableAdapters.DarbuotojaiTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            darbuotojo_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darbuotojaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // darbuotojo_IdLabel
            // 
            darbuotojo_IdLabel.AutoSize = true;
            darbuotojo_IdLabel.Location = new System.Drawing.Point(41, 57);
            darbuotojo_IdLabel.Name = "darbuotojo_IdLabel";
            darbuotojo_IdLabel.Size = new System.Drawing.Size(67, 13);
            darbuotojo_IdLabel.TabIndex = 13;
            darbuotojo_IdLabel.Text = "Darbuotojas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Neatliktų darbų siuntimas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Atliktų darbų siuntimas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // darbuotojaiBindingSource
            // 
            this.darbuotojaiBindingSource.DataMember = "Darbuotojai";
            this.darbuotojaiBindingSource.DataSource = this.darbau_DBDataSet;
            // 
            // darbau_DBDataSet
            // 
            this.darbau_DBDataSet.DataSetName = "Darbau_DBDataSet";
            this.darbau_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbuotojaiTableAdapter
            // 
            this.darbuotojaiTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.darbuotojaiBindingSource, "Id", true));
            this.comboBox1.DataSource = this.darbuotojaiBindingSource;
            this.comboBox1.DisplayMember = "Vardas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Visų darbų siuntimas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Uždaryti";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 156);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // ats_siuntimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(darbuotojo_IdLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ats_siuntimas";
            this.Text = "ats_siuntimas";
            this.Load += new System.EventHandler(this.ats_siuntimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darbuotojaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Darbau_DBDataSet darbau_DBDataSet;
        private System.Windows.Forms.BindingSource darbuotojaiBindingSource;
        private Darbau_DBDataSetTableAdapters.DarbuotojaiTableAdapter darbuotojaiTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}