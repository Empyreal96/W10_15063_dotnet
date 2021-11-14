// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogClosingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3678149684, 15295, 18388, 190, 79, 201, 236, 17, 89, 24, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentDialogClosingEventArgs))]
  internal interface IContentDialogClosingEventArgs
  {
    ContentDialogResult Result { get; }

    bool Cancel { get; set; }

    ContentDialogClosingDeferral GetDeferral();
  }
}
