// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSourceResolveResultEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimedTextSourceResolveResultEventArgs))]
  [Guid(1217428636, 56536, 19507, 154, 211, 108, 220, 231, 177, 197, 102)]
  internal interface ITimedTextSourceResolveResultEventArgs
  {
    TimedMetadataTrackError Error { get; }

    IVectorView<TimedMetadataTrack> Tracks { get; }
  }
}
