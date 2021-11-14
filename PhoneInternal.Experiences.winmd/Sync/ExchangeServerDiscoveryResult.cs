// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.ExchangeServerDiscoveryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Activatable(100859904)]
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ExchangeServerDiscoveryResult : IExchangeServerDiscoveryResult
  {
    [MethodImpl]
    public extern ExchangeServerDiscoveryResult();

    public extern string ServerName { [MethodImpl] get; }

    public extern string ServerEndPoint { [MethodImpl] get; }
  }
}
