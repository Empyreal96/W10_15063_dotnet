// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyProperty
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [Guid(2242984304, 39876, 20118, 172, 241, 48, 200, 253, 61, 85, 200)]
  [ExclusiveTo(typeof (DependencyProperty))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDependencyProperty
  {
    PropertyMetadata GetMetadata(TypeName forType);
  }
}
