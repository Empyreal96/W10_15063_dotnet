﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class WebViewDeferredPermissionRequest : IWebViewDeferredPermissionRequest
  {
    public extern Uri Uri { [MethodImpl] get; }

    public extern WebViewPermissionType PermissionType { [MethodImpl] get; }

    public extern uint Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void Allow();

    [MethodImpl]
    public extern void Deny();
  }
}