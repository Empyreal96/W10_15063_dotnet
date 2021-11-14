// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ShellTileData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Windows.Data;

namespace Microsoft.Phone.Shell
{
  public abstract class ShellTileData
  {
    private const int MaxPropertyLength = 512;
    internal const string ShellContentRoot = "\\Shared\\ShellContent\\";

    internal ShellTileData()
    {
    }

    [SecuritySafeCritical]
    internal ShellTileData(string XMLContent) => this.Parse(XMLContent);

    [SecurityCritical]
    internal void Parse(string XMLContent)
    {
      if (Encoding.Unicode.GetByteCount(XMLContent) > 3072)
        throw new ArgumentException("XMLContent byte size cannot exceed 3072 Bytes");
      TokenPropertiesForTile tokenProperties = new TokenPropertiesForTile();
      SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.ParseInputXML(XMLContent, ref tokenProperties));
      if (tokenProperties.templateType != TileUtils.GetDataType(this))
        throw new ArgumentException("Tile data type in xmlContent is wrong");
      this.AssignProperties(tokenProperties);
    }

    internal abstract void AssignProperties(TokenPropertiesForTile tokenProperties);

    [Tile(PropertyId = TILE_PROPERTY_TYPE.TILE_PROPERTY_TITLE, ValueConverter = "Microsoft.Phone.Shell.StringToResourceConverter")]
    public string Title { get; set; }

    internal abstract short TemplateType { get; }

    internal abstract TILE_PROPERTY_TYPE[] TemplateTypeProperties { get; }

    internal void CheckForInvalidPath(Uri uri)
    {
      if (uri.IsAbsoluteUri && (string.CompareOrdinal(uri.Scheme, "appdata") == 0 || string.CompareOrdinal(uri.Scheme, "isostore") == 0))
        throw new ArgumentException("appdata:/ or isostore:/ path is not allowed in xmlContent.");
    }

    internal void SerializeToTile(ref TileStoreTile tile)
    {
      tile.PropertyCount = 0U;
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      foreach (PropertyInfo property in this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
      {
        foreach (Attribute customAttribute in property.GetCustomAttributes(true))
        {
          if (customAttribute is TileAttribute tileAttribute2 && ((IEnumerable<TILE_PROPERTY_TYPE>) this.TemplateTypeProperties).Contains<TILE_PROPERTY_TYPE>(tileAttribute2.PropertyId))
          {
            object obj = property.GetValue((object) this, (object[]) null);
            string str = tileAttribute2.DefaultValue;
            if (obj != null)
            {
              if (tileAttribute2.ValueConverter == null || tileAttribute2.ValueConverter.GetType() != typeof (UriToLocalStoreConverter))
                str = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}", obj);
              else
                str = (string) ((IValueConverter) Activator.CreateInstance(Type.GetType(tileAttribute2.ValueConverter))).Convert(obj, typeof (string), (object) null, CultureInfo.InvariantCulture);
            }
            if (str != null)
            {
              uint num = (uint) ((TILE_PROPERTY_TYPE) ((int) this.TemplateType << 16) | tileAttribute2.PropertyId);
              if (str.Length > 512)
                str = str.Substring(0, 512);
              stringList1.Add(num.ToString());
              stringList2.Add(str);
              ++tile.PropertyCount;
            }
          }
        }
      }
      tile.PropertyKeys = stringList1.ToArray();
      tile.PropertyValues = stringList2.ToArray();
    }

    internal static string GetLocalFilePath(Uri imageUri)
    {
      if (imageUri == (Uri) null)
        return (string) null;
      if (imageUri.OriginalString == string.Empty)
        return string.Empty;
      if (imageUri.ToString().StartsWith("file:"))
        throw new NotSupportedException(imageUri.ToString());
      ApplicationHost current = ApplicationHost.Current;
      string fullPath = Path.GetFullPath(current.GetFileSystemPath(imageUri.OriginalString));
      if (imageUri.IsAbsoluteUri && string.CompareOrdinal(imageUri.Scheme, "isostore") == 0)
      {
        if (!fullPath.StartsWith(current.AppIsolatedStorePath + "\\Shared\\ShellContent\\", StringComparison.OrdinalIgnoreCase))
          throw new NotSupportedException(imageUri.ToString());
      }
      else if (!fullPath.StartsWith(current.AppInstallFolder, StringComparison.OrdinalIgnoreCase))
        throw new NotSupportedException(imageUri.ToString());
      return Uri.UriSchemeFile + Uri.SchemeDelimiter + fullPath;
    }

    internal void SerializeToToken(IPMTileInfo token)
    {
      foreach (PropertyInfo property in this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
      {
        foreach (Attribute customAttribute in property.GetCustomAttributes(true))
        {
          if (customAttribute is TileAttribute tileAttribute2 && ((IEnumerable<TILE_PROPERTY_TYPE>) this.TemplateTypeProperties).Contains<TILE_PROPERTY_TYPE>(tileAttribute2.PropertyId))
          {
            object obj = property.GetValue((object) this, (object[]) null);
            string PropValue = tileAttribute2.DefaultValue;
            if (obj != null)
            {
              if (tileAttribute2.ValueConverter == null)
                PropValue = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}", obj);
              else
                PropValue = (string) ((IValueConverter) Activator.CreateInstance(Type.GetType(tileAttribute2.ValueConverter))).Convert(obj, typeof (string), (object) null, CultureInfo.InvariantCulture);
            }
            if (PropValue != null)
            {
              uint PropID = (uint) ((TILE_PROPERTY_TYPE) ((int) this.TemplateType << 16) | tileAttribute2.PropertyId);
              if (PropValue.Length > 512)
                PropValue = PropValue.Substring(0, 512);
              IPMTilePropertyInfo ppPropInfo;
              if (token.get_PropertyById(PropID, out ppPropInfo) == 0 && ppPropInfo != null)
                ppPropInfo.set_Property(PropValue);
            }
          }
        }
      }
    }
  }
}
