// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.IErrorReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  [ExclusiveTo(typeof (ErrorReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4240883545, 4739, 19850, 191, 223, 86, 107, 51, 221, 178, 143)]
  internal interface IErrorReceivedEventArgs
  {
    SerialError Error { get; }
  }
}
