/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Gazebo
{
    public class GetJointPropertiesRequest : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "gazebo_msgs/GetJointProperties";

        public string joint_name;
        //  name of joint

        public GetJointPropertiesRequest()
        {
            this.joint_name = "";
        }

        public GetJointPropertiesRequest(string joint_name)
        {
            this.joint_name = joint_name;
        }
    }
}
