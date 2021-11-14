// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.SaveRingtoneTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.IO;

namespace Microsoft.Phone.Tasks
{
  public sealed class SaveRingtoneTask : ChooserBase<TaskEventArgs>
  {
    private Uri _source;
    private string _displayName;
    private string _tokenId;
    private const int MAX_PATH = 260;
    private const int MAX_FILE_SIZE = 1048576;

    public Uri Source
    {
      get => this._source;
      set
      {
        string str = !(value == (Uri) null) ? value.LocalPath.Substring(value.LocalPath.LastIndexOf(".") + 1) : throw new ArgumentNullException(nameof (Source), "Path cannot be null.");
        if (!str.ToLower().Equals("wma") && !str.ToLower().Equals("mp3") && !str.ToLower().Equals("m4r"))
          throw new ArgumentOutOfRangeException(nameof (Source), "Ringtone file is in an invalid format.");
        this._source = value;
      }
    }

    public string DisplayName
    {
      get => this._displayName;
      set
      {
        if (value == null || value.ToString().Length < 1)
          this._displayName = "";
        else
          this._displayName = value.ToString().Length <= 260 ? value : throw new ArgumentException("DisplayName is too long.");
      }
    }

    public bool IsShareable { get; set; }

    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      this.Source = !(this._source == (Uri) null) ? this._source : throw new InvalidOperationException("Path cannot be null.");
      this.DisplayName = this._displayName;
      string empty = string.Empty;
      string fileSystemPath;
      try
      {
        fileSystemPath = ApplicationHost.Current.GetFileSystemPath(this.Source.ToString());
        this._tokenId = DSC.DSCreateSharedFileTokenManaged(fileSystemPath);
      }
      catch (Exception ex)
      {
        throw new InvalidOperationException("Path must point to a file in your Isolated Storage or Application Data directory.");
      }
      ParameterPropertyBag ppb = new ParameterPropertyBag();
      ppb.CreateProperty("TokenId").StringValue = this._tokenId;
      ppb.CreateProperty("Source").StringValue = fileSystemPath;
      ppb.CreateProperty("DisplayName").StringValue = this.DisplayName;
      ppb.CreateProperty("IsShareable").BoolValue = this.IsShareable;
      this.Show(new Uri("app://D8CF8EC7-EC6D-4892-AAB9-1E3A4B5FA24B/SaveRingtone", UriKind.Absolute), ppb);
    }

    internal override void OnInvokeReturned(byte[] outputBuffer, Delegate fireThisHandlerOnly)
    {
      bool flag = false;
      uint num = 0;
      if (outputBuffer.Length != 0)
      {
        byte[] buffer = outputBuffer;
        ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag(buffer, (uint) buffer.Length);
        ParameterProperty property = parameterPropertyBag.GetProperty("Error");
        if (property.ValueType == ParameterPropertyValueType.ValueType_Int32)
          num = (uint) property.Int32Value;
        flag = num == 0U;
        GC.KeepAlive((object) parameterPropertyBag);
      }
      else
        num = 4U;
      if (flag)
      {
        this.FireCompleted((object) this, new TaskEventArgs(TaskResult.OK), fireThisHandlerOnly);
      }
      else
      {
        TaskEventArgs e = new TaskEventArgs(TaskResult.Cancel);
        if (num > 0U)
        {
          switch (num)
          {
            case 1:
              e.Error = (Exception) new InvalidOperationException("Ringtone file is in an invalid format.");
              break;
            case 2:
              e.Error = (Exception) new InvalidOperationException("Ringtone file is too large.");
              break;
            case 3:
              e.Error = (Exception) new IOException("There is not enough space on disk.");
              break;
            case 4:
              break;
            default:
              e.Error = (Exception) new IOException("Failed to save ringtone.");
              break;
          }
        }
        this.FireCompleted((object) this, e, fireThisHandlerOnly);
      }
    }

    internal enum SAVE_RINGTONE_RESULT
    {
      SAVE_RINGTONE_RESULT_SUCCESS,
      SAVE_RINGTONE_RESULT_ERRORINVALIDDATA,
      SAVE_RINGTONE_RESULT_ERRORFILETOOLARGE,
      SAVE_RINGTONE_RESULT_ERRORDISKFULL,
      SAVE_RINGTONE_RESULT_ERRORCANCEL,
    }
  }
}
