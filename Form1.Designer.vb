<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.btPlay = New System.Windows.Forms.Button
        Me.btPause = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblNumero = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btPlay
        '
        Me.btPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btPlay.ForeColor = System.Drawing.Color.Lime
        Me.btPlay.Location = New System.Drawing.Point(22, 253)
        Me.btPlay.Name = "btPlay"
        Me.btPlay.Size = New System.Drawing.Size(75, 25)
        Me.btPlay.TabIndex = 3
        Me.btPlay.Text = "l>"
        Me.btPlay.UseVisualStyleBackColor = True
        '
        'btPause
        '
        Me.btPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btPause.ForeColor = System.Drawing.Color.Red
        Me.btPause.Location = New System.Drawing.Point(22, 285)
        Me.btPause.Name = "btPause"
        Me.btPause.Size = New System.Drawing.Size(75, 25)
        Me.btPause.TabIndex = 4
        Me.btPause.Text = "||"
        Me.btPause.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(8, 573)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "           "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(97, 104)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.ForeColor = System.Drawing.Color.White
        Me.lblNumero.Location = New System.Drawing.Point(18, 16)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(149, 38)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "           "
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(7, 57)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(84, 30)
        Me.txtNumero.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(10, 123)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(75, 17)
        Me.ListBox1.TabIndex = 16
        Me.ListBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblNumero)
        Me.Panel2.Controls.Add(Me.txtNumero)
        Me.Panel2.Location = New System.Drawing.Point(12, 457)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(97, 113)
        Me.Panel2.TabIndex = 9
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(966, 730)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btPause)
        Me.Controls.Add(Me.btPlay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*^v^"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btPlay As System.Windows.Forms.Button
    Friend WithEvents btPause As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
