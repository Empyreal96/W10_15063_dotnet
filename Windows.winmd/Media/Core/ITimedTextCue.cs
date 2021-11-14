// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1372036689, 15238, 18765, 179, 89, 187, 46, 167, 172, 169, 169)]
  [ExclusiveTo(typeof (TimedTextCue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextCue : IMediaCue
  {
    TimedTextRegion CueRegion { get; set; }

    TimedTextStyle CueStyle { get; set; }

    IVector<TimedTextLine> Lines { get; }
  }
}
