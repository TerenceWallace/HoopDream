
Namespace HoopDream
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormMain
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.PlayerList1 = New HoopDream.Gui.Controls.PlayerList()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.miRefresh = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PlayerList1
            '
            Me.PlayerList1.BackColor = System.Drawing.SystemColors.Window
            Me.PlayerList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlayerList1.Location = New System.Drawing.Point(0, 24)
            Me.PlayerList1.Name = "PlayerList1"
            Me.PlayerList1.Size = New System.Drawing.Size(1103, 357)
            Me.PlayerList1.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(1103, 24)
            Me.MenuStrip1.TabIndex = 1
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ToolsToolStripMenuItem
            '
            Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miRefresh})
            Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
            Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
            Me.ToolsToolStripMenuItem.Text = "&Tools"
            '
            'miRefresh
            '
            Me.miRefresh.Name = "miRefresh"
            Me.miRefresh.Size = New System.Drawing.Size(152, 22)
            Me.miRefresh.Text = "&Refresh"
            '
            'ExitToolStripMenuItem
            '
            Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.ExitToolStripMenuItem.Text = "E&xit"
            '
            'FileToolStripMenuItem
            '
            Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
            Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
            Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
            Me.FileToolStripMenuItem.Text = "&File"
            '
            'FormMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1103, 381)
            Me.Controls.Add(Me.PlayerList1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "FormMain"
            Me.Text = "HoopDream - Arkitech EBC Corporation"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents PlayerList1 As Gui.Controls.PlayerList
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents miRefresh As ToolStripMenuItem
        Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    End Class
End Namespace