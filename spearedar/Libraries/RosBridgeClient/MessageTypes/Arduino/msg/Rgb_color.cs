/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Arduino
{
    public class Rgb_color : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "arduino_msgs/Rgb_color";

        public byte r;
        //  red
        public byte g;
        //  green
        public byte b;
        //  blue
        public ushort c;
        //  clear

        public Rgb_color()
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
            this.c = 0;
        }

        public Rgb_color(byte r, byte g, byte b, ushort c)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.c = c;
        }
    }
}
