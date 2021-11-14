// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSwitchStreamsRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3202603061, 42245, 20378, 185, 67, 43, 140, 177, 180, 187, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceSwitchStreamsRequestDeferral))]
  internal interface IMediaStreamSourceSwitchStreamsRequestDeferral
  {
    void Complete();
  }
}
