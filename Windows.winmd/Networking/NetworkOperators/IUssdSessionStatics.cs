// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IUssdSessionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (UssdSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(798674818, 4097, 19805, 191, 129, 42, 186, 27, 75, 228, 168)]
  internal interface IUssdSessionStatics
  {
    UssdSession CreateFromNetworkAccountId(string networkAccountId);

    UssdSession CreateFromNetworkInterfaceId(string networkInterfaceId);
  }
}
