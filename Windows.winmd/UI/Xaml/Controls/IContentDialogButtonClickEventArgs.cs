// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogButtonClickEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1597293061, 35578, 19698, 140, 160, 38, 77, 115, 190, 214, 61)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentDialogButtonClickEventArgs))]
  [WebHostHidden]
  internal interface IContentDialogButtonClickEventArgs
  {
    bool Cancel { get; set; }

    ContentDialogButtonClickDeferral GetDeferral();
  }
}
