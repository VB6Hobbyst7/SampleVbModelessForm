Imports Rhino
Imports Rhino.Commands

Namespace SampleVbModelessForm

  <System.Runtime.InteropServices.Guid("27d6b91b-a6b4-4f72-9642-87f8577b26c4")> _
  Public Class SampleVbModelessPointsCommand
    Inherits Command

    Private Shared m_Instance As SampleVbModelessPointsCommand
    Private Shared m_Form As SampleVbModelessPointsForm

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
      ' Rhino only creates one instance of each command class defined in a
      ' plug-in, so it is safe to store a refence in a static field.
      m_Instance = Me
    End Sub

    ''' <summary>
    ''' The only instance of this command
    ''' </summary>
    Public Shared ReadOnly Property Instance() As SampleVbModelessPointsCommand
      Get
        Return m_Instance
      End Get
    End Property

    ''' <summary>
    ''' Form accessor
    ''' </summary>
    Public Shared Property Form() As SampleVbModelessPointsForm
      Get
        Return m_Form
      End Get
      Set(value As SampleVbModelessPointsForm)
        m_Form = value
      End Set
    End Property

    ''' <returns>
    ''' The command name as it appears on the Rhino command line
    ''' </returns>
    Public Overrides ReadOnly Property EnglishName() As String
      Get
        Return "SampleVbModelessPointsCommand"
      End Get
    End Property

    ''' <summary>
    ''' Runs the command
    ''' </summary>
    Protected Overrides Function RunCommand(ByVal doc As RhinoDoc, ByVal mode As RunMode) As Result

      If Form Is Nothing OrElse Form.IsDisposed Then
        Form = New SampleVbModelessPointsForm()
        Form.Show(RhinoApp.MainWindow())
      Else
        Form.BringToFront()
      End If

      Return Result.Success
    End Function

  End Class

End Namespace