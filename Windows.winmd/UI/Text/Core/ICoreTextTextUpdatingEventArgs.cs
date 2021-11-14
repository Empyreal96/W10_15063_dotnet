// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextTextUpdatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  [Guid(4003959181, 52267, 20227, 143, 246, 2, 253, 33, 125, 180, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreTextTextUpdatingEventArgs))]
  internal interface ICoreTextTextUpdatingEventArgs
  {
    CoreTextRange Range { get; }

    string Text { get; }

    CoreTextRange NewSelection { get; }

    Language InputLanguage { get; }

    CoreTextTextUpdatingResult Result { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
