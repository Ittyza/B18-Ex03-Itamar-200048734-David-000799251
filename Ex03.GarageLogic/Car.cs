namespace Ex03.GarageLogic
{
    internal abstract class Car : Vehicle
    {
        private const int c_MaxAirPressure = 32;
        private const int c_AmountOfWheels = 4;

        private AggregateEnumTypes.eTypeColor m_TypeOfColor;
        private AggregateEnumTypes.eNumOfDoors m_NumOfDoors;

        protected Car(string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber) 
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber)
        {
            TotalAmountOfWheels = c_AmountOfWheels;
            initAndSetWheels(c_MaxAirPressure);
            ManifactureWheels = string.Empty;
        }

        internal AggregateEnumTypes.eNumOfDoors NumOfDoors { get => m_NumOfDoors; set => m_NumOfDoors = value; }

        internal AggregateEnumTypes.eTypeColor TypeOfColor { get => m_TypeOfColor; set => m_TypeOfColor = value; }

        public override string ToString()
        {
            return string.Format(
                "The model Name is {0}, the license number is : {1}, the owner name is {2}, his phone number is {3} the car has {4} doors and the color is {5}",
                ModelName,
                LicenseNumber,
                OwnerName,
                OwnerPhoneNumber,
                NumOfDoors,
                TypeOfColor);
        }
    }
}
