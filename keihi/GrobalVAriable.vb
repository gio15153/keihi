Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome.ChromeDriverService

Class GrobalVariable
    Public service As Chrome.ChromeDriverService = CreateDefaultService()
    Public webDrive As Chrome.ChromeDriver

    Sub New()
        '起動時のドライバを非表示にするフラグ
        service.HideCommandPromptWindow = True

        webDrive = New Chrome.ChromeDriver(service)
    End Sub

End Class
