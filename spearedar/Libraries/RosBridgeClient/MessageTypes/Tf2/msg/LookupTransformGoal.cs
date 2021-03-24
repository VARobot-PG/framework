/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Tf2
{
    public class LookupTransformGoal : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "tf2_msgs/LookupTransformGoal";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        // Simple API
        public string target_frame;
        public string source_frame;
        public Time source_time;
        public Duration timeout;
        // Advanced API
        public Time target_time;
        public string fixed_frame;
        // Whether or not to use the advanced API
        public bool advanced;

        public LookupTransformGoal()
        {
            this.target_frame = "";
            this.source_frame = "";
            this.source_time = new Time();
            this.timeout = new Duration();
            this.target_time = new Time();
            this.fixed_frame = "";
            this.advanced = false;
        }

        public LookupTransformGoal(string target_frame, string source_frame, Time source_time, Duration timeout, Time target_time, string fixed_frame, bool advanced)
        {
            this.target_frame = target_frame;
            this.source_frame = source_frame;
            this.source_time = source_time;
            this.timeout = timeout;
            this.target_time = target_time;
            this.fixed_frame = fixed_frame;
            this.advanced = advanced;
        }
    }
}
