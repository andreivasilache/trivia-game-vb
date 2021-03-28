Public Class StoreInstance
    Public Shared ReadOnly instance As New Store()

    'Prevent user making a new instance of the class from the outside.
    Private Sub New()
    End Sub

End Class
