#ifndef _ROS_SERVICE_GetDeviceName_h
#define _ROS_SERVICE_GetDeviceName_h
#include <stdint.h>
#include <string.h>
#include <stdlib.h>
#include "ros/msg.h"
#include "std_msgs/String.h"

namespace dobot_msgs
{

static const char GETDEVICENAME[] = "dobot_msgs/GetDeviceName";

  class GetDeviceNameRequest : public ros::Msg
  {
    public:

    GetDeviceNameRequest()
    {
    }

    virtual int serialize(unsigned char *outbuffer) const
    {
      int offset = 0;
      return offset;
    }

    virtual int deserialize(unsigned char *inbuffer)
    {
      int offset = 0;
     return offset;
    }

    const char * getType(){ return GETDEVICENAME; };
    const char * getMD5(){ return "d41d8cd98f00b204e9800998ecf8427e"; };

  };

  class GetDeviceNameResponse : public ros::Msg
  {
    public:
      typedef int32_t _result_type;
      _result_type result;
      typedef std_msgs::String _deviceName_type;
      _deviceName_type deviceName;

    GetDeviceNameResponse():
      result(0),
      deviceName()
    {
    }

    virtual int serialize(unsigned char *outbuffer) const
    {
      int offset = 0;
      union {
        int32_t real;
        uint32_t base;
      } u_result;
      u_result.real = this->result;
      *(outbuffer + offset + 0) = (u_result.base >> (8 * 0)) & 0xFF;
      *(outbuffer + offset + 1) = (u_result.base >> (8 * 1)) & 0xFF;
      *(outbuffer + offset + 2) = (u_result.base >> (8 * 2)) & 0xFF;
      *(outbuffer + offset + 3) = (u_result.base >> (8 * 3)) & 0xFF;
      offset += sizeof(this->result);
      offset += this->deviceName.serialize(outbuffer + offset);
      return offset;
    }

    virtual int deserialize(unsigned char *inbuffer)
    {
      int offset = 0;
      union {
        int32_t real;
        uint32_t base;
      } u_result;
      u_result.base = 0;
      u_result.base |= ((uint32_t) (*(inbuffer + offset + 0))) << (8 * 0);
      u_result.base |= ((uint32_t) (*(inbuffer + offset + 1))) << (8 * 1);
      u_result.base |= ((uint32_t) (*(inbuffer + offset + 2))) << (8 * 2);
      u_result.base |= ((uint32_t) (*(inbuffer + offset + 3))) << (8 * 3);
      this->result = u_result.real;
      offset += sizeof(this->result);
      offset += this->deviceName.deserialize(inbuffer + offset);
     return offset;
    }

    const char * getType(){ return GETDEVICENAME; };
    const char * getMD5(){ return "a703c880c9a21252b3f02bc128299ae6"; };

  };

  class GetDeviceName {
    public:
    typedef GetDeviceNameRequest Request;
    typedef GetDeviceNameResponse Response;
  };

}
#endif
