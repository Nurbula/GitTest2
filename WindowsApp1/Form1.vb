Public Class Form1
    Private Sub listFlavor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFlavor.SelectedIndexChanged
        If listFlavor.SelectedItem = "Chocolate" Then
            PictureBox1.Image = My.Resources.easy_chocolate_ice_cream_recipe_1945798_hero_01_45d9f26a0aaf4c1dba38d7e0a2ab51e2
        ElseIf listFlavor.SelectedItem = "Vanilla" Then
            PictureBox1.Image = My.Resources.Vanilla_2_Ingredient_Ice_cream_scaled
        ElseIf listFlavor.SelectedItem = "Strawberry" Then
            PictureBox1.Image = My.Resources.strawberry_ice_cream_10_0b3e120e7d6f4df1be3c57c17699eb2c
        ElseIf listFlavor.SelectedItem = "Oreo" Then
            PictureBox1.Image = My.Resources.download
        ElseIf listFlavor.SelectedItem = "Fudge" Then
            PictureBox1.Image = My.Resources.Homemade_Chocolate_Fudge_Ice_Cream_Get_Inspired_Everyday_8
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

