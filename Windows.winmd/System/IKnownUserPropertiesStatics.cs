// Decompiled with JetBrains decompiler
// Type: Windows.System.IKnownUserPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (KnownUserProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2002096410, 28869, 18661, 182, 55, 91, 163, 68, 30, 78, 228)]
  internal interface IKnownUserPropertiesStatics
  {
    string DisplayName { get; }

    string FirstName { get; }

    string LastName { get; }

    string ProviderName { get; }

    string AccountName { get; }

    string GuestHost { get; }

    string PrincipalName { get; }

    string DomainName { get; }

    string SessionInitiationProtocolUri { get; }
  }
}
