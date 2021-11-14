// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IInsetClip
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(510912071, 33991, 18298, 180, 116, 88, 128, 224, 68, 46, 21)]
  [ExclusiveTo(typeof (InsetClip))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IInsetClip
  {
    float BottomInset { get; set; }

    float LeftInset { get; set; }

    float RightInset { get; set; }

    float TopInset { get; set; }
  }
}
