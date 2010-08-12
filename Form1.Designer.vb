<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iNephron
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iNephron))
        Me.step1 = New System.Windows.Forms.GroupBox
        Me.lblSelectedDeviceName = New System.Windows.Forms.Label
        Me.lblDeviceName = New System.Windows.Forms.Label
        Me.lblInstruction1 = New System.Windows.Forms.Label
        Me.lblSelectedFirmware2 = New System.Windows.Forms.Label
        Me.lblSelectedFirwmare1 = New System.Windows.Forms.Label
        Me.ButtonBrowseF2 = New System.Windows.Forms.Button
        Me.ButtonBrowseF1 = New System.Windows.Forms.Button
        Me.lblFirmware2 = New System.Windows.Forms.Label
        Me.lblFirmware1 = New System.Windows.Forms.Label
        Me.step2 = New System.Windows.Forms.GroupBox
        Me.Button_Step2 = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pBar = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Step3 = New System.Windows.Forms.GroupBox
        Me.Check_Prepare = New System.Windows.Forms.PictureBox
        Me.Check_Boot = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblStep3 = New System.Windows.Forms.Label
        Me.step4 = New System.Windows.Forms.GroupBox
        Me.successBoot = New System.Windows.Forms.PictureBox
        Me.Boot = New System.Windows.Forms.Button
        Me.lblBootStatus = New System.Windows.Forms.Label
        Me.pBoot = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.step5 = New System.Windows.Forms.GroupBox
        Me.successPrepare = New System.Windows.Forms.PictureBox
        Me.Prepare = New System.Windows.Forms.Button
        Me.lblPrepareStatus = New System.Windows.Forms.Label
        Me.pPrepare = New System.Windows.Forms.ProgressBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.buttonNext = New System.Windows.Forms.PictureBox
        Me.nephron = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.MakeIBootPatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.step1.SuspendLayout()
        Me.step2.SuspendLayout()
        Me.Step3.SuspendLayout()
        CType(Me.Check_Prepare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check_Boot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step4.SuspendLayout()
        CType(Me.successBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step5.SuspendLayout()
        CType(Me.successPrepare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nephron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'step1
        '
        Me.step1.Controls.Add(Me.lblSelectedDeviceName)
        Me.step1.Controls.Add(Me.lblDeviceName)
        Me.step1.Controls.Add(Me.lblInstruction1)
        Me.step1.Controls.Add(Me.lblSelectedFirmware2)
        Me.step1.Controls.Add(Me.lblSelectedFirwmare1)
        Me.step1.Controls.Add(Me.ButtonBrowseF2)
        Me.step1.Controls.Add(Me.ButtonBrowseF1)
        Me.step1.Controls.Add(Me.lblFirmware2)
        Me.step1.Controls.Add(Me.lblFirmware1)
        Me.step1.Location = New System.Drawing.Point(12, 27)
        Me.step1.Name = "step1"
        Me.step1.Size = New System.Drawing.Size(462, 317)
        Me.step1.TabIndex = 1
        Me.step1.TabStop = False
        Me.step1.Visible = False
        '
        'lblSelectedDeviceName
        '
        Me.lblSelectedDeviceName.Location = New System.Drawing.Point(108, 183)
        Me.lblSelectedDeviceName.Name = "lblSelectedDeviceName"
        Me.lblSelectedDeviceName.Size = New System.Drawing.Size(237, 19)
        Me.lblSelectedDeviceName.TabIndex = 8
        Me.lblSelectedDeviceName.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Location = New System.Drawing.Point(16, 187)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(84, 15)
        Me.lblDeviceName.TabIndex = 7
        Me.lblDeviceName.Text = "Device Name:"
        '
        'lblInstruction1
        '
        Me.lblInstruction1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction1.Location = New System.Drawing.Point(16, 25)
        Me.lblInstruction1.Name = "lblInstruction1"
        Me.lblInstruction1.Size = New System.Drawing.Size(373, 69)
        Me.lblInstruction1.TabIndex = 6
        Me.lblInstruction1.Text = "Welcome to Nephron!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose your sn0wbreeze iOS 4 created ipsw (as firwmare 1) " & _
            "and original 3.1.2 (as firmware 2)."
        '
        'lblSelectedFirmware2
        '
        Me.lblSelectedFirmware2.Location = New System.Drawing.Point(108, 154)
        Me.lblSelectedFirmware2.Name = "lblSelectedFirmware2"
        Me.lblSelectedFirmware2.Size = New System.Drawing.Size(237, 19)
        Me.lblSelectedFirmware2.TabIndex = 5
        Me.lblSelectedFirmware2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSelectedFirwmare1
        '
        Me.lblSelectedFirwmare1.Location = New System.Drawing.Point(108, 125)
        Me.lblSelectedFirwmare1.Name = "lblSelectedFirwmare1"
        Me.lblSelectedFirwmare1.Size = New System.Drawing.Size(237, 19)
        Me.lblSelectedFirwmare1.TabIndex = 4
        Me.lblSelectedFirwmare1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ButtonBrowseF2
        '
        Me.ButtonBrowseF2.Location = New System.Drawing.Point(351, 150)
        Me.ButtonBrowseF2.Name = "ButtonBrowseF2"
        Me.ButtonBrowseF2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseF2.TabIndex = 3
        Me.ButtonBrowseF2.Text = "Browse.."
        Me.ButtonBrowseF2.UseVisualStyleBackColor = True
        '
        'ButtonBrowseF1
        '
        Me.ButtonBrowseF1.Location = New System.Drawing.Point(351, 121)
        Me.ButtonBrowseF1.Name = "ButtonBrowseF1"
        Me.ButtonBrowseF1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseF1.TabIndex = 2
        Me.ButtonBrowseF1.Text = "Browse.."
        Me.ButtonBrowseF1.UseVisualStyleBackColor = True
        '
        'lblFirmware2
        '
        Me.lblFirmware2.AutoSize = True
        Me.lblFirmware2.Location = New System.Drawing.Point(16, 154)
        Me.lblFirmware2.Name = "lblFirmware2"
        Me.lblFirmware2.Size = New System.Drawing.Size(72, 15)
        Me.lblFirmware2.TabIndex = 1
        Me.lblFirmware2.Text = "Firmware 2:"
        '
        'lblFirmware1
        '
        Me.lblFirmware1.AutoSize = True
        Me.lblFirmware1.Location = New System.Drawing.Point(16, 125)
        Me.lblFirmware1.Name = "lblFirmware1"
        Me.lblFirmware1.Size = New System.Drawing.Size(72, 15)
        Me.lblFirmware1.TabIndex = 0
        Me.lblFirmware1.Text = "Firmware 1:"
        '
        'step2
        '
        Me.step2.BackColor = System.Drawing.SystemColors.Control
        Me.step2.Controls.Add(Me.Button_Step2)
        Me.step2.Controls.Add(Me.lblStatus)
        Me.step2.Controls.Add(Me.pBar)
        Me.step2.Controls.Add(Me.Label3)
        Me.step2.Controls.Add(Me.Label5)
        Me.step2.Location = New System.Drawing.Point(12, 27)
        Me.step2.Name = "step2"
        Me.step2.Size = New System.Drawing.Size(462, 317)
        Me.step2.TabIndex = 3
        Me.step2.TabStop = False
        Me.step2.Visible = False
        '
        'Button_Step2
        '
        Me.Button_Step2.Location = New System.Drawing.Point(373, 25)
        Me.Button_Step2.Name = "Button_Step2"
        Me.Button_Step2.Size = New System.Drawing.Size(53, 23)
        Me.Button_Step2.TabIndex = 9
        Me.Button_Step2.Text = "Step2"
        Me.Button_Step2.UseVisualStyleBackColor = True
        Me.Button_Step2.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(16, 119)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(421, 25)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Sleeping"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(19, 148)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(418, 30)
        Me.pBar.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Welcome to Nephron!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose your sn0wbreeze iOS 4 created ipsw (as firwmare 1) " & _
            "and original 3.1.2 (as firmware 2)."
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(108, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Step3
        '
        Me.Step3.Controls.Add(Me.Check_Prepare)
        Me.Step3.Controls.Add(Me.Check_Boot)
        Me.Step3.Controls.Add(Me.Button2)
        Me.Step3.Controls.Add(Me.Button1)
        Me.Step3.Controls.Add(Me.lblStep3)
        Me.Step3.Location = New System.Drawing.Point(12, 27)
        Me.Step3.Name = "Step3"
        Me.Step3.Size = New System.Drawing.Size(462, 317)
        Me.Step3.TabIndex = 4
        Me.Step3.TabStop = False
        Me.Step3.Visible = False
        '
        'Check_Prepare
        '
        Me.Check_Prepare.Image = Global.Nephron.My.Resources.Resources.Green_Checked
        Me.Check_Prepare.Location = New System.Drawing.Point(334, 205)
        Me.Check_Prepare.Name = "Check_Prepare"
        Me.Check_Prepare.Size = New System.Drawing.Size(55, 48)
        Me.Check_Prepare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Check_Prepare.TabIndex = 11
        Me.Check_Prepare.TabStop = False
        Me.Check_Prepare.Visible = False
        '
        'Check_Boot
        '
        Me.Check_Boot.Image = Global.Nephron.My.Resources.Resources.Green_Checked
        Me.Check_Boot.Location = New System.Drawing.Point(334, 146)
        Me.Check_Boot.Name = "Check_Boot"
        Me.Check_Boot.Size = New System.Drawing.Size(55, 48)
        Me.Check_Boot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Check_Boot.TabIndex = 10
        Me.Check_Boot.TabStop = False
        Me.Check_Boot.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(77, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Prepare for Restore"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(77, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Boot my iDevice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblStep3
        '
        Me.lblStep3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep3.Location = New System.Drawing.Point(22, 33)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(415, 85)
        Me.lblStep3.TabIndex = 7
        Me.lblStep3.Text = "Welcome to Nephron!"
        '
        'step4
        '
        Me.step4.Controls.Add(Me.successBoot)
        Me.step4.Controls.Add(Me.Boot)
        Me.step4.Controls.Add(Me.lblBootStatus)
        Me.step4.Controls.Add(Me.pBoot)
        Me.step4.Controls.Add(Me.Label1)
        Me.step4.Location = New System.Drawing.Point(12, 27)
        Me.step4.Name = "step4"
        Me.step4.Size = New System.Drawing.Size(462, 317)
        Me.step4.TabIndex = 5
        Me.step4.TabStop = False
        Me.step4.Visible = False
        '
        'successBoot
        '
        Me.successBoot.Image = CType(resources.GetObject("successBoot.Image"), System.Drawing.Image)
        Me.successBoot.Location = New System.Drawing.Point(189, 194)
        Me.successBoot.Name = "successBoot"
        Me.successBoot.Size = New System.Drawing.Size(89, 107)
        Me.successBoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.successBoot.TabIndex = 12
        Me.successBoot.TabStop = False
        Me.successBoot.Visible = False
        '
        'Boot
        '
        Me.Boot.Location = New System.Drawing.Point(189, 103)
        Me.Boot.Name = "Boot"
        Me.Boot.Size = New System.Drawing.Size(89, 23)
        Me.Boot.TabIndex = 11
        Me.Boot.Text = "Boot"
        Me.Boot.UseVisualStyleBackColor = True
        Me.Boot.Visible = False
        '
        'lblBootStatus
        '
        Me.lblBootStatus.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBootStatus.Location = New System.Drawing.Point(21, 129)
        Me.lblBootStatus.Name = "lblBootStatus"
        Me.lblBootStatus.Size = New System.Drawing.Size(421, 25)
        Me.lblBootStatus.TabIndex = 10
        Me.lblBootStatus.Text = "Sleeping"
        Me.lblBootStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pBoot
        '
        Me.pBoot.Location = New System.Drawing.Point(24, 158)
        Me.pBoot.Maximum = 110
        Me.pBoot.Name = "pBoot"
        Me.pBoot.Size = New System.Drawing.Size(418, 30)
        Me.pBoot.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome to Nephron!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'step5
        '
        Me.step5.Controls.Add(Me.successPrepare)
        Me.step5.Controls.Add(Me.Prepare)
        Me.step5.Controls.Add(Me.lblPrepareStatus)
        Me.step5.Controls.Add(Me.pPrepare)
        Me.step5.Controls.Add(Me.Label4)
        Me.step5.Location = New System.Drawing.Point(12, 27)
        Me.step5.Name = "step5"
        Me.step5.Size = New System.Drawing.Size(462, 317)
        Me.step5.TabIndex = 6
        Me.step5.TabStop = False
        Me.step5.Visible = False
        '
        'successPrepare
        '
        Me.successPrepare.Image = CType(resources.GetObject("successPrepare.Image"), System.Drawing.Image)
        Me.successPrepare.Location = New System.Drawing.Point(189, 194)
        Me.successPrepare.Name = "successPrepare"
        Me.successPrepare.Size = New System.Drawing.Size(89, 107)
        Me.successPrepare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.successPrepare.TabIndex = 12
        Me.successPrepare.TabStop = False
        Me.successPrepare.Visible = False
        '
        'Prepare
        '
        Me.Prepare.Location = New System.Drawing.Point(189, 103)
        Me.Prepare.Name = "Prepare"
        Me.Prepare.Size = New System.Drawing.Size(89, 23)
        Me.Prepare.TabIndex = 11
        Me.Prepare.Text = "Prepare"
        Me.Prepare.UseVisualStyleBackColor = True
        Me.Prepare.Visible = False
        '
        'lblPrepareStatus
        '
        Me.lblPrepareStatus.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrepareStatus.Location = New System.Drawing.Point(21, 129)
        Me.lblPrepareStatus.Name = "lblPrepareStatus"
        Me.lblPrepareStatus.Size = New System.Drawing.Size(421, 25)
        Me.lblPrepareStatus.TabIndex = 10
        Me.lblPrepareStatus.Text = "Sleeping"
        Me.lblPrepareStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pPrepare
        '
        Me.pPrepare.Location = New System.Drawing.Point(24, 158)
        Me.pPrepare.Maximum = 30
        Me.pPrepare.Name = "pPrepare"
        Me.pPrepare.Size = New System.Drawing.Size(418, 30)
        Me.pPrepare.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Welcome to Nephron!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.MakeIBootPatchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicenseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(12, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 81)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Original Author: Fallensn0w." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Special Thx: iH8sn0w, GreySyntax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nephron.My.Resources.Resources.Nephron_Black
        Me.PictureBox1.Location = New System.Drawing.Point(563, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'buttonNext
        '
        Me.buttonNext.Enabled = False
        Me.buttonNext.Image = Global.Nephron.My.Resources.Resources.Button_Next_Enabled_False
        Me.buttonNext.Location = New System.Drawing.Point(407, 350)
        Me.buttonNext.Name = "buttonNext"
        Me.buttonNext.Size = New System.Drawing.Size(69, 69)
        Me.buttonNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.buttonNext.TabIndex = 2
        Me.buttonNext.TabStop = False
        '
        'nephron
        '
        Me.nephron.Image = Global.Nephron.My.Resources.Resources.iPhone_Nephron
        Me.nephron.Location = New System.Drawing.Point(482, 27)
        Me.nephron.Name = "nephron"
        Me.nephron.Size = New System.Drawing.Size(239, 392)
        Me.nephron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nephron.TabIndex = 0
        Me.nephron.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(536, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MakeIBootPatchToolStripMenuItem
        '
        Me.MakeIBootPatchToolStripMenuItem.Name = "MakeIBootPatchToolStripMenuItem"
        Me.MakeIBootPatchToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.MakeIBootPatchToolStripMenuItem.Text = "Make iBoot Patch"
        Me.MakeIBootPatchToolStripMenuItem.Visible = False
        '
        'iNephron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(729, 429)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Step3)
        Me.Controls.Add(Me.step5)
        Me.Controls.Add(Me.buttonNext)
        Me.Controls.Add(Me.step1)
        Me.Controls.Add(Me.step2)
        Me.Controls.Add(Me.nephron)
        Me.Controls.Add(Me.step4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "iNephron"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nephron"
        Me.step1.ResumeLayout(False)
        Me.step1.PerformLayout()
        Me.step2.ResumeLayout(False)
        Me.Step3.ResumeLayout(False)
        Me.Step3.PerformLayout()
        CType(Me.Check_Prepare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check_Boot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step4.ResumeLayout(False)
        CType(Me.successBoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step5.ResumeLayout(False)
        CType(Me.successPrepare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nephron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nephron As System.Windows.Forms.PictureBox
    Friend WithEvents step1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFirmware1 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedFirwmare1 As System.Windows.Forms.Label
    Friend WithEvents ButtonBrowseF2 As System.Windows.Forms.Button
    Friend WithEvents ButtonBrowseF1 As System.Windows.Forms.Button
    Friend WithEvents lblFirmware2 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedFirmware2 As System.Windows.Forms.Label
    Friend WithEvents lblInstruction1 As System.Windows.Forms.Label
    Friend WithEvents buttonNext As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblSelectedDeviceName As System.Windows.Forms.Label
    Friend WithEvents lblDeviceName As System.Windows.Forms.Label
    Friend WithEvents step2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Button_Step2 As System.Windows.Forms.Button
    Friend WithEvents Step3 As System.Windows.Forms.GroupBox
    Friend WithEvents step4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStep3 As System.Windows.Forms.Label
    Friend WithEvents lblBootStatus As System.Windows.Forms.Label
    Friend WithEvents pBoot As System.Windows.Forms.ProgressBar
    Friend WithEvents Boot As System.Windows.Forms.Button
    Friend WithEvents successBoot As System.Windows.Forms.PictureBox
    Friend WithEvents step5 As System.Windows.Forms.GroupBox
    Friend WithEvents successPrepare As System.Windows.Forms.PictureBox
    Friend WithEvents Prepare As System.Windows.Forms.Button
    Friend WithEvents lblPrepareStatus As System.Windows.Forms.Label
    Friend WithEvents pPrepare As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Check_Boot As System.Windows.Forms.PictureBox
    Friend WithEvents Check_Prepare As System.Windows.Forms.PictureBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MakeIBootPatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
