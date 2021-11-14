// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ILocalContentSuggestionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4004425826, 29757, 17774, 132, 163, 35, 240, 111, 45, 21, 215)]
  [ExclusiveTo(typeof (LocalContentSuggestionSettings))]
  internal interface ILocalContentSuggestionSettings
  {
    bool Enabled { set; get; }

    IVector<StorageFolder> Locations { get; }

    string AqsFilter { set; get; }

    IVector<string> PropertiesToMatch { get; }
  }
}
