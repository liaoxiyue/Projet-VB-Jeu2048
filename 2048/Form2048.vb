Public Class Form2048

    Public lbl(16) As Label
    Public win As Boolean = False
    Public degre As String = "simple"
    Private Sub definirLabel()
        lbl(1) = lbl1
        lbl(2) = lbl2
        lbl(3) = lbl3
        lbl(4) = lbl4
        lbl(5) = lbl5
        lbl(6) = lbl6
        lbl(7) = lbl7
        lbl(8) = lbl8
        lbl(9) = lbl9
        lbl(10) = lbl10
        lbl(11) = lbl11
        lbl(12) = lbl12
        lbl(13) = lbl13
        lbl(14) = lbl14
        lbl(15) = lbl15
        lbl(16) = lbl16
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Up Or keyData = Keys.Down Or keyData = Keys.Left Or keyData = Keys.Right Then
            Return False
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Private Sub Form2048_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Connecter des boutons de clavier avec les boutons sur interface

        'conncter avec ZSQD
        Select Case Chr(e.KeyValue)
            Case "S"
                btnDown_Click(sender, e)
            Case "Z"
                btnUp_Click(sender, e)
            Case "Q"
                btnLeft_Click(sender, e)
            Case "D"
                btnRight_Click(sender, e)
        End Select

        'connecter avec Up, Down, Right, Left
        If e.KeyData = Keys.Up Then
            btnUp_Click(sender, e)
        End If
        If e.KeyData = Keys.Down Then
            btnDown_Click(sender, e)
        End If
        If e.KeyData = Keys.Right Then
            btnRight_Click(sender, e)
        End If
        If e.KeyData = Keys.Left Then
            btnLeft_Click(sender, e)
        End If
        GroupDegre.Enabled = True
    End Sub
    Private Sub Form2048_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call definirLabel()
        'activer l'utilisation de clavier 
        Me.KeyPreview = True
        btnUndo.Enabled = False
        'Pour initialiser le jeu on appelle la fonction initaliser qui charge les paramètres intiales'
        Call Initialiser(degre)
        'la fonction affiche permet de visualiser les paramètres initiaux du jeu' 
        Call Afficher()

    End Sub

    Private Sub ChangerCouleur()
        For i = 1 To 16
            If lbl(i).Text = "" Then
                lbl(i).BackColor = Color.Lavender
            ElseIf CInt(lbl(i).Text) = 2 Then
                lbl(i).BackColor = Color.GhostWhite
                lbl(i).ForeColor = Color.RosyBrown
            ElseIf CInt(lbl(i).Text) = 4 Then
                lbl(i).BackColor = Color.Cornsilk
                lbl(i).ForeColor = Color.RosyBrown
            ElseIf CInt(lbl(i).Text) = 8 Then
                lbl(i).BackColor = Color.PeachPuff
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 16 Then
                lbl(i).BackColor = Color.LightSalmon
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 32 Then
                lbl(i).BackColor = Color.Salmon
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 64 Then
                lbl(i).BackColor = Color.Tomato
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 128 Then
                lbl(i).BackColor = Color.Khaki
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 256 Then
                lbl(i).BackColor = Color.Gold
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 512 Then
                lbl(i).BackColor = Color.Goldenrod
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 1024 Then
                lbl(i).BackColor = Color.Orange
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 2048 Then
                lbl(i).BackColor = Color.Yellow
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 4096 Then
                lbl(i).BackColor = Color.MediumAquamarine
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) = 8192 Then
                lbl(i).BackColor = Color.LightSkyBlue
                lbl(i).ForeColor = Color.White
            ElseIf CInt(lbl(i).Text) >= 16384 Then
                lbl(i).BackColor = Color.MediumPurple
                lbl(i).ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub Afficher()
        'solution 2 pour afficher la variable Jeu dans les labels
        Dim l As Byte
        Dim i As Byte
        Dim j As Byte
        For i = 1 To n
            For j = 1 To n
                l = (i - 1) * n + j
                If Jeu(i, j) <> 0 Then
                    lbl(l).Text = CStr(Jeu(i, j))
                Else
                    lbl(l).Text = ""
                End If
            Next
        Next
        lblScore.Text = CStr(Score)
        Call historiqueScore()
        lblmaxscore.Text = CStr(Historique)
        ChangerCouleur()
    End Sub

    Private Sub btnRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnRestart.Click
        ' gère le redémarage d'une partie
        ' à compléter
        GroupDegre.Enabled = True
        Initialiser(degre)
        Afficher()
        btnUndo.Enabled = False
        btnDown.Enabled = True
        btnLeft.Enabled = True
        btnRight.Enabled = True
        btnUp.Enabled = True
        Me.KeyPreview = True
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        ' gère l'annulation du coup qui vient dêtre joué (on ne peut annuler qu'un coup)
        ' à compléter
        undoJeu()
        Afficher()
    End Sub

    Private Sub JeuTerminer()
        If win = False Then
            win = checkwin()
            If win = True Then
                If MsgBox("WIN!!! Voulez vous continuer? ", vbYesNo + vbQuestion, "选择") = MsgBoxResult.No Then
                    btnUndo.Enabled = False
                    btnDown.Enabled = False
                    btnLeft.Enabled = False
                    btnRight.Enabled = False
                    btnUp.Enabled = False
                    Me.KeyPreview = False
                End If
            End If
        End If
        If verifierdeplacer("up") = False And verifierdeplacer("down") = False And verifierdeplacer("right") = False And verifierdeplacer("left") = False Then
            btnUndo.Enabled = False
            btnDown.Enabled = False
            btnLeft.Enabled = False
            btnRight.Enabled = False
            btnUp.Enabled = False
            Me.KeyPreview = False
            MsgBox("Game Over!")
        End If
    End Sub

    Private Sub btnLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft.Click
        ' gère le déplacement à gauche
        ' à compléter
        Dim OK As Boolean = verifierdeplacer("left")
        btnUndo.Enabled = True
        radio_difficile.Enabled = False
        radio_simple.Enabled = False
        If OK = True Then
            Call enregistrerUndo()
            Call deplacer("left")
            Call TirerAleatoirement(degre)
            Call Afficher()
        End If
        JeuTerminer()
    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click
        ' gère le déplacement à droite
        ' à compléter
        Dim OK As Boolean = verifierdeplacer("right")
        btnUndo.Enabled = True
        radio_difficile.Enabled = False
        radio_simple.Enabled = False
        If OK = True Then
            Call enregistrerUndo()
            Call deplacer("right")
            Call TirerAleatoirement(degre)
            Call Afficher()
        End If
        JeuTerminer()
    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        ' gère le déplacement vers le haut
        ' à compléter
        Dim OK As Boolean = verifierdeplacer("up")
        btnUndo.Enabled = True
        radio_difficile.Enabled = False
        radio_simple.Enabled = False
        If OK = True Then
            Call enregistrerUndo()
            Call deplacer("up")
            Call TirerAleatoirement(degre)
            Call Afficher()
        End If
        JeuTerminer()
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click

        ' gère le déplacement vers le bas
        ' à compléter
        Dim OK As Boolean = verifierdeplacer("down")
        btnUndo.Enabled = True
        radio_difficile.Enabled = False
        radio_simple.Enabled = False
        If OK = True Then
            Call enregistrerUndo()
            Call deplacer("down")
            Call TirerAleatoirement(degre)
            Call Afficher()
        End If
        JeuTerminer()
    End Sub

    Private Sub btn_quitter_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitter.Click
        If MsgBox("Voulez-vous quitter le jeu?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub radio_simple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radio_simple.CheckedChanged
        degre = "simple"
    End Sub

    Private Sub radio_difficile_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radio_difficile.CheckedChanged
        degre = "difficile"
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        MsgBox("Vous pouvez jouer avec les Pokéballs au-dessous ou avec le clavier tapant en ""WSAD"" ou ""up, down, left, right""")
    End Sub
End Class