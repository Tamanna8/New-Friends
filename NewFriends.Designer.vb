<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewFriends
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
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblWrittenBy = New System.Windows.Forms.Label()
        Me.radJustin = New System.Windows.Forms.RadioButton()
        Me.radJonathan = New System.Windows.Forms.RadioButton()
        Me.radDemitri = New System.Windows.Forms.RadioButton()
        Me.radMelanie = New System.Windows.Forms.RadioButton()
        Me.radClear = New System.Windows.Forms.RadioButton()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInformation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblInformation.Location = New System.Drawing.Point(1, 116)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(368, 171)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "                                                      "
        '
        'lblWrittenBy
        '
        Me.lblWrittenBy.AutoSize = True
        Me.lblWrittenBy.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblWrittenBy.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrittenBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblWrittenBy.Location = New System.Drawing.Point(38, 9)
        Me.lblWrittenBy.Name = "lblWrittenBy"
        Me.lblWrittenBy.Size = New System.Drawing.Size(282, 21)
        Me.lblWrittenBy.TabIndex = 1
        Me.lblWrittenBy.Text = "Tamanna Sharma,CS115-Section B"
        '
        'radJustin
        '
        Me.radJustin.AutoSize = True
        Me.radJustin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radJustin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJustin.ForeColor = System.Drawing.SystemColors.Control
        Me.radJustin.Location = New System.Drawing.Point(42, 50)
        Me.radJustin.Name = "radJustin"
        Me.radJustin.Size = New System.Drawing.Size(65, 22)
        Me.radJustin.TabIndex = 2
        Me.radJustin.Text = "Justin"
        Me.radJustin.UseVisualStyleBackColor = False
        '
        'radJonathan
        '
        Me.radJonathan.AutoSize = True
        Me.radJonathan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radJonathan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJonathan.ForeColor = System.Drawing.Color.White
        Me.radJonathan.Location = New System.Drawing.Point(212, 50)
        Me.radJonathan.Name = "radJonathan"
        Me.radJonathan.Size = New System.Drawing.Size(87, 22)
        Me.radJonathan.TabIndex = 3
        Me.radJonathan.Text = "Jonathan"
        Me.radJonathan.UseVisualStyleBackColor = False
        '
        'radDemitri
        '
        Me.radDemitri.AutoSize = True
        Me.radDemitri.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radDemitri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDemitri.ForeColor = System.Drawing.Color.White
        Me.radDemitri.Location = New System.Drawing.Point(42, 89)
        Me.radDemitri.Name = "radDemitri"
        Me.radDemitri.Size = New System.Drawing.Size(83, 24)
        Me.radDemitri.TabIndex = 4
        Me.radDemitri.Text = "Demetri"
        Me.radDemitri.UseVisualStyleBackColor = False
        '
        'radMelanie
        '
        Me.radMelanie.AutoSize = True
        Me.radMelanie.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radMelanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMelanie.ForeColor = System.Drawing.Color.White
        Me.radMelanie.Location = New System.Drawing.Point(212, 89)
        Me.radMelanie.Name = "radMelanie"
        Me.radMelanie.Size = New System.Drawing.Size(82, 24)
        Me.radMelanie.TabIndex = 5
        Me.radMelanie.Text = "Melanie"
        Me.radMelanie.UseVisualStyleBackColor = False
        '
        'radClear
        '
        Me.radClear.AutoSize = True
        Me.radClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radClear.Font = New System.Drawing.Font("SWItal", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radClear.ForeColor = System.Drawing.Color.Transparent
        Me.radClear.Location = New System.Drawing.Point(131, 290)
        Me.radClear.Name = "radClear"
        Me.radClear.Size = New System.Drawing.Size(92, 29)
        Me.radClear.TabIndex = 6
        Me.radClear.Text = "Clear"
        Me.radClear.UseVisualStyleBackColor = False
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkBold.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkBold.Location = New System.Drawing.Point(131, 325)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(82, 26)
        Me.chkBold.TabIndex = 7
        Me.chkBold.Text = "BOLD"
        Me.chkBold.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(131, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 34)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmNewFriends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 411)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.radClear)
        Me.Controls.Add(Me.radMelanie)
        Me.Controls.Add(Me.radDemitri)
        Me.Controls.Add(Me.radJonathan)
        Me.Controls.Add(Me.radJustin)
        Me.Controls.Add(Me.lblWrittenBy)
        Me.Controls.Add(Me.lblInformation)
        Me.Name = "frmNewFriends"
        Me.Text = "New Friends"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents lblWrittenBy As System.Windows.Forms.Label
    Friend WithEvents radJustin As System.Windows.Forms.RadioButton
    Friend WithEvents radJonathan As System.Windows.Forms.RadioButton
    Friend WithEvents radDemitri As System.Windows.Forms.RadioButton
    Friend WithEvents radMelanie As System.Windows.Forms.RadioButton
    Friend WithEvents radClear As System.Windows.Forms.RadioButton
    Friend WithEvents chkBold As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
