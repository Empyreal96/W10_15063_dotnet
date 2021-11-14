// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpListStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (JumpList))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2816525953, 59006, 19316, 130, 80, 63, 50, 44, 77, 146, 195)]
  internal interface IJumpListStatics
  {
    [RemoteAsync]
    IAsyncOperation<JumpList> LoadCurrentAsync();

    bool IsSupported();
  }
}
