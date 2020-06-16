

namespace Vehicle
{
    public class VehicleCreator
    {
        
        private IVehicleBuilder _IVehicleBuilder;

        public VehicleCreator(IVehicleBuilder ivehicleBuilder){
           _IVehicleBuilder = ivehicleBuilder;

        }

        public void CreatVehicle(){
            _IVehicleBuilder.SetType();
            _IVehicleBuilder.SetNoOfTyres();
            _IVehicleBuilder.SetColour();

        }

        public void displayVehicle()
        {
            _IVehicleBuilder.Display();
        }
    }
}