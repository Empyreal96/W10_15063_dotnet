// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3303906214, 4127, 16461, 169, 73, 130, 243, 63, 205, 147, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimedTextSource))]
  internal interface ITimedTextSource
  {
    event TypedEventHandler<TimedTextSource, TimedTextSourceResolveResultEventArgs> Resolved;
  }
}
