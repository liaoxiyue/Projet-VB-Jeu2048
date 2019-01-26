Module Module2048

    Public n As Byte = 4
    Public Jeu(n, n) As Integer
    Public Undo(n, n) As Integer
    Public verifier(n, n) As Short
    Public Score As Integer = 0
    Public UndoScore As Integer
    Public verifierScore As Integer
    Public Historique As Integer = 0
    Public memoire(4) As Integer
    Public direction As String
    ' à compléter en accord avec les consignes données dans le sujet

    Public Sub Initialiser(ByVal degre)

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim i As Byte = 1
        Score = 0
        'On définit les variables x et y comme lignes et colonnes'
        For x = 1 To n
            For y = 1 To n
                Jeu(x, y) = 0
            Next
        Next
        'On ajoute les fonctions nous permettant de choisir les valeurs et les cases aléatoirement' 
        While i <= 2
            x = RandomCase()
            y = RandomCase()
            If Jeu(x, y) = 0 Then
                z = RandomValeur(degre)
                Jeu(x, y) = z
                i = i + 1
            End If
        End While
    End Sub
    Public Sub TirerAleatoirement(ByVal degre)
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim ajouter As Boolean = False
        While ajouter = False
            x = RandomCase()
            y = RandomCase()
            If Jeu(x, y) = 0 Then
                z = RandomValeur(degre)
                Jeu(x, y) = z
                ajouter = True
            End If
        End While
    End Sub

    Public Function RandomValeur(ByVal degre)
        Dim valeur As Integer
        Dim curseur As Integer
        Randomize()
        If degre = "simple" Then
            curseur = Int((Rnd() * 100) + 1)
            If curseur <= 90 Then
                valeur = 2
            Else
                valeur = 4
            End If
        ElseIf degre = "difficile" Then
            valeur = Int((2 - 1 + 1) * Rnd() + 1) * 2
        End If
        Return valeur
    End Function

    Public Function RandomValeurS()

        'Cette fonction permet de choisir 2 ou 4 aléatoirement'

        Dim valeur As Integer
        Randomize()
        valeur = Int((2 - 1 + 1) * Rnd() + 1) * 2

        Return valeur

    End Function

    Public Function RandomCase()
        'Cette fonction permet de choisir aléatoirement la case'
        Dim box As Integer

        Randomize()
        box = Int((n - 1 + 1) * Rnd() + 1)

        Return box

    End Function

    Public Sub historiqueScore()
        If Historique < Score Then
            Historique = Score
        End If
    End Sub

    Public Sub enregistrerUndo()
        For x = 1 To n
            For y = 1 To n
                Undo(x, y) = Jeu(x, y)
            Next
        Next
        UndoScore = Score
    End Sub

    Public Sub undoJeu()
        For x = 1 To n
            For y = 1 To n
                Jeu(x, y) = Undo(x, y)
            Next
        Next
        Score = UndoScore
    End Sub

    Sub CalMemoire()
        If memoire(1) <> 0 Then
            If memoire(1) = memoire(2) Then
                memoire(1) = memoire(1) + memoire(2)
                memoire(2) = 0
                Score = Score + memoire(1)
                If memoire(3) <> 0 Then
                    If memoire(3) = memoire(4) Then
                        memoire(2) = memoire(3) + memoire(4)
                        memoire(3) = 0
                        memoire(4) = 0
                        Score = Score + memoire(2)
                    Else
                        memoire(2) = memoire(3)
                        memoire(3) = memoire(4)
                        memoire(4) = 0
                    End If
                End If
            Else
                If memoire(2) <> 0 Then
                    If memoire(2) = memoire(3) Then
                        memoire(2) = memoire(2) + memoire(3)
                        memoire(3) = memoire(4)
                        memoire(4) = 0
                        Score = Score + memoire(2)
                    Else
                        If memoire(3) <> 0 Then
                            If memoire(3) = memoire(4) Then
                                memoire(3) = memoire(3) + memoire(4)
                                memoire(4) = 0
                                Score = Score + memoire(3)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Function checkwin() As Boolean
        Dim win As Boolean = False
        Dim i As Byte
        For x = 1 To n
            For y = 1 To n
                If Jeu(x, y) = 2048 Then
                    i = i + 1
                End If
            Next
        Next
        If i = 1 Then
            win = True
        End If
        Return win
    End Function

    Public Sub deplacer(ByVal direction)
        Dim x As Integer
        Dim y As Integer
        Dim a As Integer
        Dim b As Integer
        Dim s As Integer
        Dim i As Byte
        If CStr(direction) = "up" Or CStr(direction) = "left" Then
            a = 1
            b = n
            s = 1
        ElseIf CStr(direction) = "down" Or CStr(direction) = "right" Then
            a = n
            b = 1
            s = -1
        End If

        If CStr(direction) = "up" Or CStr(direction) = "down" Then
            For y = 1 To n
                i = 0
                For j = 1 To n
                    memoire(j) = 0
                Next
                For x = a To b Step s
                    If Jeu(x, y) <> 0 Then
                        i = i + 1
                        memoire(i) = Jeu(x, y)
                        Jeu(x, y) = 0
                    End If
                Next

                Call CalMemoire()
                i = 1
                For x = a To b Step s
                    Jeu(x, y) = memoire(i)
                    i = i + 1
                Next
            Next
        ElseIf CStr(direction) = "left" Or CStr(direction) = "right" Then
            For x = 1 To n
                i = 0
                For j = 1 To n
                    memoire(j) = 0
                Next
                For y = a To b Step s
                    If Jeu(x, y) <> 0 Then
                        i = i + 1
                        memoire(i) = Jeu(x, y)
                        Jeu(x, y) = 0
                    End If
                Next

                Call CalMemoire()

                i = 1
                For y = a To b Step s
                    Jeu(x, y) = memoire(i)
                    i = i + 1
                Next
            Next
        End If
    End Sub


    Public Function verifierdeplacer(ByVal direction) As Boolean
        Dim OK As Boolean = False
        For x = 1 To n
            For y = 1 To n
                verifier(x, y) = Jeu(x, y)
            Next
        Next
        verifierScore = Score
        deplacer(direction)
        For x = 1 To n
            For y = 1 To n
                If verifier(x, y) <> Jeu(x, y) Then
                    OK = True
                End If
            Next
        Next
        For x = 1 To n
            For y = 1 To n
                Jeu(x, y) = verifier(x, y)
            Next
        Next
        Score = verifierScore
        Return OK
    End Function
End Module