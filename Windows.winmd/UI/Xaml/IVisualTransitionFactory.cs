// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualTransitionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualTransition))]
  [Guid(3933570639, 53728, 19886, 180, 41, 137, 252, 50, 39, 36, 244)]
  internal interface IVisualTransitionFactory
  {
    VisualTransition CreateInstance(object outer, out object inner);
  }
}
