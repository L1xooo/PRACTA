﻿
namespace PRACTA
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.покупкаБилетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qwe1DataSet = new PRACTA.qwe1DataSet();
            this.покупка_билетаTableAdapter = new PRACTA.qwe1DataSetTableAdapters.Покупка_билетаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new PRACTA.qwe1DataSetTableAdapters.СотрудникиTableAdapter();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ФильмыTableAdapter();
            this.форматBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.форматTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ФорматTableAdapter();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудник = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Фильм = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Формат = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.времяСеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПокупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкаБилетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.форматBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.Сотрудник,
            this.Фильм,
            this.Формат,
            this.времяСеансаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.датаПокупкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.покупкаБилетаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // покупкаБилетаBindingSource
            // 
            this.покупкаБилетаBindingSource.DataMember = "Покупка билета";
            this.покупкаБилетаBindingSource.DataSource = this.qwe1DataSet;
            // 
            // qwe1DataSet
            // 
            this.qwe1DataSet.DataSetName = "qwe1DataSet";
            this.qwe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // покупка_билетаTableAdapter
            // 
            this.покупка_билетаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.qwe1DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.qwe1DataSet;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // форматBindingSource
            // 
            this.форматBindingSource.DataMember = "Формат";
            this.форматBindingSource.DataSource = this.qwe1DataSet;
            // 
            // форматTableAdapter
            // 
            this.форматTableAdapter.ClearBeforeFill = true;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            this.иДDataGridViewTextBoxColumn.Width = 125;
            // 
            // Сотрудник
            // 
            this.Сотрудник.DataPropertyName = "ИД_Сотрудника";
            this.Сотрудник.DataSource = this.сотрудникиBindingSource;
            this.Сотрудник.DisplayMember = "Фамилия";
            this.Сотрудник.HeaderText = "Сотрудник";
            this.Сотрудник.MinimumWidth = 6;
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.ValueMember = "ИД_Сотрудника";
            this.Сотрудник.Width = 125;
            // 
            // Фильм
            // 
            this.Фильм.DataPropertyName = "ИД_Фильма";
            this.Фильм.DataSource = this.фильмыBindingSource;
            this.Фильм.DisplayMember = "Название";
            this.Фильм.HeaderText = "Фильм";
            this.Фильм.MinimumWidth = 6;
            this.Фильм.Name = "Фильм";
            this.Фильм.ValueMember = "ИД_Фильма";
            this.Фильм.Width = 125;
            // 
            // Формат
            // 
            this.Формат.DataPropertyName = "ИД_Формата";
            this.Формат.DataSource = this.форматBindingSource;
            this.Формат.DisplayMember = "Наименование";
            this.Формат.HeaderText = "Формат";
            this.Формат.MinimumWidth = 6;
            this.Формат.Name = "Формат";
            this.Формат.ValueMember = "ИД_Формата";
            this.Формат.Width = 125;
            // 
            // времяСеансаDataGridViewTextBoxColumn
            // 
            this.времяСеансаDataGridViewTextBoxColumn.DataPropertyName = "Время сеанса";
            this.времяСеансаDataGridViewTextBoxColumn.HeaderText = "Время сеанса";
            this.времяСеансаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяСеансаDataGridViewTextBoxColumn.Name = "времяСеансаDataGridViewTextBoxColumn";
            this.времяСеансаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПокупкиDataGridViewTextBoxColumn
            // 
            this.датаПокупкиDataGridViewTextBoxColumn.DataPropertyName = "Дата покупки";
            this.датаПокупкиDataGridViewTextBoxColumn.HeaderText = "Дата покупки";
            this.датаПокупкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПокупкиDataGridViewTextBoxColumn.Name = "датаПокупкиDataGridViewTextBoxColumn";
            this.датаПокупкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкаБилетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.форматBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public qwe1DataSet qwe1DataSet;
        public System.Windows.Forms.BindingSource покупкаБилетаBindingSource;
        public qwe1DataSetTableAdapters.Покупка_билетаTableAdapter покупка_билетаTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private qwe1DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private qwe1DataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.BindingSource форматBindingSource;
        private qwe1DataSetTableAdapters.ФорматTableAdapter форматTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудник;
        private System.Windows.Forms.DataGridViewComboBoxColumn Фильм;
        private System.Windows.Forms.DataGridViewComboBoxColumn Формат;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяСеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПокупкиDataGridViewTextBoxColumn;
    }
}