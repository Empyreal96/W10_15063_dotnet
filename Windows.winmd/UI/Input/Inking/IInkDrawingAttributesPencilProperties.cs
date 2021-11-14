// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributesPencilProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkDrawingAttributesPencilProperties))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1327838411, 11654, 16827, 176, 232, 228, 194, 160, 37, 60, 82)]
  internal interface IInkDrawingAttributesPencilProperties
  {
    double Opacity { get; set; }
  }
}
