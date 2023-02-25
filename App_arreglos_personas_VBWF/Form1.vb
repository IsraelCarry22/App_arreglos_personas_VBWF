Imports System.Text.RegularExpressions

Public Class Form1
    Private numero_contactos As Integer = 0
    Private Contacto_agenda As Person()
    Private i As Integer = 0
    Private Sub BtmAgregar_Click(sender As Object, e As EventArgs) Handles BtmAgregar.Click
        numero_contactos = Convert.ToInt32(NumDato.Value)

        If numero_contactos = 0 Then
            MessageBox.Show("Ingresa una cantidad mayor a 0")
        End If

        Contacto_agenda = New Person(numero_contactos - 1) {}
    End Sub

    Private Sub BtmGuardar_Click(sender As Object, e As EventArgs) Handles BtmGuardar.Click
        If numero_contactos <= i Then
            Return
        End If

        If numero_contactos = 0 Then
            MessageBox.Show("Ingresa una cantidad mayor a 0")
            Return
        End If

        If txtNombre.Text = "" Then
            ErrorProvider1.SetError(txtNombre, "Nombres no ingresados")
            txtNombre.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtNombre, "")

        If txtApellido_Paterno.Text = "" Then
            ErrorProvider1.SetError(txtApellido_Paterno, "Apellido no ingresados")
            txtNombre.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtApellido_Paterno, "")

        If txtApellido_Materno.Text = "" Then
            ErrorProvider1.SetError(txtApellido_Materno, "Apellido no ingresados")
            txtNombre.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtApellido_Materno, "")
        Dim regemailo As Regex = New Regex("^(([^<>()[\]\\.,;:\s@\""]+" & "(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" & "((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" & "\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" & "[]" & "[a-zA-Z]{2,}))$", RegexOptions.Compiled)

        If Not regemailo.IsMatch(txtCorreo.Text) Then
            ErrorProvider1.SetError(txtCorreo, "Gmail no es valida")
            txtNombre.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtCorreo, "")

        If txtTelefono.Text = "" Then
            ErrorProvider1.SetError(txtTelefono, "Telefono no es valido")
            txtNombre.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtTelefono, "")
        Dim mipersona As Person = New Person()
        mipersona.Nombre = txtNombre.Text
        mipersona.Apellido_Paterno = txtApellido_Paterno.Text
        mipersona.Apellido_Materno = txtApellido_Materno.Text
        mipersona.Fecha_de_cumpleaños = dtpFechaCumpleaños.Value
        mipersona.Correo = txtCorreo.Text
        mipersona.Telefono = txtTelefono.Text
        Contacto_agenda(i) = mipersona
        i += 1
        dvgDatos.DataSource = Nothing
        dvgDatos.DataSource = Contacto_agenda
        txtNombre.Clear()
        txtApellido_Paterno.Clear()
        txtApellido_Materno.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtNombre.Focus()
    End Sub
End Class
