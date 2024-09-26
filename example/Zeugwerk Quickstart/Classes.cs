/* Generated code */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TwinCAT.Ads;

namespace PLC
{
    namespace Mirror
    {
        public class Primitive<T>
        {
            public Primitive()
            { }

            public Primitive(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){
                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Primitive<T> Data { get; set; }
            }            


            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";          
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, Value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(Value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(Value));Value = Marshal.PtrToStructure<T>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public T Value { get; set; }

            public T Sync
            {
                get
                {
                    if(_adsClient == null)
                        return Value;                

                    Value = (T)_adsClient.ReadAny(Handle, Value.GetType());
                    return Value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, Value);
                }
            }
        }
        public class Array_0_10_ZApplication_AlarmingAcknowledge
        {
            public Array_0_10_ZApplication_AlarmingAcknowledge()
            { }


            public Array_0_10_ZApplication_AlarmingAcknowledge(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_10_ZApplication_AlarmingAcknowledge Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_10_ZApplication_AlarmingAcknowledge _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_10_ZApplication_AlarmingAcknowledge>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_10_ZApplication_AlarmingAcknowledge Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_10_ZApplication_AlarmingAcknowledge Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_10_ZApplication_AlarmingAcknowledge)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_5_byte
        {
            public Array_0_5_byte()
            { }


            public Array_0_5_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_5_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_5_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_5_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_5_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_5_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_5_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_0_byte
        {
            public Array_0_0_byte()
            { }


            public Array_0_0_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_0_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_0_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_0_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_0_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_0_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_0_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_10_ZApplication_AlarmingMessageCom
        {
            public Array_0_10_ZApplication_AlarmingMessageCom()
            { }


            public Array_0_10_ZApplication_AlarmingMessageCom(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_10_ZApplication_AlarmingMessageCom Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_10_ZApplication_AlarmingMessageCom _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_10_ZApplication_AlarmingMessageCom>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_10_ZApplication_AlarmingMessageCom Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_10_ZApplication_AlarmingMessageCom Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_10_ZApplication_AlarmingMessageCom)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_1_byte
        {
            public Array_0_1_byte()
            { }


            public Array_0_1_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_1_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_1_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_1_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_1_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_1_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_1_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_2_byte
        {
            public Array_0_2_byte()
            { }


            public Array_0_2_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_2_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_2_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_2_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_2_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_2_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_2_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_13_byte
        {
            public Array_0_13_byte()
            { }


            public Array_0_13_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_13_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_13_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_13_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_13_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_13_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_13_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_3_byte
        {
            public Array_0_3_byte()
            { }


            public Array_0_3_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_3_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_3_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_3_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_3_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_3_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_3_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_4_byte
        {
            public Array_0_4_byte()
            { }


            public Array_0_4_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_4_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_4_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_4_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_4_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_4_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_4_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class Array_0_6_byte
        {
            public Array_0_6_byte()
            { }


            public Array_0_6_byte(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){

                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public Array_0_6_byte Data { get; set; }
            }               

            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.Array_0_6_byte _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.Array_0_6_byte>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }            
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.Array_0_6_byte Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            public PLC.Types.Array_0_6_byte Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    _value = (PLC.Types.Array_0_6_byte)_adsClient.ReadAny(Handle, _value.GetType());
                    return _value;
                }
                set
                {
                    _value = value;
                    _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class String256
        {
            public String256()
            { 
                _value = new PLC.Types.String256();
            }


            public String256(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){
                _value = new PLC.Types.String256();
                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public String256 Data { get; set; }
            }
            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.String256 _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.String256>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }              
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public string Value
            {
                get
                {
                    return _value.str;
                }
                set
                {
                    _value.str = value;
                }
            }

            public string Sync
            {
                get
                {
                    if(_adsClient == null)
                        return "";                

                    _value = (PLC.Types.String256)_adsClient.ReadAny(Handle, _value.GetType());                    
                    return _value.str;
                }
                set
                {
                    _value.str = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
        }
        public class String81
        {
            public String81()
            { 
                _value = new PLC.Types.String81();
            }


            public String81(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null){
                _value = new PLC.Types.String81();
                _instancePath = instancePath;
                _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public String81 Data { get; set; }
            }
            

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.String81 _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));_value = Marshal.PtrToStructure<PLC.Types.String81>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }              
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public string Value
            {
                get
                {
                    return _value.str;
                }
                set
                {
                    _value.str = value;
                }
            }

            public string Sync
            {
                get
                {
                    if(_adsClient == null)
                        return "";                

                    _value = (PLC.Types.String81)_adsClient.ReadAny(Handle, _value.GetType());                    
                    return _value.str;
                }
                set
                {
                    _value.str = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
        } 
        public class ZAux_Message
        {
            public ZAux_Message()
            {
                this.TimeStamp = new PLC.Mirror.Primitive<ulong>("", null);
                this.Text = new PLC.Mirror.String256("", null);
                this.LogLevel = new PLC.Mirror.Primitive<PLC.Enums.ZCore_LogLevel>("", null);
                            
            }        


            public ZAux_Message(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZAux_Message d = new PLC.Types.ZAux_Message()){
                this.TimeStamp = new PLC.Mirror.Primitive<ulong>($"{instancePath}.TimeStamp", adsClient);
                this.Text = new PLC.Mirror.String256($"{instancePath}.Text", adsClient);
                this.LogLevel = new PLC.Mirror.Primitive<PLC.Enums.ZCore_LogLevel>($"{instancePath}.LogLevel", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZAux_Message Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZAux_Message _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZAux_Message>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZAux_Message Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  TimeStamp.Value = _value.TimeStamp;
                  
                      Text.Value = _value.Text.str;
                  LogLevel.Value = _value.LogLevel;
                }
            }

            public PLC.Types.ZAux_Message Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZAux_Message)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<ulong> TimeStamp { get; set;  }
            public PLC.Mirror.String256 Text { get; set;  }
            
                  public PLC.Mirror.Primitive<PLC.Enums.ZCore_LogLevel> LogLevel { get; set;  }
            
        }
         
        public class ZApplication_AlarmingMessageCom
        {
            public ZApplication_AlarmingMessageCom()
            {
                this.Extend = new PLC.Mirror.ZAux_Message("", null, new PLC.Types.ZAux_Message());
                this.Source = new PLC.Mirror.String256("", null);
                this.State = new PLC.Mirror.Primitive<PLC.Enums.ZApplication_AlarmingState>("", null);
                            
            }        


            public ZApplication_AlarmingMessageCom(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AlarmingMessageCom d = new PLC.Types.ZApplication_AlarmingMessageCom()){
                this.Extend = new PLC.Mirror.ZAux_Message($"{instancePath}.Extend", adsClient, d.Extend);
                this.Source = new PLC.Mirror.String256($"{instancePath}.Source", adsClient);
                this.State = new PLC.Mirror.Primitive<PLC.Enums.ZApplication_AlarmingState>($"{instancePath}.State", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AlarmingMessageCom Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AlarmingMessageCom _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AlarmingMessageCom>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AlarmingMessageCom Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                  
                      Source.Value = _value.Source.str;
                  State.Value = _value.State;
                }
            }

            public PLC.Types.ZApplication_AlarmingMessageCom Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AlarmingMessageCom)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZAux_Message Extend { get; set;  }
            public PLC.Mirror.String256 Source { get; set;  }
            
                  public PLC.Mirror.Primitive<PLC.Enums.ZApplication_AlarmingState> State { get; set;  }
            
        }
         
        public class ZApplication_AlarmingComPublish
        {
            public ZApplication_AlarmingComPublish()
            {
                this.Buffer = new PLC.Mirror.Array_0_10_ZApplication_AlarmingMessageCom("", null);
                  
                this.MostSignificantIndex = new PLC.Mirror.Primitive<int>("", null);
                            
            }        


            public ZApplication_AlarmingComPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AlarmingComPublish d = new PLC.Types.ZApplication_AlarmingComPublish()){
                this.Buffer = new PLC.Mirror.Array_0_10_ZApplication_AlarmingMessageCom($"{instancePath}.Buffer", adsClient);
                  
                this.MostSignificantIndex = new PLC.Mirror.Primitive<int>($"{instancePath}.MostSignificantIndex", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AlarmingComPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AlarmingComPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AlarmingComPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AlarmingComPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Buffer.Value = _value.Buffer;
                  MostSignificantIndex.Value = _value.MostSignificantIndex;
                }
            }

            public PLC.Types.ZApplication_AlarmingComPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AlarmingComPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            
                  public PLC.Mirror.Array_0_10_ZApplication_AlarmingMessageCom Buffer { get; set; }          
              
            public PLC.Mirror.Primitive<int> MostSignificantIndex { get; set;  }
            
        }
         
        public class ZApplication_AlarmingAcknowledge
        {
            public ZApplication_AlarmingAcknowledge()
            {
                this.Acknowledge = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AlarmingAcknowledge(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AlarmingAcknowledge d = new PLC.Types.ZApplication_AlarmingAcknowledge()){
                this.Acknowledge = new PLC.Mirror.Primitive<byte>($"{instancePath}.Acknowledge", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AlarmingAcknowledge Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AlarmingAcknowledge _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AlarmingAcknowledge>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AlarmingAcknowledge Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Acknowledge.Value = _value.Acknowledge;
                }
            }

            public PLC.Types.ZApplication_AlarmingAcknowledge Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AlarmingAcknowledge)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> Acknowledge { get; set;  }
        }
         
        public class ZApplication_AlarmingComSubscribe
        {
            public ZApplication_AlarmingComSubscribe()
            {
                this.Buffer = new PLC.Mirror.Array_0_10_ZApplication_AlarmingAcknowledge("", null);
                  
                this.Clear = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AlarmingComSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AlarmingComSubscribe d = new PLC.Types.ZApplication_AlarmingComSubscribe()){
                this.Buffer = new PLC.Mirror.Array_0_10_ZApplication_AlarmingAcknowledge($"{instancePath}.Buffer", adsClient);
                  
                this.Clear = new PLC.Mirror.Primitive<byte>($"{instancePath}.Clear", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AlarmingComSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AlarmingComSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AlarmingComSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AlarmingComSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Buffer.Value = _value.Buffer;
                  Clear.Value = _value.Clear;
                }
            }

            public PLC.Types.ZApplication_AlarmingComSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AlarmingComSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            
                  public PLC.Mirror.Array_0_10_ZApplication_AlarmingAcknowledge Buffer { get; set; }          
              
            public PLC.Mirror.Primitive<byte> Clear { get; set;  }
        }
         
        public class ZApplication_AlarmingCom
        {
            public ZApplication_AlarmingCom()
            {
                this.Publish = new PLC.Mirror.ZApplication_AlarmingComPublish("", null, new PLC.Types.ZApplication_AlarmingComPublish());
                this.Subscribe = new PLC.Mirror.ZApplication_AlarmingComSubscribe("", null, new PLC.Types.ZApplication_AlarmingComSubscribe());
                            
            }        


            public ZApplication_AlarmingCom(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AlarmingCom d = new PLC.Types.ZApplication_AlarmingCom()){
                this.Publish = new PLC.Mirror.ZApplication_AlarmingComPublish($"{instancePath}.Publish", adsClient, d.Publish);
                this.Subscribe = new PLC.Mirror.ZApplication_AlarmingComSubscribe($"{instancePath}.Subscribe", adsClient, d.Subscribe);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AlarmingCom Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AlarmingCom _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AlarmingCom>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AlarmingCom Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Publish.Value = _value.Publish;
                  Subscribe.Value = _value.Subscribe;
                }
            }

            public PLC.Types.ZApplication_AlarmingCom Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AlarmingCom)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AlarmingComPublish Publish { get; set;  }
            public PLC.Mirror.ZApplication_AlarmingComSubscribe Subscribe { get; set;  }
            
        }
         
        public class QuickstartComRequest
        {
            public QuickstartComRequest()
            {
                this.Start = new PLC.Mirror.Primitive<byte>("", null);
                this.Stop = new PLC.Mirror.Primitive<byte>("", null);
                this.GoHome = new PLC.Mirror.Primitive<byte>("", null);
                this.Halt = new PLC.Mirror.Primitive<byte>("", null);
                this.MoveTransportXThrice = new PLC.Mirror.Primitive<byte>("", null);
                this.MoveBrieflyUpAction = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public QuickstartComRequest(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.QuickstartComRequest d = new PLC.Types.QuickstartComRequest()){
                this.Start = new PLC.Mirror.Primitive<byte>($"{instancePath}.Start", adsClient);
                this.Stop = new PLC.Mirror.Primitive<byte>($"{instancePath}.Stop", adsClient);
                this.GoHome = new PLC.Mirror.Primitive<byte>($"{instancePath}.GoHome", adsClient);
                this.Halt = new PLC.Mirror.Primitive<byte>($"{instancePath}.Halt", adsClient);
                this.MoveTransportXThrice = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveTransportXThrice", adsClient);
                this.MoveBrieflyUpAction = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveBrieflyUpAction", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public QuickstartComRequest Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.QuickstartComRequest _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.QuickstartComRequest>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.QuickstartComRequest Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Start.Value = _value.Start;
                  Stop.Value = _value.Stop;
                  GoHome.Value = _value.GoHome;
                  Halt.Value = _value.Halt;
                  MoveTransportXThrice.Value = _value.MoveTransportXThrice;
                  MoveBrieflyUpAction.Value = _value.MoveBrieflyUpAction;
                }
            }

            public PLC.Types.QuickstartComRequest Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.QuickstartComRequest)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> Start { get; set;  }
            public PLC.Mirror.Primitive<byte> Stop { get; set;  }
            public PLC.Mirror.Primitive<byte> GoHome { get; set;  }
            public PLC.Mirror.Primitive<byte> Halt { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveTransportXThrice { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveBrieflyUpAction { get; set;  }
        }
         
        public class ZApplication_AxisComBase
        {
            public ZApplication_AxisComBase()
            {
                this.Supported = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComBase(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComBase d = new PLC.Types.ZApplication_AxisComBase()){
                this.Supported = new PLC.Mirror.Primitive<byte>($"{instancePath}.Supported", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComBase Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComBase _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComBase>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComBase Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Supported.Value = _value.Supported;
                }
            }

            public PLC.Types.ZApplication_AxisComBase Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComBase)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> Supported { get; set;  }
        }
         
        public class ZApplication_AxisComAbsolutePublish
        {
            public ZApplication_AxisComAbsolutePublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());            
            }        


            public ZApplication_AxisComAbsolutePublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComAbsolutePublish d = new PLC.Types.ZApplication_AxisComAbsolutePublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComAbsolutePublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComAbsolutePublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComAbsolutePublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComAbsolutePublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                }
            }

            public PLC.Types.ZApplication_AxisComAbsolutePublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComAbsolutePublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
        }
         
