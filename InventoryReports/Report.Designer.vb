<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.lblIdentifiy = New System.Windows.Forms.Label()
        Me.bllTotalQuantity = New System.Windows.Forms.Label()
        Me.lblOrderMore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIdentifiy
        '
        Me.lblIdentifiy.AutoSize = True
        Me.lblIdentifiy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentifiy.Location = New System.Drawing.Point(36, 74)
        Me.lblIdentifiy.Name = "lblIdentifiy"
        Me.lblIdentifiy.Size = New System.Drawing.Size(239, 25)
        Me.lblIdentifiy.TabIndex = 0
        Me.lblIdentifiy.Text = "The Total Quantity Is:"
        '
        'bllTotalQuantity
        '
        Me.bllTotalQuantity.AutoSize = True
        Me.bllTotalQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bllTotalQuantity.Location = New System.Drawing.Point(36, 126)
        Me.bllTotalQuantity.Name = "bllTotalQuantity"
        Me.bllTotalQuantity.Size = New System.Drawing.Size(0, 37)
        Me.bllTotalQuantity.TabIndex = 1
        '
        'lblOrderMore
        '
        Me.lblOrderMore.AutoSize = True
        Me.lblOrderMore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMore.Location = New System.Drawing.Point(38, 238)
        Me.lblOrderMore.Name = "lblOrderMore"
        Me.lblOrderMore.Size = New System.Drawing.Size(0, 20)
        Me.lblOrderMore.TabIndex = 2
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 317)
        Me.Controls.Add(Me.lblOrderMore)
        Me.Controls.Add(Me.bllTotalQuantity)
        Me.Controls.Add(Me.lblIdentifiy)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdentifiy As Label
    Friend WithEvents bllTotalQuantity As Label
    Friend WithEvents lblOrderMore As Label
End Class
