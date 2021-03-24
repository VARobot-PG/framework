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
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Gazebo
{
    public class WorldState : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "gazebo_msgs/WorldState";

        //  This is a message that holds data necessary to reconstruct a snapshot of the world
        // 
        //  = Approach to Message Passing =
        //  The state of the world is defined by either
        //    1. Inertial Model pose, twist
        //       * kinematic data - connectivity graph from Model to each Link
        //       * joint angles
        //       * joint velocities
        //       * Applied forces - Body wrench
        //         * relative transform from Body to each collision Geom
        //  Or
        //    2. Inertial (absolute) Body pose, twist, wrench
        //       * relative transform from Body to each collision Geom - constant, so not sent over wire
        //       * back compute from canonical body info to get Model pose and twist.
        // 
        //  Chooing (2.) because it matches most physics engines out there
        //    and is simpler.
        // 
        //  = Future =
        //  Consider impacts on using reduced coordinates / graph (parent/child links) approach
        //    constraint and physics solvers.
        // 
        //  = Application =
        //  This message is used to do the following:
        //    * reconstruct the world and objects for sensor generation
        //    * stop / start simulation - need pose, twist, wrench of each body
        //    * collision detection - need pose of each collision geometry.  velocity/acceleration if
        // 
        //  = Assumptions =
        //  Assuming that each (physics) processor node locally already has
        //    * collision information - Trimesh for Geoms, etc
        //    * relative transforms from Body to Geom - this is assumed to be fixed, do not send oved wire
        //    * inertial information - does not vary in time
        //    * visual information - does not vary in time
        // 
        public Header header;
        public string[] name;
        public Pose[] pose;
        public Twist[] twist;
        public Wrench[] wrench;

        public WorldState()
        {
            this.header = new Header();
            this.name = new string[0];
            this.pose = new Pose[0];
            this.twist = new Twist[0];
            this.wrench = new Wrench[0];
        }

        public WorldState(Header header, string[] name, Pose[] pose, Twist[] twist, Wrench[] wrench)
        {
            this.header = header;
            this.name = name;
            this.pose = pose;
            this.twist = twist;
            this.wrench = wrench;
        }
    }
}
