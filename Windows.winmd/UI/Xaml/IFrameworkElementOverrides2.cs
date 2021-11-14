// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementOverrides2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(3411858105, 58292, 17804, 182, 78, 20, 52, 253, 27, 216, 138)]
  [ExclusiveTo(typeof (FrameworkElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkElementOverrides2
  {
    bool GoToElementStateCore(string stateName, bool useTransitions);
  }
}
