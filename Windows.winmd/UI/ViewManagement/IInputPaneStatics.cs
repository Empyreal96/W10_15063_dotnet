// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPaneStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InputPane))]
  [Guid(2515840826, 61255, 16970, 151, 65, 253, 40, 21, 235, 162, 189)]
  internal interface IInputPaneStatics
  {
    InputPane GetForCurrentView();
  }
}
