// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.SignalHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2453422126, 18209, 17422, 157, 218, 85, 182, 242, 224, 119, 16)]
  [WebHostHidden]
  public delegate void SignalHandler(SignalNotifier signalNotifier, bool timedOut);
}
