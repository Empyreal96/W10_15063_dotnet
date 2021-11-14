// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (Deferral))]
  [Guid(3592853298, 15231, 18087, 180, 11, 79, 220, 162, 162, 198, 147)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  internal interface IDeferral : IClosable
  {
    void Complete();
  }
}
