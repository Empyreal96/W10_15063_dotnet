// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRowDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RowDefinition))]
  [WebHostHidden]
  [Guid(1253763113, 55308, 19038, 164, 140, 248, 179, 211, 182, 83, 61)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRowDefinition
  {
    GridLength Height { get; set; }

    double MaxHeight { get; set; }

    double MinHeight { get; set; }

    double ActualHeight { get; }
  }
}
