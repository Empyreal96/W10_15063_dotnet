// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISetVersionDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SetVersionDeferral))]
  [Guid(53807266, 30746, 17274, 176, 120, 63, 50, 186, 220, 254, 71)]
  internal interface ISetVersionDeferral
  {
    void Complete();
  }
}
