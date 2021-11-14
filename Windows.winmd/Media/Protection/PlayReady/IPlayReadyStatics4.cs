// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1353257728, 55332, 16945, 157, 94, 120, 239, 136, 68, 199, 215)]
  [ExclusiveTo(typeof (PlayReadyStatics))]
  internal interface IPlayReadyStatics4 : IPlayReadyStatics3, IPlayReadyStatics2, IPlayReadyStatics
  {
    string InputTrustAuthorityToCreate { get; }

    Guid ProtectionSystemId { get; }
  }
}
