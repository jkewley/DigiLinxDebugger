using System;
using System.Net;
using System.Text;
using DigiLinXLibrary.Device.Base;

namespace DigiLinXLibrary.Network.Packets {
    public class PacketFactory {
        public static NetStreamsPacket Fetch(byte[] inputBytes, IPEndPoint aPoint, bool loadDeviceFromHttp) {
            NetStreamsMessageType aMessageType;
            string aMessage;
            string aTimeStampHex;
            DigiLinxDevice aDevice;
            int aSourcePort;

            //bytes 0-7 : something interesting
            //byte 8 : 00
            //bytes 9-10 : 00 44
            //byte 11 : 00
            //bytes 12-15 : timestamp column, reversed
            //byte 16 : 00
            //byte 17 : message type (NetStreamsMessageType)
            //byte 18 : 00
            //byte 19 : 00
            //byte 20 : begin debugging message

            //theMessageType = (NetStreamsMessageType)Enum.Parse(typeof(NetStreamsMessageType), Encoding.ASCII.GetString(new byte[] { inputBytes[17] }));
            aMessageType = (NetStreamsMessageType) Enum.Parse(typeof(NetStreamsMessageType), inputBytes[17].ToString("D"));
            aMessage = Encoding.ASCII.GetString(inputBytes, 20, inputBytes.Length - 20).Trim(new char[] {'\0', '\n', '\r'});
            aTimeStampHex = inputBytes[15].ToString("X") + inputBytes[14].ToString("X") + inputBytes[13].ToString("X") + inputBytes[12].ToString("X");
            if(loadDeviceFromHttp)
                aDevice = DeviceDirectLoader.Load(aPoint.Address);
            else aDevice = DeviceDirectLoader.LoadStub(aPoint.Address, "Unknown");
            aSourcePort = aPoint.Port;

            switch(aMessageType) {
                case NetStreamsMessageType.Error:
                    return new ErrorPacket(aSourcePort, aMessage, aTimeStampHex, aDevice);
                case NetStreamsMessageType.Warning:
                    return new WarningPacket(aSourcePort, aMessage, aTimeStampHex, aDevice);
                case NetStreamsMessageType.Info:
                    return new InfoPacket(aSourcePort, aMessage, aTimeStampHex, aDevice);
                case NetStreamsMessageType.Driver:
                    return new DriverPacket(aSourcePort, aMessage, aTimeStampHex, aDevice);
                case NetStreamsMessageType.GUI:
                    return new GUIPacket(aSourcePort, aMessage, aTimeStampHex, aDevice);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}