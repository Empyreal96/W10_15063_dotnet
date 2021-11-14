// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributes3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(1912733698, 32091, 18064, 138, 244, 230, 100, 203, 226, 183, 79)]
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkDrawingAttributes3
  {
    InkDrawingAttributesKind Kind { get; }

    InkDrawingAttributesPencilProperties PencilProperties { get; }
  }
}
