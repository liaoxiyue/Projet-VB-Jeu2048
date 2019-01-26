<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2048
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2048))
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.lblmaxscore = New System.Windows.Forms.Label()
        Me.lbl_hist = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.radio_simple = New System.Windows.Forms.RadioButton()
        Me.radio_difficile = New System.Windows.Forms.RadioButton()
        Me.GroupDegre = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupDegre.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.BackgroundImage = CType(resources.GetObject("btnLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLeft.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(214, 443)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(67, 67)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.BackgroundImage = CType(resources.GetObject("btnRight.BackgroundImage"), System.Drawing.Image)
        Me.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRight.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(365, 443)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(69, 67)
        Me.btnRight.TabIndex = 1
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Transparent
        Me.btnUp.BackgroundImage = CType(resources.GetObject("btnUp.BackgroundImage"), System.Drawing.Image)
        Me.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUp.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUp.Location = New System.Drawing.Point(290, 394)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(69, 67)
        Me.btnUp.TabIndex = 2
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackgroundImage = CType(resources.GetObject("btnDown.BackgroundImage"), System.Drawing.Image)
        Me.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDown.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(290, 494)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(69, 67)
        Me.btnDown.TabIndex = 3
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(310, 34)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(75, 20)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "le score..."
        '
        'btnUndo
        '
        Me.btnUndo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUndo.Location = New System.Drawing.Point(141, 18)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(86, 51)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Location = New System.Drawing.Point(432, 19)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(91, 34)
        Me.btn_quitter.TabIndex = 25
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'lblmaxscore
        '
        Me.lblmaxscore.AutoSize = True
        Me.lblmaxscore.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaxscore.Location = New System.Drawing.Point(542, 47)
        Me.lblmaxscore.Name = "lblmaxscore"
        Me.lblmaxscore.Size = New System.Drawing.Size(111, 20)
        Me.lblmaxscore.TabIndex = 26
        Me.lblmaxscore.Text = "meilleur score"
        '
        'lbl_hist
        '
        Me.lbl_hist.AutoSize = True
        Me.lbl_hist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hist.Location = New System.Drawing.Point(542, 20)
        Me.lbl_hist.Name = "lbl_hist"
        Me.lbl_hist.Size = New System.Drawing.Size(96, 20)
        Me.lbl_hist.TabIndex = 27
        Me.lbl_hist.Text = "Historique:"
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.Transparent
        Me.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestart.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Image = CType(resources.GetObject("btnRestart.Image"), System.Drawing.Image)
        Me.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestart.Location = New System.Drawing.Point(23, 18)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRestart.Size = New System.Drawing.Size(112, 52)
        Me.btnRestart.TabIndex = 28
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(215, 156)
        Me.lbl1.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(52, 48)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "2048"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(271, 156)
        Me.lbl2.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(52, 48)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "2048"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(327, 156)
        Me.lbl3.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(52, 48)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "2048"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(383, 156)
        Me.lbl4.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(52, 48)
        Me.lbl4.TabIndex = 11
        Me.lbl4.Text = "2048"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(215, 208)
        Me.lbl5.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(52, 48)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "2048"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6
        '
        Me.lbl6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(271, 208)
        Me.lbl6.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(52, 48)
        Me.lbl6.TabIndex = 13
        Me.lbl6.Text = "2048"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl7
        '
        Me.lbl7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.White
        Me.lbl7.Location = New System.Drawing.Point(327, 208)
        Me.lbl7.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(52, 48)
        Me.lbl7.TabIndex = 14
        Me.lbl7.Text = "2048"
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl8
        '
        Me.lbl8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.White
        Me.lbl8.Location = New System.Drawing.Point(383, 208)
        Me.lbl8.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(52, 48)
        Me.lbl8.TabIndex = 15
        Me.lbl8.Text = "2048"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl9
        '
        Me.lbl9.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(215, 260)
        Me.lbl9.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(52, 48)
        Me.lbl9.TabIndex = 16
        Me.lbl9.Text = "2048"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.White
        Me.lbl10.Location = New System.Drawing.Point(271, 260)
        Me.lbl10.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(52, 48)
        Me.lbl10.TabIndex = 17
        Me.lbl10.Text = "2048"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.White
        Me.lbl11.Location = New System.Drawing.Point(327, 260)
        Me.lbl11.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(52, 48)
        Me.lbl11.TabIndex = 18
        Me.lbl11.Text = "2048"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl12
        '
        Me.lbl12.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.White
        Me.lbl12.Location = New System.Drawing.Point(383, 260)
        Me.lbl12.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(52, 48)
        Me.lbl12.TabIndex = 19
        Me.lbl12.Text = "2048"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl13
        '
        Me.lbl13.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.Color.White
        Me.lbl13.Location = New System.Drawing.Point(215, 312)
        Me.lbl13.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(52, 48)
        Me.lbl13.TabIndex = 20
        Me.lbl13.Text = "2048"
        Me.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl14
        '
        Me.lbl14.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.ForeColor = System.Drawing.Color.White
        Me.lbl14.Location = New System.Drawing.Point(271, 312)
        Me.lbl14.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(52, 48)
        Me.lbl14.TabIndex = 22
        Me.lbl14.Text = "2048"
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl15
        '
        Me.lbl15.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.ForeColor = System.Drawing.Color.White
        Me.lbl15.Location = New System.Drawing.Point(327, 312)
        Me.lbl15.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(52, 48)
        Me.lbl15.TabIndex = 23
        Me.lbl15.Text = "2048"
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl16
        '
        Me.lbl16.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16.ForeColor = System.Drawing.Color.White
        Me.lbl16.Location = New System.Drawing.Point(383, 312)
        Me.lbl16.MinimumSize = New System.Drawing.Size(52, 48)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(52, 48)
        Me.lbl16.TabIndex = 24
        Me.lbl16.Text = "2048"
        Me.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(688, 588)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightGray
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Location = New System.Drawing.Point(205, 145)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(240, 225)
        '
        'radio_simple
        '
        Me.radio_simple.AutoSize = True
        Me.radio_simple.Checked = True
        Me.radio_simple.Location = New System.Drawing.Point(6, 24)
        Me.radio_simple.Name = "radio_simple"
        Me.radio_simple.Size = New System.Drawing.Size(65, 21)
        Me.radio_simple.TabIndex = 30
        Me.radio_simple.TabStop = True
        Me.radio_simple.Text = "Simple"
        Me.radio_simple.UseVisualStyleBackColor = True
        '
        'radio_difficile
        '
        Me.radio_difficile.AutoSize = True
        Me.radio_difficile.Location = New System.Drawing.Point(103, 24)
        Me.radio_difficile.Name = "radio_difficile"
        Me.radio_difficile.Size = New System.Drawing.Size(69, 21)
        Me.radio_difficile.TabIndex = 31
        Me.radio_difficile.TabStop = True
        Me.radio_difficile.Text = "Difficile"
        Me.radio_difficile.UseVisualStyleBackColor = True
        '
        'GroupDegre
        '
        Me.GroupDegre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupDegre.Controls.Add(Me.radio_difficile)
        Me.GroupDegre.Controls.Add(Me.radio_simple)
        Me.GroupDegre.Font = New System.Drawing.Font("Calibri", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDegre.Location = New System.Drawing.Point(23, 76)
        Me.GroupDegre.Name = "GroupDegre"
        Me.GroupDegre.Size = New System.Drawing.Size(204, 51)
        Me.GroupDegre.TabIndex = 32
        Me.GroupDegre.TabStop = False
        Me.GroupDegre.Text = "Choisir degré"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(545, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 113)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 466)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 110)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(23, 143)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 51)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Form2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(688, 588)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lbl_hist)
        Me.Controls.Add(Me.lblmaxscore)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.GroupDegre)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form2048"
        Me.Text = "Jeu du 2048"
        Me.GroupDegre.ResumeLayout(False)
        Me.GroupDegre.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btn_quitter As System.Windows.Forms.Button
    Friend WithEvents lblmaxscore As System.Windows.Forms.Label
    Friend WithEvents lbl_hist As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents radio_simple As System.Windows.Forms.RadioButton
    Friend WithEvents radio_difficile As System.Windows.Forms.RadioButton
    Friend WithEvents GroupDegre As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
