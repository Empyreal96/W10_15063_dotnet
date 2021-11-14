// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPenFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarCustomPen))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3524580918, 61866, 20296, 191, 44, 169, 38, 202, 174, 76, 96)]
  [WebHostHidden]
  internal interface IInkToolbarCustomPenFactory
  {
    InkToolbarCustomPen CreateInstance(object outer, out object inner);
  }
}
