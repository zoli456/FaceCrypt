using System.Collections.Generic;
using DirectShowLib;

namespace FaceCrypt.Face
{
    internal class Webcam
    {
        internal static int MegengedettElteres = 3000;

        /// <summary>
        ///     Előállítja a webkamerák listáját
        /// </summary>
        /// <returns></returns>
        internal static List<KeyValuePair<int, string>> Get_Kamera_lista()
        {
            //-> Create a List to store for ComboCameras
            var ListCamerasData = new List<KeyValuePair<int, string>>();

            //-> Find systems cameras with DirectShow.Net dll
            var _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            var _DeviceIndex = 0;
            foreach (var _Camera in _SystemCamereas)
            {
                ListCamerasData.Add(new KeyValuePair<int, string>(_DeviceIndex, _Camera.Name));
                _DeviceIndex++;
            }

            return ListCamerasData;
        }
    }
}