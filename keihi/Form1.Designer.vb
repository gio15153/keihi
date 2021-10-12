<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.himokuLbl = New System.Windows.Forms.Label()
        Me.keiroFromLbl = New System.Windows.Forms.Label()
        Me.ohukuLbl = New System.Windows.Forms.Label()
        Me.keiroToLbl = New System.Windows.Forms.Label()
        Me.kingakuLbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.priceTxt = New System.Windows.Forms.TextBox()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.remarks = New System.Windows.Forms.TextBox()
        Me.departureStation = New System.Windows.Forms.TextBox()
        Me.arrivalStation = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.expenseTxt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(64, 77)
        Me.MonthCalendar1.MaxSelectionCount = 31
        Me.MonthCalendar1.MonthlyBoldedDates = New Date() {New Date(CType(0, Long)), New Date(CType(0, Long)), New Date(CType(0, Long)), New Date(CType(0, Long)), New Date(CType(0, Long)), New Date(CType(0, Long))}
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "日時入力"
        '
        'himokuLbl
        '
        Me.himokuLbl.AutoSize = True
        Me.himokuLbl.Location = New System.Drawing.Point(381, 72)
        Me.himokuLbl.Name = "himokuLbl"
        Me.himokuLbl.Size = New System.Drawing.Size(29, 12)
        Me.himokuLbl.TabIndex = 10
        Me.himokuLbl.Text = "費目"
        '
        'keiroFromLbl
        '
        Me.keiroFromLbl.AutoSize = True
        Me.keiroFromLbl.Location = New System.Drawing.Point(381, 122)
        Me.keiroFromLbl.Name = "keiroFromLbl"
        Me.keiroFromLbl.Size = New System.Drawing.Size(67, 12)
        Me.keiroFromLbl.TabIndex = 11
        Me.keiroFromLbl.Text = "経路:出発駅"
        '
        'ohukuLbl
        '
        Me.ohukuLbl.AutoSize = True
        Me.ohukuLbl.Location = New System.Drawing.Point(381, 168)
        Me.ohukuLbl.Name = "ohukuLbl"
        Me.ohukuLbl.Size = New System.Drawing.Size(54, 12)
        Me.ohukuLbl.TabIndex = 12
        Me.ohukuLbl.Text = "往復フラグ"
        '
        'keiroToLbl
        '
        Me.keiroToLbl.AutoSize = True
        Me.keiroToLbl.Location = New System.Drawing.Point(381, 215)
        Me.keiroToLbl.Name = "keiroToLbl"
        Me.keiroToLbl.Size = New System.Drawing.Size(67, 12)
        Me.keiroToLbl.TabIndex = 13
        Me.keiroToLbl.Text = "経路:到着駅"
        '
        'kingakuLbl
        '
        Me.kingakuLbl.AutoSize = True
        Me.kingakuLbl.Location = New System.Drawing.Point(381, 276)
        Me.kingakuLbl.Name = "kingakuLbl"
        Me.kingakuLbl.Size = New System.Drawing.Size(29, 12)
        Me.kingakuLbl.TabIndex = 14
        Me.kingakuLbl.Text = "金額"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "備考"
        '
        'priceTxt
        '
        Me.priceTxt.Location = New System.Drawing.Point(460, 269)
        Me.priceTxt.MaxLength = 6
        Me.priceTxt.Name = "priceTxt"
        Me.priceTxt.Size = New System.Drawing.Size(202, 19)
        Me.priceTxt.TabIndex = 6
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(592, 316)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(70, 31)
        Me.startBtn.TabIndex = 8
        Me.startBtn.Text = "開始"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'remarks
        '
        Me.remarks.Location = New System.Drawing.Point(64, 291)
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(261, 56)
        Me.remarks.TabIndex = 7
        '
        'departureStation
        '
        Me.departureStation.Location = New System.Drawing.Point(460, 115)
        Me.departureStation.Name = "departureStation"
        Me.departureStation.Size = New System.Drawing.Size(202, 19)
        Me.departureStation.TabIndex = 2
        '
        'arrivalStation
        '
        Me.arrivalStation.Location = New System.Drawing.Point(460, 212)
        Me.arrivalStation.Name = "arrivalStation"
        Me.arrivalStation.Size = New System.Drawing.Size(202, 19)
        Me.arrivalStation.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(466, 166)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "⇒"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(526, 166)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "⇔"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'expenseTxt
        '
        Me.expenseTxt.FormattingEnabled = True
        Me.expenseTxt.Items.AddRange(New Object() {"通勤費", "交通費", "交通費[領収書あり］"})
        Me.expenseTxt.Location = New System.Drawing.Point(460, 69)
        Me.expenseTxt.Name = "expenseTxt"
        Me.expenseTxt.Size = New System.Drawing.Size(202, 20)
        Me.expenseTxt.TabIndex = 1
        Me.expenseTxt.Text = "通勤費"
        Me.expenseTxt.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(175, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "※開始ボタンを押すと自動で経費精算ページに遷移します。ログインを行ってからボタンを押してください。"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 402)
        Me.Controls.Add(Me.expenseTxt)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.arrivalStation)
        Me.Controls.Add(Me.departureStation)
        Me.Controls.Add(Me.priceTxt)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.kingakuLbl)
        Me.Controls.Add(Me.keiroToLbl)
        Me.Controls.Add(Me.ohukuLbl)
        Me.Controls.Add(Me.keiroFromLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.himokuLbl)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents himokuLbl As Label
    Friend WithEvents keiroFromLbl As Label
    Friend WithEvents ohukuLbl As Label
    Friend WithEvents keiroToLbl As Label
    Friend WithEvents kingakuLbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents priceTxt As TextBox
    Friend WithEvents startBtn As Button
    Friend WithEvents remarks As TextBox
    Friend WithEvents departureStation As TextBox
    Friend WithEvents arrivalStation As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents expenseTxt As ComboBox
    Friend WithEvents Label1 As Label
End Class
