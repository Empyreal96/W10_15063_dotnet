﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DataContextChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataContextChangedEventArgs : IDataContextChangedEventArgs
  {
    public extern object NewValue { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
