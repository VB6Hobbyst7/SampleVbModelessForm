Imports Rhino

Public Class SampleVbModelessPointsForm

  Private m_Random As New System.Random()

  Private Sub SampleVbModelessPointsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    Dim doc As Rhino.RhinoDoc = Rhino.RhinoDoc.ActiveDoc
    If (doc IsNot Nothing) Then
      Dim x As Double = GetRandaomDouble(0.0, 100.0)
      Dim y As Double = GetRandaomDouble(0.0, 100.0)
      Dim z As Double = GetRandaomDouble(0.0, 100.0)
      Dim point As New Rhino.Geometry.Point3d(x, y, z)
      doc.Objects.AddPoint(point)
      doc.Views.Redraw()
    End If

  End Sub

  Private Function GetRandaomDouble(ByVal min As Double, ByVal max As Double) As Double
    Return min + m_Random.NextDouble() * (max - min)
  End Function

End Class