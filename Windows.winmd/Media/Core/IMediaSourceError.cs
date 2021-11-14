// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1544194405, 14277, 20125, 141, 33, 28, 222, 233, 12, 236, 198)]
  [ExclusiveTo(typeof (MediaSourceError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaSourceError
  {
    HResult ExtendedError { get; }
  }
}
