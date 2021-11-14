// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISetterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3553246530, 2481, 18901, 136, 145, 231, 181, 100, 142, 2, 162)]
  [ExclusiveTo(typeof (Setter))]
  internal interface ISetterFactory
  {
    Setter CreateInstance(DependencyProperty targetProperty, object value);
  }
}
