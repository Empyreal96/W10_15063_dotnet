// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.TitleContainer
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Resources;

namespace Microsoft.Xna.Framework
{
  public static class TitleContainer
  {
    private static char[] badCharacters = new char[7]
    {
      ':',
      '*',
      '?',
      '"',
      '<',
      '>',
      '|'
    };

    public static Stream OpenStream(string name)
    {
      name = !string.IsNullOrEmpty(name) ? TitleContainer.GetCleanPath(name) : throw new ArgumentNullException(nameof (name));
      if (TitleContainer.IsCleanPathAbsolute(name))
        throw new ArgumentException(FrameworkResources.InvalidTitleContainerName);
      Uri uriResource;
      try
      {
        uriResource = new Uri(name.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar), UriKind.Relative);
      }
      catch (Exception ex)
      {
        throw new ArgumentException(FrameworkResources.InvalidTitleContainerName, ex);
      }
      StreamResourceInfo resourceStream;
      try
      {
        resourceStream = Application.GetResourceStream(uriResource);
      }
      catch (Exception ex)
      {
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OpenStreamError, (object) name), ex);
      }
      return resourceStream != null && resourceStream.Stream != null ? resourceStream.Stream : throw new FileNotFoundException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OpenStreamNotFound, (object) name));
    }

    internal static bool IsPathAbsolute(string path)
    {
      path = TitleContainer.GetCleanPath(path);
      return TitleContainer.IsCleanPathAbsolute(path);
    }

    internal static string GetCleanPath(string path)
    {
      path = path.Replace('/', '\\');
      path = path.Replace("\\.\\", "\\");
      while (path.StartsWith(".\\"))
        path = path.Substring(".\\".Length);
      while (path.EndsWith("\\."))
        path = path.Length <= "\\.".Length ? "\\" : path.Substring(0, path.Length - "\\.".Length);
      int position1;
      for (int startIndex = 1; startIndex < path.Length; startIndex = TitleContainer.CollapseParentDirectory(ref path, position1, "\\..\\".Length))
      {
        position1 = path.IndexOf("\\..\\", startIndex);
        if (position1 < 0)
          break;
      }
      if (path.EndsWith("\\.."))
      {
        int position2 = path.Length - "\\..".Length;
        if (position2 > 0)
          TitleContainer.CollapseParentDirectory(ref path, position2, "\\..".Length);
      }
      if (path == ".")
        path = string.Empty;
      return path;
    }

    private static int CollapseParentDirectory(ref string path, int position, int removeLength)
    {
      int startIndex = path.LastIndexOf('\\', position - 1) + 1;
      ref string local = ref path;
      local = local.Remove(startIndex, position - startIndex + removeLength);
      return Math.Max(startIndex - 1, 1);
    }

    private static bool IsCleanPathAbsolute(string path) => path.IndexOfAny(TitleContainer.badCharacters) >= 0 || path.StartsWith("\\") || (path.StartsWith("..\\") || path.Contains("\\..\\")) || (path.EndsWith("\\..") || path == "..");
  }
}
