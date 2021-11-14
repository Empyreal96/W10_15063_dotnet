// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ShellTileEnumerator
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell
{
  internal sealed class ShellTileEnumerator : 
    IEnumerable<ShellTile>,
    IEnumerable,
    IEnumerator<ShellTile>,
    IEnumerator,
    IDisposable
  {
    private IPMTileInfoEnumerator tokenIdEnum;
    private TileStoreTile[] m_tiles;
    private uint m_index;
    private ShellTile current;
    private bool first = true;

    [SecuritySafeCritical]
    internal ShellTileEnumerator()
    {
    }

    public void Dispose()
    {
    }

    public ShellTile Current => this.current;

    object IEnumerator.Current => (object) this.current;

    public IEnumerator<ShellTile> GetEnumerator() => (IEnumerator<ShellTile>) this;

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this;

    private int GetAllTiles()
    {
      IntPtr tiles;
      uint count;
      int all = SafeNativeMethods.ShellTileGetAll(ShellTile.ProductId, out tiles, out count);
      if (all == 0)
      {
        IntPtr ptr = tiles;
        this.m_tiles = new TileStoreTile[(int) count];
        for (uint index = 0; index < count; ++index)
        {
          this.m_tiles[(int) index] = (TileStoreTile) Marshal.PtrToStructure(ptr, typeof (TileStoreTile));
          ptr = IntPtr.op_Addition(ptr, Marshal.SizeOf((object) this.m_tiles[(int) index]));
        }
      }
      return all;
    }

    [SecuritySafeCritical]
    public bool MoveNext()
    {
      int num = 0;
      TileStoreTile tile;
      tile.TileId = (string) null;
      if (SafeNativeMethods.IsTileStoreWriteEnabled())
      {
        if (this.first)
        {
          this.m_index = 0U;
          num = this.GetAllTiles();
          if (num != 0)
            return false;
        }
        if ((long) this.m_index < (long) this.m_tiles.Length)
        {
          if (SafeNativeMethods.IsTileStoreReadEnabled())
            this.first = false;
          tile = this.m_tiles[(int) this.m_index++];
          string invocationUri = tile.Arguments;
          if (tile.IsPrimary && invocationUri != null && invocationUri.ToString().IndexOf('#') == 0)
            invocationUri = invocationUri.Substring(1);
          if (SafeNativeMethods.IsTileStoreReadEnabled())
          {
            this.current = new ShellTile(tile.TileId, invocationUri, tile.IsPrimary, tile.TileId);
            return true;
          }
        }
        if (SafeNativeMethods.IsTileStoreReadEnabled())
          return false;
      }
      IPMTileInfo ppTileInfo = (IPMTileInfo) null;
      if (this.first)
      {
        if (ShellTile.EnumManager.get_TileInfo(ShellTile.ProductId, "", out ppTileInfo) != 0 || ppTileInfo == null)
          return false;
        PM_ENUM_TILE_FILTER_APP_ALL Filter = new PM_ENUM_TILE_FILTER_APP_ALL();
        Filter.init();
        Filter.TileProductID = ShellTile.ProductId;
        num = ShellTile.EnumManager.get_AllTiles(out this.tokenIdEnum, Filter);
        if (num != 0 || this.tokenIdEnum == null)
          return false;
        this.first = false;
      }
      else
      {
        while (num == 0)
        {
          ppTileInfo = (IPMTileInfo) null;
          num = this.tokenIdEnum.get_Next(out ppTileInfo);
          if (num == 0 && ppTileInfo != null)
          {
            bool pIsVisible = false;
            bool pIsDefault = false;
            ppTileInfo.get_HubPinnedState(PM_TILE_HUBTYPE.PM_TILE_HUBTYPE_STARTMENU, out pIsVisible);
            ppTileInfo.get_IsDefault(out pIsDefault);
            if (pIsVisible && !pIsDefault)
              break;
          }
        }
      }
      if (num != 0 || ppTileInfo == null)
        return false;
      bool pIsDefault1 = false;
      string pTileID;
      ppTileInfo.get_TileID(out pTileID);
      string pParameters;
      ppTileInfo.get_InvocationInfo(out string _, out pParameters);
      ppTileInfo.get_IsDefault(out pIsDefault1);
      if (pIsDefault1)
      {
        this.current = new ShellTile(pTileID, pParameters, true, tile.TileId ?? pTileID);
      }
      else
      {
        if (pParameters.ToString().IndexOf('#') == 0)
          pParameters = pParameters.Substring(1);
        this.current = new ShellTile(pTileID, pParameters, tile.TileId ?? pTileID);
      }
      return true;
    }

    [SecuritySafeCritical]
    public void Reset() => this.first = true;
  }
}
