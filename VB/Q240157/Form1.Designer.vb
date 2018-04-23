Imports Microsoft.VisualBasic
Imports System
Namespace Q240157
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.myCheckEdit1 = New DXSample.Editors.MyCheckEdit()
			Me.myCheckEdit2 = New DXSample.Editors.MyCheckEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMyCheckEdit1 = New DXSample.Editors.RepositoryItemMyCheckEdit()
			Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMyCheckEdit2 = New DXSample.Editors.RepositoryItemMyCheckEdit()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.myCheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myCheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myCheckEdit1
			' 
			Me.myCheckEdit1.Location = New System.Drawing.Point(12, 12)
			Me.myCheckEdit1.Name = "myCheckEdit1"
			Me.myCheckEdit1.Properties.Caption = "Text"
			Me.myCheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.myCheckEdit1.Properties.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Bottom
			Me.myCheckEdit1.Size = New System.Drawing.Size(130, 36)
			Me.myCheckEdit1.TabIndex = 1
			' 
			' myCheckEdit2
			' 
			Me.myCheckEdit2.Location = New System.Drawing.Point(248, 12)
			Me.myCheckEdit2.Name = "myCheckEdit2"
			Me.myCheckEdit2.Properties.Caption = "Text"
			Me.myCheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.myCheckEdit2.Properties.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Top
			Me.myCheckEdit2.Size = New System.Drawing.Size(135, 36)
			Me.myCheckEdit2.TabIndex = 2
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Location = New System.Drawing.Point(12, 61)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMyCheckEdit1, Me.repositoryItemMyCheckEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(400, 200)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			Me.dataColumn1.DataType = GetType(Boolean)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			Me.dataColumn2.DataType = GetType(Boolean)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1, Me.colColumn2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colColumn1
			' 
			Me.colColumn1.ColumnEdit = Me.repositoryItemMyCheckEdit1
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' repositoryItemMyCheckEdit1
			' 
			Me.repositoryItemMyCheckEdit1.AutoHeight = False
			Me.repositoryItemMyCheckEdit1.Name = "repositoryItemMyCheckEdit1"
			Me.repositoryItemMyCheckEdit1.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Top
			' 
			' colColumn2
			' 
			Me.colColumn2.ColumnEdit = Me.repositoryItemMyCheckEdit2
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.Name = "colColumn2"
			Me.colColumn2.Visible = True
			Me.colColumn2.VisibleIndex = 1
			' 
			' repositoryItemMyCheckEdit2
			' 
			Me.repositoryItemMyCheckEdit2.AutoHeight = False
			Me.repositoryItemMyCheckEdit2.Name = "repositoryItemMyCheckEdit2"
			Me.repositoryItemMyCheckEdit2.VerticalGlyphAlignment = DXSample.Editors.VerticalGlyphAlignment.Bottom
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(422, 273)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.myCheckEdit2)
			Me.Controls.Add(Me.myCheckEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myCheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myCheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myCheckEdit1 As DXSample.Editors.MyCheckEdit
		Private myCheckEdit2 As DXSample.Editors.MyCheckEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyCheckEdit1 As DXSample.Editors.RepositoryItemMyCheckEdit
		Private repositoryItemMyCheckEdit2 As DXSample.Editors.RepositoryItemMyCheckEdit
		Private bindingSource1 As System.Windows.Forms.BindingSource

	End Class
End Namespace

