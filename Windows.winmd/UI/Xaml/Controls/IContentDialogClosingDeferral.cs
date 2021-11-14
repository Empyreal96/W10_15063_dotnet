// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogClosingDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(559762705, 32304, 19641, 167, 16, 90, 79, 156, 202, 139, 66)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentDialogClosingDeferral))]
  internal interface IContentDialogClosingDeferral
  {
    void Complete();
  }
}
