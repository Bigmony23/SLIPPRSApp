﻿namespace SLIPPRSApp
{
    partial class Mesto_xraneniya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesto_xraneniya));
            this.mesto_xraneniyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new SLIPPRSApp.Dataset();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mesto_xraneniyaTableAdapter = new SLIPPRSApp.DatasetTableAdapters.Mesto_xraneniyaTableAdapter();
            this.tableAdapterManager = new SLIPPRSApp.DatasetTableAdapters.TableAdapterManager();
            this.mesto_xraneniyaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mesto_xraneniyaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.slippers11DataSet = new SLIPPRSApp.Slippers11DataSet();
            this.mesto_xraneniyaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mesto_xraneniyaTableAdapter1 = new SLIPPRSApp.Slippers11DataSetTableAdapters.Mesto_xraneniyaTableAdapter();
            this.tableAdapterManager1 = new SLIPPRSApp.Slippers11DataSetTableAdapters.TableAdapterManager();
            this.mesto_xraneniyaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaBindingNavigator)).BeginInit();
            this.mesto_xraneniyaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slippers11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mesto_xraneniyaBindingSource
            // 
            this.mesto_xraneniyaBindingSource.DataMember = "Mesto_xraneniya";
            this.mesto_xraneniyaBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ид Продукта";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(155, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 32);
            this.button4.TabIndex = 29;
            this.button4.Text = "Показать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(20, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "Фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(457, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(311, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mesto_xraneniyaTableAdapter
            // 
            this.mesto_xraneniyaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Mesto_xraneniyaTableAdapter = this.mesto_xraneniyaTableAdapter;
            this.tableAdapterManager.Model_tovaraTableAdapter = null;
            this.tableAdapterManager.Ostatki_tovaraTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.Prodaji1TableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Rasxod1TableAdapter = null;
            this.tableAdapterManager.TovarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SLIPPRSApp.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mesto_xraneniyaBindingNavigator
            // 
            this.mesto_xraneniyaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mesto_xraneniyaBindingNavigator.BindingSource = this.mesto_xraneniyaBindingSource;
            this.mesto_xraneniyaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mesto_xraneniyaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mesto_xraneniyaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mesto_xraneniyaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mesto_xraneniyaBindingNavigatorSaveItem});
            this.mesto_xraneniyaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mesto_xraneniyaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mesto_xraneniyaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mesto_xraneniyaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mesto_xraneniyaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mesto_xraneniyaBindingNavigator.Name = "mesto_xraneniyaBindingNavigator";
            this.mesto_xraneniyaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mesto_xraneniyaBindingNavigator.Size = new System.Drawing.Size(840, 27);
            this.mesto_xraneniyaBindingNavigator.TabIndex = 34;
            this.mesto_xraneniyaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(44, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mesto_xraneniyaBindingNavigatorSaveItem
            // 
            this.mesto_xraneniyaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mesto_xraneniyaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mesto_xraneniyaBindingNavigatorSaveItem.Image")));
            this.mesto_xraneniyaBindingNavigatorSaveItem.Name = "mesto_xraneniyaBindingNavigatorSaveItem";
            this.mesto_xraneniyaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.mesto_xraneniyaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mesto_xraneniyaBindingNavigatorSaveItem.Click += new System.EventHandler(this.mesto_xraneniyaBindingNavigatorSaveItem_Click);
            // 
            // slippers11DataSet
            // 
            this.slippers11DataSet.DataSetName = "Slippers11DataSet";
            this.slippers11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesto_xraneniyaBindingSource1
            // 
            this.mesto_xraneniyaBindingSource1.DataMember = "Mesto_xraneniya";
            this.mesto_xraneniyaBindingSource1.DataSource = this.slippers11DataSet;
            // 
            // mesto_xraneniyaTableAdapter1
            // 
            this.mesto_xraneniyaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Mesto_xraneniyaTableAdapter = this.mesto_xraneniyaTableAdapter1;
            this.tableAdapterManager1.OstatkiTableAdapter = null;
            this.tableAdapterManager1.PrixodTableAdapter = null;
            this.tableAdapterManager1.ProdajiTableAdapter = null;
            this.tableAdapterManager1.ProizvoditelTableAdapter = null;
            this.tableAdapterManager1.Real_ProdajiTableAdapter = null;
            this.tableAdapterManager1.TovarsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SLIPPRSApp.Slippers11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Vid_tovaraTableAdapter = null;
            this.tableAdapterManager1.VozvratTableAdapter = null;
            // 
            // mesto_xraneniyaDataGridView
            // 
            this.mesto_xraneniyaDataGridView.AutoGenerateColumns = false;
            this.mesto_xraneniyaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mesto_xraneniyaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mesto_xraneniyaDataGridView.DataSource = this.mesto_xraneniyaBindingSource1;
            this.mesto_xraneniyaDataGridView.Location = new System.Drawing.Point(21, 57);
            this.mesto_xraneniyaDataGridView.Name = "mesto_xraneniyaDataGridView";
            this.mesto_xraneniyaDataGridView.RowHeadersWidth = 51;
            this.mesto_xraneniyaDataGridView.RowTemplate.Height = 24;
            this.mesto_xraneniyaDataGridView.Size = new System.Drawing.Size(550, 236);
            this.mesto_xraneniyaDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Mesto_xraneniya";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Sklad_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Склад";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД Продукта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kolichestvo";
            this.dataGridViewTextBoxColumn4.HeaderText = "количество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 369);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 35;
            // 
            // Mesto_xraneniya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 484);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mesto_xraneniyaDataGridView);
            this.Controls.Add(this.mesto_xraneniyaBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Mesto_xraneniya";
            this.Text = "Mesto_xraneniya";
            this.Load += new System.EventHandler(this.Mesto_xraneniya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaBindingNavigator)).EndInit();
            this.mesto_xraneniyaBindingNavigator.ResumeLayout(false);
            this.mesto_xraneniyaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slippers11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesto_xraneniyaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource mesto_xraneniyaBindingSource;
        private DatasetTableAdapters.Mesto_xraneniyaTableAdapter mesto_xraneniyaTableAdapter;
        private DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mesto_xraneniyaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mesto_xraneniyaBindingNavigatorSaveItem;
        private Slippers11DataSet slippers11DataSet;
        private System.Windows.Forms.BindingSource mesto_xraneniyaBindingSource1;
        private Slippers11DataSetTableAdapters.Mesto_xraneniyaTableAdapter mesto_xraneniyaTableAdapter1;
        private Slippers11DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView mesto_xraneniyaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}