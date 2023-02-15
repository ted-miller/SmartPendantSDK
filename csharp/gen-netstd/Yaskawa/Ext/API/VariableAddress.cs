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
  /// Variable address (scope, address-space & address/index)
  /// </summary>
  public partial class VariableAddress : TBase
  {
    private global::Yaskawa.Ext.API.Scope _scope;
    private global::Yaskawa.Ext.API.AddressSpace _aspace;
    private long _address;

    /// <summary>
    /// 
    /// <seealso cref="global::Yaskawa.Ext.API.Scope"/>
    /// </summary>
    public global::Yaskawa.Ext.API.Scope Scope
    {
      get
      {
        return _scope;
      }
      set
      {
        __isset.scope = true;
        this._scope = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Yaskawa.Ext.API.AddressSpace"/>
    /// </summary>
    public global::Yaskawa.Ext.API.AddressSpace Aspace
    {
      get
      {
        return _aspace;
      }
      set
      {
        __isset.aspace = true;
        this._aspace = value;
      }
    }

    public long Address
    {
      get
      {
        return _address;
      }
      set
      {
        __isset.address = true;
        this._address = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool scope;
      public bool aspace;
      public bool address;
    }

    public VariableAddress()
    {
      this._scope = global::Yaskawa.Ext.API.Scope.Global;
      this.__isset.scope = true;
      this._aspace = global::Yaskawa.Ext.API.AddressSpace.Unified;
      this.__isset.aspace = true;
    }

    public VariableAddress DeepCopy()
    {
      var tmp215 = new VariableAddress();
      if(__isset.scope)
      {
        tmp215.Scope = this.Scope;
      }
      tmp215.__isset.scope = this.__isset.scope;
      if(__isset.aspace)
      {
        tmp215.Aspace = this.Aspace;
      }
      tmp215.__isset.aspace = this.__isset.aspace;
      if(__isset.address)
      {
        tmp215.Address = this.Address;
      }
      tmp215.__isset.address = this.__isset.address;
      return tmp215;
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
                Scope = (global::Yaskawa.Ext.API.Scope)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Aspace = (global::Yaskawa.Ext.API.AddressSpace)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Address = await iprot.ReadI64Async(cancellationToken);
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
        var tmp216 = new TStruct("VariableAddress");
        await oprot.WriteStructBeginAsync(tmp216, cancellationToken);
        var tmp217 = new TField();
        if(__isset.scope)
        {
          tmp217.Name = "scope";
          tmp217.Type = TType.I32;
          tmp217.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp217, cancellationToken);
          await oprot.WriteI32Async((int)Scope, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.aspace)
        {
          tmp217.Name = "aspace";
          tmp217.Type = TType.I32;
          tmp217.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp217, cancellationToken);
          await oprot.WriteI32Async((int)Aspace, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.address)
        {
          tmp217.Name = "address";
          tmp217.Type = TType.I64;
          tmp217.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp217, cancellationToken);
          await oprot.WriteI64Async(Address, cancellationToken);
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
      if (!(that is VariableAddress other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.scope == other.__isset.scope) && ((!__isset.scope) || (global::System.Object.Equals(Scope, other.Scope))))
        && ((__isset.aspace == other.__isset.aspace) && ((!__isset.aspace) || (global::System.Object.Equals(Aspace, other.Aspace))))
        && ((__isset.address == other.__isset.address) && ((!__isset.address) || (global::System.Object.Equals(Address, other.Address))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.scope)
        {
          hashcode = (hashcode * 397) + Scope.GetHashCode();
        }
        if(__isset.aspace)
        {
          hashcode = (hashcode * 397) + Aspace.GetHashCode();
        }
        if(__isset.address)
        {
          hashcode = (hashcode * 397) + Address.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp218 = new StringBuilder("VariableAddress(");
      int tmp219 = 0;
      if(__isset.scope)
      {
        if(0 < tmp219++) { tmp218.Append(", "); }
        tmp218.Append("Scope: ");
        Scope.ToString(tmp218);
      }
      if(__isset.aspace)
      {
        if(0 < tmp219++) { tmp218.Append(", "); }
        tmp218.Append("Aspace: ");
        Aspace.ToString(tmp218);
      }
      if(__isset.address)
      {
        if(0 < tmp219++) { tmp218.Append(", "); }
        tmp218.Append("Address: ");
        Address.ToString(tmp218);
      }
      tmp218.Append(')');
      return tmp218.ToString();
    }
  }

}