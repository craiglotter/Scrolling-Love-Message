Imports AxWMPLib

Public Class Main_Screen
    Inherits System.Windows.Forms.Form
    Dim currentindex As Integer = 0
    Dim filereader As System.IO.StreamReader
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mediaplayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lyrics As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.mediaplayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lyrics = New System.Windows.Forms.RichTextBox
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.mediaplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(448, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 1
        '
        'mediaplayer
        '
        Me.mediaplayer.Enabled = True
        Me.mediaplayer.Location = New System.Drawing.Point(8, 8)
        Me.mediaplayer.Name = "mediaplayer"
        Me.mediaplayer.OcxState = CType(resources.GetObject("mediaplayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaplayer.Size = New System.Drawing.Size(75, 23)
        Me.mediaplayer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 4
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lyrics
        '
        Me.lyrics.BackColor = System.Drawing.Color.Red
        Me.lyrics.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lyrics.Cursor = System.Windows.Forms.Cursors.Default
        Me.lyrics.DetectUrls = False
        Me.lyrics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyrics.ForeColor = System.Drawing.Color.LightPink
        Me.lyrics.Location = New System.Drawing.Point(136, 152)
        Me.lyrics.Name = "lyrics"
        Me.lyrics.ReadOnly = True
        Me.lyrics.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.lyrics.Size = New System.Drawing.Size(248, 168)
        Me.lyrics.TabIndex = 5
        Me.lyrics.Text = ""
        '
        'Timer3
        '
        Me.Timer3.Interval = 2000
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(168, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "I love you!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Interval = 13000
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightPink
        Me.Label5.Location = New System.Drawing.Point(192, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Wait for it"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(408, 464)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CodeUnit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(376, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Version 20070711.02"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Main_Screen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lyrics)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mediaplayer)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Main_Screen"
        Me.Text = "For My Angel"
        CType(Me.mediaplayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If (m.Result.ToInt32 = HTCLIENT) Then
                    m.Result = IntPtr.op_Explicit(HTCAPTION)
                End If
                Exit Sub
        End Select

        MyBase.WndProc(m)
    End Sub

    Private Sub Error_Handler(ByVal message As String)
        Try
            MsgBox(message, MsgBoxStyle.Exclamation, "Critical Error Encountered")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Try
            Application.Exit()
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub

    Private Sub Main_Screen_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            filereader.Close()
            mediaplayer.Ctlcontrols.stop()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer1.Dispose()
            Timer2.Dispose()
            Timer3.Dispose()
            Timer4.Dispose()
            Timer5.Dispose()

        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            mediaplayer.uiMode = "invisible"
            mediaplayer.Visible = False
            mediaplayer.Height = 0
            mediaplayer.Width = 0
            mediaplayer.AllowDrop = False
            mediaplayer.URL = Application.StartupPath & "\reason.mp3"

            filereader = New System.IO.StreamReader(Application.StartupPath & "\The_reason.txt", True)

            'lyrics.LoadFile(Application.StartupPath & "\The_reason.txt", RichTextBoxStreamType.PlainText)
            'lyrics.SelectAll()
            'lyrics.SelectionAlignment = HorizontalAlignment.Center
            'lyrics.Select(0, 0)
            'lyrics.Refresh()
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            currentindex = currentindex + 1
            If currentindex > 6 Then
                currentindex = 0
            End If
            Dim i As Integer = 0
            Dim fullstop As String = ""
            For i = 1 To currentindex
                fullstop = fullstop & "."
            Next
            Label5.Text = "Wait for it" & fullstop
            If mediaplayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
                mediaplayer.Ctlcontrols.play()
            End If
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try

    End Sub



    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try
            If mediaplayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
                mediaplayer.Ctlcontrols.play()
                Timer1.Start()
            Else
                mediaplayer.Ctlcontrols.stop()
                Timer1.Stop()
            End If
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Label2.Text = mediaplayer.playState.ToString.Replace("wmpps", "")
            If mediaplayer.playState = WMPLib.WMPPlayState.wmppsPlaying And lyrics.TextLength < 2 Then
                Timer4.Start()
            End If
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Try
            Dim writeline = filereader.ReadLine()
            If Not (writeline Is Nothing) Then
                writeline = writeline & vbCrLf
                lyrics.AppendText(writeline)
                lyrics.SelectAll()
                lyrics.SelectionAlignment = HorizontalAlignment.Center
                lyrics.Select(lyrics.TextLength, 0)
                lyrics.Refresh()
                'Label1.Select()
            Else
                Timer3.Stop()
                Timer5.Start()
            End If
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Try
            Label5.Visible = False
            Timer3.Enabled = True
            Timer3.Start()
            Timer4.Stop()
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Try
            Label4.Visible = True
            Timer5.Stop()
        Catch ex As Exception
            Error_Handler(ex.ToString)
        End Try
    End Sub
End Class
