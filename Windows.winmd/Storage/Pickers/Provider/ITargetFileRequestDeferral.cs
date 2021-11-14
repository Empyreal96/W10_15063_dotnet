// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.ITargetFileRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [Guid(1257151889, 48917, 19881, 149, 246, 246, 183, 213, 88, 34, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TargetFileRequestDeferral))]
  internal interface ITargetFileRequestDeferral
  {
    void Complete();
  }
}
