// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyInvokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3488206231, 50968, 16529, 183, 221, 173, 241, 192, 114, 177, 225)]
  [ExclusiveTo(typeof (AccessKeyInvokedEventArgs))]
  [WebHostHidden]
  internal interface IAccessKeyInvokedEventArgs
  {
    bool Handled { get; set; }
  }
}
