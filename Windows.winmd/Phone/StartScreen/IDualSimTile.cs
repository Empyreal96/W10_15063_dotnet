// Decompiled with JetBrains decompiler
// Type: Windows.Phone.StartScreen.IDualSimTile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.StartScreen
{
  [ExclusiveTo(typeof (DualSimTile))]
  [ContractVersion(typeof (DualSimTileContract), 65536)]
  [Guid(339390995, 53343, 16449, 161, 140, 62, 63, 203, 117, 180, 30)]
  internal interface IDualSimTile
  {
    string DisplayName { set; get; }

    bool IsPinnedToStart { get; }

    [RemoteAsync]
    IAsyncOperation<bool> CreateAsync();

    [RemoteAsync]
    IAsyncOperation<bool> UpdateAsync();

    [RemoteAsync]
    IAsyncOperation<bool> DeleteAsync();
  }
}
