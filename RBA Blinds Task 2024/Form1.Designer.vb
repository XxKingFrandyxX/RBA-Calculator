<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LBLone = New Label()
        LBLtwo = New Label()
        txtWidth = New TextBox()
        txtHeight = New TextBox()
        LBLthree = New Label()
        GPBone = New GroupBox()
        radGloss = New RadioButton()
        radMatte = New RadioButton()
        radWhite = New RadioButton()
        radNatural = New RadioButton()
        numQuantity = New NumericUpDown()
        Label4 = New Label()
        btnCalculate = New Button()
        TXTsubtotal = New TextBox()
        TXTgst = New TextBox()
        TXTtotal = New TextBox()
        TXTdiscount = New TextBox()
        BTNclear = New Button()
        BTNexit = New Button()
        LBLfive = New Label()
        LBLsix = New Label()
        LBLseven = New Label()
        LBLeight = New Label()
        GPBone.SuspendLayout()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LBLone
        ' 
        LBLone.AutoSize = True
        LBLone.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBLone.ForeColor = Color.Purple
        LBLone.Location = New Point(52, 22)
        LBLone.Name = "LBLone"
        LBLone.Size = New Size(288, 30)
        LBLone.TabIndex = 0
        LBLone.Text = "RBA Blinds Cost Calculator"
        ' 
        ' LBLtwo
        ' 
        LBLtwo.AutoSize = True
        LBLtwo.Location = New Point(52, 69)
        LBLtwo.Name = "LBLtwo"
        LBLtwo.Size = New Size(64, 15)
        LBLtwo.TabIndex = 1
        LBLtwo.Text = "Width (m):"
        ' 
        ' txtWidth
        ' 
        txtWidth.Location = New Point(52, 86)
        txtWidth.Margin = New Padding(3, 2, 3, 2)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(133, 23)
        txtWidth.TabIndex = 2
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(241, 86)
        txtHeight.Margin = New Padding(3, 2, 3, 2)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(132, 23)
        txtHeight.TabIndex = 4
        ' 
        ' LBLthree
        ' 
        LBLthree.AutoSize = True
        LBLthree.Location = New Point(241, 69)
        LBLthree.Name = "LBLthree"
        LBLthree.Size = New Size(68, 15)
        LBLthree.TabIndex = 3
        LBLthree.Text = "Height (m):"
        ' 
        ' GPBone
        ' 
        GPBone.Controls.Add(radGloss)
        GPBone.Controls.Add(radMatte)
        GPBone.Controls.Add(radWhite)
        GPBone.Controls.Add(radNatural)
        GPBone.Location = New Point(52, 124)
        GPBone.Margin = New Padding(3, 2, 3, 2)
        GPBone.Name = "GPBone"
        GPBone.Padding = New Padding(3, 2, 3, 2)
        GPBone.Size = New Size(132, 137)
        GPBone.TabIndex = 5
        GPBone.TabStop = False
        GPBone.Text = "Style:"
        ' 
        ' radGloss
        ' 
        radGloss.AutoSize = True
        radGloss.Location = New Point(9, 96)
        radGloss.Margin = New Padding(3, 2, 3, 2)
        radGloss.Name = "radGloss"
        radGloss.Size = New Size(100, 19)
        radGloss.TabIndex = 3
        radGloss.TabStop = True
        radGloss.Text = "Colour (Gloss)"
        radGloss.UseVisualStyleBackColor = True
        ' 
        ' radMatte
        ' 
        radMatte.AutoSize = True
        radMatte.Location = New Point(9, 74)
        radMatte.Margin = New Padding(3, 2, 3, 2)
        radMatte.Name = "radMatte"
        radMatte.Size = New Size(103, 19)
        radMatte.TabIndex = 2
        radMatte.TabStop = True
        radMatte.Text = "Colour (Matte)"
        radMatte.UseVisualStyleBackColor = True
        ' 
        ' radWhite
        ' 
        radWhite.AutoSize = True
        radWhite.Location = New Point(9, 51)
        radWhite.Margin = New Padding(3, 2, 3, 2)
        radWhite.Name = "radWhite"
        radWhite.Size = New Size(56, 19)
        radWhite.TabIndex = 1
        radWhite.TabStop = True
        radWhite.Text = "White"
        radWhite.UseVisualStyleBackColor = True
        ' 
        ' radNatural
        ' 
        radNatural.AutoSize = True
        radNatural.Location = New Point(9, 28)
        radNatural.Margin = New Padding(3, 2, 3, 2)
        radNatural.Name = "radNatural"
        radNatural.Size = New Size(64, 19)
        radNatural.TabIndex = 0
        radNatural.TabStop = True
        radNatural.Text = "Natural"
        radNatural.UseVisualStyleBackColor = True
        ' 
        ' numQuantity
        ' 
        numQuantity.Location = New Point(241, 142)
        numQuantity.Margin = New Padding(3, 2, 3, 2)
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(131, 23)
        numQuantity.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(241, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 7
        Label4.Text = "Quantity:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(50, 336)
        btnCalculate.Margin = New Padding(3, 2, 3, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(82, 22)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' TXTsubtotal
        ' 
        TXTsubtotal.Location = New Point(241, 190)
        TXTsubtotal.Margin = New Padding(3, 2, 3, 2)
        TXTsubtotal.Name = "TXTsubtotal"
        TXTsubtotal.Size = New Size(132, 23)
        TXTsubtotal.TabIndex = 9
        ' 
        ' TXTgst
        ' 
        TXTgst.Location = New Point(241, 236)
        TXTgst.Margin = New Padding(3, 2, 3, 2)
        TXTgst.Name = "TXTgst"
        TXTgst.Size = New Size(132, 23)
        TXTgst.TabIndex = 10
        ' 
        ' TXTtotal
        ' 
        TXTtotal.Location = New Point(241, 284)
        TXTtotal.Margin = New Padding(3, 2, 3, 2)
        TXTtotal.Name = "TXTtotal"
        TXTtotal.Size = New Size(132, 23)
        TXTtotal.TabIndex = 11
        ' 
        ' TXTdiscount
        ' 
        TXTdiscount.Location = New Point(50, 284)
        TXTdiscount.Margin = New Padding(3, 2, 3, 2)
        TXTdiscount.Name = "TXTdiscount"
        TXTdiscount.ReadOnly = True
        TXTdiscount.Size = New Size(132, 23)
        TXTdiscount.TabIndex = 12
        ' 
        ' BTNclear
        ' 
        BTNclear.Location = New Point(172, 336)
        BTNclear.Margin = New Padding(3, 2, 3, 2)
        BTNclear.Name = "BTNclear"
        BTNclear.Size = New Size(82, 22)
        BTNclear.TabIndex = 13
        BTNclear.Text = "Clear"
        BTNclear.UseVisualStyleBackColor = True
        ' 
        ' BTNexit
        ' 
        BTNexit.Location = New Point(309, 336)
        BTNexit.Margin = New Padding(3, 2, 3, 2)
        BTNexit.Name = "BTNexit"
        BTNexit.Size = New Size(82, 22)
        BTNexit.TabIndex = 14
        BTNexit.Text = "Exit"
        BTNexit.UseVisualStyleBackColor = True
        ' 
        ' LBLfive
        ' 
        LBLfive.AutoSize = True
        LBLfive.Location = New Point(52, 264)
        LBLfive.Name = "LBLfive"
        LBLfive.Size = New Size(57, 15)
        LBLfive.TabIndex = 15
        LBLfive.Text = "Discount:"
        ' 
        ' LBLsix
        ' 
        LBLsix.AutoSize = True
        LBLsix.Location = New Point(241, 173)
        LBLsix.Name = "LBLsix"
        LBLsix.Size = New Size(61, 15)
        LBLsix.TabIndex = 16
        LBLsix.Text = "Sub-Total:"
        ' 
        ' LBLseven
        ' 
        LBLseven.AutoSize = True
        LBLseven.Location = New Point(241, 218)
        LBLseven.Name = "LBLseven"
        LBLseven.Size = New Size(64, 15)
        LBLseven.TabIndex = 17
        LBLseven.Text = "GST (10%):"
        ' 
        ' LBLeight
        ' 
        LBLeight.AutoSize = True
        LBLeight.Location = New Point(241, 264)
        LBLeight.Name = "LBLeight"
        LBLeight.Size = New Size(36, 15)
        LBLeight.TabIndex = 18
        LBLeight.Text = "Total:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 376)
        Controls.Add(LBLeight)
        Controls.Add(LBLseven)
        Controls.Add(LBLsix)
        Controls.Add(LBLfive)
        Controls.Add(BTNexit)
        Controls.Add(BTNclear)
        Controls.Add(TXTdiscount)
        Controls.Add(TXTtotal)
        Controls.Add(TXTgst)
        Controls.Add(TXTsubtotal)
        Controls.Add(btnCalculate)
        Controls.Add(Label4)
        Controls.Add(numQuantity)
        Controls.Add(GPBone)
        Controls.Add(txtHeight)
        Controls.Add(LBLthree)
        Controls.Add(txtWidth)
        Controls.Add(LBLtwo)
        Controls.Add(LBLone)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        GPBone.ResumeLayout(False)
        GPBone.PerformLayout()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLone As Label
    Friend WithEvents LBLtwo As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents LBLthree As Label
    Friend WithEvents GPBone As GroupBox
    Friend WithEvents radGloss As RadioButton
    Friend WithEvents radMatte As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents radNatural As RadioButton
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents TXTsubtotal As TextBox
    Friend WithEvents TXTgst As TextBox
    Friend WithEvents TXTtotal As TextBox
    Friend WithEvents TXTdiscount As TextBox
    Friend WithEvents BTNclear As Button
    Friend WithEvents BTNexit As Button
    Friend WithEvents LBLfive As Label
    Friend WithEvents LBLsix As Label
    Friend WithEvents LBLseven As Label
    Friend WithEvents LBLeight As Label

End Class
