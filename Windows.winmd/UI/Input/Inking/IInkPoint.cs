// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkPoint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2676434731, 34188, 18085, 155, 65, 209, 149, 151, 4, 89, 253)]
  internal interface IInkPoint
  {
    Point Position { get; }

    float Pressure { get; }
  }
}
