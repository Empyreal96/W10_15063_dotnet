// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TemplatePartAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [AllowMultiple]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  public sealed class TemplatePartAttribute : Attribute
  {
    public string Name;
    public Type Type;

    [MethodImpl]
    public extern TemplatePartAttribute();
  }
}
