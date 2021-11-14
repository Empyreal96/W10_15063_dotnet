// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ShellTile
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using Windows.Internal.LegacyLiveTile;

namespace Microsoft.Phone.Shell
{
  public sealed class ShellTile
  {
    internal static readonly Uri DEFAULT = new Uri("/", UriKind.Relative);
    private string id;
    private string tileStoreId;
    private static EventHandler<ActivatedEventArgs> activateEventHandler = (EventHandler<ActivatedEventArgs>) null;
    private static Guid AppProductId = Guid.Empty;
    private static readonly char[] s_escapeChars = new char[5]
    {
      '<',
      '>',
      '"',
      '\'',
      '&'
    };

    internal ShellTile(
      string tileId,
      string invocationUri,
      bool isDefault,
      string tileStoreTileId)
    {
      this.NavigationUri = !isDefault ? new Uri(invocationUri, UriKind.Relative) : ShellTile.DEFAULT;
      this.id = tileId;
      this.tileStoreId = tileStoreTileId;
    }

    internal ShellTile(string tileId, string invocationUri, string tileStoreTileId)
      : this(tileId, invocationUri, false, tileStoreTileId)
    {
    }

    internal static string GetHash(string input)
    {
      if (input.Length <= 64)
        return input;
      byte[] hash = new SHA256Managed().ComputeHash(Encoding.Unicode.GetBytes(input));
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < hash.Length; ++index)
        stringBuilder.Append(hash[index].ToString("x2"));
      return stringBuilder.ToString();
    }

    public Uri NavigationUri { get; private set; }

    internal string Id => this.id;

    public static IEnumerable<ShellTile> ActiveTiles => (IEnumerable<ShellTile>) new ShellTileEnumerator();

    private static void Application_Activated(object sender, ActivatedEventArgs e)
    {
    }

    [SecuritySafeCritical]
    public static void Create(Uri navigationUri, ShellTileData initialData)
    {
      if (TileUtils.GetDataType(initialData) != DataType.StandardData)
        throw new InvalidOperationException("initialData can be only of type StandardTileData. \nFor all other types, please, use public static void Create(Uri navigationUri, ShellTileData initialData, bool supportsWideTile");
      ShellTile.Create(navigationUri, initialData, false);
    }

