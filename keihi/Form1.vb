Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome.ChromeDriverService
Public Class Form1



    Dim start As StartUpObject = New StartUpObject()


    'Load時にログイン画面を呼び出す
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        start.webDrive.Url = "https://login.salesforce.com/?locale=jp"

    End Sub

    ''' <summary>
    ''' 主処理を開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        Dim startDate As Date = InputDates.Items(0)
        Dim _date As Date = startDate
        Dim EndDate As Date = InputDates.Items(InputDates.Items.Count - 1)


        '経費入力ページに移動
        start.webDrive.Navigate.GoToUrl("https://teamspirit-674--teamspirit.ap5.visual.force.com/apex/AtkEmpExpView?sfdc.tabName=01r7F0000002DXs")

        '二回目以降のポップアップを承認（エラー回避）
        Me.AcceptPopup()

        'Form入力値に対するcheck
        If FormCheck() = False Then
            Exit Sub
        End If
        Threading.Thread.Sleep(3000)



        '+ボタンをクリック ⇒次の入力フォームを呼び出す
        'memo--ChromeDriver.FindElement()Clickでクリックアクションを起こせる
        'memo--複数のクラスを取得した場合配列で扱うと楽
        start.webDrive.FindElements(By.ClassName("png-add"))(1).Click()
        Threading.Thread.Sleep(500)


        '日数分フォームへの入力処理の繰り返し
        Try
            For Each day In InputDates.Items

                InputProcess(day, startDate.ToShortDateString)
                '次の入力フォームへ
                start.webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[3]/div[1]/button")).Click()
                'バッファ
                Threading.Thread.Sleep(100)
            Next
            MessageBox.Show("処理が正常に終了しました。ブラウザ上で保存を行ってください")

        Catch ex As Exception
            MessageBox.Show("エラーが発生したため処理を中断しました。")

        End Try



    End Sub
    ''' <summary>
    ''' 入力項目のチェック
    ''' </summary>
    ''' <returns></returns>
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


        'Web画面に各入力値を設定
        '日付
        start.webDrive.FindElement(By.Id("DlgDetailDate")).Clear()
        start.webDrive.FindElement(By.Id("DlgDetailDate")).SendKeys(day)

        '初回限定処理
        If day.Equals(startDay) Then
            '費目
            '通勤費
            start.webDrive.FindElement(By.Id("DlgDetailExpItem")).Click()
            If expenseTxt.SelectedIndex = 0 Then
                start.webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown + Keys.Enter)
                '交通費    
            ElseIf expenseTxt.SelectedIndex = 1 Then
                start.webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter) 'キー指定は改善の余地あり

            ElseIf expenseTxt.SelectedIndex = 2 Then
                start.webDrive.FindElement(By.Id("DlgDetailExpItem")).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter) 'キー指定は改善の余地あり



            End If

            '往復フラグ

            If RadioButton1.Checked = True Then
                    'memo--XpathはfullXPathで指定
                    'start.webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/div[3]/div[2]/div/input[1]")).Clear()

                ElseIf RadioButton2.Checked = True Then
                    start.webDrive.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/div[3]/div[2]/div/input[1]")).Click()
                End If


        End If

        start.webDrive.FindElement(By.Id("DlgDetailCost")).Clear()
        start.webDrive.FindElement(By.Id("DlgDetailCost")).SendKeys("\" + priceTxt.Text)
        start.webDrive.FindElement(By.Id("DlgExpDetailStFrom")).SendKeys(departureStation.Text)
        start.webDrive.FindElement(By.Id("DlgExpDetailStTo")).SendKeys(arrivalStation.Text)
        start.webDrive.FindElement(By.Id("DlgDetailDetail")).SendKeys(remarks.Text)

    End Sub

    ''' <summary>
    ''' chromeDriverとブラウザを閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        start.webDrive.Close()
        start.webDrive.Quit()

    End Sub

    ''' <summary>
    ''' 二回目以降入力を行った際に表示されるページ再読み込みのポップアップをクリック
    ''' </summary>
    Public Sub AcceptPopup()

        On Error Resume Next
        start.webDrive.SwitchTo.Alert.Accept()

    End Sub


    ''' <summary>
    ''' 画面に入力する日付のリストに選択した日付を挿入する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startDate As Date = MonthCalendar1.SelectionRange.Start
        Dim _date As Date = startDate
        Dim EndDate As Date = MonthCalendar1.SelectionRange.End
        Dim Dates = New List(Of String)

        '日付の範囲を変数Datesに格納
        '土日は入力しない
        Dates.Clear()
        For i = startDate.DayOfYear To EndDate.DayOfYear
            If _date.DayOfWeek = DayOfWeek.Saturday Or
                    _date.DayOfWeek = DayOfWeek.Sunday Then

                _date = _date.AddDays(1.0)
                Continue For

            End If

            Dates.Add(_date.ToShortDateString)
            _date = _date.AddDays(1.0)

        Next

        For Each day In Dates
            InputDates.Items.Add(day)
        Next

    End Sub

    ''' <summary>
    ''' 選択した日付を画面に入力する日付のリストから削除する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If InputDates.SelectedIndex <> -1 Then
            While InputDates.SelectedIndex <> -1
                InputDates.Items.RemoveAt(InputDates.SelectedIndex)
            End While
        Else
            MessageBox.Show("削除する日付を選択してください")
        End If

    End Sub
End Class
