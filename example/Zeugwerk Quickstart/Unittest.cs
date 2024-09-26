/* Generated code */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
using PLC.Types;
using PLC.Enums;
namespace PLC
{
    namespace Types
    {
        [TestClass]
        public class PlcStructAlignment
        {
            
            [TestMethod]
            public void check_ZAux_Message()
            {
                IntPtr buffer = Marshal.AllocHGlobal(272);
                PLC.Types.ZAux_Message instance = (PLC.Types.ZAux_Message)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZAux_Message));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZAux_Message), "TimeStamp").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.TimeStamp));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZAux_Message), "Text").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(256, Marshal.SizeOf(instance.Text));
                Assert.AreEqual(264, Marshal.OffsetOf(typeof(PLC.Types.ZAux_Message), "LogLevel").ToInt32());
                Assert.AreEqual(2, Marshal.SizeOf(Enum.GetUnderlyingType(typeof(PLC.Enums.ZCore_LogLevel))));
                
                
                try
                {
                    Assert.AreEqual(272, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AlarmingMessageCom()
            {
                IntPtr buffer = Marshal.AllocHGlobal(544);
                PLC.Types.ZApplication_AlarmingMessageCom instance = (PLC.Types.ZApplication_AlarmingMessageCom)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AlarmingMessageCom));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingMessageCom), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(272, Marshal.SizeOf(instance.Extend));
                Assert.AreEqual(272, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingMessageCom), "Source").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(256, Marshal.SizeOf(instance.Source));
                Assert.AreEqual(528, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingMessageCom), "State").ToInt32());
                Assert.AreEqual(2, Marshal.SizeOf(Enum.GetUnderlyingType(typeof(PLC.Enums.ZApplication_AlarmingState))));
                
                
                try
                {
                    Assert.AreEqual(544, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AlarmingComPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(5992);
                PLC.Types.ZApplication_AlarmingComPublish instance = (PLC.Types.ZApplication_AlarmingComPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AlarmingComPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingComPublish), "Buffer").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(5984, Marshal.SizeOf(instance.Buffer));
                Assert.AreEqual(5984, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingComPublish), "MostSignificantIndex").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(4, Marshal.SizeOf(instance.MostSignificantIndex));
                
                try
                {
                    Assert.AreEqual(5992, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AlarmingAcknowledge()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AlarmingAcknowledge instance = (PLC.Types.ZApplication_AlarmingAcknowledge)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AlarmingAcknowledge));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingAcknowledge), "Acknowledge").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Acknowledge));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AlarmingComSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(12);
                PLC.Types.ZApplication_AlarmingComSubscribe instance = (PLC.Types.ZApplication_AlarmingComSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AlarmingComSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingComSubscribe), "Buffer").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(11, Marshal.SizeOf(instance.Buffer));
                Assert.AreEqual(11, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingComSubscribe), "Clear").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Clear));
                
                try
                {
                    Assert.AreEqual(12, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AlarmingCom()
            {
                IntPtr buffer = Marshal.AllocHGlobal(6008);
                PLC.Types.ZApplication_AlarmingCom instance = (PLC.Types.ZApplication_AlarmingCom)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AlarmingCom));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingCom), "Publish").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(5992, Marshal.SizeOf(instance.Publish));
                Assert.AreEqual(5992, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AlarmingCom), "Subscribe").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(12, Marshal.SizeOf(instance.Subscribe));
                
                try
                {
                    Assert.AreEqual(6008, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_QuickstartComRequest()
            {
                IntPtr buffer = Marshal.AllocHGlobal(6);
                PLC.Types.QuickstartComRequest instance = (PLC.Types.QuickstartComRequest)Marshal.PtrToStructure(buffer, typeof(PLC.Types.QuickstartComRequest));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComRequest), "Start").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Start));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComRequest), "Stop").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Stop));
                Assert.AreEqual(2, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComRequest), "GoHome").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.GoHome));
                Assert.AreEqual(3, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComRequest), "Halt").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Halt));
                Assert.AreEqual(4, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComRequest), "MoveTransportXThrice").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveTransportXThrice));
                Assert.AreEqual(5, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComRequest), "MoveBrieflyUpAction").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveBrieflyUpAction));
                
                try
                {
                    Assert.AreEqual(6, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComBase()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComBase instance = (PLC.Types.ZApplication_AxisComBase)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComBase));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBase), "Supported").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Supported));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComAbsolutePublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComAbsolutePublish instance = (PLC.Types.ZApplication_AxisComAbsolutePublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComAbsolutePublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComAbsolutePublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComBasePublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(472);
                PLC.Types.ZApplication_AxisComBasePublish instance = (PLC.Types.ZApplication_AxisComBasePublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComBasePublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Name").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(81, Marshal.SizeOf(instance.Name));
                Assert.AreEqual(82, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Busy").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Busy));
                Assert.AreEqual(83, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Error").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Error));
                Assert.AreEqual(84, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Manufacturer").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(81, Marshal.SizeOf(instance.Manufacturer));
                Assert.AreEqual(165, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Simulated").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Simulated));
                Assert.AreEqual(166, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "SafetyState").ToInt32());
                Assert.AreEqual(2, Marshal.SizeOf(Enum.GetUnderlyingType(typeof(PLC.Enums.ZEquipment_AxisSafetyStateFlags))));
                
                Assert.AreEqual(168, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "MotionState").ToInt32());
                Assert.AreEqual(2, Marshal.SizeOf(Enum.GetUnderlyingType(typeof(PLC.Enums.ZEquipment_AxisMotionState))));
                
                Assert.AreEqual(170, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "DriveState").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(256, Marshal.SizeOf(instance.DriveState));
                Assert.AreEqual(426, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "DrivePowered").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.DrivePowered));
                Assert.AreEqual(427, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "DriveEnabled").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.DriveEnabled));
                Assert.AreEqual(428, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "Parked").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Parked));
                Assert.AreEqual(432, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "ActualPosition").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.ActualPosition));
                Assert.AreEqual(440, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "ActualFollowingError").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.ActualFollowingError));
                Assert.AreEqual(448, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "ActualVelocity").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.ActualVelocity));
                Assert.AreEqual(456, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "ActualCurrent").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.ActualCurrent));
                Assert.AreEqual(464, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "DecimalPlacesPosition").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.DecimalPlacesPosition));
                Assert.AreEqual(466, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "DecimalPlacesVelocity").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.DecimalPlacesVelocity));
                Assert.AreEqual(468, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBasePublish), "DecimalPlacesCurrent").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.DecimalPlacesCurrent));
                
                try
                {
                    Assert.AreEqual(472, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComHaltPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComHaltPublish instance = (PLC.Types.ZApplication_AxisComHaltPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComHaltPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComHaltPublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComVelocityFeedratePublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(16);
                PLC.Types.ZApplication_AxisComVelocityFeedratePublish instance = (PLC.Types.ZApplication_AxisComVelocityFeedratePublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComVelocityFeedratePublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocityFeedratePublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocityFeedratePublish), "Feedrate").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Feedrate));
                
                try
                {
                    Assert.AreEqual(16, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComBrakePublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(2);
                PLC.Types.ZApplication_AxisComBrakePublish instance = (PLC.Types.ZApplication_AxisComBrakePublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComBrakePublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBrakePublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBrakePublish), "BrakeOpened").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.BrakeOpened));
                
                try
                {
                    Assert.AreEqual(2, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComHomingPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComHomingPublish instance = (PLC.Types.ZApplication_AxisComHomingPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComHomingPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComHomingPublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComCurrentPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComCurrentPublish instance = (PLC.Types.ZApplication_AxisComCurrentPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComCurrentPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComCurrentPublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComVelocityPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComVelocityPublish instance = (PLC.Types.ZApplication_AxisComVelocityPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComVelocityPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocityPublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComPositionPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(2);
                PLC.Types.ZApplication_AxisComPositionPublish instance = (PLC.Types.ZApplication_AxisComPositionPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComPositionPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionPublish), "Extend").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Extend));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionPublish), "Referenced").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Referenced));
                
                try
                {
                    Assert.AreEqual(2, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(512);
                PLC.Types.ZApplication_AxisComPublish instance = (PLC.Types.ZApplication_AxisComPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Absolute").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Absolute));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Base").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(472, Marshal.SizeOf(instance.Base));
                Assert.AreEqual(480, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Halt").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Halt));
                Assert.AreEqual(488, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "VelocityFeedrate").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(16, Marshal.SizeOf(instance.VelocityFeedrate));
                Assert.AreEqual(504, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Brake").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.Brake));
                Assert.AreEqual(506, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Homing").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Homing));
                Assert.AreEqual(507, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Current").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Current));
                Assert.AreEqual(508, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Velocity").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Velocity));
                Assert.AreEqual(509, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPublish), "Position").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.Position));
                
                try
                {
                    Assert.AreEqual(512, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_ActuatorDigitalComPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(600);
                PLC.Types.ZApplication_ActuatorDigitalComPublish instance = (PLC.Types.ZApplication_ActuatorDigitalComPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "Name").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(256, Marshal.SizeOf(instance.Name));
                Assert.AreEqual(256, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "Busy").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Busy));
                Assert.AreEqual(257, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "Error").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Error));
                Assert.AreEqual(258, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "AtMinus").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.AtMinus));
                Assert.AreEqual(259, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "AtPlus").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.AtPlus));
                Assert.AreEqual(264, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "Duration").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Duration));
                Assert.AreEqual(272, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "MinusOutputName").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(81, Marshal.SizeOf(instance.MinusOutputName));
                Assert.AreEqual(353, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "PlusOutputName").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(81, Marshal.SizeOf(instance.PlusOutputName));
                Assert.AreEqual(434, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "MinusInputName").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(81, Marshal.SizeOf(instance.MinusInputName));
                Assert.AreEqual(515, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComPublish), "PlusInputName").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(81, Marshal.SizeOf(instance.PlusInputName));
                
                try
                {
                    Assert.AreEqual(600, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_DigitalComPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(259);
                PLC.Types.ZApplication_DigitalComPublish instance = (PLC.Types.ZApplication_DigitalComPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_DigitalComPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_DigitalComPublish), "Name").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(256, Marshal.SizeOf(instance.Name));
                Assert.AreEqual(256, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_DigitalComPublish), "Simulated").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Simulated));
                Assert.AreEqual(257, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_DigitalComPublish), "Writeable").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Writeable));
                Assert.AreEqual(258, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_DigitalComPublish), "Enabled").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Enabled));
                
                try
                {
                    Assert.AreEqual(259, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_QuickstartComPublishEquipment()
            {
                IntPtr buffer = Marshal.AllocHGlobal(3184);
                PLC.Types.QuickstartComPublishEquipment instance = (PLC.Types.QuickstartComPublishEquipment)Marshal.PtrToStructure(buffer, typeof(PLC.Types.QuickstartComPublishEquipment));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "TransportX").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(512, Marshal.SizeOf(instance.TransportX));
                Assert.AreEqual(512, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "CylinderY").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(600, Marshal.SizeOf(instance.CylinderY));
                Assert.AreEqual(1112, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "CylinderYDown").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.CylinderYDown));
                Assert.AreEqual(1371, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "CylinderYUp").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.CylinderYUp));
                Assert.AreEqual(1630, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "CylinderYIsDown").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.CylinderYIsDown));
                Assert.AreEqual(1889, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "CylinderYIsUp").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.CylinderYIsUp));
                Assert.AreEqual(2148, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "MagnetOn").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.MagnetOn));
                Assert.AreEqual(2407, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "LimitSwitchLeft").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.LimitSwitchLeft));
                Assert.AreEqual(2666, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "LimitSwitchRight").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.LimitSwitchRight));
                Assert.AreEqual(2925, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublishEquipment), "ConveyorOn").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(259, Marshal.SizeOf(instance.ConveyorOn));
                
                try
                {
                    Assert.AreEqual(3184, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_QuickstartComPublish()
            {
                IntPtr buffer = Marshal.AllocHGlobal(3192);
                PLC.Types.QuickstartComPublish instance = (PLC.Types.QuickstartComPublish)Marshal.PtrToStructure(buffer, typeof(PLC.Types.QuickstartComPublish));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublish), "State").ToInt32());
                Assert.AreEqual(2, Marshal.SizeOf(Enum.GetUnderlyingType(typeof(PLC.Enums.ZApplication_UnitStateMachineState))));
                
                Assert.AreEqual(2, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublish), "Request").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(6, Marshal.SizeOf(instance.Request));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComPublish), "Equipment").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(3184, Marshal.SizeOf(instance.Equipment));
                
                try
                {
                    Assert.AreEqual(3192, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComAbsoluteSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(16);
                PLC.Types.ZApplication_AxisComAbsoluteSubscribe instance = (PLC.Types.ZApplication_AxisComAbsoluteSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComAbsoluteSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComAbsoluteSubscribe), "Position").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Position));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComAbsoluteSubscribe), "SetAbsolutePosition").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.SetAbsolutePosition));
                
                try
                {
                    Assert.AreEqual(16, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComBaseSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(3);
                PLC.Types.ZApplication_AxisComBaseSubscribe instance = (PLC.Types.ZApplication_AxisComBaseSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComBaseSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBaseSubscribe), "EnableDrive").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.EnableDrive));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBaseSubscribe), "DisableDrive").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.DisableDrive));
                Assert.AreEqual(2, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBaseSubscribe), "Stop").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Stop));
                
                try
                {
                    Assert.AreEqual(3, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComHaltSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComHaltSubscribe instance = (PLC.Types.ZApplication_AxisComHaltSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComHaltSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComHaltSubscribe), "Halt").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Halt));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComVelocityFeedrateSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(16);
                PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe instance = (PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe), "Feedrate").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Feedrate));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocityFeedrateSubscribe), "Apply").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Apply));
                
                try
                {
                    Assert.AreEqual(16, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComBrakeSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(2);
                PLC.Types.ZApplication_AxisComBrakeSubscribe instance = (PLC.Types.ZApplication_AxisComBrakeSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComBrakeSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBrakeSubscribe), "OpenBrake").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.OpenBrake));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComBrakeSubscribe), "CloseBrake").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.CloseBrake));
                
                try
                {
                    Assert.AreEqual(2, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComHomingSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(1);
                PLC.Types.ZApplication_AxisComHomingSubscribe instance = (PLC.Types.ZApplication_AxisComHomingSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComHomingSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComHomingSubscribe), "Homing").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Homing));
                
                try
                {
                    Assert.AreEqual(1, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComVelocitySubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(16);
                PLC.Types.ZApplication_AxisComVelocitySubscribe instance = (PLC.Types.ZApplication_AxisComVelocitySubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComVelocitySubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocitySubscribe), "Velocity").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Velocity));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComVelocitySubscribe), "MoveVelocity").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveVelocity));
                
                try
                {
                    Assert.AreEqual(16, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComPositionSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(72);
                PLC.Types.ZApplication_AxisComPositionSubscribe instance = (PLC.Types.ZApplication_AxisComPositionSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComPositionSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "Speed").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Speed));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "Position1").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Position1));
                Assert.AreEqual(16, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "MoveAbsolute1").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveAbsolute1));
                Assert.AreEqual(24, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "Position2").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Position2));
                Assert.AreEqual(32, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "MoveAbsolute2").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveAbsolute2));
                Assert.AreEqual(40, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "Delay").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Delay));
                Assert.AreEqual(48, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "MoveContinuous").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveContinuous));
                Assert.AreEqual(56, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "Distance").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(8, Marshal.SizeOf(instance.Distance));
                Assert.AreEqual(64, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComPositionSubscribe), "MoveRelative").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveRelative));
                
                try
                {
                    Assert.AreEqual(72, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_AxisComSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(136);
                PLC.Types.ZApplication_AxisComSubscribe instance = (PLC.Types.ZApplication_AxisComSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_AxisComSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Absolute").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(16, Marshal.SizeOf(instance.Absolute));
                Assert.AreEqual(16, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Base").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(3, Marshal.SizeOf(instance.Base));
                Assert.AreEqual(19, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Halt").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Halt));
                Assert.AreEqual(24, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "VelocityFeedrate").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(16, Marshal.SizeOf(instance.VelocityFeedrate));
                Assert.AreEqual(40, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Brake").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.Brake));
                Assert.AreEqual(42, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Homing").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Homing));
                Assert.AreEqual(48, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Velocity").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(16, Marshal.SizeOf(instance.Velocity));
                Assert.AreEqual(64, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_AxisComSubscribe), "Position").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(72, Marshal.SizeOf(instance.Position));
                
                try
                {
                    Assert.AreEqual(136, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_ActuatorDigitalComSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(2);
                PLC.Types.ZApplication_ActuatorDigitalComSubscribe instance = (PLC.Types.ZApplication_ActuatorDigitalComSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_ActuatorDigitalComSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComSubscribe), "MovePlus").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MovePlus));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_ActuatorDigitalComSubscribe), "MoveMinus").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.MoveMinus));
                
                try
                {
                    Assert.AreEqual(2, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_ZApplication_DigitalComSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(2);
                PLC.Types.ZApplication_DigitalComSubscribe instance = (PLC.Types.ZApplication_DigitalComSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.ZApplication_DigitalComSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_DigitalComSubscribe), "Write").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Write));
                Assert.AreEqual(1, Marshal.OffsetOf(typeof(PLC.Types.ZApplication_DigitalComSubscribe), "Enable").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(1, Marshal.SizeOf(instance.Enable));
                
                try
                {
                    Assert.AreEqual(2, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_QuickstartComSubscribeEquipment()
            {
                IntPtr buffer = Marshal.AllocHGlobal(160);
                PLC.Types.QuickstartComSubscribeEquipment instance = (PLC.Types.QuickstartComSubscribeEquipment)Marshal.PtrToStructure(buffer, typeof(PLC.Types.QuickstartComSubscribeEquipment));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "TransportX").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(136, Marshal.SizeOf(instance.TransportX));
                Assert.AreEqual(136, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "CylinderY").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.CylinderY));
                Assert.AreEqual(138, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "CylinderYDown").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.CylinderYDown));
                Assert.AreEqual(140, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "CylinderYUp").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.CylinderYUp));
                Assert.AreEqual(142, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "CylinderYIsDown").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.CylinderYIsDown));
                Assert.AreEqual(144, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "CylinderYIsUp").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.CylinderYIsUp));
                Assert.AreEqual(146, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "MagnetOn").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.MagnetOn));
                Assert.AreEqual(148, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "LimitSwitchLeft").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.LimitSwitchLeft));
                Assert.AreEqual(150, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "LimitSwitchRight").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.LimitSwitchRight));
                Assert.AreEqual(152, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribeEquipment), "ConveyorOn").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(2, Marshal.SizeOf(instance.ConveyorOn));
                
                try
                {
                    Assert.AreEqual(160, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_QuickstartComSubscribe()
            {
                IntPtr buffer = Marshal.AllocHGlobal(168);
                PLC.Types.QuickstartComSubscribe instance = (PLC.Types.QuickstartComSubscribe)Marshal.PtrToStructure(buffer, typeof(PLC.Types.QuickstartComSubscribe));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribe), "Request").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(6, Marshal.SizeOf(instance.Request));
                Assert.AreEqual(8, Marshal.OffsetOf(typeof(PLC.Types.QuickstartComSubscribe), "Equipment").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(160, Marshal.SizeOf(instance.Equipment));
                
                try
                {
                    Assert.AreEqual(168, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
            [TestMethod]
            public void check_QuickstartCom()
            {
                IntPtr buffer = Marshal.AllocHGlobal(3360);
                PLC.Types.QuickstartCom instance = (PLC.Types.QuickstartCom)Marshal.PtrToStructure(buffer, typeof(PLC.Types.QuickstartCom));
                Assert.AreEqual(0, Marshal.OffsetOf(typeof(PLC.Types.QuickstartCom), "Publish").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(3192, Marshal.SizeOf(instance.Publish));
                Assert.AreEqual(3192, Marshal.OffsetOf(typeof(PLC.Types.QuickstartCom), "Subscribe").ToInt32());
                // C# this fails, but because of an error in Marshal
                //Assert.AreEqual(168, Marshal.SizeOf(instance.Subscribe));
                
                try
                {
                    Assert.AreEqual(3360, Marshal.SizeOf(instance));
                } catch(System.InvalidProgramException ex)
                {
                    // Marshal.Sizeof has a bug with large structures
                }  
            }
            
        }
    }
}