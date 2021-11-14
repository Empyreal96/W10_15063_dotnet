// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStroke3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkStroke))]
  [Guid(1249932148, 38041, 16669, 161, 196, 104, 133, 93, 3, 214, 95)]
  internal interface IInkStroke3
  {
    uint Id { get; }

    IReference<DateTime> StrokeStartedTime { get; set; }

    IReference<TimeSpan> StrokeDuration { get; set; }
  }
}
