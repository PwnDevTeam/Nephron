Imports System.IO

Public Class iNephron

    Dim dlgFirmware1 As New OpenFileDialog, _
           dlgFirmware2 As New OpenFileDialog

    Dim Firmware1Selected As Boolean = False, _
           Firmware2Selected As Boolean = False

    Dim hardware As String, processor As String, hardware_x As String
    Dim KEY As String, IV As String, iBootFold As String


    ' This is for disable the X button.
    Private Declare Function GetSystemMenu Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bRevert As Int32) As IntPtr
    Private Declare Function GetMenuItemCount Lib "user32.dll" (ByVal hMenu As IntPtr) As Int32
    Private Declare Function DrawMenuBar Lib "user32.dll" (ByVal hWnd As IntPtr) As Int32
    Private Declare Function RemoveMenu Lib "user32.dll" (ByVal hMenu As IntPtr, ByVal nPosition As Int32, ByVal wFlags As Int32) As Int32

    Private Const MF_BYPOSITION As Int32 = &H400
    Private Const MF_REMOVE As Int32 = &H1000


    Private Sub RemoveCloseButton(ByVal frmForm As Form)
        Dim hMenu As IntPtr, n As Int32
        hMenu = GetSystemMenu(frmForm.Handle, 0)
        If Not hMenu.Equals(IntPtr.Zero) Then
            n = GetMenuItemCount(hMenu)
            If n > 0 Then
                RemoveMenu(hMenu, n - 1, MF_BYPOSITION Or MF_REMOVE)
                RemoveMenu(hMenu, n - 2, MF_BYPOSITION Or MF_REMOVE)
                DrawMenuBar(frmForm.Handle)
            End If
        End If
    End Sub

    Public Function SaveTextToFile(ByVal strData As String, ByVal FullPath As String, Optional ByVal ErrInfo As String = "") As Boolean
        Dim bAns As Boolean = False, objReader As StreamWriter : Try : objReader = New StreamWriter(FullPath) : objReader.Write(strData) : objReader.Close() : bAns = True : Catch Ex As Exception : ErrInfo = Ex.Message : End Try : Return bAns
    End Function
    Public Function GetFileContents(ByVal FullPath As String, Optional ByRef ErrInfo As String = "") As String
        Dim strContents As String = "" : Dim objReader As StreamReader : Try : objReader = New StreamReader(FullPath) : strContents = objReader.ReadToEnd() : objReader.Close() : Catch Ex As Exception : ErrInfo = Ex.Message : End Try : Return strContents
    End Function

    Public Sub WriteLog(ByVal Text As String)
        old = GetFileContents(Application.ProductName & ".txt")
        SaveTextToFile((old & Application.ProductName & " @ " & TimeOfDay & " -> " & LCase(Text)) & vbCrLf, Application.ProductName & ".txt")
    End Sub

    Sub addVal(ByVal ProgBar As ProgressBar, ByVal iValue As Integer)
        '       For i = 0 To iValue
        ProgBar.Value += iValue
        '    Next
    End Sub

    Sub DoCMD(ByVal file As String, ByVal arg As String)
        Dim procNlite As New Process
        winstyle = 1
        procNlite.StartInfo.FileName = file
        procNlite.StartInfo.Arguments = " " & arg
        procNlite.StartInfo.WindowStyle = winstyle
        Application.DoEvents()
        procNlite.Start()
        Do Until procNlite.HasExited
            Application.DoEvents()
            For i = 0 To 5000000
                Application.DoEvents()
            Next
        Loop
        procNlite.WaitForExit()
    End Sub

    ' Shortcut subroutines.
    Sub bspatch(ByVal OldFile, ByVal NewFile, ByVal PatchFile)
        DoCMD("bspatch.exe", Chr(34) & OldFile & Chr(34) & " " & Chr(34) & NewFile & Chr(34) & " " & Chr(34) & PatchFile & Chr(34))
    End Sub
    Sub XpwnToolDecrypt(ByVal InputFile, ByVal OutputFile, ByVal iKey, ByVal iIV)
        DoCMD("xpwntool.exe", " " & Chr(34) & InputFile & Chr(34) & " " & Chr(34) & OutputFile & Chr(34) & " -k " & iKey & " -iv " & iIV)
    End Sub
    Sub XpwnToolEncrypt(ByVal InputFile, ByVal OutputFile, ByVal iTemplate, ByVal iKey, ByVal iIV)
        DoCMD("xpwntool.exe", " " & Chr(34) & InputFile & Chr(34) & " " & Chr(34) & OutputFile & Chr(34) & " " & Chr(34) & " -t " & iTemplate & Chr(34) & " -k " & iKey & " -iv " & iIV)
    End Sub

    Private Sub iNephron_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Width = 735 : Me.Height = 467
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemoveCloseButton(Me) ' since its bugged when you hit the close button, i disabled it.

        ' If you're editing, uncomment these lines (once started it will move all groupboxes to the location of GroupBox 1)
        Me.Width = 735 : Me.Height = 467 ' annother fix, i let it be as it is because it doesn't really matter anyways.
        '  step2.Width = step1.Width : step2.Height = step1.Height : step2.Left = step1.Left : step2.Top = step1.Top
        '  Step3.Width = step1.Width : Step3.Height = step1.Height : Step3.Left = step1.Left : Step3.Top = step1.Top
        '  step4.Width = step1.Width : step4.Height = step1.Height : step4.Left = step1.Left : step4.Top = step1.Top
        '  step5.Width = step1.Width : step5.Height = step1.Height : step5.Left = step1.Left : step5.Top = step1.Top

        If File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\custom\iboot.payload") Then
            If File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\custom\kernel.40") Then
                If File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\custom\ibec.40") Then
                    If File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\custom\devtree.40") Then
                        step1.Visible = False
                        step2.Visible = False
                        Step3.Visible = True
                        lblStep3.Text = "Welcome to Nephron!" & vbCrLf & vbCrLf & _
                                                "Nephron has discovered that you have files for device " & GetFileContents(Application.StartupPath & "\custom\device.txt") & "." & vbCrLf & _
                                                "These options below requires your Device to be in Recovery Mode!" & vbCrLf & _
                                                "So hit the Nephron logo at the iPhone to right to enter Recovery mode!"
                        Exit Sub
                    End If
                End If
            End If
        End If

        step1.Visible = True

    End Sub

    Private Sub ButtonBrowseF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowseF1.Click
        With dlgFirmware1
            .Title = "Select your sn0wbreezed 4.0 firmware"
            .FileName = ""
            .Filter = "Apple Software Update Files|*.ipsw"
            .ShowDialog()
        End With
        If dlgFirmware1.FileName = "" Then
            Firmware1Selected = False
        Else
            Firmware1Selected = True
            lblSelectedFirwmare1.Text = System.IO.Path.GetFileName(dlgFirmware1.FileName)
        End If
    End Sub
    Private Sub ButtonBrowseF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowseF2.Click
        With dlgFirmware2
            .Title = "Select your sn0wbreezed 3.1.2 firmware"
            .FileName = ""
            .Filter = "Apple Software Update Files|*.ipsw"
            .ShowDialog()
        End With
        If dlgFirmware2.FileName = "" Then
            Firmware2Selected = False
        Else
            Firmware2Selected = True
            lblSelectedFirmware2.Text = System.IO.Path.GetFileName(dlgFirmware2.FileName)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Firmware1Selected = True And Firmware2Selected = True Then
            If buttonNext.Enabled = False Then
                buttonNext.Image = (My.Resources.Button_Next_Focus_False)
            End If
            buttonNext.Enabled = True
        End If
        If InStr(dlgFirmware1.FileName, "iPhone") And InStr(dlgFirmware1.FileName, "2") Or InStr(dlgFirmware1.FileName, "3GS") Then lblSelectedDeviceName.Text = "iPhone 3G [S]"
        If InStr(dlgFirmware1.FileName, "iPod") And InStr(dlgFirmware1.FileName, "2") Or InStr(dlgFirmware1.FileName, "2G") Then lblSelectedDeviceName.Text = "iPod Touch 2G"
        If InStr(dlgFirmware1.FileName, "iPod") And InStr(dlgFirmware1.FileName, "3") Or InStr(dlgFirmware1.FileName, "3G") Then lblSelectedDeviceName.Text = "iPod Touch 3G"
    End Sub


    Private Sub buttonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonNext.Click

        buttonNext.Enabled = False : buttonNext.Image = (My.Resources.Button_Next_Enabled_False)

        If step1.Visible = True Then
            step1.Visible = False : step2.Visible = True
            SaveTextToFile(lblSelectedDeviceName.Text, Application.StartupPath & "\custom\device.txt")
            Timer1.Stop()
            Button_Step2_Click(sender, e)

        ElseIf step2.Visible = True Then
            step2.Visible = False : Step3.Visible = True
            lblStep3.Text = "Welcome to Nephron!" & vbCrLf & vbCrLf & _
                                          "Nephron has discovered that you have files for device " & GetFileContents(Application.StartupPath & "\custom\device.txt") & "." & vbCrLf & vbCrLf & "These options below requires to be in Recovery"

        End If

        If Check_Boot.Visible = True Then
            Step3.Visible = False : step4.Visible = True
            buttonNext.Enabled = False : Boot_Click(sender, e)

        ElseIf Check_Prepare.Visible = True Then
            Step3.Visible = False : step5.Visible = True
            buttonNext.Enabled = False : Prepare_Click(sender, e)

        End If

    End Sub

    Private Sub buttonNext_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles buttonNext.MouseDown
        If buttonNext.Enabled = True Then buttonNext.Image = (My.Resources.Button_Next_Clicked)
    End Sub
    Private Sub buttonNext_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles buttonNext.MouseUp
        If buttonNext.Enabled = True Then buttonNext_MouseEnter(sender, e)
    End Sub
    Private Sub buttonNext_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonNext.MouseEnter
        If buttonNext.Enabled = True Then buttonNext.Image = (My.Resources.Button_Next_Focus_True)
    End Sub
    Private Sub buttonNext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonNext.MouseLeave
        If buttonNext.Enabled = True Then buttonNext.Image = (My.Resources.Button_Next_Focus_False)
    End Sub





    Private Sub Button_Step2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Step2.Click
        Firmware1Selected = False And Firmware2Selected = False
        buttonNext.Image = (My.Resources.Button_Next_Enabled_False)

        lblStatus.Text = ("Gathering resources for " & lblDeviceName.Text & ".")

        If lblSelectedDeviceName.Text = "iPod Touch 2G" Then
            hardware_x = "n72"
            hardware = "n72ap"
            processor = "s5l8720x"
            KEY = "191b6846543d7026b6f0d5247f030588" ' 3.1.2
            IV = "5e421f8ce8c811311bbbb8a734ec07ce"    ' 3.1.2
            iBootFold = "iPod2,1"
        End If

        If lblSelectedDeviceName.Text = "iPod Touch 3G" Then
            hardware_x = "n18"
            hardware = "n18ap"
            processor = "S5L8922x"
            KEY = "eabfe2fc4bad7f97c090ed021e7fd80a7463251c4919a3c637d2a0c529b79d5a" ' 3.1.2
            IV = "6e7dc46c6a9cf573dda9af515c1b50ac"    ' 3.1.2
            iBootFold = "iPod3,1"
        End If

        If lblSelectedDeviceName.Text = "iPhone 3G [S]" Then
            hardware_x = "n88"
            hardware = "n88ap"
            processor = "S5L8920x"
            KEY = "c72ab4aae971f3a9ec356dfe555e4aef72d8e96c480698445ac236904e6a3443" ' 3.1.2
            IV = "127aa60e77da219961ee70707f44cbd4"    ' 3.1.2
            iBootFold = "iPhone2,1"
        End If

        For i = 0 To 500000
            Application.DoEvents()
        Next

        addVal(pBar, 10)

        lblStatus.Text = ("Setting up Nephron's Environment..")

        decrypted_iBoot = Application.StartupPath & "\iBoot." & hardware & ".DECRYPTED.img3"
        patched_iBoot = Application.StartupPath & "\iBoot." & hardware & ".PATCHED.img3"
        pwned_iBoot = Application.StartupPath & "\custom\iboot.payload"

        extracted_iBoot = Application.StartupPath & "\custom\iBoot." & hardware & ".RELEASE.img3"
        extracted_DeviceTree = Application.StartupPath & "\custom\devtree.40"
        extracted_iBEC = Application.StartupPath & "\custom\ibec.40"
        extracted_Kernel = Application.StartupPath & "\custom\kernel.40"

        ipsw_DeviceTree = "Firmware\all_flash\all_flash." & hardware & ".production\DeviceTree." & hardware & ".img3"
        ipsw_iBEC = "Firmware\dfu\iBEC." & hardware & ".RELEASE.dfu"
        ipsw_Kernel = "kernelcache.release." & hardware_x


        For i = 0 To 500000
            Application.DoEvents()
        Next
        addVal(pBar, 10)

        lblStatus.Text = ("Extracting iBoot from firwmare...")
        DoCMD("unzip.exe", "-o " & Chr(34) & dlgFirmware2.FileName & Chr(34) & " " & Chr(34) & "Firmware\all_flash\all_flash." & hardware & ".production\iBoot." & hardware & ".RELEASE.img3" & Chr(34))
        System.IO.File.Move(Application.StartupPath & "\Firmware\all_flash\all_flash." & hardware & ".production\iBoot." & hardware & ".RELEASE.img3", extracted_iBoot)
        addVal(pBar, 10)



        lblStatus.Text = ("Decrypting iBoot")
        XpwnToolDecrypt(extracted_iBoot, decrypted_iBoot, KEY, IV)
        addVal(pBar, 10)

        lblStatus.Text = ("Pwning the iBoot..")
        bspatch(decrypted_iBoot, patched_iBoot, Application.StartupPath & "\" & iBootFold & "\iboot.patch")

        addVal(pBar, 10)

        lblStatus.Text = ("Encrypting iBoot")
        XpwnToolEncrypt(patched_iBoot, pwned_iBoot, extracted_iBoot, KEY, IV)

        addVal(pBar, 10)

        lblStatus.Text = ("Extracting Device Tree from firwmare...")
        DoCMD("unzip.exe", " -o " & Chr(34) & dlgFirmware1.FileName & Chr(34) & " " & Chr(34) & ipsw_DeviceTree & Chr(34))
        System.IO.File.Move(Application.StartupPath & "\Firmware\all_flash\all_flash." & hardware & ".production\DeviceTree." & hardware & ".img3", extracted_DeviceTree)

        addVal(pBar, 10)

        lblStatus.Text = ("Extracting iBEC from firwmare...")
        DoCMD("unzip.exe", " -o " & Chr(34) & dlgFirmware1.FileName & Chr(34) & " " & Chr(34) & ipsw_iBEC & Chr(34))
        System.IO.File.Move(Application.StartupPath & "\Firmware\dfu\iBEC." & hardware & ".RELEASE.dfu", extracted_iBEC)

        addVal(pBar, 10)

        lblStatus.Text = ("Extracting Kernel from firwmare...")
        DoCMD("unzip.exe", " -o " & Chr(34) & dlgFirmware1.FileName & Chr(34) & " " & Chr(34) & ipsw_Kernel & Chr(34))
        System.IO.File.Move(Application.StartupPath & "\kernelcache.release." & hardware_x, extracted_Kernel)

        addVal(pBar, 10)

        lblStatus.Text = ("Cleaning up the mess..")
        System.IO.File.Delete(extracted_iBoot)
        System.IO.File.Delete(decrypted_iBoot)
        System.IO.File.Delete(patched_iBoot)
        System.IO.Directory.Delete("Firmware", True)

        addVal(pBar, 10)

        lblStatus.Text = ("Nephron's done. Press the arrow to continue")

        buttonNext.Enabled = True
        buttonNext.Image = (My.Resources.Button_Next_Focus_False)
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Check_Boot.Visible = True : Check_Prepare.Visible = False
        buttonNext.Enabled = True : buttonNext.Image = (My.Resources.Button_Next_Focus_False)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Check_Boot.Visible = False : Check_Prepare.Visible = True
        buttonNext.Enabled = True : buttonNext.Image = (My.Resources.Button_Next_Focus_False)
    End Sub

    Private Sub Boot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boot.Click

        lblBootStatus.Text = ("Sending iboot payload..")
        DoCMD("irecovery.exe", "-k " & Chr(34) & Application.StartupPath & "\custom\iboot.payload" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Sending iBEC..")
        DoCMD("irecovery.exe", "-f " & Chr(34) & Application.StartupPath & "\custom\ibec.40" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Setting up iBEC..")
        DoCMD("irecovery.exe", "-c " & Chr(34) & "go" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Waiting for iBEC to Setup..")
        For x = 1 To 10000000
            Application.DoEvents()
        Next
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Sending Device Tree..")
        DoCMD("irecovery.exe", "-f " & Chr(34) & Application.StartupPath & "\custom\devtree.40" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Setting up the Device Tree...")
        DoCMD("irecovery.exe", " -c " & Chr(34) & "devicetree" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Sending Logo..")
        DoCMD("irecovery.exe", "-f " & Chr(34) & Application.StartupPath & "\custom\wait.img3" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Setting up the Logo..")
        DoCMD("irecovery.exe", "-c " & Chr(34) & "setpicture 1" & Chr(34))
        DoCMD("irecovery.exe", "-c " & Chr(34) & "bgcolor 1 1 1" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Sending Kernel...")
        DoCMD("irecovery.exe", "-f " & Chr(34) & Application.StartupPath & "\custom\kernel.40" & Chr(34))
        addVal(pBoot, 10)

        lblBootStatus.Text = ("Sending bootx command..")
        DoCMD("irecovery.exe", "-c " & Chr(34) & "bootx" & Chr(34))
        successBoot.Visible = True
        addVal(pBoot, 10)

    End Sub


    Private Sub Prepare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prepare.Click

        lblPrepareStatus.Text = ("Sending iBoot payload..")
        DoCMD("irecovery.exe", " -k " & Chr(34) & Application.StartupPath & "\custom\iboot.payload" & Chr(34))
        addVal(pPrepare, 10)

        lblPrepareStatus.Text = ("Sending Logo..")
        DoCMD("irecovery.exe", " -f " & Chr(34) & Application.StartupPath & "\custom\wait.img3" & Chr(34))
        addVal(pPrepare, 10)

        lblPrepareStatus.Text = ("Setting up the Logo..")
        DoCMD("irecovery.exe", " -c " & Chr(34) & "setpicture 1" & Chr(34))
        DoCMD("irecovery.exe", " -c " & Chr(34) & "bgcolor 1 1 1" & Chr(34))
        addVal(pPrepare, 10)
        '  MsgBox("If you see the Logo at your screen then you're good to go!" & vbCrLf & vbCrLf & "- Fallensn0w")
        successPrepare.Visible = True

    End Sub

    Private Sub LicenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Nephron -- By: Fallensn0w" & vbCrLf & vbCrLf & _
                                    "I made this program becuase when i was at @github i found a simlar program (or actuall the same) called ''Pneumonia'' and then i found out it was only for Mac so i spend a couple of hours to port it to Windows Platform. And well, here it is. " & _
                                    vbCrLf & vbCrLf & _
                                    "Graphics i used:" & vbCrLf & _
                                    "   -    Next Button from QuickPWN (Modified a bit)" & vbCrLf & _
                                    "   -    Green Checks (from sn0wbreeze)" & vbCrLf & _
                                    "   -    Blank iPhone but with Nephron Logo (from Pneumonia)" & _
                                    vbCrLf & vbCrLf & _
                                    "Yes i know there's Payload Pwner & iBooty but these programs aren't open-source which Nephron is! :)", _
        Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Label6.Text = "Entering Recovery.."
        DoCMD("iphucwin32.exe", "-qo enterrecovery")
        Label6.Text = ""
    End Sub

    Private Sub MakeIBootPatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeIBootPatchToolStripMenuItem.Click
        Dim iPT2G_Bin() As String = Split("66 83 68 73 70 70 52 48 88 0 0 0 0 0 0 0 57 0 0 0 0 0 0 0 0 32 0 0 0 0 0 0 66 90 104 57 49 65 89 38 83 89 141 52 68 15 0 0 33 119 225 248 24 0 33 0 1 1 1 64 4 0 4 0 8 64 0 0 4 80 0 0 0 160 0 49 76 38 154 3 76 66 189 77 26 52 3 79 80 137 82 214 46 181 96 0 120 195 114 64 47 199 212 15 15 166 204 87 203 241 119 36 83 133 9 8 211 68 64 240 66 90 104 57 49 65 89 38 83 89 29 215 215 179 0 0 0 72 96 192 0 133 0 0 64 64 0 32 8 32 0 49 12 8 27 213 70 135 169 148 46 18 69 212 245 184 31 23 114 69 56 80 144 29 215 215 179 66 90 104 57 49 65 89 38 83 89 86 231 202 95 0 0 14 127 255 213 0 204 16 192 2 4 64 68 68 1 68 4 4 68 68 100 64 64 66 192 0 64 3 64 64 0 1 10 96 96 0 32 0 104 68 128 1 166 154 0 52 109 67 64 208 4 166 164 8 26 12 128 50 0 208 27 106 157 44 0 29 141 179 156 107 178 219 208 145 147 178 252 69 45 146 1 128 3 20 100 38 206 82 143 47 175 85 113 224 165 234 42 219 177 8 77 205 51 105 82 35 176 19 193 158 87 152 9 134 23 175 24 167 149 17 34 13 120 143 208 32 146 18 140 29 239 137 209 3 255 23 114 69 56 80 144 86 231 202 95", " ")

        '      Dim bytes() As Byte = StrToByteArray(iPT2G_Bin)
        writeBin("iboot.patch", bytes)
    End Sub



    Sub writeBin(ByVal tehFile As String, ByVal byteData() As Byte)
        ' Create a file and write the byte data to a file.
        Dim oFileStream As System.IO.FileStream
        oFileStream = New System.IO.FileStream(tehFile, System.IO.FileMode.Create)
        oFileStream.Write(byteData, 0, byteData.Length)
        oFileStream.Close()
    End Sub

End Class

