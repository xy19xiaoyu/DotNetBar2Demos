Imports System.IO
Imports System.Runtime.InteropServices

Namespace SuperGridDemo
	Friend Class ShellServices
		#Region "Dll Imports"

		<DllImport("gdi32")> _
		Private Shared Sub DeleteObject(ByVal lObject As IntPtr)
		End Sub

		<DllImport("shell32.dll")> _
		Private Shared Function SHGetFileInfo(ByVal pszPath As String, ByVal dwAttributes As Integer, ByRef psfi As ShellFileInfo, ByVal cbSizeFileInfo As Integer, ByVal uFlags As Integer) As Integer
		End Function

		#End Region

		#Region "Private data"

		Private Const SHGFI_ICON As Integer = &H100
		Private Const SHGFI_SMALLICON As Integer = &H1
		Private Const SHGFI_LARGEICON As Integer = &H0
		Private Const SHGFI_TYPENAME As Integer = &H400
		Private Const SHGFI_USEFILEATTRIBUTES As Integer = &H10

		Private Const FileTypeFlags As Integer = SHGFI_TYPENAME Or SHGFI_USEFILEATTRIBUTES
		Private Const FileIconFlags As Integer = SHGFI_ICON

		Private Shared _SystemImages As New SystemImages()

		#End Region

		#Region "ShellFileInfo"

		<StructLayout(LayoutKind.Sequential)> _
		Private Structure ShellFileInfo
			Public IconHandle As Integer
			Public IconIndex As Integer
			Public Attributes As Integer

			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)> _
			Public DisplayName As String

			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 80)> _
			Public TypeName As String
		End Structure

		#End Region

		#Region "GetFileType"

		Public Shared Function GetFileType(ByVal path As String) As String
			Dim fileInfo As New ShellFileInfo()

			fileInfo.TypeName = New String(" "c, 80)

			If SHGetFileInfo(path, 0, fileInfo, Marshal.SizeOf(fileInfo), FileTypeFlags) <> 0 Then
				Return (fileInfo.TypeName.Trim())
			End If

			Return ("")
		End Function

		#End Region

		#Region "GetFileImage"

		Public Shared Function GetFileImage(ByVal path As String, ByVal largeIcon As Boolean, ByVal extensionOnly As Boolean) As Image
			Dim ext As String = GetExtension(path)

			If largeIcon = True Then
				If _SystemImages.LargeImageList.Images.ContainsKey(ext) Then
					Return (_SystemImages.LargeImageList.Images(ext))
				End If
			Else
				If _SystemImages.SmallImageList.Images.ContainsKey(ext) Then
					Return (_SystemImages.SmallImageList.Images(ext))
				End If
			End If

			Dim icon As Icon = GetFileIcon(path, largeIcon, extensionOnly)

			If icon IsNot Nothing Then
				Dim image As Bitmap = icon.ToBitmap()

				If largeIcon = True Then
					_SystemImages.LargeImageList.Images.Add(ext, image)
				Else
					_SystemImages.SmallImageList.Images.Add(ext, image)
				End If

				Return (image)
			End If

			Return (Nothing)
		End Function

		#Region "GetExtension"

		Private Shared Function GetExtension(ByVal path As String) As String
			Dim info As New FileInfo(path)

			Dim ext As String = info.Extension

			If String.IsNullOrEmpty(ext) Then
				If (info.Attributes And FileAttributes.Directory) <> 0 Then
					ext = "5EEB255733234c4dBECF9A128E896A1E"
				Else
					ext = "F9EB930C78D2477c80A51945D505E9C4"
				End If
			Else
				If ext.Equals(".exe", StringComparison.InvariantCultureIgnoreCase) OrElse ext.Equals(".lnk", StringComparison.InvariantCultureIgnoreCase) Then
					ext = info.Name
				End If
			End If

			Return (ext)
		End Function

		#End Region

		#Region "GetFileIcon"

		Private Shared Function GetFileIcon(ByVal path As String, ByVal largeIcon As Boolean, ByVal extensionOnly As Boolean) As Icon
			Dim fileInfo As New ShellFileInfo()

            Dim flags As Integer = FileIconFlags Or (IIf(largeIcon = True, SHGFI_LARGEICON, SHGFI_SMALLICON))

			If extensionOnly = True Then
				flags = flags Or SHGFI_USEFILEATTRIBUTES
			End If

			If SHGetFileInfo(path, &H80, fileInfo, Marshal.SizeOf(fileInfo), flags) <> 0 Then
				Dim hIcon As New IntPtr(fileInfo.IconHandle)

				If hIcon <> CType(0, IntPtr) Then
					Dim myIcon As Icon = Icon.FromHandle(hIcon)

					DeleteObject(hIcon)

					Return (myIcon)
				End If
			End If

			Return (Nothing)
		End Function

		#End Region

		#End Region

		#Region "LoadRtbText"

		''' <summary>
		''' Loads the given RichTextBox from the given resource
		''' </summary>
		''' <param name="rtb"></param>
		''' <param name="resource"></param>
		Public Shared Sub LoadRtbText(ByVal rtb As RichTextBox, ByVal resource As String)
			Using stream As Stream = GetType(DemoGridBasics0).Assembly.GetManifestResourceStream(resource)
				If stream IsNot Nothing Then
					Using reader As New StreamReader(stream)
						rtb.Rtf = reader.ReadToEnd()
					End Using
				End If
			End Using
		End Sub

		#End Region

		#Region "LoadBitmap"

		''' <summary>
		''' Loads a bitmap from the given resource
		''' </summary>
		''' <param name="resource"></param>
		''' <returns></returns>
		Public Shared Function LoadBitmap(ByVal resource As String) As Bitmap
			Using stream As Stream = GetType(DemoGridBasics0).Assembly.GetManifestResourceStream(resource)
				If stream IsNot Nothing Then
					Return (New Bitmap(stream))
				End If
			End Using

			Return (Nothing)
		End Function

		#End Region

		#Region "SystemImages"

		Private Class SystemImages
			Public SmallImageList As ImageList
			Public LargeImageList As ImageList

			Public Sub New()
				SmallImageList = New ImageList()

				SmallImageList.ColorDepth = ColorDepth.Depth32Bit
				SmallImageList.ImageSize = SystemInformation.SmallIconSize

				LargeImageList = New ImageList()

				LargeImageList.ColorDepth = ColorDepth.Depth32Bit
				LargeImageList.ImageSize = SystemInformation.IconSize
			End Sub
		End Class

#End Region

        #Region "GetResource"

        Public Shared Function GetResource(ByVal resource As String) As Object
            Return (GetType(DemoGridBasics0).Assembly.GetManifestResourceStream(resource))
        End Function

        #End Region

	End Class
End Namespace
