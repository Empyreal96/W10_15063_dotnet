// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISolidColorBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (SolidColorBrush))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2642741328, 26355, 18655, 154, 143, 130, 75, 213, 224, 112, 175)]
  internal interface ISolidColorBrush
  {
    Color Color { get; set; }
  }
}
