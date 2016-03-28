<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "Archivo a encriptar"
        Me.OpenFileDialog1.Filter = "Texto |*.txt"
        Me.OpenFileDialog1.Title = "Archivo que se desea encriptiar"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.DefaultExt = "bmp"
        Me.OpenFileDialog2.FileName = "Base para enmascarar"
        Me.OpenFileDialog2.Filter = "BMP |*.bmp"
        Me.OpenFileDialog2.Title = "Archivo que se va a utilizar como enmascaramiento"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Archivo final"
        Me.SaveFileDialog1.Title = "Archivo encriptado"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(279, 124)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BackgroundImage = Global.encriptador.My.Resources.Resources.fondo
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(271, 98)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encriptar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Archivo a encriptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(7, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Encriptar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(6, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Base para enmascarar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.encriptador.My.Resources.Resources.fondo32
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(271, 98)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Desencriptar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(6, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(259, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Archivo desencriptado"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Archivo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.Filter = "Texto|*.txt"
        Me.SaveFileDialog2.Title = "Archivo desencriptado"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "Archivo encriptado"
        Me.OpenFileDialog3.Filter = "BMP |*.bmp"
        Me.OpenFileDialog3.Title = "Archivo a desencriptar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.encriptador.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(279, 124)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Encriptador"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog

End Class
