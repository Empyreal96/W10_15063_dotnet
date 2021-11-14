// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.MessageReceivedHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4020963202, 63202, 18037, 160, 69, 216, 227, 32, 194, 72, 8)]
  public delegate void MessageReceivedHandler(ProximityDevice sender, ProximityMessage message);
}
