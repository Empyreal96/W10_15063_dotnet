﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.ContentPropertyAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  public sealed class ContentPropertyAttribute : Attribute
  {
    public string Name;

    [MethodImpl]
    public extern ContentPropertyAttribute();
  }
}
