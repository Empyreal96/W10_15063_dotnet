// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.DateTimeReader
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class DateTimeReader : ContentTypeReader<DateTime>
  {
    protected internal override DateTime Read(
      ContentReader input,
      DateTime existingInstance)
    {
      long num = input.ReadInt64();
      long ticks = num & 4611686018427387903L;
      DateTimeKind kind = (DateTimeKind) ((ulong) num >> 62);
      return kind == DateTimeKind.Local ? new DateTime(ticks, DateTimeKind.Utc).ToLocalTime() : new DateTime(ticks, kind);
    }
  }
}
