// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectivityInterval
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectivityInterval))]
  [Guid(1336557567, 26438, 18468, 169, 100, 238, 216, 232, 127, 135, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectivityInterval
  {
    DateTime StartTime { get; }

    TimeSpan ConnectionDuration { get; }
  }
}
