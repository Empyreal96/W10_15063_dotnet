// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSampleRenderedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaStreamSourceSampleRenderedEventArgs))]
  [Guid(2640935685, 54514, 19578, 157, 254, 141, 108, 208, 179, 238, 132)]
  internal interface IMediaStreamSourceSampleRenderedEventArgs
  {
    TimeSpan SampleLag { get; }
  }
}
