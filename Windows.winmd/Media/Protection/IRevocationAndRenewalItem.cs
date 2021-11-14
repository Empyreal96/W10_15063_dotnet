// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IRevocationAndRenewalItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RevocationAndRenewalItem))]
  [Guid(815383052, 15600, 18922, 144, 45, 202, 243, 45, 45, 222, 44)]
  internal interface IRevocationAndRenewalItem
  {
    RevocationAndRenewalReasons Reasons { get; }

    string HeaderHash { get; }

    string PublicKeyHash { get; }

    string Name { get; }

    string RenewalId { get; }
  }
}
