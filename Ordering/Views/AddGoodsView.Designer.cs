namespace Ordering.Views
{
    partial class AddGoodsView
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.53F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.17F)});
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.textEdit3);
            this.tablePanel1.Controls.Add(this.textEdit1);
            this.tablePanel1.Controls.Add(this.simpleButton3);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(422, 78);
            this.tablePanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 1);
            this.label3.Location = new System.Drawing.Point(115, 32);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 1);
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Location = new System.Drawing.Point(115, 6);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наименование";
            // 
            // textEdit3
            // 
            this.tablePanel1.SetColumn(this.textEdit3, 2);
            this.textEdit3.Location = new System.Drawing.Point(263, 29);
            this.textEdit3.Name = "textEdit3";
            this.tablePanel1.SetRow(this.textEdit3, 1);
            this.textEdit3.Size = new System.Drawing.Size(156, 20);
            this.textEdit3.TabIndex = 7;
            // 
            // textEdit1
            // 
            this.tablePanel1.SetColumn(this.textEdit1, 2);
            this.textEdit1.Location = new System.Drawing.Point(263, 3);
            this.textEdit1.Name = "textEdit1";
            this.tablePanel1.SetRow(this.textEdit1, 0);
            this.textEdit1.Size = new System.Drawing.Size(156, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel1.SetColumn(this.simpleButton3, 1);
            this.simpleButton3.Location = new System.Drawing.Point(115, 55);
            this.simpleButton3.Name = "simpleButton3";
            this.tablePanel1.SetRow(this.simpleButton3, 2);
            this.simpleButton3.Size = new System.Drawing.Size(142, 20);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "сохранить";
            this.simpleButton3.Click += new System.EventHandler(this.AddGoods);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel1.SetColumn(this.simpleButton1, 2);
            this.simpleButton1.Location = new System.Drawing.Point(263, 55);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 2);
            this.simpleButton1.Size = new System.Drawing.Size(156, 20);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "отмена";
            // 
            // AddGoodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "AddGoodsView";
            this.Size = new System.Drawing.Size(422, 132);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
