<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtmAgregar = New System.Windows.Forms.Button()
        Me.dvgDatos = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaCumpleaños = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.NumDato = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido_Paterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido_Materno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtmGuardar = New System.Windows.Forms.Button()
        CType(Me.dvgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtmAgregar
        '
        Me.BtmAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmAgregar.Location = New System.Drawing.Point(503, 18)
        Me.BtmAgregar.Name = "BtmAgregar"
        Me.BtmAgregar.Size = New System.Drawing.Size(113, 39)
        Me.BtmAgregar.TabIndex = 0
        Me.BtmAgregar.Text = "Agregar"
        Me.BtmAgregar.UseVisualStyleBackColor = True
        '
        'dvgDatos
        '
        Me.dvgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgDatos.Location = New System.Drawing.Point(12, 288)
        Me.dvgDatos.Name = "dvgDatos"
        Me.dvgDatos.RowTemplate.Height = 25
        Me.dvgDatos.Size = New System.Drawing.Size(604, 213)
        Me.dvgDatos.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Num Campos:"
        '
        'dtpFechaCumpleaños
        '
        Me.dtpFechaCumpleaños.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCumpleaños.Location = New System.Drawing.Point(183, 240)
        Me.dtpFechaCumpleaños.Name = "dtpFechaCumpleaños"
        Me.dtpFechaCumpleaños.Size = New System.Drawing.Size(176, 23)
        Me.dtpFechaCumpleaños.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(141, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(218, 23)
        Me.txtNombre.TabIndex = 4
        '
        'NumDato
        '
        Me.NumDato.Location = New System.Drawing.Point(141, 18)
        Me.NumDato.Name = "NumDato"
        Me.NumDato.Size = New System.Drawing.Size(218, 23)
        Me.NumDato.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Apellido Paterno:"
        '
        'txtApellido_Paterno
        '
        Me.txtApellido_Paterno.Location = New System.Drawing.Point(141, 77)
        Me.txtApellido_Paterno.Name = "txtApellido_Paterno"
        Me.txtApellido_Paterno.Size = New System.Drawing.Size(218, 23)
        Me.txtApellido_Paterno.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Apellido Materno:"
        '
        'txtApellido_Materno
        '
        Me.txtApellido_Materno.Location = New System.Drawing.Point(141, 119)
        Me.txtApellido_Materno.Name = "txtApellido_Materno"
        Me.txtApellido_Materno.Size = New System.Drawing.Size(218, 23)
        Me.txtApellido_Materno.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(141, 159)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(218, 23)
        Me.txtTelefono.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(141, 200)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(218, 23)
        Me.txtCorreo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha de Cumpleaños:"
        '
        'BtmGuardar
        '
        Me.BtmGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmGuardar.Location = New System.Drawing.Point(503, 77)
        Me.BtmGuardar.Name = "BtmGuardar"
        Me.BtmGuardar.Size = New System.Drawing.Size(113, 39)
        Me.BtmGuardar.TabIndex = 16
        Me.BtmGuardar.Text = "Guardar"
        Me.BtmGuardar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 513)
        Me.Controls.Add(Me.BtmGuardar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido_Materno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido_Paterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumDato)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dtpFechaCumpleaños)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dvgDatos)
        Me.Controls.Add(Me.BtmAgregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dvgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtmAgregar As Button
    Friend WithEvents dvgDatos As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents NumDato As NumericUpDown
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dtpFechaCumpleaños As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido_Materno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido_Paterno As TextBox
    Friend WithEvents BtmGuardar As Button
End Class
