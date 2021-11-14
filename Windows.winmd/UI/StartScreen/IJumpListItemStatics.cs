// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpListItemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(4055876840, 51114, 18891, 141, 222, 236, 252, 205, 122, 215, 228)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (JumpListItem))]
  internal interface IJumpListItemStatics
  {
    JumpListItem CreateWithArguments(string arguments, string displayName);

    JumpListItem CreateSeparator();
  }
}
