/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Dobot
{
    public class SetColorSensorRequest : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "dobot_msgs/SetColorSensor";

        public bool enable;
        public byte colorPort;

        public SetColorSensorRequest()
        {
            this.enable = false;
            this.colorPort = 0;
        }

        public SetColorSensorRequest(bool enable, byte colorPort)
        {
            this.enable = enable;
            this.colorPort = colorPort;
        }
    }
}
