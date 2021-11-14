// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ICacheModeFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CacheMode))]
  [Guid(3944713307, 2747, 20080, 184, 168, 98, 13, 13, 149, 58, 178)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICacheModeFactory
  {
    CacheMode CreateInstance(object outer, out object inner);
  }
}
