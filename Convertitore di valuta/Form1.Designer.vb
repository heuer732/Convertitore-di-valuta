<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cconverter
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cconverter))
        Me.L1_Lc = New System.Windows.Forms.Label()
        Me.L2_Er = New System.Windows.Forms.Label()
        Me.L3_Fc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.B1_Result = New System.Windows.Forms.Button()
        Me.B2_Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L1_Lc
        '
        Me.L1_Lc.AutoSize = True
        Me.L1_Lc.Location = New System.Drawing.Point(0, 9)
        Me.L1_Lc.Name = "L1_Lc"
        Me.L1_Lc.Size = New System.Drawing.Size(91, 18)
        Me.L1_Lc.TabIndex = 0
        Me.L1_Lc.Text = "Valuta locale"
        '
        'L2_Er
        '
        Me.L2_Er.AutoSize = True
        Me.L2_Er.Location = New System.Drawing.Point(0, 57)
        Me.L2_Er.Name = "L2_Er"
        Me.L2_Er.Size = New System.Drawing.Size(118, 18)
        Me.L2_Er.TabIndex = 1
        Me.L2_Er.Text = "Tasso di cambio"
        '
        'L3_Fc
        '
        Me.L3_Fc.AutoSize = True
        Me.L3_Fc.Location = New System.Drawing.Point(0, 105)
        Me.L3_Fc.Name = "L3_Fc"
        Me.L3_Fc.Size = New System.Drawing.Size(109, 18)
        Me.L3_Fc.TabIndex = 2
        Me.L3_Fc.Text = "Valuta straniera"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 36)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "© 2020 Matthias Heuer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tutti i sono resavati." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(3, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 16
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(158, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 17
        '
        'B1_Result
        '
        Me.B1_Result.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.B1_Result.Location = New System.Drawing.Point(185, 172)
        Me.B1_Result.Name = "B1_Result"
        Me.B1_Result.Size = New System.Drawing.Size(97, 23)
        Me.B1_Result.TabIndex = 18
        Me.B1_Result.Text = "Risultato"
        Me.B1_Result.UseVisualStyleBackColor = True
        '
        'B2_Clear
        '
        Me.B2_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.B2_Clear.Location = New System.Drawing.Point(288, 172)
        Me.B2_Clear.Name = "B2_Clear"
        Me.B2_Clear.Size = New System.Drawing.Size(97, 23)
        Me.B2_Clear.TabIndex = 19
        Me.B2_Clear.Text = "Cancellare"
        Me.B2_Clear.UseVisualStyleBackColor = True
        '
        'Cconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 200)
        Me.Controls.Add(Me.B2_Clear)
        Me.Controls.Add(Me.B1_Result)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.L3_Fc)
        Me.Controls.Add(Me.L2_Er)
        Me.Controls.Add(Me.L1_Lc)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cconverter"
        Me.Text = "Convertitore di valuta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L1_Lc As Label
    Friend WithEvents L2_Er As Label
    Friend WithEvents L3_Fc As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents B1_Result As Button
    Friend WithEvents B2_Clear As Button
End Class
