<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonUpdate2
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxHiddenID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonDelete2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonConnect.Location = New System.Drawing.Point(12, 12)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(169, 33)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "ConnectMySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.Location = New System.Drawing.Point(47, 48)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age:"
        '
        'TextBoxAge
        '
        Me.TextBoxAge.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAge.Location = New System.Drawing.Point(47, 75)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxAge.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email:"
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(407, 206)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(167, 57)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "Create InsertData"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(589, 269)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(172, 48)
        Me.ButtonDelete.TabIndex = 8
        Me.ButtonDelete.Text = "Delete (Remove data)"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(589, 206)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(172, 57)
        Me.ButtonUpdate.TabIndex = 9
        Me.ButtonUpdate.Text = "Update (Edit Data)"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(407, 269)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(167, 48)
        Me.ButtonRead.TabIndex = 10
        Me.ButtonRead.Text = "Read (Retrieve data)"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(228, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(523, 171)
        Me.DataGridView1.TabIndex = 11
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Location = New System.Drawing.Point(47, 101)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxEmail.TabIndex = 5
        '
        'TextBoxID
        '
        Me.TextBoxID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxID.Location = New System.Drawing.Point(47, 137)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxID.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ID:"
        '
        'TextBoxHiddenID
        '
        Me.TextBoxHiddenID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxHiddenID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxHiddenID.Location = New System.Drawing.Point(47, 163)
        Me.TextBoxHiddenID.Name = "TextBoxHiddenID"
        Me.TextBoxHiddenID.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxHiddenID.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Update(Modifying existing data)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonDelete2
        '
        Me.ButtonDelete2.Location = New System.Drawing.Point(228, 206)
        Me.ButtonDelete2.Name = "ButtonDelete2"
        Me.ButtonDelete2.Size = New System.Drawing.Size(161, 57)
        Me.ButtonDelete2.TabIndex = 16
        Me.ButtonDelete2.Text = "Delete (Remove data)"
        Me.ButtonDelete2.UseVisualStyleBackColor = True
        '
        'ButtonUpdate2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonDelete2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxHiddenID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "ButtonUpdate2"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxHiddenID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonDelete2 As Button
End Class
