namespace Darbu_sarasas
{
    partial class Darbu_koregavimas
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label darbuotojo_IdLabel;
            System.Windows.Forms.Label darbasLabel;
            System.Windows.Forms.Label darbo_prLabel;
            System.Windows.Forms.Label darbo_pabLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Darbu_koregavimas));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.darbau_DBDataSet = new Darbu_sarasas.Darbau_DBDataSet();
            this.darbaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbaiTableAdapter = new Darbu_sarasas.Darbau_DBDataSetTableAdapters.DarbaiTableAdapter();
            this.tableAdapterManager = new Darbu_sarasas.Darbau_DBDataSetTableAdapters.TableAdapterManager();
            this.darbaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.darbuotojo_IdTextBox = new System.Windows.Forms.TextBox();
            this.darbasTextBox = new System.Windows.Forms.TextBox();
            this.darbo_prTextBox = new System.Windows.Forms.TextBox();
            this.darbo_pabTextBox = new System.Windows.Forms.TextBox();
            this.darbaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            darbuotojo_IdLabel = new System.Windows.Forms.Label();
            darbasLabel = new System.Windows.Forms.Label();
            darbo_prLabel = new System.Windows.Forms.Label();
            darbo_pabLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingNavigator)).BeginInit();
            this.darbaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(635, 94);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 23;
            idLabel.Text = "Id:";
            // 
            // darbuotojo_IdLabel
            // 
            darbuotojo_IdLabel.AutoSize = true;
            darbuotojo_IdLabel.Location = new System.Drawing.Point(635, 120);
            darbuotojo_IdLabel.Name = "darbuotojo_IdLabel";
            darbuotojo_IdLabel.Size = new System.Drawing.Size(74, 13);
            darbuotojo_IdLabel.TabIndex = 25;
            darbuotojo_IdLabel.Text = "Darbuotojo Id:";
            // 
            // darbasLabel
            // 
            darbasLabel.AutoSize = true;
            darbasLabel.Location = new System.Drawing.Point(635, 146);
            darbasLabel.Name = "darbasLabel";
            darbasLabel.Size = new System.Drawing.Size(44, 13);
            darbasLabel.TabIndex = 27;
            darbasLabel.Text = "Darbas:";
            // 
            // darbo_prLabel
            // 
            darbo_prLabel.AutoSize = true;
            darbo_prLabel.Location = new System.Drawing.Point(635, 172);
            darbo_prLabel.Name = "darbo_prLabel";
            darbo_prLabel.Size = new System.Drawing.Size(51, 13);
            darbo_prLabel.TabIndex = 29;
            darbo_prLabel.Text = "Darbo pr:";
            // 
            // darbo_pabLabel
            // 
            darbo_pabLabel.AutoSize = true;
            darbo_pabLabel.Location = new System.Drawing.Point(635, 198);
            darbo_pabLabel.Name = "darbo_pabLabel";
            darbo_pabLabel.Size = new System.Drawing.Size(60, 13);
            darbo_pabLabel.TabIndex = 31;
            darbo_pabLabel.Text = "Darbo pab:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Uždaryti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Redaguoti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // darbaiTableAdapter
            // 
            this.darbaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DarbaiTableAdapter = this.darbaiTableAdapter;
            this.tableAdapterManager.DarbuotojaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Darbu_sarasas.Darbau_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // darbaiBindingNavigator
            // 
            this.darbaiBindingNavigator.AddNewItem = null;
            this.darbaiBindingNavigator.BindingSource = this.darbaiBindingSource;
            this.darbaiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.darbaiBindingNavigator.DeleteItem = null;
            this.darbaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.darbaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.darbaiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.darbaiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.darbaiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.darbaiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.darbaiBindingNavigator.Name = "darbaiBindingNavigator";
            this.darbaiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.darbaiBindingNavigator.Size = new System.Drawing.Size(859, 25);
            this.darbaiBindingNavigator.TabIndex = 23;
            this.darbaiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.darbaiBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(715, 91);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 24;
            // 
            // darbuotojo_IdTextBox
            // 
            this.darbuotojo_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.darbaiBindingSource, "Darbuotojo_Id", true));
            this.darbuotojo_IdTextBox.Location = new System.Drawing.Point(715, 117);
            this.darbuotojo_IdTextBox.Name = "darbuotojo_IdTextBox";
            this.darbuotojo_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.darbuotojo_IdTextBox.TabIndex = 26;
            // 
            // darbasTextBox
            // 
            this.darbasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.darbaiBindingSource, "Darbas", true));
            this.darbasTextBox.Location = new System.Drawing.Point(715, 143);
            this.darbasTextBox.Name = "darbasTextBox";
            this.darbasTextBox.Size = new System.Drawing.Size(100, 20);
            this.darbasTextBox.TabIndex = 28;
            // 
            // darbo_prTextBox
            // 
            this.darbo_prTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.darbaiBindingSource, "Darbo_pr", true));
            this.darbo_prTextBox.Location = new System.Drawing.Point(715, 169);
            this.darbo_prTextBox.Name = "darbo_prTextBox";
            this.darbo_prTextBox.Size = new System.Drawing.Size(100, 20);
            this.darbo_prTextBox.TabIndex = 30;
            // 
            // darbo_pabTextBox
            // 
            this.darbo_pabTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.darbaiBindingSource, "Darbo_pab", true));
            this.darbo_pabTextBox.Location = new System.Drawing.Point(715, 195);
            this.darbo_pabTextBox.Name = "darbo_pabTextBox";
            this.darbo_pabTextBox.Size = new System.Drawing.Size(100, 20);
            this.darbo_pabTextBox.TabIndex = 32;
            // 
            // darbaiDataGridView
            // 
            this.darbaiDataGridView.AutoGenerateColumns = false;
            this.darbaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.darbaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.darbaiDataGridView.DataSource = this.darbaiBindingSource;
            this.darbaiDataGridView.Location = new System.Drawing.Point(12, 47);
            this.darbaiDataGridView.Name = "darbaiDataGridView";
            this.darbaiDataGridView.Size = new System.Drawing.Size(582, 220);
            this.darbaiDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Darbuotojo_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Darbuotojo_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Darbas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Darbas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Darbo_pr";
            this.dataGridViewTextBoxColumn4.HeaderText = "Darbo_pr";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Darbo_pab";
            this.dataGridViewTextBoxColumn5.HeaderText = "Darbo_pab";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Trinti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Darbu_koregavimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 403);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.darbaiDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(darbuotojo_IdLabel);
            this.Controls.Add(this.darbuotojo_IdTextBox);
            this.Controls.Add(darbasLabel);
            this.Controls.Add(this.darbasTextBox);
            this.Controls.Add(darbo_prLabel);
            this.Controls.Add(this.darbo_prTextBox);
            this.Controls.Add(darbo_pabLabel);
            this.Controls.Add(this.darbo_pabTextBox);
            this.Controls.Add(this.darbaiBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Darbu_koregavimas";
            this.Text = "Darbu_koregavimas";
            this.Load += new System.EventHandler(this.Darbu_koregavimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darbau_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiBindingNavigator)).EndInit();
            this.darbaiBindingNavigator.ResumeLayout(false);
            this.darbaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Darbau_DBDataSet darbau_DBDataSet;
        private System.Windows.Forms.BindingSource darbaiBindingSource;
        private Darbau_DBDataSetTableAdapters.DarbaiTableAdapter darbaiTableAdapter;
        private Darbau_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator darbaiBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox darbuotojo_IdTextBox;
        private System.Windows.Forms.TextBox darbasTextBox;
        private System.Windows.Forms.TextBox darbo_prTextBox;
        private System.Windows.Forms.TextBox darbo_pabTextBox;
        private System.Windows.Forms.DataGridView darbaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button3;
    }
}