<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.clbKota = New System.Windows.Forms.CheckedListBox()
        Me.tombolHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clbKota
        '
        Me.clbKota.FormattingEnabled = True
        Me.clbKota.Items.AddRange(New Object() {"Siantar", "Medan", "Pekan Baru", "Padang", "Palembang", "Bengkulu", "Jambi", "Lampung", "Batam", "Bangka Belitung", "Jakarta", "Semarang", "Bandung", "Solo", "Surabaya"})
        Me.clbKota.Location = New System.Drawing.Point(13, 13)
        Me.clbKota.Name = "clbKota"
        Me.clbKota.Size = New System.Drawing.Size(178, 184)
        Me.clbKota.TabIndex = 0
        '
        'tombolHitung
        '
        Me.tombolHitung.Location = New System.Drawing.Point(13, 215)
        Me.tombolHitung.Name = "tombolHitung"
        Me.tombolHitung.Size = New System.Drawing.Size(178, 40)
        Me.tombolHitung.TabIndex = 1
        Me.tombolHitung.Text = "Hitung Banyak Kota Dicentang"
        Me.tombolHitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 267)
        Me.Controls.Add(Me.tombolHitung)
        Me.Controls.Add(Me.clbKota)
        Me.Name = "Form1"
        Me.Text = "Demo Kotak List Periksa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clbKota As System.Windows.Forms.CheckedListBox
    Friend WithEvents tombolHitung As System.Windows.Forms.Button

End Class
