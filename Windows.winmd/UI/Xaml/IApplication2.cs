// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplication2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(26281150, 21034, 22788, 245, 47, 222, 114, 1, 4, 41, 224)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Application))]
  internal interface IApplication2
  {
    FocusVisualKind FocusVisualKind { get; set; }

    ApplicationRequiresPointerMode RequiresPointerMode { get; set; }

    event LeavingBackgroundEventHandler LeavingBackground;

    event EnteredBackgroundEventHandler EnteredBackground;
  }
}
