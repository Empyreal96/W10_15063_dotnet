// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IStartScreenManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.StartScreen
{
  [Guid(2019946255, 46469, 17998, 137, 147, 52, 232, 248, 115, 141, 72)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (StartScreenManager))]
  internal interface IStartScreenManagerStatics
  {
    StartScreenManager GetDefault();

    StartScreenManager GetForUser(User user);
  }
}
