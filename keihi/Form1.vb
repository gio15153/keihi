Imports OpenQA.Selenium.DriverOptions
Imports OpenQA.Selenium
Imports Selenium.WebElement
Imports System.Collections
Imports Selenium.SelectElement
Imports OpenQA.Selenium.Chrome.ChromeDriverService
Public Class Form1

    Dim service As Chrome.ChromeDriverService = CreateDefaultService()
    Dim webDrive As Chrome.ChromeDriver = New Chrome.ChromeDriver(service)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        webDrive.Url = "https://login.salesforce.com/?locale=jp"


    End Sub


    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        webDrive.Navigate.GoToUrl("https://teamspirit-674--teamspirit.ap5.visual.force.com/apex/AtkEmpExpView?sfdc.tabName=01r7F0000002DXs")

        Threading.Thread.Sleep(3000)
        Dim startDate As Date = MonthCalendar1.SelectionRange.Start
        Dim _date As Date = startDate
        Dim EndDate As Date = MonthCalendar1.SelectionRange.End
        Dim Dates = New List(Of String)



        Dim CurrentHTML As String = webDrive.PageSource()

        'Form入力値に対するcheck
        If FormCheck(webDrive) = False Then
            MessageBox.Show("処理を異常終了します")
            Exit Sub
        End If


        'Web画面に入力値を設定
        '土日は入力しない
        For i = startDate.Day To EndDate.Day
            If _date.DayOfWeek = DayOfWeek.Saturday Or
                    _date.DayOfWeek = DayOfWeek.Sunday Then

                _date = _date.AddDays(1.0)
                Continue For

            End If

            Dates.Add(_date.ToShortDateString)
            _date = _date.AddDays(1.0)

        Next

        Try
            '+ボタンをクリック 
            'memo--ChromeDriver.Clickでクリックアクションを起こせる
            webDrive.FindElementsByClassName("png-add")(1).Click()
            Threading.Thread.Sleep(500)

            '日付を入力したい
            For Each day In Dates
                InputProcess(day, startDate.ToShortDateString)
                webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[3]/div[1]/button")).Click()

                Threading.Thread.Sleep(100)

            Next
            MessageBox.Show("処理が正常に終了しました")
        Catch ex As Exception
            webDrive.Close()
            webDrive.Quit()
            Close()


        End Try


    End Sub

    Public Function FormCheck(ByRef webDrive As Chrome.ChromeDriver)

        Dim formFlg As Boolean = True


        Select Case formFlg
            Case String.IsNullOrEmpty(expenseTxt.Text)
                MessageBox.Show("費目が入力されていません")
                formFlg = False
            Case String.IsNullOrEmpty(departureStation.Text)
                MessageBox.Show("出発駅が入力されていません")
                formFlg = False
            Case String.IsNullOrEmpty(arrivalStation.Text)
                MessageBox.Show("到着駅が入力されていません")
                formFlg = False
            Case String.IsNullOrEmpty(priceTxt.Text)
                MessageBox.Show("金額が入力されていません")
                formFlg = False
            Case Else
        End Select

        Return formFlg
    End Function

    ''' <summary>
    ''' 経費明細に各項目を入力する
    ''' </summary>
    ''' <param name="day"></param>
    Public Sub InputProcess(day As String, startDay As String)


        webDrive.FindElement(By.Id("DlgDetailDate")).Clear()
        webDrive.FindElement(By.Id("DlgDetailDate")).SendKeys(day)


        If day = startDay Then

            webDrive.FindElement(By.Id("DlgDetailExpItem")).Click()
            If expenseTxt.SelectedIndex = 0 Then
                webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown + Keys.Enter)

            ElseIf expenseTxt.SelectedIndex = 1 Then
                webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown * 3 + Keys.Enter)

            End If
            If RadioButton1.Checked = True And day = startDay Then
                'memo--XpathはfullXPathで指定
                webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/div[3]/div[2]/div/input[1]")).Click()

            ElseIf RadioButton2.Checked = True And day = startDay Then
                webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/div[3]/div[2]/div/input[1]")).Click()

            End If
        End If

        webDrive.FindElement(By.Id("DlgDetailCost")).Clear()
        webDrive.FindElement(By.Id("DlgDetailCost")).SendKeys("\" + priceTxt.Text)
        webDrive.FindElement(By.Id("DlgExpDetailStFrom")).SendKeys(departureStation.Text)
        webDrive.FindElement(By.Id("DlgExpDetailStTo")).SendKeys(arrivalStation.Text)
        webDrive.FindElement(By.Id("DlgDetailDetail")).SendKeys(remarks.Text)

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        webDrive.Close()
        webDrive.Quit()

    End Sub
End Class
