// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogClosedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2421498607, 11450, 19192, 182, 102, 204, 54, 194, 39, 50, 251)]
  [ExclusiveTo(typeof (ContentDialogClosedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IContentDialogClosedEventArgs
  {
    ContentDialogResult Result { get; }
  }
}
