// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INotifyEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2936931831, 50359, 17605, 176, 157, 92, 183, 5, 43, 58, 151)]
  [ExclusiveTo(typeof (NotifyEventArgs))]
  internal interface INotifyEventArgs
  {
    string Value { get; }
  }
}
