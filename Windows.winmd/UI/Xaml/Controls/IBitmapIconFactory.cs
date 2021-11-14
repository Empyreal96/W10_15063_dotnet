// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBitmapIconFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1188449053, 31305, 20326, 151, 41, 40, 72, 199, 136, 228, 2)]
  [ExclusiveTo(typeof (BitmapIcon))]
  [WebHostHidden]
  internal interface IBitmapIconFactory
  {
    BitmapIcon CreateInstance(object outer, out object inner);
  }
}
