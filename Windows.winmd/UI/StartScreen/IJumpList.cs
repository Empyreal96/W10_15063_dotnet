// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(2955103294, 52591, 19638, 166, 17, 97, 253, 80, 95, 62, 209)]
  [ExclusiveTo(typeof (JumpList))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IJumpList
  {
    IVector<JumpListItem> Items { get; }

    JumpListSystemGroupKind SystemGroupKind { get; set; }

    [RemoteAsync]
    IAsyncAction SaveAsync();
  }
}
