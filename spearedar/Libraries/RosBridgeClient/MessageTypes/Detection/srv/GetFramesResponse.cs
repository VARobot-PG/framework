/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Detection
{
    public class GetFramesResponse : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "detection_msgs/GetFrames";

        public string[] names;
        public Transform[] transforms;

        public GetFramesResponse()
        {
            this.names = new string[0];
            this.transforms = new Transform[0];
        }

        public GetFramesResponse(string[] names, Transform[] transforms)
        {
            this.names = names;
            this.transforms = transforms;
        }
    }
}
