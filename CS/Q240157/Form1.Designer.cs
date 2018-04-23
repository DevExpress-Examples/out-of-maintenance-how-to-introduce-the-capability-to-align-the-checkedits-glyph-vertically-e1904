namespace Q240157 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.myCheckEdit1 = new DXSample.Editors.MyCheckEdit();
            this.myCheckEdit2 = new DXSample.Editors.MyCheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMyCheckEdit1 = new DXSample.Editors.RepositoryItemMyCheckEdit();
            this.colColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMyCheckEdit2 = new DXSample.Editors.RepositoryItemMyCheckEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCheckEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // myCheckEdit1
            // 
            this.myCheckEdit1.Location = new System.Drawing.Point(12, 12);
            this.myCheckEdit1.Name = "myCheckEdit1";
            this.myCheckEdit1.Properties.Caption = "Text";
            this.myCheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myCheckEdit1.Properties.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Bottom;
            this.myCheckEdit1.Size = new System.Drawing.Size(130, 36);
            this.myCheckEdit1.TabIndex = 1;
            // 
            // myCheckEdit2
            // 
            this.myCheckEdit2.Location = new System.Drawing.Point(248, 12);
            this.myCheckEdit2.Name = "myCheckEdit2";
            this.myCheckEdit2.Properties.Caption = "Text";
            this.myCheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myCheckEdit2.Properties.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Top;
            this.myCheckEdit2.Size = new System.Drawing.Size(135, 36);
            this.myCheckEdit2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMyCheckEdit1,
            this.repositoryItemMyCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            this.dataColumn1.DataType = typeof(bool);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            this.dataColumn2.DataType = typeof(bool);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColumn1,
            this.colColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colColumn1
            // 
            this.colColumn1.ColumnEdit = this.repositoryItemMyCheckEdit1;
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 0;
            // 
            // repositoryItemMyCheckEdit1
            // 
            this.repositoryItemMyCheckEdit1.AutoHeight = false;
            this.repositoryItemMyCheckEdit1.Name = "repositoryItemMyCheckEdit1";
            this.repositoryItemMyCheckEdit1.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Top;
            // 
            // colColumn2
            // 
            this.colColumn2.ColumnEdit = this.repositoryItemMyCheckEdit2;
            this.colColumn2.FieldName = "Column2";
            this.colColumn2.Name = "colColumn2";
            this.colColumn2.Visible = true;
            this.colColumn2.VisibleIndex = 1;
            // 
            // repositoryItemMyCheckEdit2
            // 
            this.repositoryItemMyCheckEdit2.AutoHeight = false;
            this.repositoryItemMyCheckEdit2.Name = "repositoryItemMyCheckEdit2";
            this.repositoryItemMyCheckEdit2.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Bottom;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Table1";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.myCheckEdit2);
            this.Controls.Add(this.myCheckEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCheckEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.Editors.MyCheckEdit myCheckEdit1;
        private DXSample.Editors.MyCheckEdit myCheckEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn2;
        private DXSample.Editors.RepositoryItemMyCheckEdit repositoryItemMyCheckEdit1;
        private DXSample.Editors.RepositoryItemMyCheckEdit repositoryItemMyCheckEdit2;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}

