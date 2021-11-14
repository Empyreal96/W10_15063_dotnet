// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSubformat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3608367151, 12897, 18210, 160, 194, 185, 55, 178, 57, 15, 20)]
  [ExclusiveTo(typeof (TimedTextSubformat))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextSubformat
  {
    int StartIndex { get; set; }

    int Length { get; set; }

    TimedTextStyle SubformatStyle { get; set; }
  }
}
