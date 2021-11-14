// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IJumpListItemBackgroundConverter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (JumpListItemBackgroundConverter))]
  [WebHostHidden]
  [Guid(2165799000, 53796, 16652, 177, 108, 197, 182, 187, 97, 136, 178)]
  internal interface IJumpListItemBackgroundConverter
  {
    Brush Enabled { get; set; }

    Brush Disabled { get; set; }
  }
}
