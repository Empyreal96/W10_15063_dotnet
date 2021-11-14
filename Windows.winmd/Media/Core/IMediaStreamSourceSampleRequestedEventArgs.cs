// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSampleRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceSampleRequestedEventArgs))]
  [Guid(284801950, 29125, 18735, 132, 127, 13, 161, 243, 94, 129, 248)]
  internal interface IMediaStreamSourceSampleRequestedEventArgs
  {
    MediaStreamSourceSampleRequest Request { get; }
  }
}
