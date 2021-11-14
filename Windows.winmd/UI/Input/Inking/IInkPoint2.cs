// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPoint2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkPoint))]
  [Guid(4222206967, 44630, 19804, 189, 47, 10, 196, 95, 94, 74, 249)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkPoint2
  {
    float TiltX { get; }

    float TiltY { get; }

    ulong Timestamp { get; }
  }
}
