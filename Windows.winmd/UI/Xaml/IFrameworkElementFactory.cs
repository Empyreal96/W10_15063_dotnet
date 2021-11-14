// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3736002854, 970, 18790, 181, 118, 96, 76, 206, 147, 181, 232)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameworkElement))]
  internal interface IFrameworkElementFactory
  {
    FrameworkElement CreateInstance(object outer, out object inner);
  }
}
