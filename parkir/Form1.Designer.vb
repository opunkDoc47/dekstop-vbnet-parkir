<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.itemMenuData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkiranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataParkiranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEGAWAIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemTarif = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Lbuser = New System.Windows.Forms.Label()
        Me.Btin = New System.Windows.Forms.Button()
        Me.Btout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btlogin = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tomato
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemMenuData, Me.MenuItemTarif})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'itemMenuData
        '
        Me.itemMenuData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParkiranToolStripMenuItem, Me.DataParkiranToolStripMenuItem, Me.PEGAWAIToolStripMenuItem})
        Me.itemMenuData.Name = "itemMenuData"
        Me.itemMenuData.Size = New System.Drawing.Size(48, 20)
        Me.itemMenuData.Text = "DATA"
        Me.itemMenuData.Visible = False
        '
        'ParkiranToolStripMenuItem
        '
        Me.ParkiranToolStripMenuItem.Name = "ParkiranToolStripMenuItem"
        Me.ParkiranToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ParkiranToolStripMenuItem.Text = "PARKIR"
        '
        'DataParkiranToolStripMenuItem
        '
        Me.DataParkiranToolStripMenuItem.Name = "DataParkiranToolStripMenuItem"
        Me.DataParkiranToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DataParkiranToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PEGAWAIToolStripMenuItem
        '
        Me.PEGAWAIToolStripMenuItem.Name = "PEGAWAIToolStripMenuItem"
        Me.PEGAWAIToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PEGAWAIToolStripMenuItem.Text = "PEGAWAI"
        '
        'MenuItemTarif
        '
        Me.MenuItemTarif.Name = "MenuItemTarif"
        Me.MenuItemTarif.Size = New System.Drawing.Size(49, 20)
        Me.MenuItemTarif.Text = "TARIF"
        Me.MenuItemTarif.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Tomato
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Location = New System.Drawing.Point(453, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "USER :"
        '
        'Lbuser
        '
        Me.Lbuser.AutoSize = True
        Me.Lbuser.BackColor = System.Drawing.Color.Tomato
        Me.Lbuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbuser.Location = New System.Drawing.Point(502, 9)
        Me.Lbuser.Name = "Lbuser"
        Me.Lbuser.Size = New System.Drawing.Size(0, 13)
        Me.Lbuser.TabIndex = 5
        '
        'Btin
        '
        Me.Btin.BackColor = System.Drawing.Color.Transparent
        Me.Btin.BackgroundImage = CType(resources.GetObject("Btin.BackgroundImage"), System.Drawing.Image)
        Me.Btin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btin.Location = New System.Drawing.Point(65, 130)
        Me.Btin.Name = "Btin"
        Me.Btin.Size = New System.Drawing.Size(186, 203)
        Me.Btin.TabIndex = 6
        Me.Btin.UseVisualStyleBackColor = False
        Me.Btin.Visible = False
        '
        'Btout
        '
        Me.Btout.BackgroundImage = CType(resources.GetObject("Btout.BackgroundImage"), System.Drawing.Image)
        Me.Btout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btout.Location = New System.Drawing.Point(311, 130)
        Me.Btout.Name = "Btout"
        Me.Btout.Size = New System.Drawing.Size(185, 203)
        Me.Btout.TabIndex = 7
        Me.Btout.UseVisualStyleBackColor = True
        Me.Btout.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "masuk"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 47)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "keluar"
        Me.Label2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(107, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 47)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Parking Area"
        '
        'Btlogin
        '
        Me.Btlogin.BackColor = System.Drawing.Color.Transparent
        Me.Btlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btlogin.Location = New System.Drawing.Point(505, 341)
        Me.Btlogin.Name = "Btlogin"
        Me.Btlogin.Size = New System.Drawing.Size(75, 37)
        Me.Btlogin.TabIndex = 13
        Me.Btlogin.Text = "LOG IN"
        Me.Btlogin.UseVisualStyleBackColor = False
        '
        'menuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 390)
        Me.Controls.Add(Me.Btlogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btout)
        Me.Controls.Add(Me.Btin)
        Me.Controls.Add(Me.Lbuser)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuUtama"
        Me.Text = "menu utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemMenuData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParkiranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataParkiranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Lbuser As System.Windows.Forms.Label
    Friend WithEvents PEGAWAIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemTarif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btin As System.Windows.Forms.Button
    Friend WithEvents Btout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btlogin As System.Windows.Forms.Button

End Class
