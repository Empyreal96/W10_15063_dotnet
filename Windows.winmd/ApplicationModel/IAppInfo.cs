// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(3481229747, 27145, 19944, 166, 192, 87, 146, 213, 104, 128, 209)]
  [ExclusiveTo(typeof (AppInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppInfo
  {
    string Id { get; }

    string AppUserModelId { get; }

    AppDisplayInfo DisplayInfo { get; }

    string PackageFamilyName { get; }
  }
}
