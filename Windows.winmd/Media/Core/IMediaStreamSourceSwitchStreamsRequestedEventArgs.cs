// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSwitchStreamsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1109404530, 28321, 18039, 152, 30, 53, 10, 13, 164, 18, 170)]
  [ExclusiveTo(typeof (MediaStreamSourceSwitchStreamsRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaStreamSourceSwitchStreamsRequestedEventArgs
  {
    MediaStreamSourceSwitchStreamsRequest Request { get; }
  }
}
