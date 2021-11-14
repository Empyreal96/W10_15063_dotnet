// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IJumpListItemForegroundConverter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(361819448, 50436, 18326, 166, 58, 91, 252, 158, 239, 170, 232)]
  [WebHostHidden]
  [ExclusiveTo(typeof (JumpListItemForegroundConverter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IJumpListItemForegroundConverter
  {
    Brush Enabled { get; set; }

    Brush Disabled { get; set; }
  }
}
