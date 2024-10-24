Imports Microsoft.Xna.Framework

Friend Class BaseGame
    Inherits Game
    Private ReadOnly _graphics As GraphicsDeviceManager

    Sub New()
        _graphics = New GraphicsDeviceManager(Me)
    End Sub
End Class
