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
    public class SpawnModelRequest : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "gazebo_msgs/SpawnModel";

        public string model_name;
        //  name of the model to be spawn
        public string model_xml;
        //  this should be an urdf or gazebo xml
        public string robot_namespace;
        //  spawn robot and all ROS interfaces under this namespace
        public Pose initial_pose;
        //  only applied to canonical body
        public string reference_frame;
        //  initial_pose is defined relative to the frame of this model/body
        //  if left empty or "world", then gazebo world frame is used
        //  if non-existent model/body is specified, an error is returned
        //    and the model is not spawned

        public SpawnModelRequest()
        {
            this.model_name = "";
            this.model_xml = "";
            this.robot_namespace = "";
            this.initial_pose = new Pose();
            this.reference_frame = "";
        }

        public SpawnModelRequest(string model_name, string model_xml, string robot_namespace, Pose initial_pose, string reference_frame)
        {
            this.model_name = model_name;
            this.model_xml = model_xml;
            this.robot_namespace = robot_namespace;
            this.initial_pose = initial_pose;
            this.reference_frame = reference_frame;
        }
    }
}
