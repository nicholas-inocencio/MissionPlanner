

using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN {




        public const int UAVCAN_EQUIPMENT_SAFETY_ARMINGSTATUS_MAX_PACK_SIZE = 1;
        public const ulong UAVCAN_EQUIPMENT_SAFETY_ARMINGSTATUS_DT_SIG = 0x8700F375556A8003;

        public const int UAVCAN_EQUIPMENT_SAFETY_ARMINGSTATUS_DT_ID = 1100;





        public const double UAVCAN_EQUIPMENT_SAFETY_ARMINGSTATUS_STATUS_DISARMED = 0; // saturated uint8

        public const double UAVCAN_EQUIPMENT_SAFETY_ARMINGSTATUS_STATUS_FULLY_ARMED = 255; // saturated uint8




        public partial class uavcan_equipment_safety_ArmingStatus: IDroneCANSerialize {



            public uint8_t status = new uint8_t();




            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_uavcan_equipment_safety_ArmingStatus(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_uavcan_equipment_safety_ArmingStatus(transfer, this);
            }
        }
    }
}
