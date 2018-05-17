using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;

        public float MaxValue { get => m_MaxValue; set => m_MaxValue = value; }

        public float MinValue { get => m_MinValue; set => m_MinValue = value; }

        public ValueOutOfRangeException(string i_Message, float i_MaxValue) : base(i_Message)
        {
            MaxValue = i_MaxValue;
            MinValue = 0f;
        }
    }
}
