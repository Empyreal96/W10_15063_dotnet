// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IExchangeServerDiscoveryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [ExclusiveTo(typeof (ExchangeServerDiscoveryResult))]
  [Version(100859904)]
  [Guid(4169499137, 54598, 16678, 164, 227, 103, 54, 202, 89, 0, 213)]
  internal interface IExchangeServerDiscoveryResult
  {
    string ServerName { get; }

    string ServerEndPoint { get; }
  }
}
