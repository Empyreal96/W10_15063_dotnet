// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISyndicationAttributeFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SyndicationAttribute : ISyndicationAttribute
  {
    [MethodImpl]
    public extern SyndicationAttribute(
      string attributeName,
      string attributeNamespace,
      string attributeValue);

    [MethodImpl]
    public extern SyndicationAttribute();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Namespace { [MethodImpl] get; [MethodImpl] set; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
