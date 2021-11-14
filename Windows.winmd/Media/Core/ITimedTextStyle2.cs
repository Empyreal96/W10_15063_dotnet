// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextStyle2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1700743469, 24849, 18311, 137, 204, 104, 111, 236, 229, 126, 20)]
  [ExclusiveTo(typeof (TimedTextStyle))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ITimedTextStyle2
  {
    TimedTextFontStyle FontStyle { get; set; }

    bool IsUnderlineEnabled { get; set; }

    bool IsLineThroughEnabled { get; set; }

    bool IsOverlineEnabled { get; set; }
  }
}
