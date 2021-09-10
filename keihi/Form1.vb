Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome.ChromeDriverService
Public Class Form1

    Public service As Chrome.ChromeDriverService = CreateDefaultService()

    Dim start As GrobalVariable = New GrobalVariable()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim loadDrive As Chrome.ChromeDriver = New Chrome.ChromeDriver
        start.webDrive.Url = "https://login.salesforce.com/?locale=jp"


    End Sub


    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        start.webDrive.Navigate.GoToUrl("https://teamspirit-674--teamspirit.ap5.visual.force.com/apex/AtkEmpExpView?sfdc.tabName=01r7F0000002DXs")

        'Form入力値に対するcheck
        If FormCheck() = False Then
            Exit Sub
        End If
        Threading.Thread.Sleep(5000)
        Dim startDate As Date = MonthCalendar1.SelectionRange.Start
        Dim _date As Date = startDate
        Dim EndDate As Date = MonthCalendar1.SelectionRange.End
        Dim Dates = New List(Of String)





        'Web画面に入力値を設定
        '土日は入力しない
        For i = startDate.DayOfYear To EndDate.DayOfYear
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
            'memo--複数のクラスを取得した場合配列で扱うと楽
            start.webDrive.FindElementsByClassName("png-add")(1).Click()
            Threading.Thread.Sleep(500)

            '日付を入力する
            For Each day In Dates
                '画面に項目を入力する処理
                InputProcess(day, startDate.ToShortDateString)
                '次の入力フォームへ
                start.webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[3]/div[1]/button")).Click()

                Threading.Thread.Sleep(100)

            Next
            MessageBox.Show("処理が正常に終了しました。ブラウザ上で保存を行ってください")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            start.webDrive.Close()
            start.webDrive.Quit()
            Close()


        End Try


    End Sub

    Public Function FormCheck()

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

        '日付
        start.webDrive.FindElement(By.Id("DlgDetailDate")).Clear()
        start.webDrive.FindElement(By.Id("DlgDetailDate")).SendKeys(day)

        '初回限定処理
        If day.Equals(startDay) Then
            '費目
            start.webDrive.FindElement(By.Id("DlgDetailExpItem")).Click()
            If expenseTxt.SelectedIndex = 0 Then
                start.webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown + Keys.Enter)

            ElseIf expenseTxt.SelectedIndex = 1 Then
                start.webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown * 3 + Keys.Enter)　'キー指定は改善の余地あり

            End If

            '往復フラグ
            Try
                If RadioButton1.Checked = True Then
                    'memo--XpathはfullXPathで指定

                    'start.webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/div[3]/div[2]/div/input[1]")).Clear()

                ElseIf RadioButton2.Checked = True Then
                    start.webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/div[3]/div[2]/div/input[1]")).Click()
                End If

            Catch ex As Exception
            End Try
        End If

        start.webDrive.FindElement(By.Id("DlgDetailCost")).Clear()
        start.webDrive.FindElement(By.Id("DlgDetailCost")).SendKeys("\" + priceTxt.Text)
        start.webDrive.FindElement(By.Id("DlgExpDetailStFrom")).SendKeys(departureStation.Text)
        start.webDrive.FindElement(By.Id("DlgExpDetailStTo")).SendKeys(arrivalStation.Text)
        start.webDrive.FindElement(By.Id("DlgDetailDetail")).SendKeys(remarks.Text)

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        start.webDrive.Close()
        start.webDrive.Quit()

    End Sub
End Class
