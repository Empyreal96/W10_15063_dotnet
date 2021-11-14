// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerVisualizationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1293837409, 34039, 18845, 189, 145, 42, 54, 226, 183, 170, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PointerVisualizationSettings))]
  internal interface IPointerVisualizationSettings
  {
    bool IsContactFeedbackEnabled { set; get; }

    bool IsBarrelButtonFeedbackEnabled { set; get; }
  }
}
