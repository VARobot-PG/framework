/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class JoyFeedback : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/JoyFeedback";

        //  Declare of the type of feedback
        public const byte TYPE_LED = 0;
        public const byte TYPE_RUMBLE = 1;
        public const byte TYPE_BUZZER = 2;
        public byte type;
        //  This will hold an id number for each type of each feedback.
        //  Example, the first led would be id=0, the second would be id=1
        public byte id;
        //  Intensity of the feedback, from 0.0 to 1.0, inclusive.  If device is
        //  actually binary, driver should treat 0<=x<0.5 as off, 0.5<=x<=1 as on.
        public float intensity;

        public JoyFeedback()
        {
            this.type = 0;
            this.id = 0;
            this.intensity = 0.0f;
        }

        public JoyFeedback(byte type, byte id, float intensity)
        {
            this.type = type;
            this.id = id;
            this.intensity = intensity;
        }
    }
}
