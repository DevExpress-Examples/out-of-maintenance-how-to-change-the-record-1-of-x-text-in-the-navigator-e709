Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Controls

Namespace LocalizedText
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			Localizer.Active = New MyLocalizer()

			InitializeComponent()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Location = New System.Drawing.Point(16, 16)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(261, 24)
			Me.dataNavigator1.TabIndex = 0
			Me.dataNavigator1.Text = "dataNavigator1"
			Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(16, 48)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(168, 20)
			Me.textEdit1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(413, 172)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Name = "Form1"
			Me.Text = "How to change the ""Record 1 of X"" text in the navigator"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim table As New DataTable()
			table.Columns.Add()
			For i As Integer = 1 To 3
				table.Rows.Add(New Object() { String.Format("Item {0}", i) })
			Next i
			Dim bs As New BindingSource(table, "")

			textEdit1.DataBindings.Add("EditValue", bs, "Column1")
			dataNavigator1.DataSource = bs
		End Sub
	End Class
End Namespace