// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IRelativeSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (RelativeSource))]
  [Guid(4018377421, 17518, 20371, 170, 203, 155, 18, 85, 87, 116, 96)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IRelativeSourceFactory
  {
    RelativeSource CreateInstance(object outer, out object inner);
  }
}
