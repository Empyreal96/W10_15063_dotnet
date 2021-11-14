// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingOperationsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (BindingOperations))]
  [WebHostHidden]
  [Guid(3780505459, 38304, 19115, 140, 125, 42, 71, 218, 7, 60, 121)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBindingOperationsStatics
  {
    void SetBinding(DependencyObject target, DependencyProperty dp, BindingBase binding);
  }
}
