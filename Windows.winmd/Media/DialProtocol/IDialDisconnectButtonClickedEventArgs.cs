// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDisconnectButtonClickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [Guid(1383485778, 40065, 20053, 173, 194, 14, 190, 153, 205, 227, 182)]
  [ExclusiveTo(typeof (DialDisconnectButtonClickedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDialDisconnectButtonClickedEventArgs
  {
    DialDevice Device { get; }
  }
}
