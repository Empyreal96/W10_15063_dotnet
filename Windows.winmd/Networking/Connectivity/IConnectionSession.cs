// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4287651148, 63547, 16816, 138, 12, 20, 98, 217, 197, 107, 115)]
  [ExclusiveTo(typeof (ConnectionSession))]
  internal interface IConnectionSession : IClosable
  {
    ConnectionProfile ConnectionProfile { get; }
  }
}
