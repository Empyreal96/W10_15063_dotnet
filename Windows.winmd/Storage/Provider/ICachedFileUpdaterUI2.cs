// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ICachedFileUpdaterUI2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ExclusiveTo(typeof (CachedFileUpdaterUI))]
  [Guid(2287378972, 34457, 17216, 159, 73, 247, 202, 215, 254, 137, 145)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICachedFileUpdaterUI2 : ICachedFileUpdaterUI
  {
    FileUpdateRequest UpdateRequest { get; }

    FileUpdateRequestDeferral GetDeferral();
  }
}
