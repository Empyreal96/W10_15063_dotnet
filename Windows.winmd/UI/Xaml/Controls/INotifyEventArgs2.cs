// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INotifyEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(219418454, 7630, 20429, 133, 188, 90, 85, 114, 39, 59, 156)]
  [ExclusiveTo(typeof (NotifyEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface INotifyEventArgs2
  {
    Uri CallingUri { get; }
  }
}
