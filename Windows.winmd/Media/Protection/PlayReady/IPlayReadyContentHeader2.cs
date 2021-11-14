// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeader2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(899447284, 8576, 18828, 150, 91, 231, 84, 216, 117, 234, 178)]
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  internal interface IPlayReadyContentHeader2 : IPlayReadyContentHeader
  {
    Guid[] KeyIds { get; }

    string[] KeyIdStrings { get; }
  }
}
