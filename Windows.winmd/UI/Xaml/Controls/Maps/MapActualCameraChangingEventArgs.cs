﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapActualCameraChangingEventArgs : 
    IMapActualCameraChangingEventArgs,
    IMapActualCameraChangingEventArgs2
  {
    [MethodImpl]
    public extern MapActualCameraChangingEventArgs();

    public extern MapCamera Camera { [MethodImpl] get; }

    public extern MapCameraChangeReason ChangeReason { [MethodImpl] get; }
  }
}
