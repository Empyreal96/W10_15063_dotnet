// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStackPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (StackPanel))]
  [Guid(3098447842, 54849, 20439, 128, 180, 116, 57, 32, 125, 39, 152)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStackPanel
  {
    bool AreScrollSnapPointsRegular { get; set; }

    Orientation Orientation { get; set; }
  }
}
