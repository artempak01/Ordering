namespace Ordering.Views
{
    partial class AddOrderView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textEdit19 = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit19.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.tablePanel1.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 133);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 5);
            this.tablePanel1.SetRowSpan(this.gridControl1, 6);
            this.gridControl1.Size = new System.Drawing.Size(353, 150);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Наименование";
            this.gridColumn1.FieldName = "Key.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Количество";
            this.gridColumn2.FieldName = "Value";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // goodsBindingSource1
            // 
            this.goodsBindingSource1.DataSource = typeof(Ordering.Shop.Goods);
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.59F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 34.24F)});
            this.tablePanel1.Controls.Add(this.comboBox1);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.comboBox8);
            this.tablePanel1.Controls.Add(this.textEdit19);
            this.tablePanel1.Controls.Add(this.label15);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.textEdit3);
            this.tablePanel1.Controls.Add(this.simpleButton3);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.label12);
            this.tablePanel1.Controls.Add(this.textEdit4);
            this.tablePanel1.Controls.Add(this.label16);
            this.tablePanel1.Controls.Add(this.textEdit1);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(359, 450);
            this.tablePanel1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.tablePanel1.SetColumn(this.comboBox1, 1);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 29);
            this.comboBox1.Name = "comboBox1";
            this.tablePanel1.SetRow(this.comboBox1, 1);
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.fillClient);
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 1);
            this.simpleButton2.Location = new System.Drawing.Point(181, 341);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 13);
            this.simpleButton2.Size = new System.Drawing.Size(175, 20);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "добавить в заказ";
            this.simpleButton2.Click += new System.EventHandler(this.addGoodsToOrder);
            // 
            // comboBox8
            // 
            this.tablePanel1.SetColumn(this.comboBox8, 1);
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(181, 289);
            this.comboBox8.Name = "comboBox8";
            this.tablePanel1.SetRow(this.comboBox8, 11);
            this.comboBox8.Size = new System.Drawing.Size(175, 21);
            this.comboBox8.TabIndex = 13;
            // 
            // textEdit19
            // 
            this.tablePanel1.SetColumn(this.textEdit19, 1);
            this.textEdit19.Location = new System.Drawing.Point(181, 107);
            this.textEdit19.Name = "textEdit19";
            this.textEdit19.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit19.Properties.MaskSettings.Set("mask", "c");
            this.textEdit19.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.tablePanel1.SetRow(this.textEdit19, 4);
            this.textEdit19.Size = new System.Drawing.Size(175, 20);
            this.textEdit19.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.tablePanel1.SetColumn(this.label15, 0);
            this.label15.Location = new System.Drawing.Point(3, 110);
            this.label15.Name = "label15";
            this.tablePanel1.SetRow(this.label15, 4);
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 0);
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 3);
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Клиента";
            // 
            // textEdit3
            // 
            this.tablePanel1.SetColumn(this.textEdit3, 1);
            this.textEdit3.Location = new System.Drawing.Point(181, 81);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.textEdit3.Properties.MaskSettings.Set("mask", "d");
            this.tablePanel1.SetRow(this.textEdit3, 3);
            this.textEdit3.Size = new System.Drawing.Size(175, 20);
            this.textEdit3.TabIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel1.SetColumn(this.simpleButton3, 0);
            this.simpleButton3.Location = new System.Drawing.Point(3, 410);
            this.simpleButton3.Name = "simpleButton3";
            this.tablePanel1.SetRow(this.simpleButton3, 15);
            this.simpleButton3.Size = new System.Drawing.Size(172, 20);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "сохранить";
            this.simpleButton3.Click += new System.EventHandler(this.saveNewOrder);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel1.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(181, 410);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 15);
            this.simpleButton1.Size = new System.Drawing.Size(175, 20);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "отмена";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tablePanel1.SetColumn(this.label12, 0);
            this.label12.Location = new System.Drawing.Point(3, 58);
            this.label12.Name = "label12";
            this.tablePanel1.SetRow(this.label12, 2);
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Наименование клиента";
            // 
            // textEdit4
            // 
            this.tablePanel1.SetColumn(this.textEdit4, 1);
            this.textEdit4.Location = new System.Drawing.Point(181, 55);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tablePanel1.SetRow(this.textEdit4, 2);
            this.textEdit4.Size = new System.Drawing.Size(175, 20);
            this.textEdit4.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.tablePanel1.SetColumn(this.label16, 0);
            this.label16.Location = new System.Drawing.Point(3, 292);
            this.label16.Name = "label16";
            this.tablePanel1.SetRow(this.label16, 11);
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Добавить товар";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textEdit1
            // 
            this.tablePanel1.SetColumn(this.textEdit1, 1);
            this.textEdit1.Location = new System.Drawing.Point(181, 315);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tablePanel1.SetRow(this.textEdit1, 12);
            this.textEdit1.Size = new System.Drawing.Size(175, 20);
            this.textEdit1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.label1.Location = new System.Drawing.Point(3, 318);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 12);
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество";
            this.label1.Click += new System.EventHandler(this.label16_Click);
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(Ordering.Shop.Goods);
            // 
            // AddOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "AddOrderView";
            this.Size = new System.Drawing.Size(359, 532);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit19.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox comboBox8;
        private DevExpress.XtraEditors.TextEdit textEdit19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource goodsBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
