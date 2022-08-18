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
        Me.monkeybutton1 = New System.Windows.Forms.Button()
        Me.displaypicturebox = New System.Windows.Forms.PictureBox()
        Me.monkeyPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.namelabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.displaypicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monkeyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monkeybutton1
        '
        Me.monkeybutton1.Location = New System.Drawing.Point(144, 277)
        Me.monkeybutton1.Name = "monkeybutton1"
        Me.monkeybutton1.Size = New System.Drawing.Size(75, 23)
        Me.monkeybutton1.TabIndex = 0
        Me.monkeybutton1.Text = "monkey"
        Me.monkeybutton1.UseVisualStyleBackColor = True
        '
        'displaypicturebox
        '
        Me.displaypicturebox.Location = New System.Drawing.Point(-1, 4)
        Me.displaypicturebox.Name = "displaypicturebox"
        Me.displaypicturebox.Size = New System.Drawing.Size(291, 227)
        Me.displaypicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displaypicturebox.TabIndex = 1
        Me.displaypicturebox.TabStop = False
        '
        'monkeyPictureBox
        '
        Me.monkeyPictureBox.Image = Global.monkeydex.My.Resources.Resources.download
        Me.monkeyPictureBox.Location = New System.Drawing.Point(98, 315)
        Me.monkeyPictureBox.Name = "monkeyPictureBox"
        Me.monkeyPictureBox.Size = New System.Drawing.Size(225, 95)
        Me.monkeyPictureBox.TabIndex = 2
        Me.monkeyPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "legs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "food"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "predators"
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Location = New System.Drawing.Point(458, 35)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(41, 16)
        Me.namelabel.TabIndex = 7
        Me.namelabel.Text = "name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(458, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Legs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(458, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "food"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(450, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "predators"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.monkeyPictureBox)
        Me.Controls.Add(Me.displaypicturebox)
        Me.Controls.Add(Me.monkeybutton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.displaypicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monkeyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents monkeybutton1 As Button
    Friend WithEvents displaypicturebox As PictureBox
    Friend WithEvents monkeyPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents namelabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
