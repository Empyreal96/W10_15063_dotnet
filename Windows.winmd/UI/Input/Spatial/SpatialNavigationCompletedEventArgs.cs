﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialNavigationCompletedEventArgs : ISpatialNavigationCompletedEventArgs
  {
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }

    public extern Vector3 NormalizedOffset { [MethodImpl] get; }
  }
}
