// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimedMetadataTrackError))]
  [Guid(3010885909, 16660, 18457, 185, 217, 221, 118, 8, 158, 114, 248)]
  internal interface ITimedMetadataTrackError
  {
    TimedMetadataTrackErrorCode ErrorCode { get; }

    HResult ExtendedError { get; }
  }
}
