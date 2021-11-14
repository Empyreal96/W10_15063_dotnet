// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IHostedViewClosingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (HostedViewClosingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3526923324, 45646, 18320, 172, 181, 62, 66, 67, 196, 255, 135)]
  internal interface IHostedViewClosingEventArgs
  {
    Deferral GetDeferral();
  }
}
