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
    public class SetQueuedCmdForceStopExecResponse : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "dobot_msgs/SetQueuedCmdForceStopExec";

        public int result;

        public SetQueuedCmdForceStopExecResponse()
        {
            this.result = 0;
        }

        public SetQueuedCmdForceStopExecResponse(int result)
        {
            this.result = result;
        }
    }
}
