// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlLoadSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class XmlLoadSettings : IXmlLoadSettings
  {
    [MethodImpl]
    public extern XmlLoadSettings();

    public extern uint MaxElementDepth { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ProhibitDtd { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ResolveExternals { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ValidateOnParse { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ElementContentWhiteSpace { [MethodImpl] get; [MethodImpl] set; }
  }
}
