// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionBatchTypes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum CompositionBatchTypes : uint
  {
    None = 0,
    Animation = 1,
    Effect = 2,
  }
}
