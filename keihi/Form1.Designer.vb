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
        Me.InputDates = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(14, 33)
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
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "日時選択"
        '
        'himokuLbl
        '
        Me.himokuLbl.AutoSize = True
        Me.himokuLbl.BackColor = System.Drawing.SystemColors.Info
        Me.himokuLbl.Location = New System.Drawing.Point(3, 7)
        Me.himokuLbl.Name = "himokuLbl"
        Me.himokuLbl.Size = New System.Drawing.Size(29, 12)
        Me.himokuLbl.TabIndex = 10
        Me.himokuLbl.Text = "費目"
        '
        'keiroFromLbl
        '
        Me.keiroFromLbl.AutoSize = True
        Me.keiroFromLbl.BackColor = System.Drawing.SystemColors.Info
        Me.keiroFromLbl.Location = New System.Drawing.Point(3, 53)
        Me.keiroFromLbl.Name = "keiroFromLbl"
        Me.keiroFromLbl.Size = New System.Drawing.Size(67, 12)
        Me.keiroFromLbl.TabIndex = 11
        Me.keiroFromLbl.Text = "経路:出発駅"
        '
        'ohukuLbl
        '
        Me.ohukuLbl.AutoSize = True
        Me.ohukuLbl.BackColor = System.Drawing.SystemColors.Info
        Me.ohukuLbl.Location = New System.Drawing.Point(3, 103)
        Me.ohukuLbl.Name = "ohukuLbl"
        Me.ohukuLbl.Size = New System.Drawing.Size(54, 12)
        Me.ohukuLbl.TabIndex = 12
        Me.ohukuLbl.Text = "往復フラグ"
        '
        'keiroToLbl
        '
        Me.keiroToLbl.AutoSize = True
        Me.keiroToLbl.BackColor = System.Drawing.SystemColors.Info
        Me.keiroToLbl.Location = New System.Drawing.Point(2, 150)
        Me.keiroToLbl.Name = "keiroToLbl"
        Me.keiroToLbl.Size = New System.Drawing.Size(67, 12)
        Me.keiroToLbl.TabIndex = 13
        Me.keiroToLbl.Text = "経路:到着駅"
        '
        'kingakuLbl
        '
        Me.kingakuLbl.AutoSize = True
        Me.kingakuLbl.BackColor = System.Drawing.SystemColors.Info
        Me.kingakuLbl.Location = New System.Drawing.Point(3, 211)
        Me.kingakuLbl.Name = "kingakuLbl"
        Me.kingakuLbl.Size = New System.Drawing.Size(29, 12)
        Me.kingakuLbl.TabIndex = 14
        Me.kingakuLbl.Text = "金額"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(25, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "備考"
        '
        'priceTxt
        '
        Me.priceTxt.Location = New System.Drawing.Point(79, 204)
        Me.priceTxt.MaxLength = 6
        Me.priceTxt.Name = "priceTxt"
        Me.priceTxt.Size = New System.Drawing.Size(135, 19)
        Me.priceTxt.TabIndex = 6
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(513, 316)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(135, 31)
        Me.startBtn.TabIndex = 8
        Me.startBtn.Text = "開始"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'remarks
        '
        Me.remarks.Location = New System.Drawing.Point(26, 291)
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(390, 56)
        Me.remarks.TabIndex = 7
        '
        'departureStation
        '
        Me.departureStation.Location = New System.Drawing.Point(79, 50)
        Me.departureStation.Name = "departureStation"
        Me.departureStation.Size = New System.Drawing.Size(135, 19)
        Me.departureStation.TabIndex = 2
        '
        'arrivalStation
        '
        Me.arrivalStation.Location = New System.Drawing.Point(79, 147)
        Me.arrivalStation.Name = "arrivalStation"
        Me.arrivalStation.Size = New System.Drawing.Size(135, 19)
        Me.arrivalStation.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(85, 101)
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
        Me.RadioButton2.Location = New System.Drawing.Point(145, 101)
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
        Me.expenseTxt.Location = New System.Drawing.Point(79, 4)
        Me.expenseTxt.Name = "expenseTxt"
        Me.expenseTxt.Size = New System.Drawing.Size(135, 20)
        Me.expenseTxt.TabIndex = 1
        Me.expenseTxt.Text = "通勤費"
        Me.expenseTxt.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(373, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "※開始ボタンを押すと自動で経費精算ページに遷移します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 　ログインを行ってから開始ボタンを押してください。"
        '
        'InputDates
        '
        Me.InputDates.FormattingEnabled = True
        Me.InputDates.ItemHeight = 12
        Me.InputDates.Location = New System.Drawing.Point(292, 34)
        Me.InputDates.Name = "InputDates"
        Me.InputDates.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.InputDates.Size = New System.Drawing.Size(113, 160)
        Me.InputDates.Sorted = True
        Me.InputDates.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 22)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 22)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "削除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "→"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "←"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.InputDates)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 209)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.expenseTxt)
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.arrivalStation)
        Me.Panel2.Controls.Add(Me.departureStation)
        Me.Panel2.Controls.Add(Me.priceTxt)
        Me.Panel2.Controls.Add(Me.kingakuLbl)
        Me.Panel2.Controls.Add(Me.keiroToLbl)
        Me.Panel2.Controls.Add(Me.ohukuLbl)
        Me.Panel2.Controls.Add(Me.keiroFromLbl)
        Me.Panel2.Controls.Add(Me.himokuLbl)
        Me.Panel2.Location = New System.Drawing.Point(422, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 238)
        Me.Panel2.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 402)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents InputDates As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
