// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectParameter
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectParameter
  {
    internal uint _handle;
    internal string _name = string.Empty;
    internal string _semantic = string.Empty;
    private UnsafeNativeStructures.EFFECT_PARAMETER_DESC _desc;
    private EffectAnnotationCollection _annotations;
    private Effect _parent;
    private EffectParameterCollection _structureMembers;
    private EffectParameterCollection _elements;
    private uint _structureMemberCount;
    private uint _elementCount;

    internal EffectParameter(
      Effect parent,
      uint parentHandle,
      uint index,
      D3DXEffectParameterType type)
    {
      StringBuilder name = new StringBuilder(260);
      StringBuilder semantic = new StringBuilder(260);
      this._handle = UnsafeNativeMethods.Effect.GetGlobal(parent.GraphicsDevice).GetParameter(parent.GraphicsDevice.pComPtr, UnsafeNativeStructures.D3DXPARAM_INPUT.GetStructure(parent.pComPtr, parentHandle, index, type), out this._desc, name, semantic);
      if (this._handle == uint.MaxValue)
        return;
      this._name = string.Intern(name.ToString());
      this._semantic = string.Intern(semantic.ToString());
      if (this._desc.Annotations > 0U)
        this._annotations = new EffectAnnotationCollection(parent, this._handle, this._desc.Annotations);
      this._structureMemberCount = this._desc.Elements > 0U ? 0U : this._desc.StructMembers;
      this._elementCount = this._desc.Elements;
      this._parent = parent;
    }

    internal EffectParameter(
      Effect parent,
      uint handle,
      ref UnsafeNativeStructures.EFFECT_PARAMETER_DESC desc)
    {
      this._handle = handle;
      this._parent = parent;
      this._desc = desc;
    }

    public EffectAnnotationCollection Annotations => this._annotations == null ? EffectAnnotationCollection.Empty : this._annotations;

    public string Name => this._name;

    public string Semantic => this._semantic;

    public int ColumnCount => (int) this._desc.Columns;

    public int RowCount => (int) this._desc.Rows;

    public EffectParameterClass ParameterClass => this._desc.Class;

    public EffectParameterType ParameterType => this._desc.Type;

    public EffectParameterCollection StructureMembers
    {
      get
      {
        if (this._structureMembers == null)
        {
          if (this._structureMemberCount <= 0U)
            return EffectParameterCollection.Empty;
          this._structureMembers = new EffectParameterCollection(this._parent, this._handle, this._structureMemberCount, D3DXEffectParameterType.Parameter);
        }
        return this._structureMembers;
      }
    }

    public EffectParameterCollection Elements
    {
      get
      {
        if (this._elements == null)
        {
          if (this._elementCount <= 0U)
            return EffectParameterCollection.Empty;
          this._elements = new EffectParameterCollection(this._parent, this._handle, this._elementCount, D3DXEffectParameterType.ArrayElement);
        }
        return this._elements;
      }
    }

    internal int ElementCount => (int) this._elementCount;

    public void SetValue(string value)
    {
      if (this.ParameterType != EffectParameterType.String)
        throw new InvalidCastException();
      char[] chArray1 = value == null ? new char[0] : value.ToCharArray();
      if ((chArray1.Length & 1) != 0)
      {
        char[] chArray2 = new char[chArray1.Length + 1];
        chArray1.CopyTo((Array) chArray2, 0);
        chArray1 = chArray2;
      }
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueString, this._parent.pComPtr, this._handle, (Array) chArray1, 1U);
    }

    public void SetValue(Texture value)
    {
      if (value != null)
      {
        if (value._isDisposed)
          throw new ObjectDisposedException(nameof (value));
        if (value.isActiveRenderTarget)
          throw new InvalidOperationException(FrameworkResources.MustResolveRenderTarget);
      }
      if (this.ParameterType != EffectParameterType.Texture && this.ParameterType != EffectParameterType.Texture1D && (this.ParameterType != EffectParameterType.Texture2D && this.ParameterType != EffectParameterType.Texture3D) && this.ParameterType != EffectParameterType.TextureCube)
        throw new InvalidCastException();
      PacketHelpers.SendEffectSetTexturePacket(this._parent.GraphicsDevice, this._parent.pComPtr, value, this._handle);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(Vector3 value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass != EffectParameterClass.Vector || this.ColumnCount != 3 || this.RowCount != 1)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &value, 3U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(Vector2 value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass != EffectParameterClass.Vector || this.ColumnCount != 2 || this.RowCount != 1)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &value, 2U);
    }

    public void SetValue(bool[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Scalar && this.ParameterClass != EffectParameterClass.Vector && this.ParameterClass != EffectParameterClass.Matrix)
        throw new InvalidCastException();
      int[] numArray = new int[value.Length];
      for (int index = 0; index < numArray.Length; ++index)
        numArray[index] = value[index] ? 1 : 0;
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueBoolArray, this._parent.pComPtr, this._handle, (Array) numArray, 1U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(bool value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass == EffectParameterClass.Vector && this.RowCount == 1)
      {
        switch (this.ColumnCount)
        {
          case 2:
            Vector2 vector2;
            ref Vector2 local1 = ref vector2;
            int num1 = value ? 1 : 0;
            double num2;
            float num3 = (float) (num2 = (double) num1);
            local1.Y = (float) num2;
            local1.X = num3;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &vector2, 2U);
            break;
          case 3:
            Vector3 vector3;
            ref Vector3 local2 = ref vector3;
            int num4 = value ? 1 : 0;
            double num5;
            float num6 = (float) (num5 = (double) num4);
            local2.Z = (float) num5;
            double num7;
            float num8 = (float) (num7 = (double) num6);
            local2.Y = (float) num7;
            local2.X = num8;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &vector3, 3U);
            break;
          case 4:
            Vector4 vector4;
            ref Vector4 local3 = ref vector4;
            int num9 = value ? 1 : 0;
            double num10;
            float num11 = (float) (num10 = (double) num9);
            local3.W = (float) num10;
            double num12;
            float num13 = (float) (num12 = (double) num11);
            local3.Z = (float) num12;
            double num14;
            float num15 = (float) (num14 = (double) num13);
            local3.Y = (float) num14;
            local3.X = num15;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueVector, this._parent.pComPtr, this._handle, (void*) &vector4, 1U);
            break;
          default:
            throw new InvalidCastException();
        }
      }
      else if (this.ParameterClass == EffectParameterClass.Matrix)
      {
        float num16 = value ? 1f : 0.0f;
        Matrix matrix;
        ref Matrix local4 = ref matrix;
        double num17;
        float num18 = (float) (num17 = (double) num16);
        local4.M14 = (float) num17;
        double num19;
        float num20 = (float) (num19 = (double) num18);
        local4.M13 = (float) num19;
        double num21;
        float num22 = (float) (num21 = (double) num20);
        local4.M12 = (float) num21;
        local4.M11 = num22;
        ref Matrix local5 = ref matrix;
        double num23;
        float num24 = (float) (num23 = (double) num16);
        local5.M24 = (float) num23;
        double num25;
        float num26 = (float) (num25 = (double) num24);
        local5.M23 = (float) num25;
        double num27;
        float num28 = (float) (num27 = (double) num26);
        local5.M22 = (float) num27;
        local5.M21 = num28;
        ref Matrix local6 = ref matrix;
        double num29;
        float num30 = (float) (num29 = (double) num16);
        local6.M34 = (float) num29;
        double num31;
        float num32 = (float) (num31 = (double) num30);
        local6.M33 = (float) num31;
        double num33;
        float num34 = (float) (num33 = (double) num32);
        local6.M32 = (float) num33;
        local6.M31 = num34;
        ref Matrix local7 = ref matrix;
        double num35;
        float num36 = (float) (num35 = (double) num16);
        local7.M44 = (float) num35;
        double num37;
        float num38 = (float) (num37 = (double) num36);
        local7.M43 = (float) num37;
        double num39;
        float num40 = (float) (num39 = (double) num38);
        local7.M42 = (float) num39;
        local7.M41 = num40;
        PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrix, this._parent.pComPtr, this._handle, (void*) &matrix, 1U);
      }
      else
      {
        if (this.ParameterClass != EffectParameterClass.Scalar)
          throw new InvalidCastException();
        PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueBool, this._parent.pComPtr, this._handle, (void*) &(value ? 1 : 0), 1U);
      }
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(float value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass == EffectParameterClass.Vector && this.RowCount == 1)
      {
        switch (this.ColumnCount)
        {
          case 2:
            Vector2 vector2;
            ref Vector2 local1 = ref vector2;
            double num1;
            float num2 = (float) (num1 = (double) value);
            local1.Y = (float) num1;
            local1.X = num2;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &vector2, 2U);
            break;
          case 3:
            Vector3 vector3;
            ref Vector3 local2 = ref vector3;
            double num3;
            float num4 = (float) (num3 = (double) value);
            local2.Z = (float) num3;
            double num5;
            float num6 = (float) (num5 = (double) num4);
            local2.Y = (float) num5;
            local2.X = num6;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &vector3, 3U);
            break;
          case 4:
            Vector4 vector4;
            ref Vector4 local3 = ref vector4;
            double num7;
            float num8 = (float) (num7 = (double) value);
            local3.W = (float) num7;
            double num9;
            float num10 = (float) (num9 = (double) num8);
            local3.Z = (float) num9;
            double num11;
            float num12 = (float) (num11 = (double) num10);
            local3.Y = (float) num11;
            local3.X = num12;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueVector, this._parent.pComPtr, this._handle, (void*) &vector4, 1U);
            break;
          default:
            throw new InvalidCastException();
        }
      }
      else if (this.ParameterClass == EffectParameterClass.Matrix)
      {
        Matrix matrix;
        ref Matrix local4 = ref matrix;
        double num13;
        float num14 = (float) (num13 = (double) value);
        local4.M14 = (float) num13;
        double num15;
        float num16 = (float) (num15 = (double) num14);
        local4.M13 = (float) num15;
        double num17;
        float num18 = (float) (num17 = (double) num16);
        local4.M12 = (float) num17;
        local4.M11 = num18;
        ref Matrix local5 = ref matrix;
        double num19;
        float num20 = (float) (num19 = (double) value);
        local5.M24 = (float) num19;
        double num21;
        float num22 = (float) (num21 = (double) num20);
        local5.M23 = (float) num21;
        double num23;
        float num24 = (float) (num23 = (double) num22);
        local5.M22 = (float) num23;
        local5.M21 = num24;
        ref Matrix local6 = ref matrix;
        double num25;
        float num26 = (float) (num25 = (double) value);
        local6.M34 = (float) num25;
        double num27;
        float num28 = (float) (num27 = (double) num26);
        local6.M33 = (float) num27;
        double num29;
        float num30 = (float) (num29 = (double) num28);
        local6.M32 = (float) num29;
        local6.M31 = num30;
        ref Matrix local7 = ref matrix;
        double num31;
        float num32 = (float) (num31 = (double) value);
        local7.M44 = (float) num31;
        double num33;
        float num34 = (float) (num33 = (double) num32);
        local7.M43 = (float) num33;
        double num35;
        float num36 = (float) (num35 = (double) num34);
        local7.M42 = (float) num35;
        local7.M41 = num36;
        PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrix, this._parent.pComPtr, this._handle, (void*) &matrix, 1U);
      }
      else
      {
        if (this.ParameterClass != EffectParameterClass.Scalar)
          throw new InvalidCastException();
        PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &value, 1U);
      }
    }

    public void SetValue(float[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Scalar && this.ParameterClass != EffectParameterClass.Vector && this.ParameterClass != EffectParameterClass.Matrix)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloatArray, this._parent.pComPtr, this._handle, (Array) value, 1U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(int value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass == EffectParameterClass.Vector && this.RowCount == 1)
      {
        switch (this.ColumnCount)
        {
          case 2:
            Vector2 vector2;
            ref Vector2 local1 = ref vector2;
            double num1;
            float num2 = (float) (num1 = (double) value);
            local1.Y = (float) num1;
            local1.X = num2;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &vector2, 2U);
            break;
          case 3:
            Vector3 vector3;
            ref Vector3 local2 = ref vector3;
            double num3;
            float num4 = (float) (num3 = (double) value);
            local2.Z = (float) num3;
            double num5;
            float num6 = (float) (num5 = (double) num4);
            local2.Y = (float) num5;
            local2.X = num6;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloat, this._parent.pComPtr, this._handle, (void*) &vector3, 3U);
            break;
          case 4:
            Vector4 vector4;
            ref Vector4 local3 = ref vector4;
            double num7;
            float num8 = (float) (num7 = (double) value);
            local3.W = (float) num7;
            double num9;
            float num10 = (float) (num9 = (double) num8);
            local3.Z = (float) num9;
            double num11;
            float num12 = (float) (num11 = (double) num10);
            local3.Y = (float) num11;
            local3.X = num12;
            PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueVector, this._parent.pComPtr, this._handle, (void*) &vector4, 1U);
            break;
          default:
            throw new InvalidCastException();
        }
      }
      else if (this.ParameterClass == EffectParameterClass.Matrix)
      {
        float num13 = (float) value;
        Matrix matrix;
        ref Matrix local4 = ref matrix;
        double num14;
        float num15 = (float) (num14 = (double) num13);
        local4.M14 = (float) num14;
        double num16;
        float num17 = (float) (num16 = (double) num15);
        local4.M13 = (float) num16;
        double num18;
        float num19 = (float) (num18 = (double) num17);
        local4.M12 = (float) num18;
        local4.M11 = num19;
        ref Matrix local5 = ref matrix;
        double num20;
        float num21 = (float) (num20 = (double) num13);
        local5.M24 = (float) num20;
        double num22;
        float num23 = (float) (num22 = (double) num21);
        local5.M23 = (float) num22;
        double num24;
        float num25 = (float) (num24 = (double) num23);
        local5.M22 = (float) num24;
        local5.M21 = num25;
        ref Matrix local6 = ref matrix;
        double num26;
        float num27 = (float) (num26 = (double) num13);
        local6.M34 = (float) num26;
        double num28;
        float num29 = (float) (num28 = (double) num27);
        local6.M33 = (float) num28;
        double num30;
        float num31 = (float) (num30 = (double) num29);
        local6.M32 = (float) num30;
        local6.M31 = num31;
        ref Matrix local7 = ref matrix;
        double num32;
        float num33 = (float) (num32 = (double) num13);
        local7.M44 = (float) num32;
        double num34;
        float num35 = (float) (num34 = (double) num33);
        local7.M43 = (float) num34;
        double num36;
        float num37 = (float) (num36 = (double) num35);
        local7.M42 = (float) num36;
        local7.M41 = num37;
        PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrix, this._parent.pComPtr, this._handle, (void*) &matrix, 1U);
      }
      else
      {
        if (this.ParameterClass != EffectParameterClass.Scalar)
          throw new InvalidCastException();
        PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueInt, this._parent.pComPtr, this._handle, (void*) &value, 1U);
      }
    }

    public void SetValue(int[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Scalar && this.ParameterClass != EffectParameterClass.Vector && this.ParameterClass != EffectParameterClass.Matrix)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueIntArray, this._parent.pComPtr, this._handle, (Array) value, 1U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(Matrix value)
    {
      if (this.ParameterClass != EffectParameterClass.Matrix || this.ElementCount != 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrix, this._parent.pComPtr, this._handle, (void*) &value, 1U);
    }

    public void SetValue(Matrix[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Matrix || value.Length > this.ElementCount || this.ElementCount == 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrixArray, this._parent.pComPtr, this._handle, (Array) value, 1U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(Quaternion value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass != EffectParameterClass.Vector || this.ColumnCount != 4 || this.RowCount != 1)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueVector, this._parent.pComPtr, this._handle, (void*) &value, 1U);
    }

    public void SetValue(Quaternion[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Vector || this.ElementCount == 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloatArray, this._parent.pComPtr, this._handle, (Array) value, 4U);
    }

    public void SetValue(Vector2[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Vector || this.ElementCount == 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloatArray, this._parent.pComPtr, this._handle, (Array) value, 2U);
    }

    public void SetValue(Vector3[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Vector || this.ElementCount == 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloatArray, this._parent.pComPtr, this._handle, (Array) value, 3U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValue(Vector4 value)
    {
      if (this.ElementCount != 0)
        throw new InvalidCastException();
      if (this.ParameterClass != EffectParameterClass.Vector || this.ColumnCount != 4 || this.RowCount != 1)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueVector, this._parent.pComPtr, this._handle, (void*) &value, 1U);
    }

    public void SetValue(Vector4[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Vector || this.ElementCount == 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueFloatArray, this._parent.pComPtr, this._handle, (Array) value, 4U);
    }

    [SecuritySafeCritical]
    public unsafe void SetValueTranspose(Matrix value)
    {
      if (this.ParameterClass != EffectParameterClass.Matrix || this.ElementCount != 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameter(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrixTranspose, this._parent.pComPtr, this._handle, (void*) &value, 1U);
    }

    public void SetValueTranspose(Matrix[] value)
    {
      if (this.ParameterClass != EffectParameterClass.Matrix || value.Length > this.ElementCount || this.ElementCount == 0)
        throw new InvalidCastException();
      PacketHelpers.SendEffectParameterArray(this._parent.GraphicsDevice, HLCBPacketType.EffectSetValueMatrixTransposeArray, this._parent.pComPtr, this._handle, (Array) value, 1U);
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public unsafe bool GetValueBoolean()
    {
      if (this.ParameterClass != EffectParameterClass.Scalar && this.ElementCount == 0)
        throw new InvalidCastException();
      int num = 0;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Boolean, (void*) &num, 4U, 1U));
      return (uint) num > 0U;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe bool[] GetValueBooleanArray(int count)
    {
      int[] numArray = count > 0 ? new int[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (int* numPtr = &numArray[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.BooleanArray, (void*) numPtr, (uint) (4 * count), (uint) count));
      bool[] flagArray = new bool[numArray.Length];
      for (int index = 0; index < flagArray.Length; ++index)
        flagArray[index] = (uint) numArray[index] > 0U;
      return flagArray;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe int GetValueInt32()
    {
      if (this.ParameterClass != EffectParameterClass.Scalar && this.ElementCount == 0)
        throw new InvalidCastException();
      int num = 0;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Int32, (void*) &num, 4U, 1U));
      return num;
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public unsafe int[] GetValueInt32Array(int count)
    {
      int[] numArray = count > 0 ? new int[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (int* numPtr = &numArray[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Int32Array, (void*) numPtr, (uint) (4 * count), (uint) count));
      return numArray;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Matrix GetValueMatrix()
    {
      Matrix identity = Matrix.Identity;
      if (this.ElementCount == 0)
      {
        if (this.ParameterClass == EffectParameterClass.Scalar)
        {
          float num1;
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num1, 4U, 1U));
          ref Matrix local1 = ref identity;
          double num2;
          float num3 = (float) (num2 = (double) num1);
          local1.M14 = (float) num2;
          double num4;
          float num5 = (float) (num4 = (double) num3);
          local1.M13 = (float) num4;
          double num6;
          float num7 = (float) (num6 = (double) num5);
          local1.M12 = (float) num6;
          local1.M11 = num7;
          ref Matrix local2 = ref identity;
          double num8;
          float num9 = (float) (num8 = (double) num1);
          local2.M24 = (float) num8;
          double num10;
          float num11 = (float) (num10 = (double) num9);
          local2.M23 = (float) num10;
          double num12;
          float num13 = (float) (num12 = (double) num11);
          local2.M22 = (float) num12;
          local2.M21 = num13;
          ref Matrix local3 = ref identity;
          double num14;
          float num15 = (float) (num14 = (double) num1);
          local3.M34 = (float) num14;
          double num16;
          float num17 = (float) (num16 = (double) num15);
          local3.M33 = (float) num16;
          double num18;
          float num19 = (float) (num18 = (double) num17);
          local3.M32 = (float) num18;
          local3.M31 = num19;
          ref Matrix local4 = ref identity;
          double num20;
          float num21 = (float) (num20 = (double) num1);
          local4.M44 = (float) num20;
          double num22;
          float num23 = (float) (num22 = (double) num21);
          local4.M43 = (float) num22;
          double num24;
          float num25 = (float) (num24 = (double) num23);
          local4.M42 = (float) num24;
          local4.M41 = num25;
          return identity;
        }
        if (this.ParameterClass != EffectParameterClass.Matrix)
          throw new InvalidCastException();
      }
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Matrix, (void*) &identity, (uint) sizeof (Matrix), 1U));
      return identity;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Matrix[] GetValueMatrixArray(int count)
    {
      if (count <= 0)
        throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      if (this.ParameterClass != EffectParameterClass.Matrix || this.ElementCount == 0)
        throw new InvalidCastException();
      Matrix[] matrixArray = new Matrix[count];
      fixed (Matrix* matrixPtr = &matrixArray[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.MatrixArray, (void*) matrixPtr, (uint) (sizeof (Matrix) * count), (uint) count));
      return matrixArray;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Matrix GetValueMatrixTranspose()
    {
      Matrix identity = Matrix.Identity;
      if (this.ElementCount == 0)
      {
        if (this.ParameterClass == EffectParameterClass.Scalar)
        {
          float num1;
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num1, 4U, 1U));
          ref Matrix local1 = ref identity;
          double num2;
          float num3 = (float) (num2 = (double) num1);
          local1.M14 = (float) num2;
          double num4;
          float num5 = (float) (num4 = (double) num3);
          local1.M13 = (float) num4;
          double num6;
          float num7 = (float) (num6 = (double) num5);
          local1.M12 = (float) num6;
          local1.M11 = num7;
          ref Matrix local2 = ref identity;
          double num8;
          float num9 = (float) (num8 = (double) num1);
          local2.M24 = (float) num8;
          double num10;
          float num11 = (float) (num10 = (double) num9);
          local2.M23 = (float) num10;
          double num12;
          float num13 = (float) (num12 = (double) num11);
          local2.M22 = (float) num12;
          local2.M21 = num13;
          ref Matrix local3 = ref identity;
          double num14;
          float num15 = (float) (num14 = (double) num1);
          local3.M34 = (float) num14;
          double num16;
          float num17 = (float) (num16 = (double) num15);
          local3.M33 = (float) num16;
          double num18;
          float num19 = (float) (num18 = (double) num17);
          local3.M32 = (float) num18;
          local3.M31 = num19;
          ref Matrix local4 = ref identity;
          double num20;
          float num21 = (float) (num20 = (double) num1);
          local4.M44 = (float) num20;
          double num22;
          float num23 = (float) (num22 = (double) num21);
          local4.M43 = (float) num22;
          double num24;
          float num25 = (float) (num24 = (double) num23);
          local4.M42 = (float) num24;
          local4.M41 = num25;
          return identity;
        }
        if (this.ParameterClass != EffectParameterClass.Matrix)
          throw new InvalidCastException();
      }
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.MatrixTranspose, (void*) &identity, (uint) sizeof (Matrix), 1U));
      return identity;
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public unsafe Matrix[] GetValueMatrixTransposeArray(int count)
    {
      if (count <= 0)
        throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      if (this.ParameterClass != EffectParameterClass.Matrix || this.ElementCount == 0)
        throw new InvalidCastException();
      Matrix[] matrixArray = new Matrix[count];
      fixed (Matrix* matrixPtr = &matrixArray[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.MatrixTransposeArray, (void*) matrixPtr, (uint) (sizeof (Matrix) * count), (uint) count));
      return matrixArray;
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public unsafe Quaternion GetValueQuaternion()
    {
      Quaternion quaternion = new Quaternion();
      if (this.ElementCount == 0)
      {
        if (this.ParameterClass == EffectParameterClass.Scalar)
        {
          float num1;
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num1, 4U, 1U));
          ref Quaternion local = ref quaternion;
          double num2;
          float num3 = (float) (num2 = (double) num1);
          local.W = (float) num2;
          double num4;
          float num5 = (float) (num4 = (double) num3);
          local.Z = (float) num4;
          double num6;
          float num7 = (float) (num6 = (double) num5);
          local.Y = (float) num6;
          local.X = num7;
          return quaternion;
        }
        if (this.ParameterClass != EffectParameterClass.Vector)
          throw new InvalidCastException();
        if (this.ColumnCount != 4 || this.RowCount != 1)
          throw new InvalidCastException();
      }
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Vector4, (void*) &quaternion, (uint) sizeof (Quaternion), 1U));
      return quaternion;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Quaternion[] GetValueQuaternionArray(int count)
    {
      Quaternion[] quaternionArray = count > 0 ? new Quaternion[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (Quaternion* quaternionPtr = &quaternionArray[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.SingleArray, (void*) quaternionPtr, (uint) (4 * count * 4), (uint) (count * 4)));
      return quaternionArray;
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public unsafe float GetValueSingle()
    {
      if (this.ParameterClass != EffectParameterClass.Scalar && this.ElementCount == 0)
        throw new InvalidCastException();
      float num;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num, 4U, 1U));
      return num;
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public unsafe float[] GetValueSingleArray(int count)
    {
      float[] numArray = count > 0 ? new float[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (float* numPtr = &numArray[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.SingleArray, (void*) numPtr, (uint) (4 * count), (uint) count));
      return numArray;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Vector2 GetValueVector2()
    {
      Vector2 vector2 = new Vector2();
      if (this.ElementCount == 0)
      {
        if (this.ParameterClass == EffectParameterClass.Scalar)
        {
          float num1;
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num1, 4U, 1U));
          ref Vector2 local = ref vector2;
          double num2;
          float num3 = (float) (num2 = (double) num1);
          local.Y = (float) num2;
          local.X = num3;
          return vector2;
        }
        if (this.ParameterClass != EffectParameterClass.Vector)
          throw new InvalidCastException();
        if (this.ColumnCount != 2 || this.RowCount != 1)
          throw new InvalidCastException();
      }
      Vector4 vector4;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Vector4, (void*) &vector4, (uint) sizeof (Vector4), 1U));
      vector2.X = vector4.X;
      vector2.Y = vector4.Y;
      return vector2;
    }

    [SecuritySafeCritical]
    public unsafe Vector2[] GetValueVector2Array(int count)
    {
      Vector2[] vector2Array = count > 0 ? new Vector2[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (Vector2* vector2Ptr = &vector2Array[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.SingleArray, (void*) vector2Ptr, (uint) (sizeof (Vector2) * count), (uint) (count * 2)));
      return vector2Array;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Vector3 GetValueVector3()
    {
      Vector3 vector3 = new Vector3();
      if (this.ElementCount == 0)
      {
        if (this.ParameterClass == EffectParameterClass.Scalar)
        {
          float num1;
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num1, 4U, 1U));
          ref Vector3 local = ref vector3;
          double num2;
          float num3 = (float) (num2 = (double) num1);
          local.Z = (float) num2;
          double num4;
          float num5 = (float) (num4 = (double) num3);
          local.Y = (float) num4;
          local.X = num5;
          return vector3;
        }
        if (this.ParameterClass != EffectParameterClass.Vector)
          throw new InvalidCastException();
        if (this.ColumnCount != 3 || this.RowCount != 1)
          throw new InvalidCastException();
      }
      Vector4 vector4;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Vector4, (void*) &vector4, (uint) sizeof (Vector4), 1U));
      vector3.X = vector4.X;
      vector3.Y = vector4.Y;
      vector3.Z = vector4.Z;
      return vector3;
    }

    [SecuritySafeCritical]
    public unsafe Vector3[] GetValueVector3Array(int count)
    {
      Vector3[] vector3Array = count > 0 ? new Vector3[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (Vector3* vector3Ptr = &vector3Array[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.SingleArray, (void*) vector3Ptr, (uint) (sizeof (Vector3) * count), (uint) (count * 3)));
      return vector3Array;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    [SecuritySafeCritical]
    public unsafe Vector4 GetValueVector4()
    {
      Vector4 vector4 = new Vector4();
      if (this.ElementCount == 0)
      {
        if (this.ParameterClass == EffectParameterClass.Scalar)
        {
          float num1;
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Single, (void*) &num1, 4U, 1U));
          ref Vector4 local = ref vector4;
          double num2;
          float num3 = (float) (num2 = (double) num1);
          local.W = (float) num2;
          double num4;
          float num5 = (float) (num4 = (double) num3);
          local.Z = (float) num4;
          double num6;
          float num7 = (float) (num6 = (double) num5);
          local.Y = (float) num6;
          local.X = num7;
          return vector4;
        }
        if (this.ParameterClass != EffectParameterClass.Vector)
          throw new InvalidCastException();
        if (this.ColumnCount != 4 || this.RowCount != 1)
          throw new InvalidCastException();
      }
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.Vector4, (void*) &vector4, (uint) sizeof (Vector4), 1U));
      return vector4;
    }

    [SecuritySafeCritical]
    public unsafe Vector4[] GetValueVector4Array(int count)
    {
      Vector4[] vector4Array = count > 0 ? new Vector4[count] : throw new ArgumentOutOfRangeException(nameof (count), FrameworkResources.MustRetrieveAtLeastOne);
      fixed (Vector4* vector4Ptr = &vector4Array[0])
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValue(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, GetShaderValueType.SingleArray, (void*) vector4Ptr, (uint) (4 * count * 4), (uint) (count * 4)));
      return vector4Array;
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public string GetValueString()
    {
      if (this.ParameterType != EffectParameterType.String)
        throw new InvalidCastException();
      StringBuilder sb = new StringBuilder(260);
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetValueString(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, sb));
      return sb.ToString();
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public Texture2D GetValueTexture2D()
    {
      if (this.ParameterType != EffectParameterType.Texture && this.ParameterType != EffectParameterType.Texture2D)
        throw new InvalidCastException();
      uint textureHandle;
      TextureType textureType;
      UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetTexture(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, out textureHandle, out textureType, out parameters));
      if (textureHandle == uint.MaxValue)
        return (Texture2D) null;
      if (textureType != TextureType.Texture2D)
        throw new InvalidOperationException();
      return (Texture2D) this._parent.GraphicsDevice.GetKnownResourceFromHandle(textureHandle) ?? new Texture2D(this._parent.GraphicsDevice, textureHandle, parameters);
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public Texture3D GetValueTexture3D()
    {
      if (this.ParameterType != EffectParameterType.Texture && this.ParameterType != EffectParameterType.Texture3D)
        throw new InvalidCastException();
      uint textureHandle;
      TextureType textureType;
      UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetTexture(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, out textureHandle, out textureType, out parameters));
      if (textureHandle == uint.MaxValue)
        return (Texture3D) null;
      if (textureType != TextureType.Texture3D)
        throw new InvalidOperationException();
      return (Texture3D) this._parent.GraphicsDevice.GetKnownResourceFromHandle(textureHandle) ?? new Texture3D(this._parent.GraphicsDevice, textureHandle, parameters);
    }

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public TextureCube GetValueTextureCube()
    {
      if (this.ParameterType != EffectParameterType.Texture && this.ParameterType != EffectParameterType.TextureCube)
        throw new InvalidCastException();
      uint textureHandle;
      TextureType textureType;
      UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Effect.GetGlobal(this._parent.GraphicsDevice).GetTexture(this._parent.GraphicsDevice.pComPtr, this._parent.pComPtr, this._handle, out textureHandle, out textureType, out parameters));
      if (textureHandle == uint.MaxValue)
        return (TextureCube) null;
      if (textureType != TextureType.TextureCube)
        throw new InvalidOperationException();
      return (TextureCube) this._parent.GraphicsDevice.GetKnownResourceFromHandle(textureHandle) ?? new TextureCube(this._parent.GraphicsDevice, textureHandle, parameters);
    }
  }
}