    [SecuritySafeCritical]
    public static void Create(Uri navigationUri, ShellTileData initialData, bool supportsWideTile)
    {
      if (ShellTile.CheckForInLockdownMode())
        return;
      if (navigationUri == (Uri) null)
        throw new ArgumentNullException(nameof (navigationUri));
      if (initialData == null)
        throw new ArgumentNullException(nameof (initialData));
      if (ShellTile.DEFAULT.Equals((object) navigationUri))
        throw new ArgumentOutOfRangeException(nameof (navigationUri));
      if (navigationUri.IsAbsoluteUri)
        throw new ArgumentException("navigationUri cannot be absolute");
      if (navigationUri.ToString().IndexOf('/') != 0 && navigationUri.ToString().IndexOf('?') != 0)
        throw new UriFormatException();
      if (PhoneApplicationService.Current != null && ShellTile.activateEventHandler == null)
      {
        ShellTile.activateEventHandler = new EventHandler<ActivatedEventArgs>(ShellTile.Application_Activated);
        PhoneApplicationService.Current.Activated += ShellTile.activateEventHandler;
      }
      DataType? dataType1 = new DataType?(TileUtils.GetDataType(initialData));
      DataType? nullable1 = dataType1;
      DataType dataType2 = DataType.StandardData;
      if (((nullable1.GetValueOrDefault() == dataType2 ? (nullable1.HasValue ? 1 : 0) : 0) & (supportsWideTile ? 1 : 0)) != 0)
        throw new ArgumentException("Cannot create tile with StandardTileData and supportsWideTile == true");
      string TaskParameters = navigationUri.ToString();
      if (navigationUri.ToString().IndexOf('/') == 0)
        TaskParameters = "#" + navigationUri.ToString();
      string hash = ShellTile.GetHash(navigationUri.ToString());
      if (SafeNativeMethods.IsTileStoreWriteEnabled())
      {
        bool exists;
        SafeNativeMethods.ShellTileExists(ShellTile.ProductId, hash, out exists);
        if (exists)
          throw new InvalidOperationException();
        TileStoreTile tile = new TileStoreTile();
        tile.TemplateType = (uint) initialData.TemplateType;
        tile.IsPrimary = false;
        tile.TileId = hash;
        tile.Arguments = TaskParameters;
        initialData.SerializeToTile(ref tile);
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.ShellTileCreate(ShellTile.ProductId, ref tile), (Exception) new InvalidOperationException());
      }
      IPMTileInfo ppTileInfo = (IPMTileInfo) null;
      if (ShellTile.EnumManager.get_TileInfo(ShellTile.ProductId, hash, out ppTileInfo) == 0)
        throw new InvalidOperationException();
      IPMTileInfo ppTile = (IPMTileInfo) null;
      int hr = ShellTile.TileManager.ConstructTile(ShellTile.ProductId, hash, (TILE_TEMPLATE_TYPE) initialData.TemplateType, PM_TILE_HUBTYPE.PM_TILE_HUBTYPE_STARTMENU, out ppTile);
      if (hr == 0 && ppTile != null)
      {
        initialData.SerializeToToken(ppTile);
        ppTile.set_InvocationInfo(string.Empty, TaskParameters);
        DataType? nullable2 = dataType1;
        DataType dataType3 = DataType.StandardData;
        if ((nullable2.GetValueOrDefault() == dataType3 ? (!nullable2.HasValue ? 1 : 0) : 1) != 0)
        {
          uint PropID = (uint) ((int) initialData.TemplateType << 16 | 55);
          IPMTilePropertyInfo ppPropInfo;
          if (ppTile.get_PropertyById(PropID, out ppPropInfo) == 0 && ppPropInfo != null)
            ppPropInfo.set_Property(supportsWideTile.ToString());
        }
        hr = ShellTile.TileManager.CommitTileExternal(ppTile);
      }
      SafeNativeMethods.ThrowExceptionFromHResult(hr, (Exception) new InvalidOperationException());
      if (!TileUtils.IsTileContainsRemoteUri(dataType1, initialData))
        return;
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      TileUtils.ConstructXMLCreate(dataType1, initialData, hash, supportsWideTile, ref empty1, ref empty2);
      byte[] asciiByte1 = TileUtils.HardConvertUnicodeToASCIIByte(empty1);
      byte[] asciiByte2 = TileUtils.HardConvertUnicodeToASCIIByte(empty2);
      ShellTile.LegacyLiveTileJobManagerSingleton.Instance.AddLiveTileRequest(ShellTile.ProductId, hash, (LegacyLiveTileRecurrenceType) 0, true, asciiByte1, asciiByte2);
    }

    [SecuritySafeCritical]
    public void Update(ShellTileData data)
    {
      int hr = 0;
      if (data == null)
        throw new ArgumentNullException("ShellTileData data");
      if (SafeNativeMethods.IsTileStoreWriteEnabled())
      {
        IntPtr tile;
        bool found;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.ShellTileTryGet(ShellTile.ProductId, this.tileStoreId, out tile, out found), (Exception) new InvalidOperationException());
        if (!found)
          throw new InvalidOperationException();
        TileStoreTile structure = (TileStoreTile) Marshal.PtrToStructure(tile, typeof (TileStoreTile));
        if ((long) structure.TemplateType != (long) data.TemplateType)
          throw new ArgumentException(LocalizeString.ShellTileTemplateMismatch);
        data.SerializeToTile(ref structure);
        hr = SafeNativeMethods.ShellTileUpdate(ShellTile.ProductId, ref structure);
        SafeNativeMethods.ThrowExceptionFromHResult(hr, (Exception) new InvalidOperationException());
      }
      IPMTileInfo ppTileInfo1 = (IPMTileInfo) null;
      IPMTileInfo ppTileInfo2 = (IPMTileInfo) null;
      if (ShellTile.EnumManager.get_TileInfo(ShellTile.ProductId, this.id, out ppTileInfo2) != 0)
        throw new InvalidOperationException();
      TILE_TEMPLATE_TYPE pTemplateType;
      ppTileInfo2.get_TemplateType(out pTemplateType);
      if (pTemplateType != (TILE_TEMPLATE_TYPE) data.TemplateType)
        throw new ArgumentException(LocalizeString.ShellTileTemplateMismatch);
      DataType? dataType = new DataType?(TileUtils.GetDataType(data));
      if (TileUtils.IsTileContainsRemoteUri(dataType, data))
      {
        string empty1 = string.Empty;
        string empty2 = string.Empty;
        TileUtils.ConstructXMLUpdate(dataType, data, this.id, (Uri) null, ref empty1, ref empty2);
        byte[] asciiByte1 = TileUtils.HardConvertUnicodeToASCIIByte(empty1);
        byte[] asciiByte2 = TileUtils.HardConvertUnicodeToASCIIByte(empty2);
        ShellTile.LegacyLiveTileJobManagerSingleton.Instance.AddLiveTileRequest(ShellTile.ProductId, this.id, (LegacyLiveTileRecurrenceType) 0, true, asciiByte1, asciiByte2);
      }
      else
      {
        int num = 0;
        do
        {
          ppTileInfo1 = (IPMTileInfo) null;
          hr = ShellTile.EnumManager.get_TileInfo(ShellTile.ProductId, this.id, out ppTileInfo1);
          if (hr == 0)
          {
            data.SerializeToToken(ppTileInfo1);
            hr = ShellTile.TileManager.CommitTileExternal(ppTileInfo1);
          }
          else
            break;
        }
        while (hr == -2147024599 && ++num == 1);
      }
      SafeNativeMethods.ThrowExceptionFromHResult(hr);
      bool pIsDefault = false;
      bool pIsVisible = false;
      if (ppTileInfo1 == null)
        ShellTile.EnumManager.get_TileInfo(ShellTile.ProductId, this.id, out ppTileInfo1);
      if (ppTileInfo1 == null)
        return;
      ppTileInfo1.get_IsDefault(out pIsDefault);
      if (pIsDefault)
        ppTileInfo1.get_HubPinnedState(PM_TILE_HUBTYPE.PM_TILE_HUBTYPE_STARTMENU | PM_TILE_HUBTYPE.PM_TILE_HUBTYPE_LOCKSCREEN | PM_TILE_HUBTYPE.PM_TILE_HUBTYPE_KIDZONE, out pIsVisible);
      else
        pIsVisible = true;
      if (!pIsVisible)
        return;
      SafeNativeMethods.BNSIUpdateExpiryTime();
    }

    [SecuritySafeCritical]
    public void Delete()
    {
      if (ShellTile.CheckForInLockdownMode())
        return;
      SafeNativeMethods.ThrowExceptionFromHResult(ShellTile.TileManager.DeleteTile(ShellTile.ProductId, this.id));
      if (!SafeNativeMethods.IsTileStoreWriteEnabled())
        return;
      SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.ShellTileDelete(ShellTile.ProductId, this.tileStoreId));
    }

    [SecuritySafeCritical]
    private static bool CheckForInLockdownMode()
    {
      bool fIsInLockdownMode = false;
      SafeNativeMethods.IsAppRunningInLockdownMode(out fIsInLockdownMode);
      return fIsInLockdownMode;
    }

    internal static IPMTileManager TileManager => ShellTile.TileManagerSingleton.Instance;

    internal static IPMEnumerationManager EnumManager => ShellTile.EnumerationManagerSingleton.Instance;

    public static string ConvertToXMLFormat(string str)
    {
      if (str == null)
        return (string) null;
      StringBuilder stringBuilder = (StringBuilder) null;
      string str1 = str;
      while (true)
      {
        int num = str1.IndexOfAny(ShellTile.s_escapeChars);
        if (num != -1)
        {
          if (stringBuilder == null)
            stringBuilder = new StringBuilder();
          stringBuilder.Append(str1.Substring(0, num));
          stringBuilder.Append(ShellTile.GetEscapeSequence(str1[num]));
          str1 = str1.Substring(num + 1);
        }
        else
          break;
      }
      if (stringBuilder == null)
        return str;
      stringBuilder.Append(str1);
      return stringBuilder.ToString();
    }

    internal static Guid ProductId
    {
      [SecuritySafeCritical] get
      {
        if (ShellTile.AppProductId == Guid.Empty)
          ShellTile.AppProductId = new Guid(ApplicationHost.Current.ProductId);
        return ShellTile.AppProductId;
      }
    }

    private static bool IsRemoteUri(Uri uriTobeExamine) => uriTobeExamine.IsAbsoluteUri && uriTobeExamine.Scheme == "http";

    private static string GetEscapeSequence(char c)
    {
      switch (c)
      {
        case '"':
          return "&quot;";
        case '&':
          return "&amp;";
        case '\'':
          return "&apos;";
        case '<':
          return "&lt;";
        case '>':
          return "&gt;";
        default:
          return c.ToString();
      }
    }

    private class TileManagerSingleton
    {
      [SecuritySafeCritical]
      internal static IPMTileManager Instance = (IPMTileManager) new PMTileManager();

      [SecuritySafeCritical]
      static TileManagerSingleton()
      {
      }
    }

    private class EnumerationManagerSingleton
    {
      [SecuritySafeCritical]
      internal static IPMEnumerationManager Instance = (IPMEnumerationManager) new PMEnumerationManager();

      [SecuritySafeCritical]
      static EnumerationManagerSingleton()
      {
      }
    }

    private class LegacyLiveTileJobManagerSingleton
    {
      [SecuritySafeCritical]
      internal static WinRTLegacyLiveTileJobManager Instance = new WinRTLegacyLiveTileJobManager();

      [SecuritySafeCritical]
      static LegacyLiveTileJobManagerSingleton()
      {
      }
    }
  }
}
