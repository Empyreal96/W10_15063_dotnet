// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObject2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(704567389, 15650, 17313, 173, 208, 23, 2, 124, 8, 178, 18)]
  [ExclusiveTo(typeof (DependencyObject))]
  [WebHostHidden]
  internal interface IDependencyObject2
  {
    long RegisterPropertyChangedCallback(
      DependencyProperty dp,
      DependencyPropertyChangedCallback callback);

    void UnregisterPropertyChangedCallback(DependencyProperty dp, long token);
  }
}
