namespace Darbu_sarasas
{
    partial class Form2
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
            System.Windows.Forms.Label darbasLabel;
            System.Windows.Forms.Label darbo_prLabel;
            System.Windows.Forms.Label darbo_pabLabel;
            this.darbau_DBDataSet = new Darbu_sarasas.Darbau_DBDataSet();
            this.darbaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbuotojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.darbuotojaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.darbau_DBDataSet1 = new Darbu_sarasas.Darbau_DBDataSet();
            this.darbuotojaiTableAdapter = new Darbu_sarasas.Darbau_DBDataSetTableAdapters.DarbuotojaiTableAdapter();
            darbuotojo_IdLabel = new System.Windows.Forms.Label();
            darbasLabel = new System.Windows.Forms.Label();
            darbo_prLabel = new System.Windows.Forms.Label();
            darbo_pabLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbuotojaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbuotojaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // darbuotojo_IdLabel
            // 
            darbuotojo_IdLabel.AutoSize = true;
            darbuotojo_IdLabel.Location = new System.Drawing.Point(41, 47);
            darbuotojo_IdLabel.Name = "darbuotojo_IdLabel";
            darbuotojo_IdLabel.Size = new System.Drawing.Size(67, 13);
            darbuotojo_IdLabel.TabIndex = 3;
            darbuotojo_IdLabel.Text = "Darbuotojas:";
            // 
            // darbasLabel
            // 
            darbasLabel.AutoSize = true;
            darbasLabel.Location = new System.Drawing.Point(41, 73);
            darbasLabel.Name = "darbasLabel";
            darbasLabel.Size = new System.Drawing.Size(44, 13);
            darbasLabel.TabIndex = 5;
            darbasLabel.Text = "Darbas:";
            // 
            // darbo_prLabel
            // 
            darbo_prLabel.AutoSize = true;
            darbo_prLabel.Location = new System.Drawing.Point(41, 100);
            darbo_prLabel.Name = "darbo_prLabel";
            darbo_prLabel.Size = new System.Drawing.Size(51, 13);
            darbo_prLabel.TabIndex = 7;
            darbo_prLabel.Text = "Darbo pr:";
            // 
            // darbo_pabLabel
            // 
            darbo_pabLabel.AutoSize = true;
            darbo_pabLabel.Location = new System.Drawing.Point(41, 126);
            darbo_pabLabel.Name = "darbo_pabLabel";
            darbo_pabLabel.Size = new System.Drawing.Size(60, 13);
            darbo_pabLabel.TabIndex = 9;
            darbo_pabLabel.Text = "Darbo pab:";
            // 
            // darbau_DBDataSet
            // 
            this.darbau_DBDataSet.DataSetName = "Darbau_DBDataSet";
            this.darbau_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbaiBindingSource
            // 
            this.darbaiBindingSource.DataMember = "Darbai";
            this.darbaiBindingSource.DataSource = this.darbau_DBDataSet;
            // 
            // darbuotojaiBindingSource
            // 
            this.darbuotojaiBindingSource.DataMember = "Darbuotojai";
            this.darbuotojaiBindingSource.DataSource = this.darbau_DBDataSet;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(121, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Įvesti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.darbuotojaiBindingSource, "Id", true));
            this.comboBox1.DataSource = this.darbuotojaiBindingSource1;
            this.comboBox1.DisplayMember = "Vardas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Id";
            // 
            // darbuotojaiBindingSource1
            // 
            this.darbuotojaiBindingSource1.DataMember = "Darbuotojai";
            this.darbuotojaiBindingSource1.DataSource = this.darbau_DBDataSet;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(121, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Baigti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 126);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // darbau_DBDataSet1
            // 
            this.darbau_DBDataSet1.DataSetName = "Darbau_DBDataSet";
            this.darbau_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbuotojaiTableAdapter
            // 
            this.darbuotojaiTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(472, 524);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(darbuotojo_IdLabel);
            this.Controls.Add(darbasLabel);
            this.Controls.Add(darbo_prLabel);
            this.Controls.Add(darbo_pabLabel);
            this.Name = "Form2";
            this.Text = "Darbų įvedimas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbuotojaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbuotojaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Darbau_DBDataSet darbau_DBDataSet;
        private System.Windows.Forms.BindingSource darbaiBindingSource;
        private System.Windows.Forms.BindingSource darbuotojaiBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Darbau_DBDataSet darbau_DBDataSet1;
        private System.Windows.Forms.BindingSource darbuotojaiBindingSource1;
        private Darbau_DBDataSetTableAdapters.DarbuotojaiTableAdapter darbuotojaiTableAdapter;
    }
}