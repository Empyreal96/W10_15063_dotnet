// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfileFilter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  [Guid(3439759073, 50172, 20397, 157, 220, 89, 63, 170, 75, 120, 133)]
  [ExclusiveTo(typeof (ConnectionProfileFilter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectionProfileFilter2
  {
    IReference<bool> IsRoaming { set; get; }

    IReference<bool> IsOverDataLimit { set; get; }

    IReference<bool> IsBackgroundDataUsageRestricted { set; get; }

    IBuffer RawData { get; }
  }
}
