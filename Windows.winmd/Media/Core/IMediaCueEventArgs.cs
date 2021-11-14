// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaCueEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCueEventArgs))]
  [Guid(3509536759, 24484, 20072, 159, 229, 50, 22, 13, 206, 229, 126)]
  internal interface IMediaCueEventArgs
  {
    IMediaCue Cue { get; }
  }
}