        public class ZApplication_AxisComBasePublish
        {
            public ZApplication_AxisComBasePublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());
                this.Name = new PLC.Mirror.String81("", null);
                this.Busy = new PLC.Mirror.Primitive<byte>("", null);
                this.Error = new PLC.Mirror.Primitive<byte>("", null);
                this.Manufacturer = new PLC.Mirror.String81("", null);
                this.Simulated = new PLC.Mirror.Primitive<byte>("", null);
                this.SafetyState = new PLC.Mirror.Primitive<PLC.Enums.ZEquipment_AxisSafetyStateFlags>("", null);
                this.MotionState = new PLC.Mirror.Primitive<PLC.Enums.ZEquipment_AxisMotionState>("", null);
                this.DriveState = new PLC.Mirror.String256("", null);
                this.DrivePowered = new PLC.Mirror.Primitive<byte>("", null);
                this.DriveEnabled = new PLC.Mirror.Primitive<byte>("", null);
                this.Parked = new PLC.Mirror.Primitive<byte>("", null);
                
                this.ActualPosition = new PLC.Mirror.Primitive<double>("", null);
                this.ActualFollowingError = new PLC.Mirror.Primitive<double>("", null);
                this.ActualVelocity = new PLC.Mirror.Primitive<double>("", null);
                this.ActualCurrent = new PLC.Mirror.Primitive<double>("", null);
                this.DecimalPlacesPosition = new PLC.Mirror.Primitive<short>("", null);
                this.DecimalPlacesVelocity = new PLC.Mirror.Primitive<short>("", null);
                this.DecimalPlacesCurrent = new PLC.Mirror.Primitive<short>("", null);
                            
            }        


