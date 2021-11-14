// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceAutoAcceptSessionConnectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceAutoAcceptSessionConnectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3705266206, 33759, 17381, 143, 67, 203, 232, 71, 158, 132, 235)]
  internal interface IWiFiDirectServiceAutoAcceptSessionConnectedEventArgs
  {
    WiFiDirectServiceSession Session { get; }

    IBuffer SessionInfo { get; }
  }
}
