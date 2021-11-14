// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [Guid(1436242541, 49867, 17625, 131, 165, 96, 205, 164, 183, 29, 54)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public interface IVoipOperation
  {
    uint Id { get; }

    VoipOperationType Type { get; }
  }
}
