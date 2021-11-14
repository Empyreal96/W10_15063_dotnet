// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkInputProcessingConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkInputProcessingConfiguration))]
  [Guid(662231134, 13258, 19206, 166, 211, 172, 57, 69, 17, 109, 55)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkInputProcessingConfiguration
  {
    InkInputProcessingMode Mode { get; set; }

    InkInputRightDragAction RightDragAction { get; set; }
  }
}
