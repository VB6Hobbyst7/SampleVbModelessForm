Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Rhino.PlugIns

' Plug-in Description Attributes - all of these are optional
' These will show in Rhino's option dialog, in the tab Plug-ins
<Assembly: PlugInDescription(DescriptionType.Address, "3670 Woodland Park Ave N\n\nSeattle, WA 98103")> 
<Assembly: PlugInDescription(DescriptionType.Country, "United States")> 
<Assembly: PlugInDescription(DescriptionType.Email, "devsupport@mcneel.com")> 
<Assembly: PlugInDescription(DescriptionType.Phone, "(206) 545-6877")> 
<Assembly: PlugInDescription(DescriptionType.Fax, "(206) 545-7321")> 
<Assembly: PlugInDescription(DescriptionType.Organization, "Robert McNeel & Associates")> 
<Assembly: PlugInDescription(DescriptionType.UpdateUrl, "http://www.rhino3d.com")> 
<Assembly: PlugInDescription(DescriptionType.WebSite, "http://www.rhino3d.com")> 


' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("SampleVbModelessForm")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("Robert McNeel & Associates")> 
<Assembly: AssemblyProduct("SampleVbModelessForm")> 
<Assembly: AssemblyCopyright("Copyright © 2013, Robert McNeel & Associates")> 
<Assembly: AssemblyTrademark("")> 

<Assembly: ComVisible(False)>

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("eae03e02-535d-4d46-83f8-034481247106")> ' This will also be the Guid of the Rhino plug-in

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.0.0.0")> 