            public ZApplication_AxisComBasePublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComBasePublish d = new PLC.Types.ZApplication_AxisComBasePublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
                this.Name = new PLC.Mirror.String81($"{instancePath}.Name", adsClient);
                this.Busy = new PLC.Mirror.Primitive<byte>($"{instancePath}.Busy", adsClient);
                this.Error = new PLC.Mirror.Primitive<byte>($"{instancePath}.Error", adsClient);
                this.Manufacturer = new PLC.Mirror.String81($"{instancePath}.Manufacturer", adsClient);
                this.Simulated = new PLC.Mirror.Primitive<byte>($"{instancePath}.Simulated", adsClient);
                this.SafetyState = new PLC.Mirror.Primitive<PLC.Enums.ZEquipment_AxisSafetyStateFlags>($"{instancePath}.SafetyState", adsClient);
                this.MotionState = new PLC.Mirror.Primitive<PLC.Enums.ZEquipment_AxisMotionState>($"{instancePath}.MotionState", adsClient);
                this.DriveState = new PLC.Mirror.String256($"{instancePath}.DriveState", adsClient);
                this.DrivePowered = new PLC.Mirror.Primitive<byte>($"{instancePath}.DrivePowered", adsClient);
                this.DriveEnabled = new PLC.Mirror.Primitive<byte>($"{instancePath}.DriveEnabled", adsClient);
                this.Parked = new PLC.Mirror.Primitive<byte>($"{instancePath}.Parked", adsClient);
                
