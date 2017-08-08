using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace SuperGridDemo
{
    internal class ShellServices
    {
        #region Dll Imports

        [DllImport("gdi32")]
        private static extern void DeleteObject(IntPtr lObject);

        [DllImport("shell32.dll")]
        private static extern int SHGetFileInfo(string pszPath,
            int dwAttributes, ref ShellFileInfo psfi, int cbSizeFileInfo, int uFlags);

        #endregion

        #region Private data

        private const int SHGFI_ICON = 0x100;
        private const int SHGFI_SMALLICON = 0x1;
        private const int SHGFI_LARGEICON = 0x0;
        private const int SHGFI_TYPENAME = 0x400;
        private const int SHGFI_USEFILEATTRIBUTES = 0x10;

        const int FileTypeFlags = SHGFI_TYPENAME | SHGFI_USEFILEATTRIBUTES;
        const int FileIconFlags = SHGFI_ICON;

        private static SystemImages _SystemImages = new SystemImages();

        #endregion

        #region ShellFileInfo

        [StructLayout(LayoutKind.Sequential)]
        private struct ShellFileInfo
        {
            public int IconHandle;
            public int IconIndex;
            public int Attributes;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string DisplayName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string TypeName;
        }

        #endregion

        #region GetFileType

        public static string GetFileType(string path)
        {
            ShellFileInfo fileInfo = new ShellFileInfo();

            fileInfo.TypeName = new string(' ', 80);

            if (SHGetFileInfo(path, 0,
                ref fileInfo, Marshal.SizeOf(fileInfo), FileTypeFlags) != 0)
            {
                return (fileInfo.TypeName.Trim());
            }

            return ("");
        }

        #endregion

        #region GetFileImage

        public static Image GetFileImage(string path, bool largeIcon, bool extensionOnly)
        {
            string ext = GetExtension(path);

            if (largeIcon == true)
            {
                if (_SystemImages.LargeImageList.Images.ContainsKey(ext))
                    return (_SystemImages.LargeImageList.Images[ext]);
            }
            else
            {
                if (_SystemImages.SmallImageList.Images.ContainsKey(ext))
                    return (_SystemImages.SmallImageList.Images[ext]);
            }

            Icon icon = GetFileIcon(path, largeIcon, extensionOnly);

            if (icon != null)
            {
                Bitmap image = icon.ToBitmap();

                if (largeIcon == true)
                    _SystemImages.LargeImageList.Images.Add(ext, image);
                else
                    _SystemImages.SmallImageList.Images.Add(ext, image);

                return (image);
            }

            return (null);
        }

        #region GetExtension

        private static string GetExtension(string path)
        {
            FileInfo info = new FileInfo(path);

            string ext = info.Extension;

            if (String.IsNullOrEmpty(ext))
            {
                if ((info.Attributes & FileAttributes.Directory) != 0)
                    ext = "5EEB255733234c4dBECF9A128E896A1E";
                else
                    ext = "F9EB930C78D2477c80A51945D505E9C4";
            }
            else
            {
                if (ext.Equals(".exe", StringComparison.InvariantCultureIgnoreCase) ||
                    ext.Equals(".lnk", StringComparison.InvariantCultureIgnoreCase))
                {
                    ext = info.Name;
                }
            }

            return (ext);
        }

        #endregion

        #region GetFileIcon

        private static Icon GetFileIcon(string path, bool largeIcon, bool extensionOnly)
        {
            ShellFileInfo fileInfo = new ShellFileInfo();

            int flags = FileIconFlags |
                ((largeIcon == true) ? SHGFI_LARGEICON : SHGFI_SMALLICON);

            if (extensionOnly == true)
                flags |= SHGFI_USEFILEATTRIBUTES;

            if (SHGetFileInfo(path, 0x80,
                ref fileInfo, Marshal.SizeOf(fileInfo), flags) != 0)
            {
                IntPtr hIcon = new IntPtr(fileInfo.IconHandle);

                if (hIcon != (IntPtr)0)
                {
                    Icon myIcon = Icon.FromHandle(hIcon);

                    DeleteObject(hIcon);

                    return (myIcon);
                }
            }

            return (null);
        }

        #endregion

        #endregion

        #region LoadRtbText

        /// <summary>
        /// Loads the given RichTextBox from the given resource
        /// </summary>
        /// <param name="rtb"></param>
        /// <param name="resource"></param>
        public static void LoadRtbText(RichTextBoxEx rtb, string resource)
        {
            using (Stream stream =
                typeof(DemoGridBasics0).Assembly.GetManifestResourceStream(resource))
            {
                if (stream != null)
                {
                    using (StreamReader reader = new StreamReader(stream))
                        rtb.Rtf = reader.ReadToEnd();
                }
            }
        }

        #endregion

        #region LoadBitmap

        /// <summary>
        /// Loads a bitmap from the given resource
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static Bitmap LoadBitmap(string resource)
        {
            using (Stream stream =
                typeof(DemoGridBasics0).Assembly.GetManifestResourceStream(resource))
            {
                if (stream != null)
                    return (new Bitmap(stream));
            }

            return (null);
        }

        #endregion

        #region SystemImages

        private class SystemImages
        {
            public ImageList SmallImageList;
            public ImageList LargeImageList;

            public SystemImages()
            {
                SmallImageList = new ImageList();

                SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
                SmallImageList.ImageSize = SystemInformation.SmallIconSize;

                LargeImageList = new ImageList();

                LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
                LargeImageList.ImageSize = SystemInformation.IconSize;
            }
        }

        #endregion

        #region GetResource

        public static object GetResource(string resource)
        {
            return (typeof(DemoGridBasics0).Assembly.GetManifestResourceStream(resource));
        }

        #endregion
    }
}
