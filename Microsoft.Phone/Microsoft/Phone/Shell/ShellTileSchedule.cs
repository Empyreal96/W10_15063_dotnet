// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ShellTileSchedule
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;
using Windows.Internal.LegacyLiveTile;

namespace Microsoft.Phone.Shell
{
  public class ShellTileSchedule
  {
    private UpdateRecurrence? recurrence;
    private string id;
    private Uri uri;
    private bool isUriSet;
    private int? maxRunCount;
    private DateTime? startTime;
    private LegacyLiveTileIntervalKind? interval;
    private ShellTileData tileData;
    private DataType? dataType;

    public ShellTileSchedule() => this.id = string.Empty;

    public ShellTileSchedule(ShellTile tileId) => this.id = tileId != null ? tileId.Id : throw new ArgumentNullException(nameof (tileId));

    public ShellTileSchedule(ShellTile tileId, ShellTileData shellTileData)
    {
      if (tileId == null)
        throw new ArgumentNullException(nameof (tileId));
      if (shellTileData == null)
        throw new ArgumentNullException(nameof (shellTileData));
      this.id = tileId.Id;
      this.dataType = new DataType?(TileUtils.GetDataType(shellTileData));
      this.tileData = shellTileData;
    }

    [SecuritySafeCritical]
    public void Start()
    {
      if (!this.dataType.HasValue && !this.isUriSet)
        throw new InvalidOperationException();
      LegacyLiveTileRecurrenceType tileRecurrenceType = (LegacyLiveTileRecurrenceType) 1;
      LegacyLiveTileIntervalKind valueOrDefault1 = this.interval.GetValueOrDefault((LegacyLiveTileIntervalKind) 0);
      uint num1 = 1;
      bool flag = true;
      DateTime valueOrDefault2 = this.startTime.GetValueOrDefault(DateTime.Now);
      if (this.recurrence.HasValue)
      {
        UpdateRecurrence? recurrence = this.recurrence;
        UpdateRecurrence updateRecurrence = UpdateRecurrence.Interval;
        if ((recurrence.GetValueOrDefault() == updateRecurrence ? (recurrence.HasValue ? 1 : 0) : 0) != 0)
          tileRecurrenceType = (LegacyLiveTileRecurrenceType) 2;
      }
      if (this.maxRunCount.HasValue)
      {
        int? maxRunCount = this.maxRunCount;
        int num2 = 0;
        if ((maxRunCount.GetValueOrDefault() > num2 ? (maxRunCount.HasValue ? 1 : 0) : 0) != 0)
        {
          num1 = (uint) this.maxRunCount.GetValueOrDefault(0);
          flag = false;
          if (num1 < uint.MaxValue)
            ++num1;
        }
      }
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      TileUtils.ConstructXMLUpdate(this.dataType, this.tileData, this.id, this.uri, ref empty1, ref empty2);
      byte[] asciiByte1 = TileUtils.HardConvertUnicodeToASCIIByte(empty1);
      byte[] asciiByte2 = TileUtils.HardConvertUnicodeToASCIIByte(empty2);
      ShellTileSchedule.LegacyLiveTileJobManagerSingleton.Instance.AddLiveTileSchedule(ShellTile.ProductId, this.id, tileRecurrenceType, valueOrDefault1, num1, flag, (DateTimeOffset) valueOrDefault2, asciiByte1, asciiByte2);
    }

    [SecuritySafeCritical]
    public void Stop()
    {
      LegacyLiveTileRecurrenceType tileRecurrenceType = (LegacyLiveTileRecurrenceType) 1;
      if (!this.interval.HasValue)
      {
        UpdateRecurrence? recurrence = this.recurrence;
        UpdateRecurrence updateRecurrence = UpdateRecurrence.Interval;
        if ((recurrence.GetValueOrDefault() == updateRecurrence ? (recurrence.HasValue ? 1 : 0) : 0) == 0)
          goto label_3;
      }
      tileRecurrenceType = (LegacyLiveTileRecurrenceType) 2;
label_3:
      ShellTileSchedule.LegacyLiveTileJobManagerSingleton.Instance.RemoveLegacyLiveTileSubscription(ShellTile.ProductId, this.id, tileRecurrenceType);
    }

    public UpdateRecurrence Recurrence
    {
      get => this.recurrence ?? UpdateRecurrence.Onetime;
      set => this.recurrence = new UpdateRecurrence?(value);
    }

    public int MaxUpdateCount
    {
      get => this.maxRunCount ?? 0;
      set => this.maxRunCount = new int?(value);
    }

    public DateTime StartTime
    {
      get => this.startTime ?? DateTime.Now;
      set => this.startTime = new DateTime?(value);
    }

    public UpdateInterval Interval
    {
      get
      {
        LegacyLiveTileIntervalKind? interval = this.interval;
        if (interval.HasValue)
        {
          switch ((int) interval.GetValueOrDefault())
          {
            case 0:
              return UpdateInterval.EveryHour;
            case 1:
              return UpdateInterval.EveryDay;
            case 2:
              return UpdateInterval.EveryWeek;
            case 3:
              return UpdateInterval.EveryMonth;
          }
        }
        return UpdateInterval.EveryHour;
      }
      [SecuritySafeCritical] set
      {
        switch (value)
        {
          case UpdateInterval.EveryHour:
            this.interval = new LegacyLiveTileIntervalKind?((LegacyLiveTileIntervalKind) 0);
            break;
          case UpdateInterval.EveryDay:
            this.interval = new LegacyLiveTileIntervalKind?((LegacyLiveTileIntervalKind) 1);
            break;
          case UpdateInterval.EveryWeek:
            this.interval = new LegacyLiveTileIntervalKind?((LegacyLiveTileIntervalKind) 2);
            break;
          case UpdateInterval.EveryMonth:
            this.interval = new LegacyLiveTileIntervalKind?((LegacyLiveTileIntervalKind) 3);
            break;
          default:
            throw new ArgumentException(LocalizeString.ShellInvalidInterval + " '" + (object) value + "'");
        }
      }
    }

    public Uri RemoteImageUri
    {
      get => this.uri;
      set
      {
        this.uri = !(value == (Uri) null) && TileUtils.GetURIScheme(value) == URIType.http ? value : throw new ArgumentException(LocalizeString.ShellInvalidRemoteImageUri + " '" + (object) value + "'");
        this.isUriSet = true;
      }
    }

    private class LegacyLiveTileJobManagerSingleton
    {
      [SecuritySafeCritical]
      internal static WinRTLegacyLiveTileJobManager Instance = new WinRTLegacyLiveTileJobManager();

      [SecuritySafeCritical]
      static LegacyLiveTileJobManagerSingleton()
      {
      }
    }
  }
}
