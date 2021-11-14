// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDeviceSelectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialDeviceSelectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1208717997, 44150, 18411, 156, 6, 161, 147, 4, 218, 2, 71)]
  internal interface IDialDeviceSelectedEventArgs
  {
    DialDevice SelectedDialDevice { get; }
  }
}
