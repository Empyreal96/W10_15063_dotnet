// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicense2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlayReadyLicense))]
  [Guid(821356455, 55523, 18592, 188, 218, 255, 159, 64, 83, 4, 54)]
  internal interface IPlayReadyLicense2 : IPlayReadyLicense
  {
    Guid SecureStopId { get; }

    uint SecurityLevel { get; }

    bool InMemoryOnly { get; }

    bool ExpiresInRealTime { get; }
  }
}
