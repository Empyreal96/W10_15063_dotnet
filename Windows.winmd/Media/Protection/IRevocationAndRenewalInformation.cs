// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IRevocationAndRenewalInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Guid(4087452539, 9473, 17310, 166, 231, 111, 201, 94, 23, 95, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RevocationAndRenewalInformation))]
  internal interface IRevocationAndRenewalInformation
  {
    IVector<RevocationAndRenewalItem> Items { get; }
  }
}
