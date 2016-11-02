namespace DatabaseExample
{
    partial class frmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabase));
            this.databaseExampleDataSet1 = new DatabaseExample.DatabaseExampleDataSet1();
            this.tblExampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblExampleTableAdapter = new DatabaseExample.DatabaseExampleDataSet1TableAdapters.tblExampleTableAdapter();
            this.tableAdapterManager = new DatabaseExample.DatabaseExampleDataSet1TableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblExampleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblExampleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblExampleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseExampleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExampleBindingNavigator)).BeginInit();
            this.tblExampleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblExampleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseExampleDataSet1
            // 
            this.databaseExampleDataSet1.DataSetName = "DatabaseExampleDataSet1";
            this.databaseExampleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblExampleBindingSource
            // 
            this.tblExampleBindingSource.DataMember = "tblExample";
            this.tblExampleBindingSource.DataSource = this.databaseExampleDataSet1;
            // 
            // tblExampleTableAdapter
            // 
            this.tblExampleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblExampleTableAdapter = this.tblExampleTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseExample.DatabaseExampleDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblExampleBindingNavigatorSaveItem
            // 
            this.tblExampleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblExampleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblExampleBindingNavigatorSaveItem.Image")));
            this.tblExampleBindingNavigatorSaveItem.Name = "tblExampleBindingNavigatorSaveItem";
            this.tblExampleBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tblExampleBindingNavigatorSaveItem.Text = "Save Data";
            this.tblExampleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblExampleBindingNavigatorSaveItem_Click);
            // 
            // tblExampleBindingNavigator
            // 
            this.tblExampleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblExampleBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblExampleBindingNavigator.BindingSource = this.tblExampleBindingSource;
            this.tblExampleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblExampleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblExampleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblExampleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblExampleBindingNavigatorSaveItem});
            this.tblExampleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblExampleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblExampleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblExampleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblExampleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblExampleBindingNavigator.Name = "tblExampleBindingNavigator";
            this.tblExampleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblExampleBindingNavigator.Size = new System.Drawing.Size(601, 27);
            this.tblExampleBindingNavigator.TabIndex = 0;
            this.tblExampleBindingNavigator.Text = "bindingNavigator1";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 46);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(385, 29);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Database Example In a Form";
            // 
            // tblExampleDataGridView
            // 
            this.tblExampleDataGridView.AutoGenerateColumns = false;
            this.tblExampleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblExampleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblExampleDataGridView.DataSource = this.tblExampleBindingSource;
            this.tblExampleDataGridView.Location = new System.Drawing.Point(12, 78);
            this.tblExampleDataGridView.Name = "tblExampleDataGridView";
            this.tblExampleDataGridView.RowTemplate.Height = 24;
            this.tblExampleDataGridView.Size = new System.Drawing.Size(577, 376);
            this.tblExampleDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarMake";
            this.dataGridViewTextBoxColumn2.HeaderText = "CarMake";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CarModel";
            this.dataGridViewTextBoxColumn3.HeaderText = "CarModel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CarYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "CarYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(601, 466);
            this.Controls.Add(this.tblExampleDataGridView);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tblExampleBindingNavigator);
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseExampleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExampleBindingNavigator)).EndInit();
            this.tblExampleBindingNavigator.ResumeLayout(false);
            this.tblExampleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblExampleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseExampleDataSet1 databaseExampleDataSet1;
        private System.Windows.Forms.BindingSource tblExampleBindingSource;
        private DatabaseExampleDataSet1TableAdapters.tblExampleTableAdapter tblExampleTableAdapter;
        private DatabaseExampleDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tblExampleBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tblExampleBindingNavigator;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView tblExampleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

