// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObjectFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2583932818, 32138, 18743, 136, 79, 236, 243, 79, 224, 42, 203)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DependencyObject))]
  internal interface IDependencyObjectFactory
  {
    DependencyObject CreateInstance(object outer, out object inner);
  }
}
