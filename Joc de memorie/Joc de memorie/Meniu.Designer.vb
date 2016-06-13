<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meniu
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
        Me.btnScor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnMediu = New System.Windows.Forms.Button()
        Me.btnGreu = New System.Windows.Forms.Button()
        Me.btnAjutor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnScor
        '
        Me.btnScor.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnScor.Location = New System.Drawing.Point(361, 35)
        Me.btnScor.Name = "btnScor"
        Me.btnScor.Size = New System.Drawing.Size(98, 40)
        Me.btnScor.TabIndex = 8
        Me.btnScor.Text = "Scor"
        Me.btnScor.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.Location = New System.Drawing.Point(361, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Iesire"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnInfo.Location = New System.Drawing.Point(206, 335)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(98, 40)
        Me.btnInfo.TabIndex = 6
        Me.btnInfo.Text = "Informatii autor"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnStart.Location = New System.Drawing.Point(34, 35)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(98, 40)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Joc nou"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnMediu
        '
        Me.btnMediu.Location = New System.Drawing.Point(118, 183)
        Me.btnMediu.Name = "btnMediu"
        Me.btnMediu.Size = New System.Drawing.Size(110, 41)
        Me.btnMediu.TabIndex = 9
        Me.btnMediu.Text = "Forma predefinita"
        Me.btnMediu.UseVisualStyleBackColor = True
        Me.btnMediu.Visible = False
        '
        'btnGreu
        '
        Me.btnGreu.Location = New System.Drawing.Point(254, 183)
        Me.btnGreu.Name = "btnGreu"
        Me.btnGreu.Size = New System.Drawing.Size(110, 41)
        Me.btnGreu.TabIndex = 10
        Me.btnGreu.Text = "Alege cularea formei"
        Me.btnGreu.UseVisualStyleBackColor = True
        Me.btnGreu.Visible = False
        '
        'btnAjutor
        '
        Me.btnAjutor.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAjutor.Location = New System.Drawing.Point(34, 335)
        Me.btnAjutor.Name = "btnAjutor"
        Me.btnAjutor.Size = New System.Drawing.Size(98, 40)
        Me.btnAjutor.TabIndex = 11
        Me.btnAjutor.Text = "Ajutor"
        Me.btnAjutor.UseVisualStyleBackColor = False
        '
        'Meniu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Joc_de_memorie.My.Resources.Resources.back1
        Me.ClientSize = New System.Drawing.Size(497, 416)
        Me.Controls.Add(Me.btnAjutor)
        Me.Controls.Add(Me.btnGreu)
        Me.Controls.Add(Me.btnMediu)
        Me.Controls.Add(Me.btnScor)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Meniu"
        Me.Text = "Meniu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnScor As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnMediu As System.Windows.Forms.Button
    Friend WithEvents btnGreu As System.Windows.Forms.Button
    Friend WithEvents btnAjutor As System.Windows.Forms.Button

End Class