                this.ActualPosition = new PLC.Mirror.Primitive<double>($"{instancePath}.ActualPosition", adsClient);
                this.ActualFollowingError = new PLC.Mirror.Primitive<double>($"{instancePath}.ActualFollowingError", adsClient);
                this.ActualVelocity = new PLC.Mirror.Primitive<double>($"{instancePath}.ActualVelocity", adsClient);
                this.ActualCurrent = new PLC.Mirror.Primitive<double>($"{instancePath}.ActualCurrent", adsClient);
                this.DecimalPlacesPosition = new PLC.Mirror.Primitive<short>($"{instancePath}.DecimalPlacesPosition", adsClient);
                this.DecimalPlacesVelocity = new PLC.Mirror.Primitive<short>($"{instancePath}.DecimalPlacesVelocity", adsClient);
                this.DecimalPlacesCurrent = new PLC.Mirror.Primitive<short>($"{instancePath}.DecimalPlacesCurrent", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComBasePublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComBasePublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComBasePublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComBasePublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                  
                      Name.Value = _value.Name.str;
                  Busy.Value = _value.Busy;
                  Error.Value = _value.Error;
                  
                      Manufacturer.Value = _value.Manufacturer.str;
                  Simulated.Value = _value.Simulated;
                  SafetyState.Value = _value.SafetyState;
                  MotionState.Value = _value.MotionState;
                  
                      DriveState.Value = _value.DriveState.str;
                  DrivePowered.Value = _value.DrivePowered;
                  DriveEnabled.Value = _value.DriveEnabled;
                  Parked.Value = _value.Parked;
                  ActualPosition.Value = _value.ActualPosition;
                  ActualFollowingError.Value = _value.ActualFollowingError;
                  ActualVelocity.Value = _value.ActualVelocity;
                  ActualCurrent.Value = _value.ActualCurrent;
                  DecimalPlacesPosition.Value = _value.DecimalPlacesPosition;
                  DecimalPlacesVelocity.Value = _value.DecimalPlacesVelocity;
                  DecimalPlacesCurrent.Value = _value.DecimalPlacesCurrent;
                }
            }

            public PLC.Types.ZApplication_AxisComBasePublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComBasePublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
            public PLC.Mirror.String81 Name { get; set;  }
            public PLC.Mirror.Primitive<byte> Busy { get; set;  }
            public PLC.Mirror.Primitive<byte> Error { get; set;  }
            public PLC.Mirror.String81 Manufacturer { get; set;  }
            public PLC.Mirror.Primitive<byte> Simulated { get; set;  }
            
                  public PLC.Mirror.Primitive<PLC.Enums.ZEquipment_AxisSafetyStateFlags> SafetyState { get; set;  }
            
                  public PLC.Mirror.Primitive<PLC.Enums.ZEquipment_AxisMotionState> MotionState { get; set;  }
            public PLC.Mirror.String256 DriveState { get; set;  }
            public PLC.Mirror.Primitive<byte> DrivePowered { get; set;  }
            public PLC.Mirror.Primitive<byte> DriveEnabled { get; set;  }
            public PLC.Mirror.Primitive<byte> Parked { get; set;  }
            
            public PLC.Mirror.Primitive<double> ActualPosition { get; set;  }
            public PLC.Mirror.Primitive<double> ActualFollowingError { get; set;  }
            public PLC.Mirror.Primitive<double> ActualVelocity { get; set;  }
            public PLC.Mirror.Primitive<double> ActualCurrent { get; set;  }
            public PLC.Mirror.Primitive<short> DecimalPlacesPosition { get; set;  }
            public PLC.Mirror.Primitive<short> DecimalPlacesVelocity { get; set;  }
            public PLC.Mirror.Primitive<short> DecimalPlacesCurrent { get; set;  }
            
        }
         
        public class ZApplication_AxisComHaltPublish
        {
            public ZApplication_AxisComHaltPublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());            
            }        


            public ZApplication_AxisComHaltPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComHaltPublish d = new PLC.Types.ZApplication_AxisComHaltPublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComHaltPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComHaltPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComHaltPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComHaltPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                }
            }

            public PLC.Types.ZApplication_AxisComHaltPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComHaltPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
        }
         
        public class ZApplication_AxisComVelocityFeedratePublish
        {
            public ZApplication_AxisComVelocityFeedratePublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());
                
                this.Feedrate = new PLC.Mirror.Primitive<double>("", null);            
            }        


            public ZApplication_AxisComVelocityFeedratePublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComVelocityFeedratePublish d = new PLC.Types.ZApplication_AxisComVelocityFeedratePublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
                
                this.Feedrate = new PLC.Mirror.Primitive<double>($"{instancePath}.Feedrate", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComVelocityFeedratePublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComVelocityFeedratePublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComVelocityFeedratePublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComVelocityFeedratePublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                  Feedrate.Value = _value.Feedrate;
                }
            }

            public PLC.Types.ZApplication_AxisComVelocityFeedratePublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComVelocityFeedratePublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
            
            public PLC.Mirror.Primitive<double> Feedrate { get; set;  }
        }
         
        public class ZApplication_AxisComBrakePublish
        {
            public ZApplication_AxisComBrakePublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());
                this.BrakeOpened = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComBrakePublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComBrakePublish d = new PLC.Types.ZApplication_AxisComBrakePublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
                this.BrakeOpened = new PLC.Mirror.Primitive<byte>($"{instancePath}.BrakeOpened", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComBrakePublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComBrakePublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComBrakePublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComBrakePublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                  BrakeOpened.Value = _value.BrakeOpened;
                }
            }

            public PLC.Types.ZApplication_AxisComBrakePublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComBrakePublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
            public PLC.Mirror.Primitive<byte> BrakeOpened { get; set;  }
        }
         
        public class ZApplication_AxisComHomingPublish
        {
            public ZApplication_AxisComHomingPublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());            
            }        


            public ZApplication_AxisComHomingPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComHomingPublish d = new PLC.Types.ZApplication_AxisComHomingPublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComHomingPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComHomingPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComHomingPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComHomingPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                }
            }

            public PLC.Types.ZApplication_AxisComHomingPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComHomingPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
        }
         
        public class ZApplication_AxisComCurrentPublish
        {
            public ZApplication_AxisComCurrentPublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());            
            }        


            public ZApplication_AxisComCurrentPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComCurrentPublish d = new PLC.Types.ZApplication_AxisComCurrentPublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComCurrentPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComCurrentPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComCurrentPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComCurrentPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                }
            }

            public PLC.Types.ZApplication_AxisComCurrentPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComCurrentPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
        }
         
        public class ZApplication_AxisComVelocityPublish
        {
            public ZApplication_AxisComVelocityPublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());            
            }        


            public ZApplication_AxisComVelocityPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComVelocityPublish d = new PLC.Types.ZApplication_AxisComVelocityPublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComVelocityPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComVelocityPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComVelocityPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComVelocityPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                }
            }

            public PLC.Types.ZApplication_AxisComVelocityPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComVelocityPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
        }
         
        public class ZApplication_AxisComPositionPublish
        {
            public ZApplication_AxisComPositionPublish()
            {
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase("", null, new PLC.Types.ZApplication_AxisComBase());
                this.Referenced = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComPositionPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComPositionPublish d = new PLC.Types.ZApplication_AxisComPositionPublish()){
                this.Extend = new PLC.Mirror.ZApplication_AxisComBase($"{instancePath}.Extend", adsClient, d.Extend);
                this.Referenced = new PLC.Mirror.Primitive<byte>($"{instancePath}.Referenced", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComPositionPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComPositionPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComPositionPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComPositionPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Extend.Value = _value.Extend;
                  Referenced.Value = _value.Referenced;
                }
            }

            public PLC.Types.ZApplication_AxisComPositionPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComPositionPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComBase Extend { get; set;  }
            public PLC.Mirror.Primitive<byte> Referenced { get; set;  }
        }
         
        public class ZApplication_AxisComPublish
        {
            public ZApplication_AxisComPublish()
            {
                this.Absolute = new PLC.Mirror.ZApplication_AxisComAbsolutePublish("", null, new PLC.Types.ZApplication_AxisComAbsolutePublish());
                
                this.Base = new PLC.Mirror.ZApplication_AxisComBasePublish("", null, new PLC.Types.ZApplication_AxisComBasePublish());
                this.Halt = new PLC.Mirror.ZApplication_AxisComHaltPublish("", null, new PLC.Types.ZApplication_AxisComHaltPublish());
                
                this.VelocityFeedrate = new PLC.Mirror.ZApplication_AxisComVelocityFeedratePublish("", null, new PLC.Types.ZApplication_AxisComVelocityFeedratePublish());
                this.Brake = new PLC.Mirror.ZApplication_AxisComBrakePublish("", null, new PLC.Types.ZApplication_AxisComBrakePublish());
                this.Homing = new PLC.Mirror.ZApplication_AxisComHomingPublish("", null, new PLC.Types.ZApplication_AxisComHomingPublish());
                this.Current = new PLC.Mirror.ZApplication_AxisComCurrentPublish("", null, new PLC.Types.ZApplication_AxisComCurrentPublish());
                this.Velocity = new PLC.Mirror.ZApplication_AxisComVelocityPublish("", null, new PLC.Types.ZApplication_AxisComVelocityPublish());
                this.Position = new PLC.Mirror.ZApplication_AxisComPositionPublish("", null, new PLC.Types.ZApplication_AxisComPositionPublish());
                            
            }        


            public ZApplication_AxisComPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComPublish d = new PLC.Types.ZApplication_AxisComPublish()){
                this.Absolute = new PLC.Mirror.ZApplication_AxisComAbsolutePublish($"{instancePath}.Absolute", adsClient, d.Absolute);
                
                this.Base = new PLC.Mirror.ZApplication_AxisComBasePublish($"{instancePath}.Base", adsClient, d.Base);
                this.Halt = new PLC.Mirror.ZApplication_AxisComHaltPublish($"{instancePath}.Halt", adsClient, d.Halt);
                
                this.VelocityFeedrate = new PLC.Mirror.ZApplication_AxisComVelocityFeedratePublish($"{instancePath}.VelocityFeedrate", adsClient, d.VelocityFeedrate);
                this.Brake = new PLC.Mirror.ZApplication_AxisComBrakePublish($"{instancePath}.Brake", adsClient, d.Brake);
                this.Homing = new PLC.Mirror.ZApplication_AxisComHomingPublish($"{instancePath}.Homing", adsClient, d.Homing);
                this.Current = new PLC.Mirror.ZApplication_AxisComCurrentPublish($"{instancePath}.Current", adsClient, d.Current);
                this.Velocity = new PLC.Mirror.ZApplication_AxisComVelocityPublish($"{instancePath}.Velocity", adsClient, d.Velocity);
                this.Position = new PLC.Mirror.ZApplication_AxisComPositionPublish($"{instancePath}.Position", adsClient, d.Position);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Absolute.Value = _value.Absolute;
                  Base.Value = _value.Base;
                  Halt.Value = _value.Halt;
                  VelocityFeedrate.Value = _value.VelocityFeedrate;
                  Brake.Value = _value.Brake;
                  Homing.Value = _value.Homing;
                  Current.Value = _value.Current;
                  Velocity.Value = _value.Velocity;
                  Position.Value = _value.Position;
                }
            }

            public PLC.Types.ZApplication_AxisComPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComAbsolutePublish Absolute { get; set;  }
            
            public PLC.Mirror.ZApplication_AxisComBasePublish Base { get; set;  }
            public PLC.Mirror.ZApplication_AxisComHaltPublish Halt { get; set;  }
            
            public PLC.Mirror.ZApplication_AxisComVelocityFeedratePublish VelocityFeedrate { get; set;  }
            public PLC.Mirror.ZApplication_AxisComBrakePublish Brake { get; set;  }
            public PLC.Mirror.ZApplication_AxisComHomingPublish Homing { get; set;  }
            public PLC.Mirror.ZApplication_AxisComCurrentPublish Current { get; set;  }
            public PLC.Mirror.ZApplication_AxisComVelocityPublish Velocity { get; set;  }
            public PLC.Mirror.ZApplication_AxisComPositionPublish Position { get; set;  }
            
        }
         
        public class ZApplication_ActuatorDigitalComPublish
        {
            public ZApplication_ActuatorDigitalComPublish()
            {
                this.Name = new PLC.Mirror.String256("", null);
                this.Busy = new PLC.Mirror.Primitive<byte>("", null);
                this.Error = new PLC.Mirror.Primitive<byte>("", null);
                this.AtMinus = new PLC.Mirror.Primitive<byte>("", null);
                this.AtPlus = new PLC.Mirror.Primitive<byte>("", null);
                
                this.Duration = new PLC.Mirror.Primitive<double>("", null);
                this.MinusOutputName = new PLC.Mirror.String81("", null);
                this.PlusOutputName = new PLC.Mirror.String81("", null);
                this.MinusInputName = new PLC.Mirror.String81("", null);
                this.PlusInputName = new PLC.Mirror.String81("", null);
                            
            }        


            public ZApplication_ActuatorDigitalComPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_ActuatorDigitalComPublish d = new PLC.Types.ZApplication_ActuatorDigitalComPublish()){
                this.Name = new PLC.Mirror.String256($"{instancePath}.Name", adsClient);
                this.Busy = new PLC.Mirror.Primitive<byte>($"{instancePath}.Busy", adsClient);
                this.Error = new PLC.Mirror.Primitive<byte>($"{instancePath}.Error", adsClient);
                this.AtMinus = new PLC.Mirror.Primitive<byte>($"{instancePath}.AtMinus", adsClient);
                this.AtPlus = new PLC.Mirror.Primitive<byte>($"{instancePath}.AtPlus", adsClient);
                
                this.Duration = new PLC.Mirror.Primitive<double>($"{instancePath}.Duration", adsClient);
                this.MinusOutputName = new PLC.Mirror.String81($"{instancePath}.MinusOutputName", adsClient);
                this.PlusOutputName = new PLC.Mirror.String81($"{instancePath}.PlusOutputName", adsClient);
                this.MinusInputName = new PLC.Mirror.String81($"{instancePath}.MinusInputName", adsClient);
                this.PlusInputName = new PLC.Mirror.String81($"{instancePath}.PlusInputName", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_ActuatorDigitalComPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_ActuatorDigitalComPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_ActuatorDigitalComPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_ActuatorDigitalComPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  
                      Name.Value = _value.Name.str;
                  Busy.Value = _value.Busy;
                  Error.Value = _value.Error;
                  AtMinus.Value = _value.AtMinus;
                  AtPlus.Value = _value.AtPlus;
                  Duration.Value = _value.Duration;
                  
                      MinusOutputName.Value = _value.MinusOutputName.str;
                  
                      PlusOutputName.Value = _value.PlusOutputName.str;
                  
                      MinusInputName.Value = _value.MinusInputName.str;
                  
                      PlusInputName.Value = _value.PlusInputName.str;
                }
            }

            public PLC.Types.ZApplication_ActuatorDigitalComPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_ActuatorDigitalComPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.String256 Name { get; set;  }
            public PLC.Mirror.Primitive<byte> Busy { get; set;  }
            public PLC.Mirror.Primitive<byte> Error { get; set;  }
            public PLC.Mirror.Primitive<byte> AtMinus { get; set;  }
            public PLC.Mirror.Primitive<byte> AtPlus { get; set;  }
            
            public PLC.Mirror.Primitive<double> Duration { get; set;  }
            public PLC.Mirror.String81 MinusOutputName { get; set;  }
            public PLC.Mirror.String81 PlusOutputName { get; set;  }
            public PLC.Mirror.String81 MinusInputName { get; set;  }
            public PLC.Mirror.String81 PlusInputName { get; set;  }
            
        }
         
        public class ZApplication_DigitalComPublish
        {
            public ZApplication_DigitalComPublish()
            {
                this.Name = new PLC.Mirror.String256("", null);
                this.Simulated = new PLC.Mirror.Primitive<byte>("", null);
                this.Writeable = new PLC.Mirror.Primitive<byte>("", null);
                this.Enabled = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_DigitalComPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_DigitalComPublish d = new PLC.Types.ZApplication_DigitalComPublish()){
                this.Name = new PLC.Mirror.String256($"{instancePath}.Name", adsClient);
                this.Simulated = new PLC.Mirror.Primitive<byte>($"{instancePath}.Simulated", adsClient);
                this.Writeable = new PLC.Mirror.Primitive<byte>($"{instancePath}.Writeable", adsClient);
                this.Enabled = new PLC.Mirror.Primitive<byte>($"{instancePath}.Enabled", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_DigitalComPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_DigitalComPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_DigitalComPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_DigitalComPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  
                      Name.Value = _value.Name.str;
                  Simulated.Value = _value.Simulated;
                  Writeable.Value = _value.Writeable;
                  Enabled.Value = _value.Enabled;
                }
            }

            public PLC.Types.ZApplication_DigitalComPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_DigitalComPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.String256 Name { get; set;  }
            public PLC.Mirror.Primitive<byte> Simulated { get; set;  }
            public PLC.Mirror.Primitive<byte> Writeable { get; set;  }
            public PLC.Mirror.Primitive<byte> Enabled { get; set;  }
        }
         
        public class QuickstartComPublishEquipment
        {
            public QuickstartComPublishEquipment()
            {
                this.TransportX = new PLC.Mirror.ZApplication_AxisComPublish("", null, new PLC.Types.ZApplication_AxisComPublish());
                this.CylinderY = new PLC.Mirror.ZApplication_ActuatorDigitalComPublish("", null, new PLC.Types.ZApplication_ActuatorDigitalComPublish());
                this.CylinderYDown = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.CylinderYUp = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.CylinderYIsDown = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.CylinderYIsUp = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.MagnetOn = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.LimitSwitchLeft = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.LimitSwitchRight = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());
                this.ConveyorOn = new PLC.Mirror.ZApplication_DigitalComPublish("", null, new PLC.Types.ZApplication_DigitalComPublish());            
            }        


            public QuickstartComPublishEquipment(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.QuickstartComPublishEquipment d = new PLC.Types.QuickstartComPublishEquipment()){
                this.TransportX = new PLC.Mirror.ZApplication_AxisComPublish($"{instancePath}.TransportX", adsClient, d.TransportX);
                this.CylinderY = new PLC.Mirror.ZApplication_ActuatorDigitalComPublish($"{instancePath}.CylinderY", adsClient, d.CylinderY);
                this.CylinderYDown = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.CylinderYDown", adsClient, d.CylinderYDown);
                this.CylinderYUp = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.CylinderYUp", adsClient, d.CylinderYUp);
                this.CylinderYIsDown = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.CylinderYIsDown", adsClient, d.CylinderYIsDown);
                this.CylinderYIsUp = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.CylinderYIsUp", adsClient, d.CylinderYIsUp);
                this.MagnetOn = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.MagnetOn", adsClient, d.MagnetOn);
                this.LimitSwitchLeft = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.LimitSwitchLeft", adsClient, d.LimitSwitchLeft);
                this.LimitSwitchRight = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.LimitSwitchRight", adsClient, d.LimitSwitchRight);
                this.ConveyorOn = new PLC.Mirror.ZApplication_DigitalComPublish($"{instancePath}.ConveyorOn", adsClient, d.ConveyorOn);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public QuickstartComPublishEquipment Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.QuickstartComPublishEquipment _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.QuickstartComPublishEquipment>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.QuickstartComPublishEquipment Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  TransportX.Value = _value.TransportX;
                  CylinderY.Value = _value.CylinderY;
                  CylinderYDown.Value = _value.CylinderYDown;
                  CylinderYUp.Value = _value.CylinderYUp;
                  CylinderYIsDown.Value = _value.CylinderYIsDown;
                  CylinderYIsUp.Value = _value.CylinderYIsUp;
                  MagnetOn.Value = _value.MagnetOn;
                  LimitSwitchLeft.Value = _value.LimitSwitchLeft;
                  LimitSwitchRight.Value = _value.LimitSwitchRight;
                  ConveyorOn.Value = _value.ConveyorOn;
                }
            }

            public PLC.Types.QuickstartComPublishEquipment Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.QuickstartComPublishEquipment)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComPublish TransportX { get; set;  }
            public PLC.Mirror.ZApplication_ActuatorDigitalComPublish CylinderY { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish CylinderYDown { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish CylinderYUp { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish CylinderYIsDown { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish CylinderYIsUp { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish MagnetOn { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish LimitSwitchLeft { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish LimitSwitchRight { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComPublish ConveyorOn { get; set;  }
        }
         
        public class QuickstartComPublish
        {
            public QuickstartComPublish()
            {
                this.State = new PLC.Mirror.Primitive<PLC.Enums.ZApplication_UnitStateMachineState>("", null);
                this.Request = new PLC.Mirror.QuickstartComRequest("", null, new PLC.Types.QuickstartComRequest());
                this.Equipment = new PLC.Mirror.QuickstartComPublishEquipment("", null, new PLC.Types.QuickstartComPublishEquipment());            
            }        


            public QuickstartComPublish(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.QuickstartComPublish d = new PLC.Types.QuickstartComPublish()){
                this.State = new PLC.Mirror.Primitive<PLC.Enums.ZApplication_UnitStateMachineState>($"{instancePath}.State", adsClient);
                this.Request = new PLC.Mirror.QuickstartComRequest($"{instancePath}.Request", adsClient, d.Request);
                this.Equipment = new PLC.Mirror.QuickstartComPublishEquipment($"{instancePath}.Equipment", adsClient, d.Equipment);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public QuickstartComPublish Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.QuickstartComPublish _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.QuickstartComPublish>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.QuickstartComPublish Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  State.Value = _value.State;
                  Request.Value = _value.Request;
                  Equipment.Value = _value.Equipment;
                }
            }

            public PLC.Types.QuickstartComPublish Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.QuickstartComPublish)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            
                  public PLC.Mirror.Primitive<PLC.Enums.ZApplication_UnitStateMachineState> State { get; set;  }
            public PLC.Mirror.QuickstartComRequest Request { get; set;  }
            public PLC.Mirror.QuickstartComPublishEquipment Equipment { get; set;  }
        }
         
        public class ZApplication_AxisComAbsoluteSubscribe
        {
            public ZApplication_AxisComAbsoluteSubscribe()
            {
                this.Position = new PLC.Mirror.Primitive<double>("", null);
                this.SetAbsolutePosition = new PLC.Mirror.Primitive<byte>("", null);
                            
            }        


            public ZApplication_AxisComAbsoluteSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComAbsoluteSubscribe d = new PLC.Types.ZApplication_AxisComAbsoluteSubscribe()){
                this.Position = new PLC.Mirror.Primitive<double>($"{instancePath}.Position", adsClient);
                this.SetAbsolutePosition = new PLC.Mirror.Primitive<byte>($"{instancePath}.SetAbsolutePosition", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComAbsoluteSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComAbsoluteSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComAbsoluteSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComAbsoluteSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Position.Value = _value.Position;
                  SetAbsolutePosition.Value = _value.SetAbsolutePosition;
                }
            }

            public PLC.Types.ZApplication_AxisComAbsoluteSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComAbsoluteSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<double> Position { get; set;  }
            public PLC.Mirror.Primitive<byte> SetAbsolutePosition { get; set;  }
            
        }
         
        public class ZApplication_AxisComBaseSubscribe
        {
            public ZApplication_AxisComBaseSubscribe()
            {
                this.EnableDrive = new PLC.Mirror.Primitive<byte>("", null);
                this.DisableDrive = new PLC.Mirror.Primitive<byte>("", null);
                this.Stop = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComBaseSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComBaseSubscribe d = new PLC.Types.ZApplication_AxisComBaseSubscribe()){
                this.EnableDrive = new PLC.Mirror.Primitive<byte>($"{instancePath}.EnableDrive", adsClient);
                this.DisableDrive = new PLC.Mirror.Primitive<byte>($"{instancePath}.DisableDrive", adsClient);
                this.Stop = new PLC.Mirror.Primitive<byte>($"{instancePath}.Stop", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComBaseSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComBaseSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComBaseSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComBaseSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  EnableDrive.Value = _value.EnableDrive;
                  DisableDrive.Value = _value.DisableDrive;
                  Stop.Value = _value.Stop;
                }
            }

            public PLC.Types.ZApplication_AxisComBaseSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComBaseSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> EnableDrive { get; set;  }
            public PLC.Mirror.Primitive<byte> DisableDrive { get; set;  }
            public PLC.Mirror.Primitive<byte> Stop { get; set;  }
        }
         
        public class ZApplication_AxisComHaltSubscribe
        {
            public ZApplication_AxisComHaltSubscribe()
            {
                this.Halt = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComHaltSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComHaltSubscribe d = new PLC.Types.ZApplication_AxisComHaltSubscribe()){
                this.Halt = new PLC.Mirror.Primitive<byte>($"{instancePath}.Halt", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComHaltSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComHaltSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComHaltSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComHaltSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Halt.Value = _value.Halt;
                }
            }

            public PLC.Types.ZApplication_AxisComHaltSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComHaltSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> Halt { get; set;  }
        }
         
        public class ZApplication_AxisComVelocityFeedrateSubscribe
        {
            public ZApplication_AxisComVelocityFeedrateSubscribe()
            {
                this.Feedrate = new PLC.Mirror.Primitive<double>("", null);
                this.Apply = new PLC.Mirror.Primitive<byte>("", null);
                            
            }        


            public ZApplication_AxisComVelocityFeedrateSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe d = new PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe()){
                this.Feedrate = new PLC.Mirror.Primitive<double>($"{instancePath}.Feedrate", adsClient);
                this.Apply = new PLC.Mirror.Primitive<byte>($"{instancePath}.Apply", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComVelocityFeedrateSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Feedrate.Value = _value.Feedrate;
                  Apply.Value = _value.Apply;
                }
            }

            public PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<double> Feedrate { get; set;  }
            public PLC.Mirror.Primitive<byte> Apply { get; set;  }
            
        }
         
        public class ZApplication_AxisComBrakeSubscribe
        {
            public ZApplication_AxisComBrakeSubscribe()
            {
                this.OpenBrake = new PLC.Mirror.Primitive<byte>("", null);
                this.CloseBrake = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComBrakeSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComBrakeSubscribe d = new PLC.Types.ZApplication_AxisComBrakeSubscribe()){
                this.OpenBrake = new PLC.Mirror.Primitive<byte>($"{instancePath}.OpenBrake", adsClient);
                this.CloseBrake = new PLC.Mirror.Primitive<byte>($"{instancePath}.CloseBrake", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComBrakeSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComBrakeSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComBrakeSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComBrakeSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  OpenBrake.Value = _value.OpenBrake;
                  CloseBrake.Value = _value.CloseBrake;
                }
            }

            public PLC.Types.ZApplication_AxisComBrakeSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComBrakeSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> OpenBrake { get; set;  }
            public PLC.Mirror.Primitive<byte> CloseBrake { get; set;  }
        }
         
        public class ZApplication_AxisComHomingSubscribe
        {
            public ZApplication_AxisComHomingSubscribe()
            {
                this.Homing = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_AxisComHomingSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComHomingSubscribe d = new PLC.Types.ZApplication_AxisComHomingSubscribe()){
                this.Homing = new PLC.Mirror.Primitive<byte>($"{instancePath}.Homing", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComHomingSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComHomingSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComHomingSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComHomingSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Homing.Value = _value.Homing;
                }
            }

            public PLC.Types.ZApplication_AxisComHomingSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComHomingSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> Homing { get; set;  }
        }
         
        public class ZApplication_AxisComVelocitySubscribe
        {
            public ZApplication_AxisComVelocitySubscribe()
            {
                this.Velocity = new PLC.Mirror.Primitive<double>("", null);
                this.MoveVelocity = new PLC.Mirror.Primitive<byte>("", null);
                            
            }        


            public ZApplication_AxisComVelocitySubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComVelocitySubscribe d = new PLC.Types.ZApplication_AxisComVelocitySubscribe()){
                this.Velocity = new PLC.Mirror.Primitive<double>($"{instancePath}.Velocity", adsClient);
                this.MoveVelocity = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveVelocity", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComVelocitySubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComVelocitySubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComVelocitySubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComVelocitySubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Velocity.Value = _value.Velocity;
                  MoveVelocity.Value = _value.MoveVelocity;
                }
            }

            public PLC.Types.ZApplication_AxisComVelocitySubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComVelocitySubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<double> Velocity { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveVelocity { get; set;  }
            
        }
         
        public class ZApplication_AxisComPositionSubscribe
        {
            public ZApplication_AxisComPositionSubscribe()
            {
                this.Speed = new PLC.Mirror.Primitive<double>("", null);
                this.Position1 = new PLC.Mirror.Primitive<double>("", null);
                this.MoveAbsolute1 = new PLC.Mirror.Primitive<byte>("", null);
                
                this.Position2 = new PLC.Mirror.Primitive<double>("", null);
                this.MoveAbsolute2 = new PLC.Mirror.Primitive<byte>("", null);
                
                this.Delay = new PLC.Mirror.Primitive<double>("", null);
                this.MoveContinuous = new PLC.Mirror.Primitive<byte>("", null);
                
                this.Distance = new PLC.Mirror.Primitive<double>("", null);
                this.MoveRelative = new PLC.Mirror.Primitive<byte>("", null);
                            
            }        


            public ZApplication_AxisComPositionSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComPositionSubscribe d = new PLC.Types.ZApplication_AxisComPositionSubscribe()){
                this.Speed = new PLC.Mirror.Primitive<double>($"{instancePath}.Speed", adsClient);
                this.Position1 = new PLC.Mirror.Primitive<double>($"{instancePath}.Position1", adsClient);
                this.MoveAbsolute1 = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveAbsolute1", adsClient);
                
                this.Position2 = new PLC.Mirror.Primitive<double>($"{instancePath}.Position2", adsClient);
                this.MoveAbsolute2 = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveAbsolute2", adsClient);
                
                this.Delay = new PLC.Mirror.Primitive<double>($"{instancePath}.Delay", adsClient);
                this.MoveContinuous = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveContinuous", adsClient);
                
                this.Distance = new PLC.Mirror.Primitive<double>($"{instancePath}.Distance", adsClient);
                this.MoveRelative = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveRelative", adsClient);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComPositionSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComPositionSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComPositionSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComPositionSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Speed.Value = _value.Speed;
                  Position1.Value = _value.Position1;
                  MoveAbsolute1.Value = _value.MoveAbsolute1;
                  Position2.Value = _value.Position2;
                  MoveAbsolute2.Value = _value.MoveAbsolute2;
                  Delay.Value = _value.Delay;
                  MoveContinuous.Value = _value.MoveContinuous;
                  Distance.Value = _value.Distance;
                  MoveRelative.Value = _value.MoveRelative;
                }
            }

            public PLC.Types.ZApplication_AxisComPositionSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComPositionSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<double> Speed { get; set;  }
            public PLC.Mirror.Primitive<double> Position1 { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveAbsolute1 { get; set;  }
            
            public PLC.Mirror.Primitive<double> Position2 { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveAbsolute2 { get; set;  }
            
            public PLC.Mirror.Primitive<double> Delay { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveContinuous { get; set;  }
            
            public PLC.Mirror.Primitive<double> Distance { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveRelative { get; set;  }
            
        }
         
        public class ZApplication_AxisComSubscribe
        {
            public ZApplication_AxisComSubscribe()
            {
                this.Absolute = new PLC.Mirror.ZApplication_AxisComAbsoluteSubscribe("", null, new PLC.Types.ZApplication_AxisComAbsoluteSubscribe());
                this.Base = new PLC.Mirror.ZApplication_AxisComBaseSubscribe("", null, new PLC.Types.ZApplication_AxisComBaseSubscribe());
                this.Halt = new PLC.Mirror.ZApplication_AxisComHaltSubscribe("", null, new PLC.Types.ZApplication_AxisComHaltSubscribe());
                
                this.VelocityFeedrate = new PLC.Mirror.ZApplication_AxisComVelocityFeedrateSubscribe("", null, new PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe());
                this.Brake = new PLC.Mirror.ZApplication_AxisComBrakeSubscribe("", null, new PLC.Types.ZApplication_AxisComBrakeSubscribe());
                this.Homing = new PLC.Mirror.ZApplication_AxisComHomingSubscribe("", null, new PLC.Types.ZApplication_AxisComHomingSubscribe());
                
                this.Velocity = new PLC.Mirror.ZApplication_AxisComVelocitySubscribe("", null, new PLC.Types.ZApplication_AxisComVelocitySubscribe());
                this.Position = new PLC.Mirror.ZApplication_AxisComPositionSubscribe("", null, new PLC.Types.ZApplication_AxisComPositionSubscribe());            
            }        


            public ZApplication_AxisComSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_AxisComSubscribe d = new PLC.Types.ZApplication_AxisComSubscribe()){
                this.Absolute = new PLC.Mirror.ZApplication_AxisComAbsoluteSubscribe($"{instancePath}.Absolute", adsClient, d.Absolute);
                this.Base = new PLC.Mirror.ZApplication_AxisComBaseSubscribe($"{instancePath}.Base", adsClient, d.Base);
                this.Halt = new PLC.Mirror.ZApplication_AxisComHaltSubscribe($"{instancePath}.Halt", adsClient, d.Halt);
                
                this.VelocityFeedrate = new PLC.Mirror.ZApplication_AxisComVelocityFeedrateSubscribe($"{instancePath}.VelocityFeedrate", adsClient, d.VelocityFeedrate);
                this.Brake = new PLC.Mirror.ZApplication_AxisComBrakeSubscribe($"{instancePath}.Brake", adsClient, d.Brake);
                this.Homing = new PLC.Mirror.ZApplication_AxisComHomingSubscribe($"{instancePath}.Homing", adsClient, d.Homing);
                
                this.Velocity = new PLC.Mirror.ZApplication_AxisComVelocitySubscribe($"{instancePath}.Velocity", adsClient, d.Velocity);
                this.Position = new PLC.Mirror.ZApplication_AxisComPositionSubscribe($"{instancePath}.Position", adsClient, d.Position);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_AxisComSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_AxisComSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_AxisComSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_AxisComSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Absolute.Value = _value.Absolute;
                  Base.Value = _value.Base;
                  Halt.Value = _value.Halt;
                  VelocityFeedrate.Value = _value.VelocityFeedrate;
                  Brake.Value = _value.Brake;
                  Homing.Value = _value.Homing;
                  Velocity.Value = _value.Velocity;
                  Position.Value = _value.Position;
                }
            }

            public PLC.Types.ZApplication_AxisComSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_AxisComSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComAbsoluteSubscribe Absolute { get; set;  }
            public PLC.Mirror.ZApplication_AxisComBaseSubscribe Base { get; set;  }
            public PLC.Mirror.ZApplication_AxisComHaltSubscribe Halt { get; set;  }
            
            public PLC.Mirror.ZApplication_AxisComVelocityFeedrateSubscribe VelocityFeedrate { get; set;  }
            public PLC.Mirror.ZApplication_AxisComBrakeSubscribe Brake { get; set;  }
            public PLC.Mirror.ZApplication_AxisComHomingSubscribe Homing { get; set;  }
            
            public PLC.Mirror.ZApplication_AxisComVelocitySubscribe Velocity { get; set;  }
            public PLC.Mirror.ZApplication_AxisComPositionSubscribe Position { get; set;  }
        }
         
        public class ZApplication_ActuatorDigitalComSubscribe
        {
            public ZApplication_ActuatorDigitalComSubscribe()
            {
                this.MovePlus = new PLC.Mirror.Primitive<byte>("", null);
                this.MoveMinus = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_ActuatorDigitalComSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_ActuatorDigitalComSubscribe d = new PLC.Types.ZApplication_ActuatorDigitalComSubscribe()){
                this.MovePlus = new PLC.Mirror.Primitive<byte>($"{instancePath}.MovePlus", adsClient);
                this.MoveMinus = new PLC.Mirror.Primitive<byte>($"{instancePath}.MoveMinus", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_ActuatorDigitalComSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_ActuatorDigitalComSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_ActuatorDigitalComSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_ActuatorDigitalComSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  MovePlus.Value = _value.MovePlus;
                  MoveMinus.Value = _value.MoveMinus;
                }
            }

            public PLC.Types.ZApplication_ActuatorDigitalComSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_ActuatorDigitalComSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> MovePlus { get; set;  }
            public PLC.Mirror.Primitive<byte> MoveMinus { get; set;  }
        }
         
        public class ZApplication_DigitalComSubscribe
        {
            public ZApplication_DigitalComSubscribe()
            {
                this.Write = new PLC.Mirror.Primitive<byte>("", null);
                this.Enable = new PLC.Mirror.Primitive<byte>("", null);            
            }        


            public ZApplication_DigitalComSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.ZApplication_DigitalComSubscribe d = new PLC.Types.ZApplication_DigitalComSubscribe()){
                this.Write = new PLC.Mirror.Primitive<byte>($"{instancePath}.Write", adsClient);
                this.Enable = new PLC.Mirror.Primitive<byte>($"{instancePath}.Enable", adsClient);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public ZApplication_DigitalComSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.ZApplication_DigitalComSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.ZApplication_DigitalComSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.ZApplication_DigitalComSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Write.Value = _value.Write;
                  Enable.Value = _value.Enable;
                }
            }

            public PLC.Types.ZApplication_DigitalComSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.ZApplication_DigitalComSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.Primitive<byte> Write { get; set;  }
            public PLC.Mirror.Primitive<byte> Enable { get; set;  }
        }
         
        public class QuickstartComSubscribeEquipment
        {
            public QuickstartComSubscribeEquipment()
            {
                this.TransportX = new PLC.Mirror.ZApplication_AxisComSubscribe("", null, new PLC.Types.ZApplication_AxisComSubscribe());
                this.CylinderY = new PLC.Mirror.ZApplication_ActuatorDigitalComSubscribe("", null, new PLC.Types.ZApplication_ActuatorDigitalComSubscribe());
                this.CylinderYDown = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.CylinderYUp = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.CylinderYIsDown = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.CylinderYIsUp = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.MagnetOn = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.LimitSwitchLeft = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.LimitSwitchRight = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                this.ConveyorOn = new PLC.Mirror.ZApplication_DigitalComSubscribe("", null, new PLC.Types.ZApplication_DigitalComSubscribe());
                            
            }        


            public QuickstartComSubscribeEquipment(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.QuickstartComSubscribeEquipment d = new PLC.Types.QuickstartComSubscribeEquipment()){
                this.TransportX = new PLC.Mirror.ZApplication_AxisComSubscribe($"{instancePath}.TransportX", adsClient, d.TransportX);
                this.CylinderY = new PLC.Mirror.ZApplication_ActuatorDigitalComSubscribe($"{instancePath}.CylinderY", adsClient, d.CylinderY);
                this.CylinderYDown = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.CylinderYDown", adsClient, d.CylinderYDown);
                this.CylinderYUp = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.CylinderYUp", adsClient, d.CylinderYUp);
                this.CylinderYIsDown = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.CylinderYIsDown", adsClient, d.CylinderYIsDown);
                this.CylinderYIsUp = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.CylinderYIsUp", adsClient, d.CylinderYIsUp);
                this.MagnetOn = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.MagnetOn", adsClient, d.MagnetOn);
                this.LimitSwitchLeft = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.LimitSwitchLeft", adsClient, d.LimitSwitchLeft);
                this.LimitSwitchRight = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.LimitSwitchRight", adsClient, d.LimitSwitchRight);
                this.ConveyorOn = new PLC.Mirror.ZApplication_DigitalComSubscribe($"{instancePath}.ConveyorOn", adsClient, d.ConveyorOn);
                
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public QuickstartComSubscribeEquipment Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.QuickstartComSubscribeEquipment _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.QuickstartComSubscribeEquipment>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.QuickstartComSubscribeEquipment Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  TransportX.Value = _value.TransportX;
                  CylinderY.Value = _value.CylinderY;
                  CylinderYDown.Value = _value.CylinderYDown;
                  CylinderYUp.Value = _value.CylinderYUp;
                  CylinderYIsDown.Value = _value.CylinderYIsDown;
                  CylinderYIsUp.Value = _value.CylinderYIsUp;
                  MagnetOn.Value = _value.MagnetOn;
                  LimitSwitchLeft.Value = _value.LimitSwitchLeft;
                  LimitSwitchRight.Value = _value.LimitSwitchRight;
                  ConveyorOn.Value = _value.ConveyorOn;
                }
            }

            public PLC.Types.QuickstartComSubscribeEquipment Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.QuickstartComSubscribeEquipment)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.ZApplication_AxisComSubscribe TransportX { get; set;  }
            public PLC.Mirror.ZApplication_ActuatorDigitalComSubscribe CylinderY { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe CylinderYDown { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe CylinderYUp { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe CylinderYIsDown { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe CylinderYIsUp { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe MagnetOn { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe LimitSwitchLeft { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe LimitSwitchRight { get; set;  }
            public PLC.Mirror.ZApplication_DigitalComSubscribe ConveyorOn { get; set;  }
            
        }
         
        public class QuickstartComSubscribe
        {
            public QuickstartComSubscribe()
            {
                this.Request = new PLC.Mirror.QuickstartComRequest("", null, new PLC.Types.QuickstartComRequest());
                
                this.Equipment = new PLC.Mirror.QuickstartComSubscribeEquipment("", null, new PLC.Types.QuickstartComSubscribeEquipment());            
            }        


            public QuickstartComSubscribe(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.QuickstartComSubscribe d = new PLC.Types.QuickstartComSubscribe()){
                this.Request = new PLC.Mirror.QuickstartComRequest($"{instancePath}.Request", adsClient, d.Request);
                
                this.Equipment = new PLC.Mirror.QuickstartComSubscribeEquipment($"{instancePath}.Equipment", adsClient, d.Equipment);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public QuickstartComSubscribe Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.QuickstartComSubscribe _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.QuickstartComSubscribe>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.QuickstartComSubscribe Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Request.Value = _value.Request;
                  Equipment.Value = _value.Equipment;
                }
            }

            public PLC.Types.QuickstartComSubscribe Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.QuickstartComSubscribe)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.QuickstartComRequest Request { get; set;  }
            
            public PLC.Mirror.QuickstartComSubscribeEquipment Equipment { get; set;  }
        }
         
        public class QuickstartCom
        {
            public QuickstartCom()
            {
                this.Publish = new PLC.Mirror.QuickstartComPublish("", null, new PLC.Types.QuickstartComPublish());
                this.Subscribe = new PLC.Mirror.QuickstartComSubscribe("", null, new PLC.Types.QuickstartComSubscribe());            
            }        


            public QuickstartCom(string instancePath, TwinCAT.Ads.TcAdsClient adsClient=null, PLC.Types.QuickstartCom d = new PLC.Types.QuickstartCom()){
                this.Publish = new PLC.Mirror.QuickstartComPublish($"{instancePath}.Publish", adsClient, d.Publish);
                this.Subscribe = new PLC.Mirror.QuickstartComSubscribe($"{instancePath}.Subscribe", adsClient, d.Subscribe);
            
              Value = d;
              _instancePath = instancePath;
              _adsClient = adsClient;
            }
            
            public class ValueChangedArgs : System.EventArgs
            {
                public QuickstartCom Data { get; set; }
            }              
                       

            private TwinCAT.Ads.TcAdsClient _adsClient;
            private int _notificationHandle;private string _instancePath = "";
            private PLC.Types.QuickstartCom _value;
            private System.EventHandler<ValueChangedArgs> _callback;
            
            public System.EventHandler<ValueChangedArgs> ValueChanged
            {
                get
                {
                    if(_adsClient == null)
                        return _callback;
                        
                    if(_notificationHandle == 0)
                    {

                        _notificationHandle = _adsClient.AddDeviceNotificationEx(_instancePath, AdsTransMode.Cyclic, 50, 100, this, _value.GetType());_adsClient.AdsNotification += ValueChangedCallback;
                    }

                    return _callback;
                }
                set
                {
                    _callback = value;
                }
            }

            private void ValueChangedCallback(object sender, AdsNotificationEventArgs e)
            {
                if(_callback == null)
                    return;
                    
                if(Object.ReferenceEquals(e.UserData, this))
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(_value));

                    AdsBinaryReader reader = new AdsBinaryReader(e.DataStream);
                    Marshal.Copy(reader.ReadBytes((int)e.DataStream.Length), 0, ptr, Marshal.SizeOf(_value));Value = Marshal.PtrToStructure<PLC.Types.QuickstartCom>(ptr);
                    Marshal.FreeHGlobal(ptr);
                    _callback.Invoke(this, new ValueChangedArgs { Data = this });  ;
                }
            }             
            

            int Handle{
                get
                {
                    if(_adsClient == null)
                        return 0;
                        
                    return _adsClient.CreateVariableHandle(_instancePath);
                }
            }

            public PLC.Types.QuickstartCom Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                  Publish.Value = _value.Publish;
                  Subscribe.Value = _value.Subscribe;
                }
            }

            public PLC.Types.QuickstartCom Sync
            {
                get
                {
                    if(_adsClient == null)
                        return _value;
                        

                    Value = (PLC.Types.QuickstartCom)_adsClient.ReadAny(Handle, _value.GetType());                     
                    return _value;
                }
                set
                {
                    Value = value;
                    if(_adsClient != null)
                        _adsClient.WriteAny(Handle, _value);
                }
            }
            public PLC.Mirror.QuickstartComPublish Publish { get; set;  }
            public PLC.Mirror.QuickstartComSubscribe Subscribe { get; set;  }
        }
        
    }
}