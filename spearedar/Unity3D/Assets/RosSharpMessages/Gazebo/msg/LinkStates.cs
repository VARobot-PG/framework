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

namespace RosSharp.RosBridgeClient.MessageTypes.Gazebo
{
    public class LinkStates : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "gazebo_msgs/LinkStates";

        //  broadcast all link states in world frame
        public string[] name;
        //  link names
        public Pose[] pose;
        //  desired pose in world frame
        public Twist[] twist;
        //  desired twist in world frame

        public LinkStates()
        {
            this.name = new string[0];
            this.pose = new Pose[0];
            this.twist = new Twist[0];
        }

        public LinkStates(string[] name, Pose[] pose, Twist[] twist)
        {
            this.name = name;
            this.pose = pose;
            this.twist = twist;
        }
    }
}
