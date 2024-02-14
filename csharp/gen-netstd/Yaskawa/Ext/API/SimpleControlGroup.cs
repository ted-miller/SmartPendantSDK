/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{

  /// <summary>
  /// A simple control group (of axes)
  /// A Robot, Robot Base (e.g. rail) or Station
  /// </summary>
  public partial class SimpleControlGroup : TBase
  {
    private global::Yaskawa.Ext.API.ControlGroupType _type;
    private sbyte _index;

    /// <summary>
    /// 
    /// <seealso cref="global::Yaskawa.Ext.API.ControlGroupType"/>
    /// </summary>
    public global::Yaskawa.Ext.API.ControlGroupType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public sbyte Index
    {
      get
      {
        return _index;
      }
      set
      {
        __isset.index = true;
        this._index = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool type;
      public bool index;
    }

    public SimpleControlGroup()
    {
    }

    public SimpleControlGroup DeepCopy()
    {
      var tmp178 = new SimpleControlGroup();
      if(__isset.type)
      {
        tmp178.Type = this.Type;
      }
      tmp178.__isset.type = this.__isset.type;
      if(__isset.index)
      {
        tmp178.Index = this.Index;
      }
      tmp178.__isset.index = this.__isset.index;
      return tmp178;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Type = (global::Yaskawa.Ext.API.ControlGroupType)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Byte)
              {
                Index = await iprot.ReadByteAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp179 = new TStruct("SimpleControlGroup");
        await oprot.WriteStructBeginAsync(tmp179, cancellationToken);
        var tmp180 = new TField();
        if(__isset.type)
        {
          tmp180.Name = "type";
          tmp180.Type = TType.I32;
          tmp180.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp180, cancellationToken);
          await oprot.WriteI32Async((int)Type, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.index)
        {
          tmp180.Name = "index";
          tmp180.Type = TType.Byte;
          tmp180.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp180, cancellationToken);
          await oprot.WriteByteAsync(Index, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is SimpleControlGroup other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.type == other.__isset.type) && ((!__isset.type) || (global::System.Object.Equals(Type, other.Type))))
        && ((__isset.index == other.__isset.index) && ((!__isset.index) || (global::System.Object.Equals(Index, other.Index))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.type)
        {
          hashcode = (hashcode * 397) + Type.GetHashCode();
        }
        if(__isset.index)
        {
          hashcode = (hashcode * 397) + Index.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp181 = new StringBuilder("SimpleControlGroup(");
      int tmp182 = 0;
      if(__isset.type)
      {
        if(0 < tmp182++) { tmp181.Append(", "); }
        tmp181.Append("Type: ");
        Type.ToString(tmp181);
      }
      if(__isset.index)
      {
        if(0 < tmp182++) { tmp181.Append(", "); }
        tmp181.Append("Index: ");
        Index.ToString(tmp181);
      }
      tmp181.Append(')');
      return tmp181.ToString();
    }
  }

}
