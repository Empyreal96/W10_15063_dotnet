// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.Alarm
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Scheduler
{
  [SecuritySafeCritical]
  public sealed class Alarm : ScheduledNotification
  {
    private Uri m_soundUrl;

    public Alarm(string name)
      : base(name, ScheduledActionType.Alarm)
    {
    }

    public Uri Sound
    {
      get => this.m_soundUrl;
      set
      {
        SystemNotificationInterop.ValidateSoundUri(value == (Uri) null ? (string) null : value.ToString(), nameof (Sound));
        this.m_soundUrl = value;
      }
    }

    public override string Title
    {
      get => base.Title;
      set => throw new NotSupportedException(nameof (Title));
    }

    internal Alarm(Alarm alarm)
      : base((ScheduledNotification) alarm)
    {
      this.m_soundUrl = alarm.m_soundUrl;
    }

    internal override ScheduledAction CreateCopy() => (ScheduledAction) new Alarm(this);
  }
}
