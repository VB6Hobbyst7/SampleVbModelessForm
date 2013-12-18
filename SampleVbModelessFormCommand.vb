Imports System
Imports System.Collections.Generic
Imports Rhino
Imports Rhino.Commands
Imports Rhino.Geometry
Imports Rhino.Input
Imports Rhino.Input.Custom

Namespace SampleVbModelessForm

  <System.Runtime.InteropServices.Guid("68386723-985b-4323-b6e9-9fdf12417b83")> _
  Public Class SampleVbModelessFormCommand
    Inherits Command

    Private Shared m_Instance As SampleVbModelessFormCommand
    Private m_Form As SampleVbModelessTextForm

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
      ' Rhino only creates one instance of each command class defined in a
      ' plug-in, so it is safe to store a refence in a static field.
      m_Instance = Me
    End Sub

    ''' <summary>
    ''' The only instance of this command.
    ''' </summary>
    Public Shared Property Instance() As SampleVbModelessFormCommand
      Get
        Return m_Instance
      End Get
      Private Set(value As SampleVbModelessFormCommand)
        m_Instance = value
      End Set
    End Property

    ''' <summary>
    ''' Form accessor
    ''' </summary>
    Public Property Form() As SampleVbModelessTextForm
      Get
        Return m_Form
      End Get
      Set(value As SampleVbModelessTextForm)
        m_Form = value
      End Set
    End Property

    ''' <returns>
    ''' The command name as it appears on the Rhino command line.
    ''' </returns>
    Public Overrides ReadOnly Property EnglishName() As String
      Get
        Return "SampleVbModelessFormCommand"
      End Get
    End Property

    ''' <summary>
    ''' Runs the command.
    ''' </summary>
    Protected Overrides Function RunCommand(ByVal doc As RhinoDoc, ByVal mode As RunMode) As Result

      If Form Is Nothing Then
        Form = New SampleVbModelessTextForm()
        AddHandler Form.FormClosed, AddressOf Form_FormClosed
        Form.Show(RhinoApp.MainWindow())
      End If

      Return Result.Success
    End Function

    ''' <summary>
    ''' FormClosed EventHandler
    ''' </summary>
    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
      Form.Dispose()
      Form = Nothing
    End Sub

  End Class
End Namespace