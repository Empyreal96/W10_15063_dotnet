// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatQueryOptions))]
  [Guid(802383014, 48950, 17143, 183, 231, 146, 60, 10, 171, 254, 22)]
  internal interface IChatQueryOptions
  {
    string SearchString { get; set; }
  }
}
