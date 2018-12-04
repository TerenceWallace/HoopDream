
Imports System.ComponentModel
Imports System.Diagnostics
Imports Microsoft.Win32


Namespace HoopDream.Gui.Controls
    Partial Class PlayerList
        Inherits System.Windows.Forms.UserControl

        Private components As IContainer
        Private WithEvents PlayerViewModelBindingSource As BindingSource


        Public Sub New()
            MyBase.New

            ' Initialize UI
            InitializeComponent()
        End Sub

        '<System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ctxPlayers = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.miExport = New System.Windows.Forms.ToolStripMenuItem()
            Me.PlayerViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.grpRank = New System.Windows.Forms.GroupBox()
            Me.gridPlayers = New System.Windows.Forms.DataGrid()
            Me.ctxPlayers.SuspendLayout()
            CType(Me.PlayerViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpRank.SuspendLayout()
            CType(Me.gridPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ctxPlayers
            '
            Me.ctxPlayers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miExport})
            Me.ctxPlayers.Name = "ContextMenuStrip1"
            Me.ctxPlayers.Size = New System.Drawing.Size(108, 26)
            '
            'miExport
            '
            Me.miExport.Name = "miExport"
            Me.miExport.Size = New System.Drawing.Size(107, 22)
            Me.miExport.Text = "E&xport"
            '
            'PlayerViewModelBindingSource
            '
            Me.PlayerViewModelBindingSource.DataSource = GetType(HoopDream.Framework.ViewModels.PlayerViewModel)
            '
            'grpRank
            '
            Me.grpRank.AccessibleDescription = "GroupBox with text ""Invoice Items"""
            Me.grpRank.AccessibleName = "Invoice Items"
            Me.grpRank.Controls.Add(Me.gridPlayers)
            Me.grpRank.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpRank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
            Me.grpRank.Location = New System.Drawing.Point(0, 0)
            Me.grpRank.Name = "grpRank"
            Me.grpRank.Size = New System.Drawing.Size(629, 349)
            Me.grpRank.TabIndex = 8
            Me.grpRank.TabStop = False
            Me.grpRank.Text = "Player Rankings"
            '
            'gridPlayers
            '
            Me.gridPlayers.AlternatingBackColor = System.Drawing.Color.Lavender
            Me.gridPlayers.BackColor = System.Drawing.Color.WhiteSmoke
            Me.gridPlayers.BackgroundColor = System.Drawing.Color.Gainsboro
            Me.gridPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gridPlayers.CaptionBackColor = System.Drawing.Color.LightSteelBlue
            Me.gridPlayers.CaptionForeColor = System.Drawing.Color.MidnightBlue
            Me.gridPlayers.DataMember = ""
            Me.gridPlayers.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gridPlayers.FlatMode = True
            Me.gridPlayers.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.gridPlayers.Location = New System.Drawing.Point(3, 35)
            Me.gridPlayers.Name = "gridPlayers"
            Me.gridPlayers.RowHeadersVisible = False
            Me.gridPlayers.Size = New System.Drawing.Size(623, 311)
            Me.gridPlayers.TabIndex = 0
            '
            'PlayerList
            '
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.Controls.Add(Me.grpRank)
            Me.Name = "PlayerList"
            Me.Size = New System.Drawing.Size(629, 349)
            Me.ctxPlayers.ResumeLayout(False)
            CType(Me.PlayerViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpRank.ResumeLayout(False)
            CType(Me.gridPlayers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


        Friend WithEvents ctxPlayers As ContextMenuStrip
        Friend WithEvents miExport As ToolStripMenuItem
        Friend WithEvents grpRank As GroupBox
        Friend WithEvents gridPlayers As DataGrid
    End Class
End Namespace
