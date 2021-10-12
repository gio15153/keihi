Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome.ChromeDriverService

Class StartUpObject
    Public service As Chrome.ChromeDriverService = CreateDefaultService()
    Public webDrive As Chrome.ChromeDriver

    '起動時のドライバを非表示にするフラグをオンに
    'これをしていないと謎のコマンド画面が表示されて邪魔なことになる
    'クラスを分けているのはForm1内だとグローバルな変数の宣言部で同じ処理ができないため
    Sub New()

        service.HideCommandPromptWindow = True
        webDrive = New Chrome.ChromeDriver(service)
    End Sub

End Class
