﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [ExclusiveTo(typeof (WebUICommandBar))]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [Guid(340381113, 42246, 17854, 143, 66, 178, 131, 126, 47, 224, 201)]
  internal interface IWebUICommandBarStatics
  {
    WebUICommandBar GetForCurrentView();
  }
}
