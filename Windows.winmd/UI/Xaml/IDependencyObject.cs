// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [Guid(1548904037, 62990, 18706, 175, 89, 95, 224, 104, 15, 8, 157)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DependencyObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDependencyObject
  {
    object GetValue(DependencyProperty dp);

    void SetValue(DependencyProperty dp, object value);

    void ClearValue(DependencyProperty dp);

    object ReadLocalValue(DependencyProperty dp);

    object GetAnimationBaseValue(DependencyProperty dp);

    CoreDispatcher Dispatcher { get; }
  }
}
