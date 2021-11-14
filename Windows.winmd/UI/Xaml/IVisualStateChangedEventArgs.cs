// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualStateChangedEventArgs))]
  [Guid(4263602865, 62239, 18321, 137, 137, 199, 14, 29, 155, 89, 255)]
  internal interface IVisualStateChangedEventArgs
  {
    VisualState OldState { get; set; }

    VisualState NewState { get; set; }

    Control Control { get; set; }
  }
}
