// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IImage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Image))]
  [Guid(4098167198, 34847, 18619, 135, 58, 100, 65, 124, 164, 240, 2)]
  [WebHostHidden]
  internal interface IImage2
  {
    CastingSource GetAsCastingSource();
  }
}
