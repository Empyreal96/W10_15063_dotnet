// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IDeferralFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (Deferral))]
  [Guid(1705110725, 16309, 18482, 140, 169, 240, 97, 178, 129, 209, 58)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  internal interface IDeferralFactory
  {
    Deferral Create(DeferralCompletedHandler handler);
  }
}
