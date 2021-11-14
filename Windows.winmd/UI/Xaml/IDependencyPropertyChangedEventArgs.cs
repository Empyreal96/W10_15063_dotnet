// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyPropertyChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DependencyPropertyChangedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2166434859, 9424, 18775, 171, 195, 34, 68, 112, 169, 58, 78)]
  internal interface IDependencyPropertyChangedEventArgs
  {
    DependencyProperty Property { get; }

    object OldValue { get; }

    object NewValue { get; }
  }
}
