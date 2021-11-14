// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IRelativeSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RelativeSource))]
  [Guid(597151364, 10274, 18490, 180, 153, 208, 240, 49, 224, 108, 107)]
  [WebHostHidden]
  internal interface IRelativeSource
  {
    RelativeSourceMode Mode { get; set; }
  }
}
