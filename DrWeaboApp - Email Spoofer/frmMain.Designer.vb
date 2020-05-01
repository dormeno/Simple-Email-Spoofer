<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlMain = New Guna.UI.WinForms.GunaGradientPanel()
        Me.lblCompany = New Guna.UI.WinForms.GunaLabel()
        Me.pnlTop = New Guna.UI.WinForms.GunaGradientPanel()
        Me.ControlClose = New Guna.UI.WinForms.GunaControlBox()
        Me.ControMax = New Guna.UI.WinForms.GunaControlBox()
        Me.ControlSize = New Guna.UI.WinForms.GunaControlBox()
        Me.lblMain = New Guna.UI.WinForms.GunaLabel()
        Me.lblCopyright = New Guna.UI.WinForms.GunaLabel()
        Me.gbMain = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnClear = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtMessage = New Guna.UI.WinForms.GunaTextBox()
        Me.txtTarget = New Guna.UI.WinForms.GunaTextBox()
        Me.lblTotal = New Guna.UI.WinForms.GunaLabel()
        Me.lblAmount = New Guna.UI.WinForms.GunaLabel()
        Me.tbAmount = New Guna.UI.WinForms.GunaVTrackBar()
        Me.pbAmount = New Guna.UI.WinForms.GunaPictureBox()
        Me.pbMessage = New Guna.UI.WinForms.GunaPictureBox()
        Me.pbSubject = New Guna.UI.WinForms.GunaPictureBox()
        Me.pbSender = New Guna.UI.WinForms.GunaPictureBox()
        Me.pbEmails = New Guna.UI.WinForms.GunaPictureBox()
        Me.btnSend = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtSender = New Guna.UI.WinForms.GunaTextBox()
        Me.txtSubject = New Guna.UI.WinForms.GunaTextBox()
        Me.Elipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Animate = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlMain.SuspendLayout
        Me.pnlTop.SuspendLayout
        Me.gbMain.SuspendLayout
        CType(Me.pbAmount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbMessage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbSubject,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbSender,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbEmails,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnlMain
        '
        Me.pnlMain.BackgroundImage = CType(resources.GetObject("pnlMain.BackgroundImage"),System.Drawing.Image)
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMain.Controls.Add(Me.lblCompany)
        Me.pnlMain.Controls.Add(Me.pnlTop)
        Me.pnlMain.Controls.Add(Me.lblCopyright)
        Me.pnlMain.Controls.Add(Me.gbMain)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.pnlMain.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.pnlMain.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(114,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(218,Byte),Integer))
        Me.pnlMain.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(114,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(218,Byte),Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Quality = 50
        Me.pnlMain.Size = New System.Drawing.Size(669, 766)
        Me.pnlMain.TabIndex = 0
        '
        'lblCompany
        '
        Me.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCompany.AutoSize = true
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCompany.Font = New System.Drawing.Font("Century Gothic", 12!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCompany.Location = New System.Drawing.Point(348, 701)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(117, 19)
        Me.lblCompany.TabIndex = 23
        Me.lblCompany.Text = "DrWeabo Inc."
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"),System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.ControlClose)
        Me.pnlTop.Controls.Add(Me.ControMax)
        Me.pnlTop.Controls.Add(Me.ControlSize)
        Me.pnlTop.Controls.Add(Me.lblMain)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.pnlTop.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.pnlTop.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.pnlTop.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(669, 31)
        Me.pnlTop.TabIndex = 22
        '
        'ControlClose
        '
        Me.ControlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ControlClose.AnimationHoverSpeed = 0.07!
        Me.ControlClose.AnimationSpeed = 0.03!
        Me.ControlClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ControlClose.IconColor = System.Drawing.Color.White
        Me.ControlClose.IconSize = 15!
        Me.ControlClose.Location = New System.Drawing.Point(630, 3)
        Me.ControlClose.Name = "ControlClose"
        Me.ControlClose.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.ControlClose.OnHoverIconColor = System.Drawing.Color.White
        Me.ControlClose.OnPressedColor = System.Drawing.Color.Black
        Me.ControlClose.Size = New System.Drawing.Size(27, 21)
        Me.ControlClose.TabIndex = 3
        '
        'ControMax
        '
        Me.ControMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ControMax.AnimationHoverSpeed = 0.07!
        Me.ControMax.AnimationSpeed = 0.03!
        Me.ControMax.BackColor = System.Drawing.Color.Transparent
        Me.ControMax.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.ControMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ControMax.IconColor = System.Drawing.Color.White
        Me.ControMax.IconSize = 15!
        Me.ControMax.Location = New System.Drawing.Point(597, 3)
        Me.ControMax.Name = "ControMax"
        Me.ControMax.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.ControMax.OnHoverIconColor = System.Drawing.Color.White
        Me.ControMax.OnPressedColor = System.Drawing.Color.Black
        Me.ControMax.Size = New System.Drawing.Size(27, 21)
        Me.ControMax.TabIndex = 19
        '
        'ControlSize
        '
        Me.ControlSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ControlSize.AnimationHoverSpeed = 0.07!
        Me.ControlSize.AnimationSpeed = 0.03!
        Me.ControlSize.BackColor = System.Drawing.Color.Transparent
        Me.ControlSize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.ControlSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ControlSize.IconColor = System.Drawing.Color.White
        Me.ControlSize.IconSize = 15!
        Me.ControlSize.Location = New System.Drawing.Point(564, 3)
        Me.ControlSize.Name = "ControlSize"
        Me.ControlSize.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.ControlSize.OnHoverIconColor = System.Drawing.Color.White
        Me.ControlSize.OnPressedColor = System.Drawing.Color.Black
        Me.ControlSize.Size = New System.Drawing.Size(27, 21)
        Me.ControlSize.TabIndex = 20
        '
        'lblMain
        '
        Me.lblMain.AutoSize = true
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("HACKED", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(6, 6)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(76, 20)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "DrWeabo"
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCopyright.AutoSize = true
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(203, 701)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(149, 19)
        Me.lblCopyright.TabIndex = 21
        Me.lblCopyright.Text = "© 2020 Copyright:"
        '
        'gbMain
        '
        Me.gbMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbMain.BackColor = System.Drawing.Color.Transparent
        Me.gbMain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.gbMain.BorderColor = System.Drawing.Color.Transparent
        Me.gbMain.BorderSize = 1
        Me.gbMain.Controls.Add(Me.btnClear)
        Me.gbMain.Controls.Add(Me.txtMessage)
        Me.gbMain.Controls.Add(Me.txtTarget)
        Me.gbMain.Controls.Add(Me.lblTotal)
        Me.gbMain.Controls.Add(Me.lblAmount)
        Me.gbMain.Controls.Add(Me.tbAmount)
        Me.gbMain.Controls.Add(Me.pbAmount)
        Me.gbMain.Controls.Add(Me.pbMessage)
        Me.gbMain.Controls.Add(Me.pbSubject)
        Me.gbMain.Controls.Add(Me.pbSender)
        Me.gbMain.Controls.Add(Me.pbEmails)
        Me.gbMain.Controls.Add(Me.btnSend)
        Me.gbMain.Controls.Add(Me.txtSender)
        Me.gbMain.Controls.Add(Me.txtSubject)
        Me.gbMain.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMain.ForeColor = System.Drawing.Color.White
        Me.gbMain.LineColor = System.Drawing.Color.FromArgb(CType(CType(114,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(218,Byte),Integer))
        Me.gbMain.LineTop = 38
        Me.gbMain.Location = New System.Drawing.Point(41, 136)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Radius = 7
        Me.gbMain.Size = New System.Drawing.Size(586, 534)
        Me.gbMain.TabIndex = 0
        Me.gbMain.Text = "EMAIL SPOOFING"
        Me.gbMain.TextLocation = New System.Drawing.Point(220, 8)
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Animated = true
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(114,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(218,Byte),Integer))
        Me.btnClear.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(181,Byte),Integer), CType(CType(129,Byte),Integer))
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClear.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnClear.Location = New System.Drawing.Point(423, 463)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(181,Byte),Integer), CType(CType(129,Byte),Integer))
        Me.btnClear.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Radius = 5
        Me.btnClear.Size = New System.Drawing.Size(134, 44)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tip.SetToolTip(Me.btnClear, "Clear all textbox..")
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMessage.BackColor = System.Drawing.Color.Transparent
        Me.txtMessage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtMessage.BorderSize = 1
        Me.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessage.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(68,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.txtMessage.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.txtMessage.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(221,Byte),Integer), CType(CType(222,Byte),Integer))
        Me.txtMessage.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.White
        Me.txtMessage.Location = New System.Drawing.Point(71, 184)
        Me.txtMessage.MaxLength = 500
        Me.txtMessage.Multiline = true
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessage.Radius = 5
        Me.txtMessage.SelectedText = ""
        Me.txtMessage.Size = New System.Drawing.Size(486, 258)
        Me.txtMessage.TabIndex = 20
        Me.txtMessage.Text = "Messages"
        '
        'txtTarget
        '
        Me.txtTarget.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTarget.BackColor = System.Drawing.Color.Transparent
        Me.txtTarget.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtTarget.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtTarget.BorderSize = 1
        Me.txtTarget.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTarget.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(68,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.txtTarget.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.txtTarget.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(221,Byte),Integer), CType(CType(222,Byte),Integer))
        Me.txtTarget.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTarget.ForeColor = System.Drawing.Color.White
        Me.txtTarget.Location = New System.Drawing.Point(71, 110)
        Me.txtTarget.MaxLength = 30
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarget.Radius = 5
        Me.txtTarget.SelectedText = ""
        Me.txtTarget.Size = New System.Drawing.Size(486, 31)
        Me.txtTarget.TabIndex = 19
        Me.txtTarget.Text = "Victims"
        Me.txtTarget.TextOffsetX = 3
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.AutoSize = true
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(29, 474)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(160, 22)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "TOTAL SENDING:"
        '
        'lblAmount
        '
        Me.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAmount.AutoSize = true
        Me.lblAmount.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.White
        Me.lblAmount.Location = New System.Drawing.Point(186, 474)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(21, 22)
        Me.lblAmount.TabIndex = 17
        Me.lblAmount.Text = "0"
        '
        'tbAmount
        '
        Me.tbAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbAmount.DisplayFocus = true
        Me.tbAmount.Location = New System.Drawing.Point(33, 258)
        Me.tbAmount.Maximum = 1000
        Me.tbAmount.Minimum = 1
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(32, 184)
        Me.tbAmount.TabIndex = 16
        Me.Tip.SetToolTip(Me.tbAmount, "Amount to sending...")
        Me.tbAmount.TrackColor = System.Drawing.Color.DimGray
        Me.tbAmount.TrackHoverColor = System.Drawing.Color.Gray
        Me.tbAmount.TrackIdleColor = System.Drawing.Color.White
        Me.tbAmount.TrackPressedColor = System.Drawing.Color.Black
        '
        'pbAmount
        '
        Me.pbAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbAmount.BaseColor = System.Drawing.Color.Transparent
        Me.pbAmount.Image = CType(resources.GetObject("pbAmount.Image"),System.Drawing.Image)
        Me.pbAmount.Location = New System.Drawing.Point(33, 221)
        Me.pbAmount.Name = "pbAmount"
        Me.pbAmount.Size = New System.Drawing.Size(32, 31)
        Me.pbAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAmount.TabIndex = 15
        Me.pbAmount.TabStop = false
        Me.Tip.SetToolTip(Me.pbAmount, "Amount's")
        '
        'pbMessage
        '
        Me.pbMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbMessage.BaseColor = System.Drawing.Color.Transparent
        Me.pbMessage.Image = CType(resources.GetObject("pbMessage.Image"),System.Drawing.Image)
        Me.pbMessage.Location = New System.Drawing.Point(33, 184)
        Me.pbMessage.Name = "pbMessage"
        Me.pbMessage.Size = New System.Drawing.Size(32, 31)
        Me.pbMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMessage.TabIndex = 14
        Me.pbMessage.TabStop = false
        Me.Tip.SetToolTip(Me.pbMessage, "Message's")
        '
        'pbSubject
        '
        Me.pbSubject.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbSubject.BaseColor = System.Drawing.Color.Transparent
        Me.pbSubject.Image = CType(resources.GetObject("pbSubject.Image"),System.Drawing.Image)
        Me.pbSubject.Location = New System.Drawing.Point(33, 147)
        Me.pbSubject.Name = "pbSubject"
        Me.pbSubject.Size = New System.Drawing.Size(32, 31)
        Me.pbSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSubject.TabIndex = 13
        Me.pbSubject.TabStop = false
        Me.Tip.SetToolTip(Me.pbSubject, "Subject's")
        '
        'pbSender
        '
        Me.pbSender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbSender.BaseColor = System.Drawing.Color.Transparent
        Me.pbSender.Image = CType(resources.GetObject("pbSender.Image"),System.Drawing.Image)
        Me.pbSender.Location = New System.Drawing.Point(33, 73)
        Me.pbSender.Name = "pbSender"
        Me.pbSender.Size = New System.Drawing.Size(32, 31)
        Me.pbSender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSender.TabIndex = 12
        Me.pbSender.TabStop = false
        Me.Tip.SetToolTip(Me.pbSender, "Sender's")
        '
        'pbEmails
        '
        Me.pbEmails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbEmails.BaseColor = System.Drawing.Color.Transparent
        Me.pbEmails.Image = CType(resources.GetObject("pbEmails.Image"),System.Drawing.Image)
        Me.pbEmails.Location = New System.Drawing.Point(33, 110)
        Me.pbEmails.Name = "pbEmails"
        Me.pbEmails.Size = New System.Drawing.Size(32, 31)
        Me.pbEmails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmails.TabIndex = 11
        Me.pbEmails.TabStop = false
        Me.Tip.SetToolTip(Me.pbEmails, "Receiver's")
        '
        'btnSend
        '
        Me.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSend.Animated = true
        Me.btnSend.AnimationHoverSpeed = 0.07!
        Me.btnSend.AnimationSpeed = 0.03!
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(114,Byte),Integer), CType(CType(137,Byte),Integer), CType(CType(218,Byte),Integer))
        Me.btnSend.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(181,Byte),Integer), CType(CType(129,Byte),Integer))
        Me.btnSend.BorderColor = System.Drawing.Color.Black
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSend.FocusedColor = System.Drawing.Color.Empty
        Me.btnSend.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Image = Nothing
        Me.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSend.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSend.Location = New System.Drawing.Point(283, 463)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(67,Byte),Integer), CType(CType(181,Byte),Integer), CType(CType(129,Byte),Integer))
        Me.btnSend.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(90,Byte),Integer))
        Me.btnSend.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSend.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSend.OnHoverImage = Nothing
        Me.btnSend.OnPressedColor = System.Drawing.Color.Black
        Me.btnSend.Radius = 5
        Me.btnSend.Size = New System.Drawing.Size(134, 44)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "SEND"
        Me.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tip.SetToolTip(Me.btnSend, "Run the spoofing...")
        '
        'txtSender
        '
        Me.txtSender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSender.BackColor = System.Drawing.Color.Transparent
        Me.txtSender.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtSender.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtSender.BorderSize = 1
        Me.txtSender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSender.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(68,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.txtSender.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.txtSender.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(221,Byte),Integer), CType(CType(222,Byte),Integer))
        Me.txtSender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSender.ForeColor = System.Drawing.Color.White
        Me.txtSender.Location = New System.Drawing.Point(71, 73)
        Me.txtSender.MaxLength = 30
        Me.txtSender.Name = "txtSender"
        Me.txtSender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSender.Radius = 5
        Me.txtSender.SelectedText = ""
        Me.txtSender.Size = New System.Drawing.Size(486, 31)
        Me.txtSender.TabIndex = 1
        Me.txtSender.Text = "Sender"
        Me.txtSender.TextOffsetX = 3
        '
        'txtSubject
        '
        Me.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSubject.BackColor = System.Drawing.Color.Transparent
        Me.txtSubject.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtSubject.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(34,Byte),Integer), CType(CType(37,Byte),Integer))
        Me.txtSubject.BorderSize = 1
        Me.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubject.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(68,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.txtSubject.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(54,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(63,Byte),Integer))
        Me.txtSubject.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(221,Byte),Integer), CType(CType(222,Byte),Integer))
        Me.txtSubject.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSubject.ForeColor = System.Drawing.Color.White
        Me.txtSubject.Location = New System.Drawing.Point(71, 147)
        Me.txtSubject.MaxLength = 50
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubject.Radius = 5
        Me.txtSubject.SelectedText = ""
        Me.txtSubject.Size = New System.Drawing.Size(486, 31)
        Me.txtSubject.TabIndex = 1
        Me.txtSubject.Text = "Subject"
        Me.txtSubject.TextOffsetX = 3
        '
        'Elipse
        '
        Me.Elipse.Radius = 5
        Me.Elipse.TargetControl = Me
        '
        'Animate
        '
        Me.Animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER
        Me.Animate.Interval = 100
        Me.Animate.TargetControl = Me
        '
        'Tip
        '
        Me.Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip.ToolTipTitle = "DrWeabo"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 766)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.Name = "frmMain"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        Me.pnlMain.ResumeLayout(false)
        Me.pnlMain.PerformLayout
        Me.pnlTop.ResumeLayout(false)
        Me.pnlTop.PerformLayout
        Me.gbMain.ResumeLayout(false)
        Me.gbMain.PerformLayout
        CType(Me.pbAmount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbMessage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbSubject,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbSender,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbEmails,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblMain As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Elipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Animate As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents ControlClose As Guna.UI.WinForms.GunaControlBox
    Private WithEvents pbAmount As Guna.UI.WinForms.GunaPictureBox
    Private WithEvents pbMessage As Guna.UI.WinForms.GunaPictureBox
    Private WithEvents pbSubject As Guna.UI.WinForms.GunaPictureBox
    Private WithEvents pbSender As Guna.UI.WinForms.GunaPictureBox
    Private WithEvents pbEmails As Guna.UI.WinForms.GunaPictureBox
    Private WithEvents pnlMain As Guna.UI.WinForms.GunaGradientPanel
    Private WithEvents gbMain As Guna.UI.WinForms.GunaGroupBox
    Private WithEvents txtSubject As Guna.UI.WinForms.GunaTextBox
    Private WithEvents btnSend As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents lblAmount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tbAmount As Guna.UI.WinForms.GunaVTrackBar
    Friend WithEvents lblTotal As Guna.UI.WinForms.GunaLabel
    Private WithEvents Tip As ToolTip
    Private WithEvents txtTarget As Guna.UI.WinForms.GunaTextBox
    Private WithEvents txtSender As Guna.UI.WinForms.GunaTextBox
    Private WithEvents txtMessage As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ControMax As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents ControlSize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents lblCopyright As Guna.UI.WinForms.GunaLabel
    Private WithEvents btnClear As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents pnlTop As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents lblCompany As Guna.UI.WinForms.GunaLabel
End Class
