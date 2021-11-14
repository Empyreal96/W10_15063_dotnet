// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.ITouchCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TouchCapabilities))]
  [Guid(551376377, 5105, 18120, 146, 133, 44, 5, 250, 62, 218, 111)]
  internal interface ITouchCapabilities
  {
    int TouchPresent { get; }

    uint Contacts { get; }
  }
}
